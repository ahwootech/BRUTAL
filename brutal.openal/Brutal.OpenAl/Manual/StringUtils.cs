// The outbound half of the package's UTF-8 boundary plumbing (inbound half: Utf8Buffer.cs). Every
// string-bearing import is a raw byte*; alcGetString's return can be a double-NUL-terminated
// device list rather than a scalar string. Callers copy the library-owned buffer into managed
// memory via these helpers before checking errors, since it is only valid until the next ALC call.

using Brutal.Strings;

namespace Brutal.OpenAlApi;

internal static unsafe class StringUtils
{
    /// <summary>
    ///     Copies a NUL-terminated UTF-8 string into a managed string, preserving a null pointer as
    ///     <see langword="null"/>.
    /// </summary>
    internal static string? Utf8ToString(byte* p) => p is null ? null : Utf8.GetString(p);

    /// <summary>
    ///     Splits a double-NUL-terminated UTF-8 string list into a managed array; a null pointer or an
    ///     empty list yields an empty array.
    /// </summary>
    internal static string[] Utf8ListToStrings(byte* p)
    {
        if (p is null)
            return [];

        var result = new List<string>();
        while (*p != 0)
        {
            var entry = Utf8.GetNullTerminatedSpan(p);
            result.Add(Utf8.GetString(entry));
            p += entry.Length + 1; // step over this entry's terminator
        }
        return [.. result];
    }
}
