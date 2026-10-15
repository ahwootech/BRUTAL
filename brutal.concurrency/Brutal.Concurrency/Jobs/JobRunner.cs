using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.Concurrency.Jobs;

/// <summary>
/// Provides functionality for queuing, running a collection of IJob instances on a single resource.
/// At present, this resource is a single thread from the System.Threadpool.
/// </summary>
public class JobRunner
{
    public const int DEFAULT_CAPACITY = 1024;
    public const ThreadPriority DEFAULT_THREAD_PRIORITY = ThreadPriority.AboveNormal;

    /// <summary>
    /// A delegate that is called when a <see cref="JobRunner"/> completes execution.
    /// </summary>
    /// <param name="runner">This JobRunner</param>
    /// <param name="result">Result of job execution</param>
    /// <param name="lastTickTimeMillis">The total time in milliseconds it took to run the jobs</param>
    public delegate void JobCompletedDelegate(
        JobRunner runner,
        ExecutionResult result,
        double lastTickTimeMillis
    );

    /// <summary>
    /// Construct a JobRunner with an optional name, thread priority, capacity and shared Lock instance.
    /// </summary>
    /// <remarks>The shared lock is useful if you want to have your own synchronisation that you wish the JobRunner to take part in. If this parameter is null
    /// then the JobRunner will fallback to using its own locking mechanism. </remarks>
    /// <param name="name">Name of the runner. Defaults to an empty string.</param>
    /// <param name="threadPriority">The priority to run the worker thread under. Defaults to <see cref="DEFAULT_THREAD_PRIORITY"/>.</param>
    /// <param name="capacity">Number of entries in the job queue to allocate space for. Defaults to <see cref="DEFAULT_CAPACITY"/>.</param>
    /// <param name="lock">An optional lock object for the JobRunner to use.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if capacity &lt; 1</exception>
    public JobRunner(
        string name = "",
        ThreadPriority threadPriority = DEFAULT_THREAD_PRIORITY,
        int capacity = DEFAULT_CAPACITY,
        Lock? @lock = null
    )
    {
        if (capacity < 1)
            throw new ArgumentOutOfRangeException(nameof(capacity), @"capacity");

        // In DotNet 9 System.Threading.Lock was added to give a bit of performance over Monitor which was used when you went
        // lock(some_object). Now you use lock(someLockInstance).
        _lock = @lock ?? new Lock();
        _timer = new JobRunnerTimer();
        _state = (int)JobState.Idle;
        _jobs = new List<IJob>(capacity);
        _nextJobIndexToExecute = -1;
        _workExecutor = new WorkExecutor(this);
        Name = name;
        ThreadPriority = threadPriority;

        _metrics = new()
        {
            AverageTickTimeMillis = 0,
            MaxTickTimeMillis = 0,
            LastTickTimeMillis = 0,
        };
    }

    /// <summary>
    /// Gets or sets the threadpriority that this runner runs on. Takes effect the next time this runner runs jobs.
    /// </summary>
    public ThreadPriority ThreadPriority { get; set; }

    /// <summary>
    /// The user-defined name of the job runner specified in the constructor.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns the current state of the JobRunner.
    /// </summary>
    public JobState State => ReadStateSynchronised();

    /// <summary>
    /// Queue a job to the JobRunner if it is currently idle.
    /// </summary>
    /// <param name="job">The job to queue</param>
    /// <exception cref="InvalidOperationException">Thrown if the job runner is not idle.</exception>
    public void Queue(IJob job)
    {
        lock (_lock)
        {
            if (ReadStateSynchronised() != JobState.Idle)
                throw new InvalidOperationException("JobRunner is not idle");
            _jobs.Add(job);
        }
    }

    /// <summary>
    /// Returns a <see cref="ReadOnlySpan{IJob}"/> of the currently queued jobs for a JobRunner.
    /// </summary>
    /// <remarks>The returned <see cref="ReadOnlySpan{IJob}"/> is a view of the <see cref="JobRunner" />'s queued jobs at the time of the call. If more jobs are added after the call or
    /// the <see cref="JobRunner" />'s jobs are executed (which clears the queue) then the ReadOnlySpan is invalidated.
    /// </remarks>
    /// <returns>The ReadOnlySpan of the queued IJob instances.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the <see cref="JobRunner" /> is not idle.</exception>
    public ReadOnlySpan<IJob> GetQueuedJobs()
    {
        lock (_lock)
        {
            if (ReadStateSynchronised() != JobState.Idle)
                throw new InvalidOperationException("JobRunner is not idle");
            return CollectionsMarshal.AsSpan(_jobs);
        }
    }

    /// <summary>
    /// Starts execution of all queued jobs.
    /// After a call to ExecuteJobs() no more jobs can be queued until the runner is idle.
    /// </summary>
    /// <param name="onCompleteHandler" cref="JobCompletedDelegate" >An optional callback that is invoked when the JobRunner jobs have finished or been aborted.</param>
    /// <remarks>If there are no jobs to run, metrics are not updated, but the callback is still called with the last tick time being set to 0</remarks>
    /// <exception cref="InvalidOperationException">Thrown if the runner is not currently idle</exception>
    public void ExecuteJobs(JobCompletedDelegate? onCompleteHandler = null)
    {
        // Locked (not just the state CAS in CheckedTransitionState) so that a concurrent
        // Queue() call is fully ordered relative to this transition: either its Add()
        // completes and is visible in the _jobs.Count read below, or it observes the
        // Scheduled state and throws before ever touching _jobs. See issue #22.
        lock (_lock)
        {
            CheckedTransitionState(JobState.Idle, JobState.Scheduled);
        }

        if (_jobs.Count == 0)
        {
            Interlocked.Exchange(ref _state, (int)JobState.Idle);
            onCompleteHandler?.Invoke(this, ExecutionResult.NoJobs, 0);
            return;
        }

        // With SafeStartTimer being here, we include the time to get the job thread actually up and running so we
        // get a view of the start to finish time.
        SafeStartTimer();
        _workExecutor.OnCompleteHandler = onCompleteHandler;
        ThreadPool.UnsafeQueueUserWorkItem(_workExecutor, false);
    }

    /// <summary>
    /// Request aborting of jobs that have not already started executing. If the JobRunner is currently Idle or in the process of aborting, this function does nothing.
    ///
    /// <remarks><br /><br />
    /// Jobs that are already running will not be aborted.<br />
    /// Metrics will not be updated.<br />
    /// </remarks>
    /// </summary>
    public void RequestAbort()
    {
        while (true)
        {
            var currentState = ReadStateSynchronised();
            if (currentState is JobState.Idle or JobState.Abort)
                return;
            Debug.Assert(currentState is JobState.Scheduled or JobState.Running);

            if (
                Interlocked.CompareExchange(ref _state, (int)JobState.Abort, (int)currentState)
                == (int)currentState
            )
                return;
        }
    }

    /// <summary>
    /// Returns the latest metrics of the JobRunner's last execution, which include AverageMillis, MaxMillis and LastMillis, in milliseconds.
    /// </summary>
    /// <remarks><p>Threadsafe and atomic. Can be called at any time from any thread to get a consistent view of the current metrics.<br />
    /// This function performs lightweight spin waiting around a sequence token. This does introduce a small overhead. Higher overhead comes
    /// with heavier contention such as calling GetMetrics while ResetMetrics is being called from another thread, or the JobRunner is updating its metrics at the end of
    /// successfully executing all of its jobs.</p><p>Call GetMetricsUnsafe() if shorn JobRunnerMetrics data (Each field itself is still atomic) is acceptable.</p></remarks>
    /// <returns cref="JobRunnerMetrics">The metrics of the JobRunner</returns>
    public JobRunnerMetrics GetMetrics()
    {
        lock (_lock)
        {
            return _metrics;
        }
    }

    /// <summary>
    /// Returns the latest metrics of the JobRunner's last execution in a non-threadsafe manner. Includes AverageMillis, MaxMillis and LastMillis, in milliseconds.<br />
    /// </summary>
    /// <remarks>NOT atomic. If you call this while ResetMetrics is running or the JobRunner threads are updating their metrics you will likely get
    /// shorn results. That is, results of previous metrics mixed with results of the latest. However, each individual value will be consistent and not shorn due to
    /// our requirement of 64bit systems, alignment of the metrics fields and doubles being atomic on those systems if aligned.</remarks>
    /// <returns cref="JobRunnerMetrics">The metrics of the JobRunner</returns>
    public JobRunnerMetrics GetMetricsUnsafe()
    {
        // AKB: Do not just return _metrics, that is not an individual copy of each field and therefore you could get shorn data within each field.
        // Even though this function may return inconsistent results, using per-field copies at least gives us atomic sets of each member.
        var returned = new JobRunnerMetrics
        {
            AverageTickTimeMillis = _metrics.AverageTickTimeMillis,
            MaxTickTimeMillis = _metrics.MaxTickTimeMillis,
            LastTickTimeMillis = _metrics.LastTickTimeMillis,
        };
        return returned;
    }

    /// <summary>
    /// Busy waits the current thread until the jobs have finished executing or been aborted.
    /// </summary>
    /// <remarks>This method busy blocks and may starve a thread or core if waiting too long</remarks>
    public void Wait()
    {
        while (ReadStateSynchronised() != JobState.Idle)
        {
            // This code intentionally left blank
        }
    }

    /// <summary>
    /// Clears all metrics of the JobRunner in an atomic fashion. You will not get shorn fields from the
    /// case where a job wants to update the metrics at the same time as ResetMetrics is clearing them.
    /// <br />
    /// </summary>
    /// <remarks>
    /// The thread safety adds about 10 nanoseconds of overhead on a 3GHz machine.<br />
    /// </remarks>
    public void ResetMetrics()
    {
        lock (_lock)
        {
            ResetMetricsUnsafe();
        }
    }

    /// <summary>
    /// Resets all collected timing and performance metrics to their initial state without thread safety guarantees.
    /// </summary>
    /// <remarks>This method is not thread-safe. CAlling ResetMetrics while others are accessing the (e.g. the JobRunner itself)
    /// could result in inconsistent values.</remarks>
    public void ResetMetricsUnsafe()
    {
        _timer.ResetTimings();
        _metrics.AverageTickTimeMillis = 0;
        _metrics.MaxTickTimeMillis = 0;
        _metrics.LastTickTimeMillis = 0;
    }

    #region Private

    private void SafeStartTimer()
    {
        lock (_lock)
        {
            _timer.Start();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private JobState ReadStateSynchronised()
    {
        return (JobState)Volatile.Read(ref _state);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void WriteStateSynchronised(JobState newState)
    {
        Volatile.Write(ref _state, (int)newState);
    }

    private void CheckedTransitionState(JobState fromState, JobState toState)
    {
        var actual = (JobState)
            Interlocked.CompareExchange(ref _state, (int)toState, (int)fromState);
        if (actual != fromState)
            throw new InvalidOperationException(
                $"Unexpected state. Expected:{fromState} Actual:{actual}"
            );
    }

    private void DoWork(JobCompletedDelegate? onCompleteHandler)
    {
        var executionResult = ExecutionResult.Success;
        try
        {
            Debug.Assert((JobState)_state is JobState.Scheduled or JobState.Abort);
            Debug.Assert(_jobs.Count > 0);

            Thread.CurrentThread.Priority = ThreadPriority;

            // From the time we set our state to Scheduled in ExecuteJobs
            // it's possible a RequestAbort came in and our state is now Abort.
            // We just let the code flow as normal and the abort check below will detect this,
            // however we must let this CompareExchange continue even if it doesn't return Scheduled.
            // There is an assumption made that the state will never be Idle here.
            Interlocked.CompareExchange(ref _state, (int)JobState.Running, (int)JobState.Scheduled);

            _nextJobIndexToExecute = 0;
            while (_nextJobIndexToExecute < _jobs.Count)
            {
                if (ReadStateSynchronised() == JobState.Abort)
                {
                    executionResult = ExecutionResult.Aborted;
                    break;
                }

                var job = _jobs[_nextJobIndexToExecute++];
                job.Run();
            }
        }
        finally
        {
            var lastTickTime = StopTimerAndUpdateMetrics(executionResult);

            _jobs.Clear();
            _nextJobIndexToExecute = -1;
            onCompleteHandler?.Invoke(this, executionResult, lastTickTime);

            // Inserts memory fences to ensure operations before the call are not ordered after the write.
            // Release semantics will ensure other threads seeing the change, will see previous changes as well.
            WriteStateSynchronised(JobState.Idle);
        }
    }

    private double StopTimerAndUpdateMetrics(ExecutionResult executionResult)
    {
        lock (_lock)
        {
            _timer.Stop();
            if (executionResult != ExecutionResult.Success)
                return _timer.LastMillis;

            _metrics.AverageTickTimeMillis = _timer.AverageMillis;
            _metrics.MaxTickTimeMillis = _timer.MaxMillis;
            _metrics.LastTickTimeMillis = _timer.LastMillis;
            return _timer.LastMillis;
        }
    }

    // Using an IThreadPoolWorkItem allows us to avoid the overhead of a closure and delegate allocation for each job execution.
    private class WorkExecutor : IThreadPoolWorkItem
    {
        public WorkExecutor(JobRunner runner)
        {
            _runner = runner;
        }

        public JobCompletedDelegate? OnCompleteHandler { private get; set; }

        public void Execute()
        {
            Debug.Assert(_runner != null);
            _runner.DoWork(OnCompleteHandler);
        }

        private readonly JobRunner _runner;
    }

    private int _state;
    private int _nextJobIndexToExecute;
    private readonly List<IJob> _jobs;
    private readonly JobRunnerTimer _timer;
    private JobRunnerMetrics _metrics;
    private readonly WorkExecutor _workExecutor;

    // This can be passed in as a parameter to the constructor if you wish to share a lock
    // amongst your JobRunners.
    private readonly Lock _lock;

    #endregion
}
