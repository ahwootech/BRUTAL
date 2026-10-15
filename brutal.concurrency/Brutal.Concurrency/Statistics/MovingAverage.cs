using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Brutal.Concurrency.Statistics;

/// <summary>
/// Provides a moving average over a fixed window of samples.
/// </summary>
/// <typeparam name="TNumber">The underlying sample type</typeparam>
public class MovingAverage<TNumber>
    where TNumber : INumber<TNumber>,
        IDivisionOperators<TNumber, TNumber, TNumber>,
        IModulusOperators<TNumber, TNumber, TNumber>
{
    /// <summary>
    /// Create a moving average sampler with a fixed window size.
    /// </summary>
    /// <param name="maxWindowSampleCount">The maximum number of samples to compute the average over</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if maxWindowSampleCount &lt;= 0</exception>
    public MovingAverage(uint maxWindowSampleCount)
    {
        if (maxWindowSampleCount <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(maxWindowSampleCount),
                "Must be greater than 0"
            );

        _maxWindowSampleCount = maxWindowSampleCount;
        _currentWindowSampleCount = 0;
        _values = new TNumber[maxWindowSampleCount];
    }

    /// <summary>
    /// Clears all samples from the moving average.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Reset()
    {
        Array.Clear(_values);
        _index = 0;
        _currentWindowSampleCount = 0;
        _sum = TNumber.Zero;
    }

    /// <summary>
    /// Adds a sample to the moving average window and returns the updated average.
    /// </summary>
    /// <param name="sample"></param>
    /// <returns></returns>
    public TNumber Update(TNumber sample)
    {
        _sum = _sum - _values[_index] + sample;
        _values[_index] = sample;
        _index = (_index + 1) % _maxWindowSampleCount;
        _currentWindowSampleCount = Math.Min(_currentWindowSampleCount + 1, _maxWindowSampleCount);
        return _sum / TNumber.CreateTruncating(_currentWindowSampleCount);
    }

    /// <summary>
    /// Returns the number of samples currently in the moving average window.
    /// </summary>
    /// <remarks>
    /// This is not the total number of samples added, but the number that are
    /// being considered for the moving average. i.e. Up until max window sample count is reached,
    /// this will be equal to the number of samples added, but once the max window sample count is reached
    /// this value will be equal to the max window sample count.
    /// </remarks>
    /// <returns>The number of samples in the moving average window.</returns>
    public uint SampleCount => _currentWindowSampleCount;

    /// <summary>
    /// Returns the current average of all samples, or <c>TNumber.Zero</c> if no samples have been added.
    /// </summary>
    public TNumber CurrentAverage =>
        _currentWindowSampleCount == 0
            ? TNumber.Zero
            : _sum / TNumber.CreateTruncating(_currentWindowSampleCount);

    private readonly uint _maxWindowSampleCount;
    private uint _currentWindowSampleCount;
    private readonly TNumber[] _values;
    private uint _index;
    private TNumber _sum = TNumber.Zero;
}
