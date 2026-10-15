using CommunityToolkit.HighPerformance;

namespace Brutal.Extensions;

public static class SpanExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Contains<T>(this Span<T> span, T value)
        where T : unmanaged, Enum
    {
        return ((ReadOnlySpan<T>)span).Contains(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe bool Contains<T>(this ReadOnlySpan<T> span, T value)
        where T : unmanaged, Enum
    {
        return sizeof(T) switch
        {
            sizeof(byte) => span.Cast<T, byte>().Contains(Unsafe.BitCast<T, byte>(value)),
            sizeof(short) => span.Cast<T, short>().Contains(Unsafe.BitCast<T, short>(value)),
            sizeof(int) => span.Cast<T, int>().Contains(Unsafe.BitCast<T, int>(value)),
            sizeof(long) => span.Cast<T, long>().Contains(Unsafe.BitCast<T, long>(value)),
            _ => throw new NotSupportedException($"Enum of size {sizeof(T)} is not supported."),
        };
    }

    /// <inheritdoc cref="ReadOnlySpan{T}.TryCopyTo"/>
    public static bool TryCopyTo<T>(this ReadOnlySpan<T> value, Span<T> destination, out int elementsWritten)
    {
        var result = value.TryCopyTo(destination);
        elementsWritten = result ? value.Length : 0;
        return result;
    }
}
