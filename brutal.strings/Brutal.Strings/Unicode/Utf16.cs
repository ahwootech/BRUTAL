using System.Diagnostics.Contracts;

namespace Brutal.Strings;

/// <summary>UTF-16 / char-span counterpart of <see cref="Utf8"/>. Minimal surface for now.</summary>
public static partial class Utf16
{
    /// <summary>
    /// Count the number of chars in a null-terminated char array.
    /// </summary>
    [Pure]
    public static unsafe int GetCharCount(Ptr<Char16> chars)
    {
        return MemoryMarshal.CreateReadOnlySpanFromNullTerminated(chars).Length;
    }

    /// <summary>
    /// Convert a null-terminated char array to a <see cref="Span{T}"/> containing the chars up to the null terminator.
    /// </summary>
    [Pure]
    public static unsafe String16View GetNullTerminatedSpan(Ptr<Char16> chars)
    {
        return MemoryMarshal.CreateReadOnlySpanFromNullTerminated(chars);
    }
}
