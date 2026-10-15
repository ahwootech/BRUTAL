using System.Diagnostics;
using Brutal.Attributes;

namespace Brutal.Localization.FixedBuffers;

/// <summary>
/// An IFixedBufferWriter that will wrap around and reuse its storage if the length requested for a Span is greater than
/// the remaining storage but less than or equal to its capacity. If you ask for lengths that fit within it's remaining
/// storage it will return part or all of it's remaining storage depending on the length hint. However, if you ask for
/// <see cref="LengthHint.MaxLengthHint" /> or a specific size that's larger than the remaining storage, it can give you up
/// to its Capacity by wrapping around. Using <see cref="LengthHint.MaxLengthHint" /> with a <see cref="RingBufferWriter&lt;T&gt;" /> essentially gives you a writer that will automatically
/// reuse its storage each time you call GetSpan or TryGetSpan.
/// </summary>
/// <typeparam name="T">The element type stored in the RingBufferWriter.</typeparam>
/// <remarks>Instantiating a default instance of <see cref="RingBufferWriter&lt;T&gt;" /> is an error due to no specification
/// of the underlying buffer. Calls to <see cref="GetSpan" /> or <see cref="TryGetSpan" /> will throw <see cref="InvalidOperationException" /> in this case.</remarks>
public ref struct RingBufferWriter<T> : IFixedBufferWriter<T>
{
    /// <summary>
    /// Create a RingBufferWriter from a Span.
    /// </summary>
    /// <param name="span">The <see cref="System.Span&lt;T&gt;" /> to use as the underlying storage.</param>
    /// <exception cref="ArgumentException">Thrown if span is empty.</exception>
    public RingBufferWriter(Span<T> span)
    {
        if (span.IsEmpty)
            throw new ArgumentException("Span must not be empty", nameof(span));

        _span = span;
        _pos = 0;
    }

    /// <inheritdoc cref="IFixedBufferWriter{T}.Advance"/>
    public void Advance(ElementCount count)
    {
        if (count < 0 || (count > 0 && count > RemainingLength))
            throw new ArgumentOutOfRangeException(
                nameof(count),
                $"Advance count out of range. Valid values are 0-{RemainingLength}"
            );
        _pos += count;
    }

    /// <inheritdoc cref="IFixedBufferWriter{T}.GetSpan"/>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if requested length is zero. This limitation may be removed at a later date.</exception>
    /// <remarks>Instantiating a default instance of <see cref="RingBufferWriter&lt;T&gt;" /> is an error due to no specification
    /// of the underlying buffer. Calls to <see cref="GetSpan" /> or <see cref="TryGetSpan" /> will throw <see cref="InvalidOperationException" /> in this case.</remarks>
    public Span<T> GetSpan(ElementCount lengthHint)
    {
        if (lengthHint == 0)
            throw new ArgumentOutOfRangeException(
                nameof(lengthHint),
                "Cannot request a zero length span."
            );

        if (!TryGetSpan(lengthHint, out var spanOut))
            throw new ArgumentException(
                $"Out of buffer. requested:{lengthHint} available:{spanOut.Length}",
                nameof(lengthHint)
            );
        return spanOut;
    }

    /// <inheritdoc cref="IFixedBufferWriter{T}.TryGetSpan"/>
    /// <remarks>Instantiating a default instance of <see cref="RingBufferWriter&lt;T&gt;" /> is an error due to no specification
    /// of the underlying buffer. Calls to <see cref="GetSpan" /> or <see cref="TryGetSpan" /> will throw <see cref="InvalidOperationException" /> in this case.</remarks>
    public bool TryGetSpan(ElementCount lengthHint, out Span<T> spanOut)
    {
        ThrowIfNoCapacity();

        var returnLength = lengthHint;
        if (lengthHint == LengthHint.NonZeroLengthHint)
            returnLength = RemainingLength != 0 ? RemainingLength : Capacity;
        else if (lengthHint == LengthHint.MaxLengthHint || lengthHint > Capacity)
            returnLength = Capacity;
        else if (lengthHint < 0)
            throw new ArgumentOutOfRangeException(
                nameof(lengthHint),
                "lengthHint cannot be negative."
            );

        Debug.Assert(returnLength <= Capacity);

        if (returnLength > RemainingLength)
            Reset();

        spanOut = RemainingSpan;
        return lengthHint == LengthHint.NonZeroLengthHint
            || lengthHint == LengthHint.MaxLengthHint
            || spanOut.Length >= lengthHint;
    }

    private void ThrowIfNoCapacity()
    {
        if (Capacity < 1)
            throw new InvalidOperationException(
                $"Invalid Capacity (0). Did you create a default instance of this writer without a Span?"
            );
    }

    private Span<T> RemainingSpan => _span.Slice(_pos, RemainingLength);

    private void Reset() => _pos = 0;

    private int RemainingLength => _span.Length - _pos;
    private int Capacity => _span.Length;
    private int _pos;
    private readonly Span<T> _span;
}
