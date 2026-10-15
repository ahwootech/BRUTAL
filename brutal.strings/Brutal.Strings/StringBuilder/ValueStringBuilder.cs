using System.Buffers;
using System.Numerics;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.Strings;

/// <summary>Stack-friendly string builder over a borrowed <see cref="Span{T}"/> buffer. No growth, no allocation.</summary>
/// <inheritdoc cref="StringBuilder{TChar}" path="/remarks"/>
/// <example>
/// <code>
/// var sb = stackalloc byte[256].ToStringBuilder();
/// sb.Append("x="u8);
/// sb.Append(42);
/// // sb.WrittenSpan == "x=42"u8
/// </code>
/// </example>
public ref partial struct ValueStringBuilder<TChar>
    where TChar : unmanaged, IBinaryInteger<TChar>
{
    /// <param name="buffer">Buffer to write into. Must hold at least 1 element (for the null terminator).</param>
    /// <exception cref="ArgumentException"><paramref name="buffer"/> is empty.</exception>
    public ValueStringBuilder(Span<TChar> buffer)
    {
        if (buffer.Length < 1)
            throw new ArgumentException(
                "Buffer must hold at least 1 element (for the null terminator).",
                nameof(buffer)
            );
        _storage = buffer;
        _storage[0] = TChar.Zero;
    }

    #region storage

    private readonly Span<TChar> _storage;

    /// Gets the current capacity.
    public int Capacity => _storage.Length - 1;

    #endregion

    #region position

    private int _position;

    /// The remaining we can write into (excluding null-terminator). GetSpan grows first if it's too small.
    private Span<TChar> FreeSpan => _storage[_position..^1]; // -1 for null terminator

    /// <inheritdoc cref="StringBuilder{TChar}.WrittenSpan"/>
    public ReadOnlySpan<TChar> WrittenSpan => _storage[.._position];

    /// <inheritdoc cref="StringBuilder{TChar}.Position"/>
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

    /// <inheritdoc cref="StringBuilder{TChar}.Length"/>
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
            throw new ArgumentOutOfRangeException(nameof(Capacity), "Cannot grow.");
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
}

public static class CharSpanExtensions
{
    /// <inheritdoc cref="ValueStringBuilder{TChar}" />
    public static ValueStringBuilder8 ToStringBuilder(this Span<Char8> value) => new(value);

    /// <inheritdoc cref="ValueStringBuilder{TChar}" />
    public static ValueStringBuilder16 ToStringBuilder(this Span<Char16> value) => new(value);
}
