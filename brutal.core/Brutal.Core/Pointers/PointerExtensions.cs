using System.Runtime.InteropServices;
using Brutal.Attributes;

namespace Brutal.Pointers.Extensions;

/// <summary>
/// Extensions for Span and ReadOnlySpan as pointers
/// </summary>
public static class PointerExtensions
{
    /// <summary>
    /// Return the underlying pointer of span. Note this may be unsafe if the span refers to memory not allocated on the
    /// native memory, as they may be relocated at any time due to generational Garbage Collections. Please review usage
    /// to ensure only fixed native memory pointers are returned.
    /// </summary>
    /// <param name="span">Span of native memory</param>
    /// <returns>Unsafe pointer to block of memory</returns>
    public static unsafe T* AsPointer<T>(this Span<T> span)
        where T : unmanaged
    {
        return (T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
    }

    /// <summary>
    /// Return the underlying pointer of span. Note this may be unsafe if the span refers to memory not allocated on the
    /// native memory, as they may be relocated at any time due to generational Garbage Collections. Please review usage
    /// to ensure only fixed native memory pointers are returned.
    /// </summary>
    /// <param name="span">ReadOnlySpan of native memory</param>
    /// <returns>Unsafe pointer to block of memory</returns>
    public static unsafe T* AsPointer<T>(this ReadOnlySpan<T> span)
        where T : unmanaged
    {
        return (T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
    }

    /// <summary>
    /// Return the underlying pointer of span. Note this may be unsafe if the span refers to memory not allocated on the
    /// native memory, as they may be relocated at any time due to generational Garbage Collections. Please review usage
    /// to ensure only fixed native memory pointers are returned.
    /// </summary>
    /// <param name="span">Span of native memory</param>
    /// <returns>Unsafe pointer to block of memory</returns>
    public static unsafe Ptr<T> AsPtr<T>(this Span<T> span)
        where T : unmanaged
    {
        return (T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
    }

    /// <summary>
    /// Return the underlying pointer of span. Note this may be unsafe if the span refers to memory not allocated on the
    /// native memory, as they may be relocated at any time due to generational Garbage Collections. Please review usage
    /// to ensure only fixed native memory pointers are returned.
    /// </summary>
    /// <param name="span">ReadOnlySpan of native memory</param>
    /// <returns>Unsafe pointer to block of memory</returns>
    public static unsafe Ptr<T> AsPtr<T>([Fixed] this ReadOnlySpan<T> span)
        where T : unmanaged
    {
        return (T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
    }
}
