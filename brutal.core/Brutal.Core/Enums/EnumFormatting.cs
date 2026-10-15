using System.Buffers;
using System.Diagnostics.CodeAnalysis;

namespace Brutal.Enums;

public static class EnumUtf8Ex
{
    extension(Enum)
    {
        /// <inheritdoc cref="Enum.TryFormat" />
        /// <remarks>UTF8 version</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFormat<T>(
            T value,
            Span<byte> destination,
            out int bytesWritten,
            [StringSyntax(StringSyntaxAttribute.EnumFormat)] ReadOnlySpan<char> format = default
        )
            where T : unmanaged, Enum
        {
            return TryFormatUnconstrained(value, destination, out bytesWritten, format);
        }

        /// <inheritdoc cref="Enum.TryFormat" />
        /// <remarks>UTF8 version, unconstrained</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFormatUnconstrained<TEnum>(
            TEnum value,
            Span<byte> destination,
            out int bytesWritten,
            [StringSyntax(StringSyntaxAttribute.EnumFormat)] ReadOnlySpan<char> format = default
        )
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException($"Type {typeof(TEnum)} is not an enum.");

            // try with a fixed-sized span first
            Span<char> utf16 = stackalloc char[256];
            if (TryFormatUnconstrained(null, value, utf16, out var charsWritten, format))
                return TryGetBytes(utf16[..charsWritten], destination, out bytesWritten);

            // fixed-sized pass failed: check if destination has more room available
            if (destination.Length > utf16.Length)
            {
                // try again with a bigger buffer
                var array16 = ArrayPool<char>.Shared.Rent(destination.Length); // UTF16 can't be larger than UTF8
                try
                {
                    utf16 = array16;
                    if (TryFormatUnconstrained(null, value, utf16, out charsWritten, format))
                        return TryGetBytes(utf16[..charsWritten], destination, out bytesWritten);
                }
                finally
                {
                    ArrayPool<char>.Shared.Return(array16);
                }
            }

            bytesWritten = 0;
            return false;

            // copy from Brutal.Strings.Utf8.TryGetBytes, which we can't reference from Common
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> destination, out int bytesWritten)
            {
                if (
                    System.Text.Unicode.Utf8.FromUtf16(chars, destination, out _, out bytesWritten)
                    == OperationStatus.Done
                )
                    return true;
                bytesWritten = 0;
                return false;
            }
        }
    }

    #region UnsafeAccessor for TryFormatUnconstrained

    extension(Enum)
    {
        /// <inheritdoc cref="Enum.TryFormat" />
        /// <remarks>UTF16 version, unconstrained</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFormatUnconstrained<TEnum>(
            TEnum value,
            Span<char> destination,
            out int charsWritten,
            [StringSyntax(StringSyntaxAttribute.EnumFormat)] ReadOnlySpan<char> format = default
        )
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException($"Type {typeof(TEnum)} is not an enum.");

            return TryFormatUnconstrained(null, value, destination, out charsWritten, format);
        }
    }

    [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = nameof(TryFormatUnconstrained))]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static extern bool TryFormatUnconstrained<TEnum>(
        Enum? _, // required by [UnsafeAccessor] type-matching
        TEnum value,
        Span<char> destination,
        out int charsWritten,
        [StringSyntax(StringSyntaxAttribute.EnumFormat)] ReadOnlySpan<char> format = default
    );

    #endregion
}

public static class EnumUtf8Extensions
{
    /// <inheritdoc cref="Enum.TryFormat" />
    /// <remarks>
    /// Expose Enum.TryFormat() as a member function, to emulate <see cref="IUtf8SpanFormattable"/> for enums,
    /// and simplify generic support.</remarks>
    /// <remarks><paramref name="provider"/> is ignored.</remarks>
    public static bool TryFormat<T>(
        this T value,
        Span<byte> destination,
        out int bytesWritten,
        ReadOnlySpan<char> format = default,
        IFormatProvider? provider = null
    )
        where T : unmanaged, Enum
    {
        return Enum.TryFormat(value, destination, out bytesWritten, format);
    }
}
