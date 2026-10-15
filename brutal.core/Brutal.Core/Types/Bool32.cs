using Brutal.Extensions;

namespace Brutal;

/// <summary>
///     Represents a boolean value interoped as a 32-bit integer.
/// </summary>
public struct Bool32(bool value) : IUtf8SpanFormattable, ISpanFormattable
{
    private readonly int _value = value ? 1 : 0;

    /// <summary>
    /// Implicit conversion to bool
    /// </summary>
    public static implicit operator bool(Bool32 b)
    {
        return b._value != 0;
    }

    /// <summary>
    /// Implicit conversion from bool
    /// </summary>
    public static implicit operator Bool32(bool b)
    {
        return new Bool32(b);
    }

    #region string formatting: IUtf8SpanFormattable, ISpanFormattable, IFormattable

    private bool AsBool => _value != 0;

    /// <inheritdoc/>
    public override string ToString()
    {
        return AsBool.ToString(); // non-allocating
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="format"/> and <paramref name="formatProvider"/> are ignored.</remarks>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return AsBool.ToString(formatProvider); // non-allocating, ignores formatProvider / same as ToString()
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="format"/> and <paramref name="provider"/> are ignored.</remarks>
    public bool TryFormat(
        Span<char> destination,
        out int charsWritten,
        ReadOnlySpan<char> format = default,
        IFormatProvider? provider = null
    )
    {
        return AsBool.TryFormat(destination, out charsWritten, format);
    }

    /// <inheritdoc/>
    /// <remarks><paramref name="provider"/> is ignored.</remarks>
    public bool TryFormat(
        Span<byte> destination,
        out int bytesWritten,
        ReadOnlySpan<char> format = default,
        IFormatProvider? provider = null
    )
    {
        return AsBool.TryFormat(destination, out bytesWritten, format);
    }

    #endregion
}
