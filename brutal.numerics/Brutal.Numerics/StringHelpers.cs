namespace Brutal.Numerics;

/// <summary>Shared implementations backing the generated .format partials (TryFormat/TryParse).</summary>
internal static class StringHelpers
{
    /// <summary>Formats a vector as <c>&lt;1, 2, 3&gt;</c>, the shape its TryParse accepts back.</summary>
    /// <returns>false if <paramref name="destination" /> is too small.</returns>
    public static bool TryFormat<TVector, TComponent>(
        TVector value,
        Span<char> destination,
        out int charsWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
        where TVector : unmanaged, IVector<TVector, TComponent>
    {
        var separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;
        var formatString = format.IsEmpty ? null : format.ToString(); // the handler takes a string format (an IFormattable legacy) - null on the default path stays alloc-free
        var handler = new MemoryExtensions.TryWriteInterpolatedStringHandler(
            TVector.ComponentCount + 1,
            2 * TVector.ComponentCount - 1,
            destination,
            provider,
            out var b
        );
        b = b && handler.AppendLiteral("<");
        for (var i = 0; i < TVector.ComponentCount; i++)
        {
            b = b && handler.AppendFormatted(value[i], formatString);
            if (i != TVector.ComponentCount - 1)
                b = b && handler.AppendFormatted(separator) && handler.AppendLiteral(" ");
        }
        _ = b && handler.AppendLiteral(">");
        return destination.TryWrite(ref handler, out charsWritten);
    }

    /// <inheritdoc cref="TryFormat{TVector, TComponent}(TVector, Span{char}, out int, ReadOnlySpan{char}, IFormatProvider?)" />
    public static bool TryFormat<TVector, TComponent>(
        TVector value,
        Span<byte> destination,
        out int bytesWritten,
        ReadOnlySpan<char> format,
        IFormatProvider? provider
    )
        where TVector : unmanaged, IVector<TVector, TComponent>
    {
        var separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;
        var formatString = format.IsEmpty ? null : format.ToString(); // the handler takes a string format (an IFormattable legacy) - null on the default path stays alloc-free
        var handler = new Utf8.TryWriteInterpolatedStringHandler(
            TVector.ComponentCount + 1,
            2 * TVector.ComponentCount - 1,
            destination,
            provider,
            out var b
        );
        b = b && handler.AppendLiteral("<");
        for (var i = 0; i < TVector.ComponentCount; i++)
        {
            b = b && handler.AppendFormatted(value[i], formatString);
            if (i != TVector.ComponentCount - 1)
                b = b && handler.AppendFormatted(separator) && handler.AppendLiteral(" ");
        }
        _ = b && handler.AppendLiteral(">");
        return Utf8.TryWrite(destination, ref handler, out bytesWritten);
    }

    /// <summary>Parses a vector from the <see cref="TryFormat{TVector, TComponent}(TVector, Span{char}, out int, ReadOnlySpan{char}, IFormatProvider?)" /> shape, <c>&lt;1, 2, 3&gt;</c>.</summary>
    /// <returns>true if the input parsed as a TVector.</returns>
    public static bool TryParse<TVector, TComponent>(
        ReadOnlySpan<char> s,
        NumberStyles style,
        IFormatProvider? provider,
        out TVector result
    )
        where TVector : unmanaged, IVector<TVector, TComponent>
        where TComponent : INumberBase<TComponent>
    {
        result = default;
        s = s.Trim();
        if (s.Length < 2 || s[0] != '<' || s[^1] != '>')
            return false;
        s = s[1..^1];
        var separator = NumberFormatInfo.GetInstance(provider).NumberGroupSeparator;
        var value = default(TVector); // built in a local so a mid-parse failure leaves result untouched
        for (var i = 0; i < TVector.ComponentCount - 1; i++)
        {
            var separatorIndex = s.IndexOf(separator);
            // trimmed because TryFormat writes "separator + space": the slice must parse under
            // caller-supplied NumberStyles without demanding AllowLeadingWhite for OUR whitespace
            if (
                separatorIndex < 0
                || !TComponent.TryParse(s[..separatorIndex].Trim(), style, provider, out var component)
            )
                return false;
            value[i] = component;
            s = s[(separatorIndex + separator.Length)..];
        }
        if (!TComponent.TryParse(s.Trim(), style, provider, out var last))
            return false;
        value[TVector.ComponentCount - 1] = last;
        result = value;
        return true;
    }
}
