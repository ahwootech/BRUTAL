using System.Diagnostics.Contracts;
using System.Numerics;

namespace Brutal.Strings;

internal static class StringBuilderUtility
{
    /// Array.MaxLength - 1 (for null terminator) - copied here because Array.MaxLength isn't const.
    /// For reference: Array.MaxLength == int.MaxValue - 56.
    public const int ArrayMaxUsableLength = 0X7FFFFFC7 - 1;

    extension<TChar>(Span<TChar> value)
        where TChar : unmanaged, IBinaryInteger<TChar>
    {
        [Pure]
        public Span<Char8> AsChar8()
        {
            Debug.Assert(typeof(TChar) == typeof(Char8));
            return Unsafe.BitCast<Span<TChar>, Span<Char8>>(value);
        }

        [Pure]
        public Span<Char16> AsChar16()
        {
            Debug.Assert(typeof(TChar) == typeof(Char16));
            return Unsafe.BitCast<Span<TChar>, Span<Char16>>(value);
        }
    }

    extension<TChar>(ReadOnlySpan<TChar> value)
        where TChar : unmanaged, IBinaryInteger<TChar>
    {
        [Pure]
        public ReadOnlySpan<Char8> AsChar8()
        {
            Debug.Assert(typeof(TChar) == typeof(Char8));
            return Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<Char8>>(value);
        }

        [Pure]
        public ReadOnlySpan<Char16> AsChar16()
        {
            Debug.Assert(typeof(TChar) == typeof(Char16));
            return Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<Char16>>(value);
        }

        [Pure]
        public String16 ToString16()
        {
            return typeof(TChar) == typeof(Char8) ? Utf8.GetString(value.AsChar8()) : value.AsChar16().ToString();
        }
    }
}
