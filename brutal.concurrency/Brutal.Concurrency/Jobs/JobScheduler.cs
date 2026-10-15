using System.Diagnostics;

namespace Brutal.Concurrency.Jobs;

/// <summary>
/// Manages running lightweight jobs on a user-defined number of work items through the system ThreadPool.
///
/// <code>
///     var jobScheduler = new JobScheduler(3, "DebugName"); // Create with 3 JobRunners
///     jobScheduler.Queue(new MyJob(), 5);     // Queue a job with an estimated cost of 5
///     jobScheduler.ExecuteJobs();             // Run all queued jobs
///     jobScheduler.Wait();                    // Busy wait for all jobs to finish
/// </code>
///
/// </summary>
public class JobScheduler
{
    /// <summary>
    /// Initialises an instance of JobScheduler.
    /// </summary>
    /// <param name="jobRunnerCount">The number of job runners this scheduler can schedule between. Must be greater than 0. This typically translates to the number
    /// of threads used by the scheduler, although ultimately that is decided by the underlying ThreadPool.</param>
    /// <param name="debugName">Debug name of this scheduler. Can be retrieved with Name property. Child JobRunners owned by this JobScheduler get debugName
    /// as their name appended with their index.</param>
    /// <param name="threadPriority">The thread priority every JobRunner owned by this JobScheduler is created with. Defaults to <see cref="JobRunner.DEFAULT_THREAD_PRIORITY"/>.
    /// Use <see cref="SetThreadPriority"/> to change it for all runners afterwards.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if jobRunnerCount == 0</exception>
    public JobScheduler(
        uint jobRunnerCount,
        string debugName = "",
        ThreadPriority threadPriority = JobRunner.DEFAULT_THREAD_PRIORITY
    )
    {
        if (jobRunnerCount == 0)
            throw new ArgumentOutOfRangeException(
                nameof(jobRunnerCount),
                @"Minimum number of job runners is 1"
            );

        _runnerWorkloads = new int[jobRunnerCount];

        _runners = new JobRunner[jobRunnerCount];
        for (var i = 0; i < _runners.Length; ++i)
            _runners[i] = new JobRunner(
                $"{debugName}{i}",
                threadPriority,
                JobRunner.DEFAULT_CAPACITY
            );

        _metricsCache = new JobRunnerMetrics[jobRunnerCount];
        _maxLastTickTime = 0;
        Name = debugName;

        _jobCompletedDelegate = OnRunnerFinished;
    }

    /// <summary>
    /// Queues a job.
    /// The scheduler will attempt to distribute the job to the JobRunners that will get the job done quickest.
    /// </summary>
    /// <param name="job">The job to queue</param>
    /// <param name="timeCostEstimate">The time cost estimate of the job. The JobScheduler will use this value to distribute
    /// jobs efficiently. Higher numbers indicate that the job will take more time to complete</param>
    /// <exception cref="InvalidOperationException">If the system is currently running jobs</exception>
    public void Queue(IJob job, int timeCostEstimate)
    {
        if (!IsAllRunnersIdle())
            throw new InvalidOperationException("Jobs in progress");

        var jobRunnerToUseIndex = LeastBurdenedRunner();

        _runnerWorkloads[jobRunnerToUseIndex] += timeCostEstimate;
        _runners[jobRunnerToUseIndex].Queue(job);
    }

    /// <summary>
    /// Busy blocks the calling thread until all jobs have finished or been aborted.
    /// </summary>
    public void Wait()
    {
        for (var i = 0; i < _runners.Length; ++i)
            _runners[i].Wait();
    }

    /// <summary>
    /// Tells all job runners to start executing their jobs.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if any job runners are already busy</exception>
    public void ExecuteJobs()
    {
        if (!IsAllRunnersIdle())
            throw new InvalidOperationException("Jobs already in progress.");

        ResetWorkloadCosts();

        Interlocked.Exchange(ref _maxLastTickTime, 0);

        foreach (var runner in _runners)
            runner.ExecuteJobs(_jobCompletedDelegate);
    }

    /// <summary>
    /// Signals to all the job runners that they should abort their work. Jobs in their Run() function will not be aborted,
    /// and it is technically possible some final jobs will be executed if they have been dequeued and are about to be
    /// Run().
    /// </summary>
    /// <param name="waitForCompletion">If true will block the current thread until all job runners are finished aborting.</param>
    public void AbortJobs(bool waitForCompletion = false)
    {
        foreach (var runner in _runners)
            runner.RequestAbort();

        if (waitForCompletion)
            Wait();
    }

    /// <summary>
    /// Copies the last metrics from each JobRunner's successful job execution into a provided span.
    /// </summary>
    /// <remarks>
    /// This function guarantees that the returned metrics for a JobRunner is a consistent, atomic, snapshot. No shorn values will be returned.
    /// </remarks>
    /// <param name="targetMetrics">A Span of JobRunnerMetrics where each entry represents the metrics of a specific JobRunner.</param>
    public void GetMetrics(Span<JobRunnerMetrics> targetMetrics)
    {
        lock (_lock)
        {
            _metricsCache.AsSpan().CopyTo(targetMetrics);
        }
    }

    /// <summary>
    /// Copies the current metrics of all JobRunners into the provided span, without synchronisation.
    /// </summary>
    /// <remarks>NOT threadsafe or atomic. Each runner's metrics are read via <see cref="JobRunner.GetMetricsUnsafe"/>,
    /// so results may be shorn (a mix of before/after values) if a runner is concurrently completing a job or
    /// resetting its metrics. Use <see cref="GetMetrics(Span{JobRunnerMetrics})"/> for a threadsafe, atomic
    /// alternative.</remarks>
    /// <param name="targetMetrics">A span to receive the metrics; must have at least as many entries as there are JobRunners.</param>
    public void GetMetricsUnsafe(Span<JobRunnerMetrics> targetMetrics)
    {
        for (var i = 0; i < _runners.Length; ++i)
            targetMetrics[i] = _runners[i].GetMetricsUnsafe();
    }

    /// <summary>
    /// Returns the <see cref="ReadOnlySpan{JobRunnerMetrics}" /> of all JobRunnerMetrics, without synchronization.
    /// </summary>
    /// <remarks>NOT threadsafe or atomic. Each runner's metrics are read via <see cref="JobRunner.GetMetricsUnsafe"/>,
    /// so results may be shorn (a mix of before/after values) if a runner is concurrently completing a job or
    /// resetting its metrics. Use <see cref="GetMetrics(Span{JobRunnerMetrics})"/> for a threadsafe, atomic
    /// alternative.</remarks>
    public ReadOnlySpan<JobRunnerMetrics> GetMetricsUnsafe()
    {
        for (var i = 0; i < _runners.Length; ++i)
            _metricsCache[i] = _runners[i].GetMetricsUnsafe();

        return new(_metricsCache);
    }

    /// <summary>
    ///  Returns the largest tick time from the last time the job runners were executed.
    /// </summary>
    /// <returns></returns>
    public double GetMaxLastTickTime()
    {
        return Volatile.Read(ref _maxLastTickTime);
    }

    public string Name { get; set; }

    /// <summary>
    /// True if any of this scheduler's JobRunners are currently scheduled, running, or aborting jobs.
    /// </summary>
    public bool IsExecuting => !IsAllRunnersIdle();

    /// <summary>
    /// Sets the thread priority of every JobRunner owned by this JobScheduler. Takes effect the next time
    /// each runner runs jobs.
    /// </summary>
    /// <param name="threadPriority">The thread priority to apply to all owned JobRunners.</param>
    public void SetThreadPriority(ThreadPriority threadPriority)
    {
        foreach (var runner in _runners)
            runner.ThreadPriority = threadPriority;
    }

    /// <summary>
    /// Resets all metrics for the job runners managed by this scheduler.
    /// This does not set the MaxLastTickTime of the JobScheduler itself.
    /// The JobScheduler will maintain this value until the next time jobs are run.
    /// </summary>
    /// <remarks>
    /// </remarks>
    public void ResetMetrics()
    {
        lock (_lock)
        {
            // Each runner is reset via its own locked ResetMetrics(), not
            // ResetMetricsUnsafe() - the runners no longer share this scheduler's
            // lock (see issue #29), so resetting unsynchronised here would race with
            // that runner's own concurrent SafeStartTimer()/StopTimerAndUpdateMetrics().
            foreach (var runner in _runners)
                runner.ResetMetrics();
            _metricsCache.AsSpan().Clear();
        }
    }

    public void ResetMetricsUnsafe()
    {
        foreach (var runner in _runners)
            runner.ResetMetricsUnsafe();
        _metricsCache.AsSpan().Clear();
    }

    /// <summary>
    /// Provides access to the collection of JobRunners managed by this JobScheduler.
    /// </summary>
    /// <remarks>Use this at your own risk in the situations where jobs </remarks>
    /// <returns>ReadOnlySpan of JobRunners this JobScheduler manages.</returns>
    public ReadOnlySpan<JobRunner> GetRunners() => new(_runners);

    /// <summary>
    /// Gets a read-only span containing the current workloads assigned to the runner.
    /// </summary>
    /// <returns>A <see cref="ReadOnlySpan{Int32}"/> representing the workloads. The span reflects the current state of the
    /// underlying data and should not be used after the containing object is modified or disposed.</returns>
    public ReadOnlySpan<int> GetWorkLoads() => new(_runnerWorkloads);

    #region Private

    private int LeastBurdenedRunner()
    {
        var runner = 0;
        for (var i = 0; i < _runners.Length; ++i)
        {
            if (_runnerWorkloads[i] < _runnerWorkloads[runner])
                runner = i;
        }
        return runner;
    }

    private void ResetWorkloadCosts()
    {
        Array.Clear(_runnerWorkloads, 0, _runners.Length);
    }

    private bool IsAllRunnersIdle()
    {
        for (var i = 0; i < _runners.Length; ++i)
        {
            if (_runners[i].State != JobState.Idle)
                return false;
        }
        return true;
    }

    /// <summary>
    /// Updates the JobScheduler's MaxLastTickTime. Ensures that the final value is the Maximum of any
    /// JobRunners that might call this function concurrently.
    /// </summary>
    /// <param name="runner" cref="JobRunner">The JobRunner that has just completed its jobs</param>
    /// <param name="result" cref="ExecutionResult">The result of the job execution</param>
    /// <param name="jobQueueRunTime">The time in milliseconds it took to last run the jobs. If 'result' is not ExecutionResult.Success, this value is undefined</param>
    private void OnRunnerFinished(JobRunner runner, ExecutionResult result, double jobQueueRunTime)
    {
        if (result != ExecutionResult.Success)
            return;

        for (var i = 0; i < _runners.Length; ++i)
        {
            if (runner == _runners[i])
            {
                lock (_lock)
                {
                    // We can call GetMetricsUnsafe because the JobRunner has finished and we are actually running on its thread.
                    _metricsCache[i] = runner.GetMetricsUnsafe();
                }
                break;
            }
        }

        // Volatile.Read, not Interlocked.Exchange(ref _maxLastTickTime, _maxLastTickTime): the read
        // of the second argument and the exchange itself are two separate, non-atomic steps. If
        // another thread's CompareExchange below lands in the gap between them (via true parallel
        // execution or preemption), this call would silently write back our stale snapshot and
        // clobber their update.
        var maxLastTickTimeSnapShot = Volatile.Read(ref _maxLastTickTime);
        while (true)
        {
            if (jobQueueRunTime <= maxLastTickTimeSnapShot)
                return;

            var maxTimeBeforeChange = Interlocked.CompareExchange(
                ref _maxLastTickTime,
                jobQueueRunTime,
                maxLastTickTimeSnapShot
            );
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            // Disabled because we do want an exact bitwise test here, but IDEs can moan about not
            // using the floating point Epsilon check.
            if (maxTimeBeforeChange == maxLastTickTimeSnapShot)
                return;
            maxLastTickTimeSnapShot = maxTimeBeforeChange;
        }
    }

    // The indices of these three arrays must map to the same JobRunner. i.e. _runners[0] has its metrics in _metricsCache[0] and its workload in _runnerWorkloads[0]
    private readonly JobRunner[] _runners;
    private readonly int[] _runnerWorkloads;
    private readonly JobRunnerMetrics[] _metricsCache;

    // I experimented with various concurrency mechanisms like sequence locks and SpinWaiter objects and in the
    // end a simple lock performed basically as good as anything else and it is much simpler to grok.
    private readonly Lock _lock = new();

    // This doc: https://github.com/dotnet/runtime/blob/main/docs/design/specs/Memory-model.md#alignment
    // Says that on 64 bit systems an 8 byte variable is aligned to 8 bytes. We need this requirement
    // because atomicity is only guaranteed for doubles (and others) if they are aligned correctly.
    private double _maxLastTickTime;
    private readonly JobRunner.JobCompletedDelegate _jobCompletedDelegate;

    #endregion
}
