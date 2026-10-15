using System.Buffers;
using System.Diagnostics.Contracts;
using System.Globalization;
using Brutal.Enums;
using Brutal.Extensions;

namespace Brutal.Strings;

/*
 * KEEP IN SYNC with Utf8.TryFormat.cs - these two files mirror the same dispatch ladder and helper method
 * order so they diff cleanly. Differences are encoding-specific and noted inline:
 *   - Utf8 needs TryFormat_ISpanFormattable (UTF-16 stack buffer → UTF-8 transcode), and TryAppend(ROS<char>, Span<byte>)
 *     to transcode the string fast-path / ICustomFormatter / IFormattable fallback. Utf16 doesn't (ISpanFormattable
 *     IS the native UTF-16 path; the equivalent TryAppend is just a CopyTo).
 *   - Both encodings have bool / char extension methods, for symmetric reasons:
 *     * bool: implements neither ISpanFormattable nor IUtf8SpanFormattable. BCL provides Boolean.TryFormat
 *       for Span<char> but it's format-less (2-arg). Both extensions route through Utf{8,16}Formatter to
 *       support the G/l format vocabulary (BCL provides Utf8Formatter; we provide Utf16Formatter,
 *       deliberately diverging from the BCL's format-less char-side to keep our two encoding surfaces aligned).
 *     * char: char.TryFormat is format-less / explicit on ISpanFormattable (boxes value types via the interface).
 *       Both extensions inline the single-element write to dodge the box.
 */

public static partial class Utf16
{
    /// <summary>
    /// Tries to format <paramref name="value"/> as UTF-16 into <paramref name="destination"/>.
    /// Equivalent to <see cref="ISpanFormattable.TryFormat"/> but works for any <typeparamref name="T"/>.
    /// </summary>
    /// <remarks>
    /// Dispatch priority:
    /// - <see cref="ICustomFormatter"/> (via <paramref name="provider"/>)
    /// - typed fast-paths: string, enum, primitive <see cref="ISpanFormattable"/> value-types
    /// - <see cref="ISpanFormattable"/>
    /// - <see cref="IFormattable"/>
    /// - <see cref="object.ToString()"/>
    /// The fast-paths short-circuit the cascade - same observable behavior, no boxing for value types.
    /// </remarks>
    /// <param name="value">The value to format. If null: write nothing and return true.</param>
    /// <param name="destination">Destination buffer for the UTF-16 output.</param>
    /// <param name="elementsWritten">Number of UTF-16 code units (chars) written on success.</param>
    /// <param name="format">Optional format string, forwarded to the value's formatting interfaces.</param>
    /// <param name="provider">Optional format provider. If it exposes <see cref="ICustomFormatter"/>, intercepts all other dispatch paths.</param>
    /// <typeparam name="T">The type of the value to format.</typeparam>
    /// <returns>True on success, false if <paramref name="destination"/> was too small.</returns>
    [Pure]
    public static bool TryFormat<T>(
        T value,
        Span<Char16> destination,
        out int elementsWritten,
        String16? format = null,
        IFormatProvider? provider = null
    )
    {
        // If there's a custom formatter, always use it.
        if (TryFormat_ICustomFormatter(value, destination, out elementsWritten, format, provider) is { } result)
        {
            return result;
        }

        if (!typeof(T).IsValueType && value is null) // 'value is null' boxes in Debug - IsValueType pre-check folds it away
        {
            elementsWritten = 0;
            return true;
        }

        if (typeof(T) == typeof(string))
        {
            return TryAppend(Unsafe.As<T, string>(ref value).AsSpan(), destination, out elementsWritten);
        }

#if NET
        // Special-case enums to avoid boxing them.
        if (typeof(T).IsEnum)
        {
            return Enum.TryFormatUnconstrained(value, destination, out elementsWritten, format);
        }
#endif

#if NET8_0_OR_GREATER
        // Value-type fast-paths: avoid the ~24 B box that `((ISpanFormattable)value).TryFormat()` would incur for an unconstrained generic T.
        // `typeof(T) == typeof(X)` folds at JIT specialization, so only the matching branch survives in each instantiation;
        // reference-type T pays nothing (all comparisons fold to false in the shared instantiation).
        // Same list as Utf8.TryFormat - every IUtf8SpanFormattable primitive also implements ISpanFormattable for Span<char>.
        if (typeof(T) == typeof(bool))
            return Unsafe.As<T, bool>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(char))
            return Unsafe.As<T, char>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(byte))
            return Unsafe.As<T, byte>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(sbyte))
            return Unsafe.As<T, sbyte>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(short))
            return Unsafe.As<T, short>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(ushort))
            return Unsafe.As<T, ushort>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(int))
            return Unsafe.As<T, int>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(uint))
            return Unsafe.As<T, uint>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(long))
            return Unsafe.As<T, long>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(ulong))
            return Unsafe.As<T, ulong>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(nint))
            return Unsafe.As<T, nint>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(nuint))
            return Unsafe.As<T, nuint>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(Int128))
            return Unsafe.As<T, Int128>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(UInt128))
            return Unsafe.As<T, UInt128>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(Half))
            return Unsafe.As<T, Half>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(float))
            return Unsafe.As<T, float>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(double))
            return Unsafe.As<T, double>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(decimal))
            return Unsafe.As<T, decimal>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(DateTime))
            return Unsafe.As<T, DateTime>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(DateTimeOffset))
            return Unsafe
                .As<T, DateTimeOffset>(ref value)
                .TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(TimeSpan))
            return Unsafe.As<T, TimeSpan>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(DateOnly))
            return Unsafe.As<T, DateOnly>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(TimeOnly))
            return Unsafe.As<T, TimeOnly>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(Guid))
            return Unsafe.As<T, Guid>(ref value).TryFormat(destination, out elementsWritten, format); // Guid's public TryFormat takes no provider (format is culture-invariant)
        if (typeof(T) == typeof(Bool8))
            return Unsafe.As<T, Bool8>(ref value).TryFormat(destination, out elementsWritten, format, provider);
        if (typeof(T) == typeof(Bool32))
            return Unsafe.As<T, Bool32>(ref value).TryFormat(destination, out elementsWritten, format, provider);
#endif

        /*
         * "is" check order: only matters for reference types (JIT-folded for value types)
         * The BCL checks were nested: IFormattable { ISpanFormattable },
         * we flattened to           : ISpanFormattable, then IFormattable,
         * as ISpanFormattable types are the most common case in modern .NET / IFormattable is a rare fallback.
         *
         * Utf8 sibling has an extra IUtf8SpanFormattable layer ahead of ISpanFormattable; for Utf16 they
         * collapse into one - ISpanFormattable IS the native UTF-16 path, so no transcode helper is needed.
         */

        // If the value can format itself directly into our buffer, do so.
        if (value is ISpanFormattable)
        {
            return ((ISpanFormattable)value).TryFormat(destination, out elementsWritten, format, provider);
        }

        var s =
            value is IFormattable
                ? ((IFormattable)value).ToString(format, provider) // If the value can ToString with the format / provider, get the resulting string, then append that.
                : value!.ToString(); // Fall back to a normal ToString and append that.
        return TryAppend(s.AsSpan(), destination, out elementsWritten);
    }

    /// Try to copy <paramref name="value"/> into <paramref name="destination"/>.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool TryAppend(scoped String16View value, Span<Char16> destination, out int elementsWritten)
    {
        return value.TryCopyTo(destination, out elementsWritten);
    }

    /// <returns>
    /// null: no custom formatter, normal dispatch should continue;
    /// otherwise, the formatter's result:
    /// true: success (even if the formatter failed or wrote nothing)
    /// false: the destination was too small.
    /// </returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool? TryFormat_ICustomFormatter<T>(
        T value,
        Span<Char16> destination,
        out int elementsWritten,
        String16? format,
        IFormatProvider? provider
    )
    {
        if (
            provider is null
            || provider.GetType() == typeof(CultureInfo)
            || // optimization to avoid GetFormat in the majority case
            provider.GetFormat(typeof(ICustomFormatter)) is not { } formatterObj
        )
        {
            elementsWritten = 0;
            return null; // not handled
        }

        var formatter = (ICustomFormatter)formatterObj; // InvalidCastException if formatterObj is the wrong type
        if (formatter.Format(format, value, provider) is { } customFormatted)
        {
            return TryAppend(customFormatted.AsSpan(), destination, out elementsWritten);
        }

        elementsWritten = 0;
        return true;
    }

    /// bool doesn't implement ISpanFormattable for some reason: this emulates it, for completeness.
    /// Also, this handles the G/l formats, which format-less bool.TryFormat() doesn't handle:
    /// https://learn.microsoft.com/en-us/dotnet/api/system.buffers.text.utf8formatter.tryformat?view=net-9.0#system-buffers-text-utf8formatter-tryformat(system-boolean-system-span((system-byte))-system-int32@-system-buffers-standardformat)
    /// Unknown formats fall back to the format-less behavior - matches C# string interpolation, which
    /// ignores the format for bool (no ISpanFormattable / IFormattable, so $"{flag:X}" yields "True").
    public static bool TryFormat(
        this bool value,
        Span<Char16> destination,
        out int elementsWritten,
        String16View format = default,
        IFormatProvider? provider = null
    )
    {
        return Utf16Formatter.TryFormat(value, destination, out elementsWritten, Utf8.ParseBoolFormat(format));
    }

    /// char implements ISpanFormattable, but explicitly: here's a public extension, for completeness.
    /// Also, the BCL actually doesn't handle any formats; cast to ushort if you need formatting.
    public static bool TryFormat(
        this char value,
        Span<Char16> destination,
        out int elementsWritten,
        String16View format = default,
        IFormatProvider? provider = null
    )
    {
        if (destination.IsEmpty)
        {
            elementsWritten = 0;
            return false;
        }

        destination[0] = value;
        elementsWritten = 1;
        return true;
    }
}
