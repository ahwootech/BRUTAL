using System.Buffers;
using Brutal.Localization;

namespace Brutal.ImGuiApi;

/// A UTF8 ref-string, for passing to ImGui API.
/// Allocated in an arena buffer -> life-span of one frame (or less), cannot be retained.
public ref partial struct ImString : IUtf8SpanFormattable, ISpanFormattable, INullable
{
    public class Storage(int capacity) : ArenaStringBuilder(capacity)
    {
        // TODO: mark [Obsolete] / replace with ImString.Clear()
        public void Reset() => Clear();
    }

    public static readonly Storage SharedStorage = new(8 * 1024 * 1024);

    private ReadOnlySpan<byte> _bytes;

    public ImString(ReadOnlySpan<byte> value)
    {
        _bytes = value; // avoid copying UTF8 literals
    }

    public ImString(ReadOnlySpan<byte> value, bool copy)
    {
        _bytes = copy ? SharedStorage.Append(value) : value;
    }

    public ImString(ReadOnlySpan<char> value)
    {
        _bytes = SharedStorage.Append(value);
    }

    public static implicit operator ImString(ReadOnlySpan<byte> value) => new(value);

    public static implicit operator ImString(Span<byte> value) => new(value);

    public static implicit operator ImString(ReadOnlySpan<char> value) => new(value);

    public static implicit operator ImString(Span<char> value) => new(value);

    public static implicit operator ImString(string value) => new(value);

    public static implicit operator ImString(String8 value) => new(value, true); // String8 isn't fixed, so we need to copy it

    public static implicit operator ImString(RefString8 value) => new(value.AsSpan());

    public static implicit operator ImString(LString value) => new(value.Format());

    public static implicit operator ImString(Ptr<byte> value) => new(Utf8.GetNullTerminatedSpan(value));

    public static implicit operator ReadOnlySpan<byte>(in ImString s) => s._bytes;

    public readonly ReadOnlySpan<byte> AsSpan() => _bytes;

    /// for PInvoke
    public ref readonly byte GetPinnableReference() => ref MemoryMarshal.GetReference(_bytes);

    /// Convert to UTF16
    public readonly Span<char> GetChars(Span<char> chars)
    {
        var len = Utf8.GetChars(_bytes, chars);
        return chars[..len];
    }

    private static byte _forceNull;

    /// Used to distinguish between "unset" vs "set to null" in optional arguments.
    public static ImString Null => new ReadOnlySpan<byte>(ref _forceNull)[..0];

    /// Returns a null-terminated empty string.
    public static ImString Empty => ""u8;

    /// Was a value set? Used to distinguish between "unset" vs "set to null" in optional arguments.
    public readonly bool IsSet => !_bytes.IsNull();

    /// Was a value set? Used to distinguish between "unset" vs "set to null" in optional arguments.
    public readonly bool IsUnset => _bytes.IsNull();

    /// Whether this represents a null string rather than an empty string.
    /// Technically "IsDefault", but "IsNull" seems more intuitive.
    public readonly bool IsNull() => _bytes.IsNull() || _bytes == Null;

    public readonly bool IsEmpty => _bytes.IsEmpty;

    // TODO: ensure byte count is always accurate / detect null-terminated byte spans
    // TODO: evaluate character count vs byte count
    public readonly int Length => _bytes.Length;

    #region IUtf8SpanFormattable, ISpanFormattable, IFormattable

    /// IUtf8SpanFormattable implementation
    public bool TryFormat(
        Span<byte> utf8Destination,
        out int bytesWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
    {
        if (_bytes.TryCopyTo(utf8Destination))
        {
            bytesWritten = _bytes.Length;
            return true;
        }

        bytesWritten = 0;
        return false;
    }

    /// ISpanFormattable implementation
    public bool TryFormat(
        Span<char> utf16Destination,
        out int charsWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
    {
        return Utf8.ToUtf16(_bytes, utf16Destination, out _, out charsWritten) != OperationStatus.Done;
    }

    /// IFormattable implementation - useless but required for ISpanFormattable
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider) => ToString();

    #endregion
}
