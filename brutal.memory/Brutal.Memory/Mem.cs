using System.Runtime.InteropServices;
using Brutal.Pointers;
using Brutal.Pointers.Extensions;

namespace Brutal.Memory;

/// <summary>
/// Memory management utilities for unmanaged memory operations.
/// </summary>
public static class Mem
{
    #region Byte
    /// <summary>
    /// Creates a new allocation for a specified number of bytes
    /// </summary>
    public static unsafe Ptr Alloc(ByteSize byteSize)
    {
        return NativeMemory.Alloc((nuint)byteSize);
    }

    /// <summary>
    /// Creates a new allocation for a specified number of elements of a specified size
    /// </summary>
    public static unsafe Ptr Alloc(ElementCount count, ByteSize stride)
    {
        return NativeMemory.Alloc((nuint)count, (nuint)stride);
    }

    /// <summary>
    /// Creates a new zeroed allocation for a specified number of bytes
    /// </summary>
    public static unsafe Ptr AllocZeroed(ByteSize byteSize)
    {
        return NativeMemory.AllocZeroed((nuint)byteSize);
    }

    /// <summary>
    /// Creates a new zeroed allocation for a specified number of elements of a specified size
    /// </summary>
    public static unsafe Ptr AllocZeroed(ElementCount count, ByteSize stride)
    {
        return NativeMemory.AllocZeroed((nuint)count, (nuint)stride);
    }

    /// <summary>
    /// Copies a specified number of bytes from <c>source</c> to <c>destination</c>
    /// </summary>
    public static unsafe void Copy(Ptr source, Ptr destination, ByteSize byteSize)
    {
        NativeMemory.Copy(source, destination, (nuint)byteSize);
    }

    /// <summary>
    /// Fills a specified number of bytes at <c>destination</c> with <c>value</c>
    /// </summary>
    public static unsafe void Fill(Ptr destination, ByteSize byteSize, byte value)
    {
        NativeMemory.Fill(destination, (nuint)byteSize, value);
    }

    /// <summary>
    /// Clears a specified number of bytes at <c>destination</c>
    /// </summary>
    public static unsafe void Clear(Ptr destination, ByteSize byteSize)
    {
        NativeMemory.Clear(destination, (nuint)byteSize);
    }

    /// <summary>
    /// Reallocates the given pointer to hold a specified number of bytes
    /// </summary>
    public static unsafe Ptr Realloc(Ptr source, ByteSize byteSize)
    {
        return NativeMemory.Realloc(source, (nuint)byteSize);
    }
    #endregion

    /// <summary>
    /// Creates a new allocation for a single instance of <c>T</c> and copies <c>val</c> into it
    /// </summary>
    public static Ptr<T> AllocAndCopy<T>(T val)
        where T : unmanaged
    {
        var ptr = Alloc<T>();
        ptr.Value = val;
        return ptr;
    }

    /// <summary>
    /// Creates a new allocation for a single instance of <c>T</c>
    /// </summary>
    public static Ptr<T> Alloc<T>()
        where T : unmanaged
    {
        return Alloc(ByteSize.Of<T>()).Cast<T>();
    }

    /// <summary>
    /// Creates a new allocation for <c>elementCount</c> instances of <c>T</c> and returns it as a span
    /// </summary>
    public static Span<T> Alloc<T>(ElementCount count)
        where T : unmanaged
    {
        return Alloc(count, ByteSize.Of<T>()).AsSpan<T>(count);
    }

    /// <summary>
    /// Creates a new zeroed allocation for a single instance of <c>T</c>
    /// </summary>
    public static Ptr<T> AllocZeroed<T>()
        where T : unmanaged
    {
        return AllocZeroed(ByteSize.Of<T>()).Cast<T>();
    }

    /// <summary>
    /// Creates a new zeroed allocation for <c>elementCount</c> instances of <c>T</c> and returns it as a span
    /// </summary>
    public static Span<T> AllocZeroed<T>(ElementCount count)
        where T : unmanaged
    {
        return AllocZeroed(count, ByteSize.Of<T>()).AsSpan<T>(count);
    }

    /// <summary>
    /// Reallocates the given pointer to hold <c>numElements</c> instances of <c>T</c>
    /// </summary>
    public static Ptr<T> Realloc<T>(Ptr<T> source, ElementCount count)
        where T : unmanaged
    {
        return Realloc(source, ByteSize.Of<T>(count)).Cast<T>();
    }

    public static void Clear<T>(Ptr<T> source, ElementCount count)
        where T : unmanaged
    {
        Clear(source, ByteSize.Of<T>(count));
    }

    public static unsafe void Clear<T>(ReadOnlySpan<T> span)
        where T : unmanaged
    {
        fixed (T* pSpan = span)
            Clear(pSpan, ByteSize.Of(span));
    }

    /// <summary>
    /// Frees a previously allocated pointer
    /// </summary>
    public static unsafe void Free(Ptr ptr)
    {
        NativeMemory.Free(ptr);
    }

    /// <summary>
    /// Frees a previously allocated span
    /// </summary>
    public static unsafe void Free<T>(Span<T> ptr)
        where T : unmanaged
    {
        NativeMemory.Free(ptr.AsPointer());
    }

    /// <summary>
    /// Copies <c>elementCount</c> elements of type <c>T</c> from <c>source</c> to <c>destination</c>
    /// </summary>
    public static void Copy<T>(Ptr<T> source, Ptr<T> destination, ElementCount count)
        where T : unmanaged
    {
        Copy(source.AsSpan(count), destination.AsSpan(count));
    }

    /// <summary>
    /// Creates a new allocation for <c>values.Length</c> instances of <c>T</c>, copies the values into it, and returns it as a span
    /// </summary>
    public static Span<T> AllocAndCopy<T>(ReadOnlySpan<T> values)
        where T : unmanaged
    {
        var memory = Alloc<T>(values.Length);
        values.CopyTo(memory);
        return memory;
    }

    /// <summary>
    /// Creates a new allocation for <c>values.Length</c> instances of <c>T</c>, copies the values into it, and returns it as a span
    /// </summary>
    public static Span<T> AllocAndCopy<T>(Span<T> values)
        where T : unmanaged
    {
        return AllocAndCopy((ReadOnlySpan<T>)values);
    }

    /// <summary>
    /// Copies the elements of <c>source</c> to <c>destination</c>
    /// </summary>
    /// <exception cref="ArgumentException">If the destination span is not long enough to hold the source span</exception>
    public static unsafe void Copy<T>(ReadOnlySpan<T> source, Span<T> destination)
        where T : unmanaged
    {
        if (source.Length > destination.Length)
            throw new ArgumentException("Destination span is not long enough to hold the source span.");

        fixed (T* pSource = source)
        fixed (T* pDestination = destination)
        {
            NativeMemory.Copy(pSource, pDestination, (nuint)ByteSize.Of<T>(source.Length));
        }
    }

    /// <summary>
    /// Copies the elements of <c>source</c> to <c>destination</c>
    /// </summary>
    /// <exception cref="ArgumentException">If the destination span is not long enough to hold the source span</exception>
    public static void Copy<T>(Span<T> source, Span<T> destination)
        where T : unmanaged
    {
        Copy((ReadOnlySpan<T>)source, destination);
    }
}
