using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi;

static class InteropExtensions
{
    /// Whether this span is unset rather than empty.
    /// Technically "IsDefault", but "IsNull" seems more intuitive.
    public static unsafe bool IsNull<T>(in this ReadOnlySpan<T> span)
        where T : unmanaged
    {
        ref var spanRef = ref MemoryMarshal.GetReference(span);
        fixed (T* spanPtr = &spanRef)
            return spanPtr == null;
    }

    /// <inheritdoc cref="IsNull{T}(in System.ReadOnlySpan{T})"/>
    public static unsafe bool IsNull<T>(in this Span<T> span)
        where T : unmanaged
    {
        ref var spanRef = ref MemoryMarshal.GetReference(span);
        fixed (T* spanPtr = &spanRef)
            return spanPtr == null;
    }
}
