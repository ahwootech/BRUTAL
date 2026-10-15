using System.Numerics;

namespace Brutal.Concurrency.Statistics;

/// <summary>
/// Sampler used by the Job system for its metrics.
/// </summary>
/// <typeparam name="TNumber"></typeparam>
public class Sampler<TNumber>
    where TNumber : INumber<TNumber>,
        IAdditionOperators<TNumber, TNumber, TNumber>,
        ISubtractionOperators<TNumber, TNumber, TNumber>,
        IMinMaxValue<TNumber>,
        INumberBase<TNumber>
{
    public Sampler()
    {
        Average = TNumber.Zero;
        Max = TNumber.MinValue;
        Last = TNumber.Zero;
    }

    public void Add(TNumber value)
    {
        Last = value;
        Max = TNumber.Max(value, Max);
        Average = _movingAverage.Update(value);
    }

    public void Reset()
    {
        _movingAverage.Reset();
        Average = TNumber.Zero;
        Max = TNumber.MinValue;
        Last = TNumber.Zero;
    }

    public TNumber Average { get; private set; }
    public TNumber Max { get; private set; }
    public TNumber Last { get; private set; }

    private readonly MovingAverage<TNumber> _movingAverage = new(50);
}
