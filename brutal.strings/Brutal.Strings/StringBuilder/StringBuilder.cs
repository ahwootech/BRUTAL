using System.Buffers;
using System.Numerics;

namespace Brutal.Strings;

using static StringBuilderUtility;

/// <summary>
/// A mutable sequence of UTF-8 or UTF-16 code units (depending on <typeparamref name="TChar"/>) with a
/// growable, null-terminated buffer and optional <see cref="MaxCapacity"/> limit. Supports C# interpolated
/// string handlers via <see cref="Interpolator"/>.
/// </summary>
/// <remarks>
/// There is deliberately no implicit conversion to <see cref="Span{T}"/>/<see cref="ReadOnlySpan{T}"/>:
/// call <see cref="WrittenSpan"/> so the borrow is visible at the call site. A span into the buffer is a
/// borrow, not a copy - span lifetime and safety are the caller's concern.
/// </remarks>
public partial class StringBuilder<TChar> : IUtf8SpanFormattable, ISpanFormattable
    where TChar : unmanaged, IBinaryInteger<TChar> // IUtfChar<TChar> would be perfect, but is internal
{
    /// Initializes a new instance of <see cref="StringBuilder{TChar}"/>.
    /// <remarks>The output span is always null-terminated. The null terminator is not included in the capacity.</remarks>
    /// <param name="capacity">Initial capacity. Must be positive.</param>
    /// <param name="maxCapacity">Maximum capacity. Defaults to <see cref="Array.MaxLength"/> - 1.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity"/> is not positive.</exception>
    /// <exception cref="ArgumentException"><paramref name="maxCapacity"/> is less than <paramref name="capacity"/> or exceeds <see cref="Array.MaxLength"/> - 1.</exception>
    public StringBuilder(int capacity = 64, int maxCapacity = ArrayMaxUsableLength)
    {
        if (capacity <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be positive.");
        if (maxCapacity < capacity)
            throw new ArgumentException("Max capacity cannot be less than capacity.", nameof(maxCapacity));
        if (maxCapacity > ArrayMaxUsableLength)
            throw new ArgumentException("Max capacity cannot exceed (Array.MaxLength - 1).", nameof(maxCapacity));

        _storage = new TChar[capacity + 1]; // +1 for null terminator - hidden from callers
        MaxCapacity = maxCapacity;
    }

    /// for pooling
    internal void ResetToDefault()
    {
        Clear();
        NewLine = Environment.NewLine;
        // Capacity is not reset to default - the price to pay for using a pooled instance.
        // MaxCapacity isn't configurable in pooled instances.
    }

    #region storage

    private TChar[] _storage;

    /// Gets the current capacity.
    public int Capacity => _storage.Length - 1;

    /// Gets the maximum capacity this instance can grow to.
    public readonly int MaxCapacity;

    private void Resize(long newCapacity)
    {
        Array.Resize(ref _storage, (int)Math.Min(newCapacity, MaxCapacity) + 1); // +1 for null terminator
    }

    /// Doubles capacity until <paramref name="appendCount"/> more elements fit.
    /// <exception cref="ArgumentOutOfRangeException">Required capacity exceeds <see cref="MaxCapacity"/>.</exception>
    private void GrowBy(int appendCount)
    {
        var requiredCapacity = (long)_position + appendCount;
        if (requiredCapacity > MaxCapacity)
            throw new ArgumentOutOfRangeException(nameof(MaxCapacity), "Cannot grow beyond MaxCapacity.");

        // keep doubling capacity until it's at least requiredCapacity
        var newCapacity = (long)Capacity; // long to avoid overflow when doubling
        do newCapacity *= 2;
        while (newCapacity < requiredCapacity);
        Resize(newCapacity);
    }

    #endregion

    #region position

    private int _position;

    /// The remaining we can write into (excluding null-terminator). GetSpan grows first if it's too small.
    private Span<TChar> FreeSpan => _storage.AsSpan(_position..^1); // -1 for null terminator

    /// Gets the elements written so far. The element immediately after this span is always the null-terminator.
    /// Borrowed view: invalidated by any later write or rewind (Append/Clear/Advance/Position). Don't retain it
    /// past the next mutation; materialize a copy (WrittenSpan.ToString16()) if you need it to outlive the builder.
    public ReadOnlySpan<TChar> WrittenSpan => _storage.AsSpan(.._position);

    /// Current write position. Get to capture a savepoint; set (rewind-only) to restore one.
    /// Setter is shrink-only: value must be in [0, current Position]. Extending isn't supported -
    /// it would expose uninitialized buffer bytes. Use GetSpan + Advance for allocate-then-fill.
    public int Position
    {
        get => _position;
        set
        {
            if ((uint)value > (uint)_position) // uint cast also checks against negative position
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Position can only be rewound; use Advance to move forward."
                );
            MoveTo(value);
        }
    }

    /// BCL <see cref="System.Text.StringBuilder.Length"/>-compat alias for <see cref="Position"/>.
    /// New code should prefer Position. Unlike BCL, the setter is shrink-only (no zero-fill, no extension);
    /// use GetSpan + Advance for allocate-then-fill.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int Length
    {
        get => _position;
        set => Position = value;
    }

    private void MoveTo(int position)
    {
        _position = position;
        _storage[position] = TChar.Zero; // null terminate
    }

    /// We failed while trying to write: restore our null terminator in case it got clobbered by a partial write.
    private bool Fail()
    {
        _storage[_position] = TChar.Zero; // null terminate
        return false;
    }

    /// We failed while trying to write: restore to checkpoint.
    private bool Fail(int checkpoint)
    {
        MoveTo(checkpoint);
        return false;
    }

    /// <inheritdoc cref="IBufferWriter{TChar}.Advance"/>
    public void Advance(int count)
    {
        if (count < 0 || count > FreeSpan.Length)
            throw new ArgumentOutOfRangeException(nameof(count));
        MoveTo(_position + count);
    }

    /// Clears all written content without releasing the underlying buffer.
    public void Clear() => MoveTo(0);

    #endregion

    private Span<TChar> GetSpan(int sizeHint)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeHint);
        var requested = Math.Max(sizeHint, 1);
        if (requested > FreeSpan.Length)
            GrowBy(requested);
        return FreeSpan;
    }

    private bool TryGetSpan(int contentSizeHint, int alignment, out Span<TChar> destination)
    {
        var sizeHint = Math.Max(contentSizeHint, Math.Abs(alignment));
        destination = FreeSpan;
        return destination.Length >= sizeHint;
    }

    /// Gets or sets the newline sequence used by <see cref="AppendLine{T}"/>. Defaults to <see cref="Environment.NewLine"/>.
    public string NewLine = Environment.NewLine;

    #region string formatting: IUtf8SpanFormattable, ISpanFormattable, IFormattable

    /// <inheritdoc/>
    [Obsolete("Allocates. Use WrittenSpan for zero-alloc, or WrittenSpan.ToString16() if you truly want a string.")]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
    public override string ToString()
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
    {
        return WrittenSpan.ToString16();
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="format"/> and <paramref name="formatProvider"/> are ignored.</remarks>
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
    {
        return WrittenSpan.ToString16();
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="format"/> and <paramref name="provider"/> are ignored.</remarks>
    bool ISpanFormattable.TryFormat(
        Span<Char16> destination,
        out int charsWritten,
        ReadOnlySpan<Char16> format,
        IFormatProvider? provider
    )
    {
        return Utf<Char16>.TryGetElements(WrittenSpan, destination, out charsWritten);
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="format"/> and <paramref name="provider"/> are ignored.</remarks>
    bool IUtf8SpanFormattable.TryFormat(
        Span<Char8> destination,
        out int bytesWritten,
        ReadOnlySpan<Char16> format,
        IFormatProvider? provider
    )
    {
        return Utf<Char8>.TryGetElements(WrittenSpan, destination, out bytesWritten);
    }

    #endregion
}
