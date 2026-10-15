using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace Brutal.TextureApi;

/// <summary>
/// Provides basic functionality for tracking resources and their disposal. Call Track() to record an instance
/// of a resource and Untrack() to stop tracking.
/// <para/>
/// If you wish to see what resources are still being tracked, along with a formatted stacktrace of when they
/// were tracked you can call <see cref="CurrentResources"/>.
/// <para/>
/// Tracking and untracking resource is threadsafe and can be done from different threads. ResourceTracker uses a
/// <see cref="ConcurrentDictionary{TKey, TValue}" /> underneath and Interlocked calls to manage internal counts.
/// </summary>
/// <remarks>
/// ARKB: This is a very rudimentary implementation just so I could see the usage of textures in KSA. This class is internal
/// for a reason and not directly usable outside Brutal for now.
/// Making this a CriticalFinalizerObject means its finaliser will run after normal finalisers, giving
/// a chance for things to Untrack first.</remarks>
/// <typeparam name="T"></typeparam>
internal class ResourceTracker<T> : CriticalFinalizerObject
    where T : notnull
{
    public readonly struct TrackedResource
    {
        public T Instance { get; init; }
        public StackTrace? StackTrace { get; init; }
    }

    public ResourceTracker()
    {
        _trackedInstances = new(new Comparer());
#if RecordTrackingOverhead
        _stopwatch = new Stopwatch();
#endif
    }

    public void Reset()
    {
        Interlocked.Exchange(ref _totalResourcesTracked, 0);
        _trackedInstances.Clear();
    }

    /// <summary>
    /// The total number of resource items tracked since the tracker was
    /// created.
    /// </summary>
    public ulong TotalTrackedCount => Interlocked.Read(ref _totalResourcesTracked);

    /// <summary>
    /// The number of resources currently being tracked. This is the difference of
    /// TotalTrackedCount and the number of successfully Untrack()'ed resources.
    /// </summary>
    public ulong CurrentTrackedCount => (ulong)_trackedInstances.Count;

    /// <summary>
    /// Track a new resource instance. The resource must NOT already be tracked.
    /// </summary>
    /// <param name="resource">The object to track</param>
    /// <exception cref="InvalidOperationException">Thrown if the resource is already being tracked</exception>
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Track(in T resource)
    {
#if RecordTrackingOverhead
        var start = Stopwatch.GetTimestamp();
#endif
        if (!_trackedInstances.TryAdd(new() { Instance = resource, StackTrace = new StackTrace(1, true) }, 0))
            throw new InvalidOperationException($"Object of type {typeof(T).Name} already being tracked");
        Interlocked.Increment(ref _totalResourcesTracked);
#if RecordTrackingOverhead
        _totalTimeSpentTracking += Stopwatch.GetTimestamp() - start;
#endif
    }

    /// <summary>
    /// Stop tracking a resource.
    /// </summary>
    /// <param name="resource">The resource to stop tracking</param>
    /// <exception cref="InvalidOperationException">Thrown if the resource isn't being tracked</exception>
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Untrack(in T resource)
    {
#if RecordTrackingOverhead
        var start = Stopwatch.GetTimestamp();
#endif
        if (!_trackedInstances.TryRemove(new() { Instance = resource }, out _))
            throw new InvalidOperationException($"Object {resource} not found in tracked instances.");
#if RecordTrackingOverhead
        _totalTimeSpentTracking += Stopwatch.GetTimestamp() - start;
#endif
    }

    /// <summary>
    /// Return a collection of TrackedResource objects.
    /// </summary>
    /// <returns></returns>
    public IReadOnlyCollection<TrackedResource> CurrentResources()
    {
        return _trackedInstances.AsReadOnly().Keys;
    }

    public class Comparer : IEqualityComparer<TrackedResource>
    {
        public bool Equals(TrackedResource x, TrackedResource y)
        {
            return ReferenceEquals(x.Instance, y.Instance);
        }

        public int GetHashCode(TrackedResource obj)
        {
            return RuntimeHelpers.GetHashCode(obj.Instance);
        }
    }

#if RecordTrackingOverhead
    public void LogUnreleasedResources(int stackFrameCount)
    {
        Console.WriteLine(
            $"Overhead: {_totalTimeSpentTracking / (float)Stopwatch.Frequency / _totalResourcesTracked * 1000000}us"
        );

        if (_trackedInstances.IsEmpty)
            return;
        foreach (var instance in _trackedInstances.Keys)
            Console.WriteLine(
                $"Allocated here: {(instance.StackTrace is not null ? StackTraceToString(instance.StackTrace, stackFrameCount) : "no trace")}"
            );
    }
#endif

    private ulong _totalResourcesTracked = 0;
    private readonly ConcurrentDictionary<TrackedResource, byte> _trackedInstances;

#if RecordTrackingOverhead
    private readonly Stopwatch _stopwatch;
    public long _totalTimeSpentTracking = 0;
#endif
}
