using System.Buffers;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Brutal.Strings;

public static class Unicode
{
    // TODO: should all these be extensions?
    // TODO: do we also need GetCellWidth()? approximate terminal-cell width of a single rune (wcwidth-style)

    /// Count the number of runes (code points) in a string,
    /// leniently: each invalid sequence counts as one replacement.
    [Pure]
    public static int GetRuneCount(String16View value)
    {
        var count = 0;
        var runes = value.EnumerateRunes();
        while (runes.MoveNext())
            count++;
        return count;
    }

    /// <inheritdoc cref="GetRuneCount(String16View)" />
    [Pure]
    public static int GetRuneCount(String8View value)
    {
        var count = 0;
        while (true)
        {
            var status = Rune.DecodeFromUtf8(value, out _, out var bytesConsumed);
            if (status == OperationStatus.NeedMoreData)
            {
                // bytesConsumed == 0 -> end of input (clean)
                // bytesConsumed > 0 -> trailing partial: count as one replacement,
                // matching the UTF-16 EnumerateRunes() which counts a lone surrogate the same way.
                if (bytesConsumed > 0)
                    count++;
                return count;
            }
            value = value[bytesConsumed..];
            count++;
        }
    }

    /// <inheritdoc cref="GetRuneCount(String16View)" />
    [Pure]
    public static int GetRuneCount<TChar>(ReadOnlySpan<TChar> value)
        where TChar : unmanaged, IBinaryInteger<TChar>
    {
        return typeof(TChar) == typeof(Char8) ? GetRuneCount(value.AsChar8()) : GetRuneCount(value.AsChar16());
    }

    /// Count the number of graphemes in a string.
    [Pure]
    public static int GetGraphemeCount(String16View value)
    {
        var count = 0;
        while (!value.IsEmpty)
        {
            var next = StringInfo.GetNextTextElementLength(value);
            if (next == 0)
                break; // TODO: null-terminator is somewhat unexpected, should we throw instead?
            value = value[next..];
            count++;
        }

        return count;
    }

    /// <inheritdoc cref="GetGraphemeCount(String16View)" />
    [Pure]
    public static int GetGraphemeCount(String8View value)
    {
        using (Utf8.GetChars(value, stackalloc Char16[256], out var chars))
        {
            return GetGraphemeCount(chars);
        }
    }

    /// <inheritdoc cref="GetGraphemeCount(String16View)" />
    [Pure]
    public static int GetGraphemeCount<TChar>(ReadOnlySpan<TChar> value)
        where TChar : unmanaged, IBinaryInteger<TChar>
    {
        return typeof(TChar) == typeof(Char8) ? GetGraphemeCount(value.AsChar8()) : GetGraphemeCount(value.AsChar16());
    }
}
