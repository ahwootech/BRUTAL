using System.Diagnostics.Contracts;
using System.Numerics;
using System.Text;
using Brutal.Extensions;

namespace Brutal.Strings;

public static class Utf<TChar>
    where TChar : unmanaged, IBinaryInteger<TChar> // IUtfChar<TChar> would be perfect, but is internal
{
    static Utf()
    {
        if (typeof(TChar) != typeof(Char8) && typeof(TChar) != typeof(Char16))
            throw new NotSupportedException(
                $"Utf<TChar> supports only Char8 (byte) and Char16 (char): {typeof(TChar)} is unsupported."
            );
    }

    /// Count the number of code units in <paramref name="value"/>.
    [Pure]
    public static int GetElementCount(String8View value)
    {
        return typeof(TChar) == typeof(Char8) ? value.Length : Utf8.GetCharCount(value);
    }

    /// <inheritdoc cref="GetElementCount(String8View)"/>
    [Pure]
    public static int GetElementCount(String16View value)
    {
        return typeof(TChar) == typeof(Char16) ? value.Length : Utf8.GetByteCount(value);
    }

    /// Copy/convert <paramref name="value"/> into <paramref name="destination"/>.
    public static void GetElements(String8View value, Span<TChar> destination)
    {
        if (typeof(TChar) == typeof(Char8))
            value.CopyTo(destination.AsChar8());
        else
            Utf8.GetChars(value, destination.AsChar16());
    }

    /// <inheritdoc cref="GetElements(String8View, Span{TChar})"/>
    public static void GetElements(String16View value, Span<TChar> destination)
    {
        if (typeof(TChar) == typeof(Char16))
            value.CopyTo(destination.AsChar16());
        else
            Utf8.GetBytes(value, destination.AsChar8());
    }

    /// Try to copy/convert <paramref name="value"/> into <paramref name="destination"/>.
    public static bool TryGetElements(String8View value, Span<TChar> destination, out int elementsWritten)
    {
        return typeof(TChar) == typeof(Char8)
            ? value.TryCopyTo(destination.AsChar8(), out elementsWritten)
            : Utf8.TryGetChars(value, destination.AsChar16(), out elementsWritten);
    }

    /// <inheritdoc cref="TryGetElements(String8View, Span{TChar}, out int)"/>
    public static bool TryGetElements(String16View value, Span<TChar> destination, out int elementsWritten)
    {
        return typeof(TChar) == typeof(Char16)
            ? value.TryCopyTo(destination.AsChar16(), out elementsWritten)
            : Utf8.TryGetBytes(value, destination.AsChar8(), out elementsWritten);
    }

    /// <inheritdoc cref="TryGetElements(String8View, Span{TChar}, out int)"/>
    public static bool TryGetElements<TSource>(
        ReadOnlySpan<TSource> value,
        Span<TChar> destination,
        out int elementsWritten
    )
        where TSource : unmanaged, IBinaryInteger<TSource>
    {
        return typeof(TSource) == typeof(Char16)
            ? TryGetElements(value.AsChar16(), destination, out elementsWritten)
            : TryGetElements(value.AsChar8(), destination, out elementsWritten);
    }

    /// <inheritdoc cref="Utf8.GetNullTerminatedSpan" />
    [Pure]
    public static ReadOnlySpan<TChar> GetNullTerminatedSpan(Ptr<TChar> first)
    {
        if (typeof(TChar) == typeof(Char8))
        {
            var bytes = Utf8.GetNullTerminatedSpan(first.Cast<Char8>());
            return Unsafe.BitCast<ReadOnlySpan<Char8>, ReadOnlySpan<TChar>>(bytes);
        }
        else
        {
            var chars = Utf16.GetNullTerminatedSpan(first.Cast<Char16>());
            return Unsafe.BitCast<ReadOnlySpan<Char16>, ReadOnlySpan<TChar>>(chars);
        }
    }

    /// <inheritdoc cref="string.ToCharArray()"/>
    /// <remarks>Allocates! Last resort helper for old string/array APIs - use spans when possible.</remarks>
    [Pure]
    public static TChar[] ToElementArray(string text)
    {
        return typeof(TChar) == typeof(Char8)
            ? Unsafe.As<TChar[]>(Encoding.UTF8.GetBytes(text))
            : Unsafe.As<TChar[]>(text.ToCharArray());
    }

    /// <inheritdoc cref="Utf8.TryFormat{T}" />
    [Pure]
    public static bool TryFormat<T>(
        T value,
        Span<TChar> destination,
        out int elementsWritten,
        string? format = null,
        IFormatProvider? provider = null
    )
    {
        return typeof(TChar) == typeof(Char8)
            ? Utf8.TryFormat(value, destination.AsChar8(), out elementsWritten, format, provider)
            : Utf16.TryFormat(value, destination.AsChar16(), out elementsWritten, format, provider);
    }

    /// <summary>
    /// Pad <paramref name="destination"/> to <paramref name="alignment"/> graphemes
    /// (right-align if positive, left-align if negative) by inserting/appending spaces.
    /// Returns false if <paramref name="destination"/> isn't big enough to fit the padded content
    /// (caller must grow + retry, or roll back).
    /// </summary>
    /// <remarks>
    /// The buffer may need to hold more elements than <paramref name="alignment"/> alone suggests:
    /// graphemes can occupy multiple code units (é = 2 UTF-8 bytes; a combining mark adds its own unit),
    /// so the effective element target is alignment + (elementsWritten − graphemes).
    /// </remarks>
    /// <param name="destination">The buffer to align within</param>
    /// <param name="elementsWritten">How many code units were written to <paramref name="destination"/> - updated to include padding on success</param>
    /// <param name="alignment">How many graphemes to align by</param>
    public static bool TryAlign(Span<TChar> destination, ref int elementsWritten, int alignment)
    {
        if (alignment == 0)
            return true;

        // Convert alignment from grapheme-count to code-unit-count.
        // IsAscii check is cheap, and avoids the much-rarer slow-path UAX-#29 segmentation.
        var written = destination[..elementsWritten];
        var graphemeOffset = IsAscii(written) ? 0 : elementsWritten - Unicode.GetGraphemeCount(written);
        alignment += graphemeOffset * Math.Sign(alignment);

        return TryAppendOrInsertAlignmentIfNeeded(destination, ref elementsWritten, 0, alignment);
    }

    private static bool IsAscii(ReadOnlySpan<TChar> span)
    {
        return typeof(TChar) == typeof(Char8) ? Ascii.IsValid(span.AsChar8()) : Ascii.IsValid(span.AsChar16());
    }

    /// Source: https://github.com/dotnet/runtime/blob/f1874490fcf9ebaebff1ff5b9536742a286d145b/src/libraries/System.Private.CoreLib/src/System/Text/Unicode/Utf8.cs#L773
    public static bool TryAppendOrInsertAlignmentIfNeeded(
        Span<TChar> destination,
        ref int position,
        int startingPos,
        int alignment
    )
    {
        Debug.Assert(startingPos >= 0 && startingPos <= position);
        Debug.Assert(alignment != 0);

        var elementsWritten = position - startingPos;

        var leftAlign = false;
        if (alignment < 0)
        {
            leftAlign = true;
            alignment = -alignment;
        }

        var paddingNeeded = alignment - elementsWritten;
        if (paddingNeeded <= 0)
        {
            return true;
        }

        if (paddingNeeded <= destination.Length - position)
        {
            var space =
                typeof(TChar) == typeof(Char8)
                    ? Unsafe.BitCast<Char8, TChar>((Char8)' ')
                    : Unsafe.BitCast<Char16, TChar>((Char16)' ');
            if (leftAlign)
            {
                destination.Slice(position, paddingNeeded).Fill(space);
            }
            else
            {
                destination.Slice(startingPos, elementsWritten).CopyTo(destination.Slice(startingPos + paddingNeeded));
                destination.Slice(startingPos, paddingNeeded).Fill(space);
            }

            position += paddingNeeded;
            return true;
        }

        return false;
    }
}
