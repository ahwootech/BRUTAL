using Brutal.Attributes;
using Brutal.Memory;
using Brutal.Pointers;
using Brutal.Pointers.Extensions;

namespace Brutal.Collections;

/// <summary>
/// An untyped span to unsafe memory, however with a stride.
/// </summary>
public readonly ref struct NativeStrideSpan(Ptr inData, ElementCount inLength, ByteSize inStride) : ISpanLike
{
    /// <summary>
    /// The pointer to the first element of the span.
    /// </summary>
    public Ptr Ptr => inData;

    /// <summary>
    /// The length of the span.
    /// </summary>
    public ElementCount Length => inLength;

    /// <summary>
    /// The stride of each element.
    /// </summary>
    public ByteSize Stride => inStride;

    public bool IsEmpty => Length == 0;

    /// <summary>
    /// The total size of the span in bytes.
    /// </summary>
    public ByteSize ByteSize => Length * Stride;

    /// <summary>
    /// Slice the span into a new raw span.
    /// </summary>
    public NativeStrideSpan Slice(int start, int length)
    {
        return new NativeStrideSpan(Ptr.Offset(start * Stride), length, Stride);
    }

    /// <summary>
    /// Create a new raw span with a different stride.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public NativeStrideSpan WithStride(ByteSize stride)
    {
        if (stride <= 0)
            throw new ArgumentOutOfRangeException(nameof(stride));
        var prevSize = ByteSize;
        return new NativeStrideSpan(Ptr, prevSize.ToElementCount(stride), stride);
    }

    /// <inheritdoc />
    public bool IsNull() => Ptr.IsNull();

    /// <summary>
    /// Create a new raw span from a managed span.
    /// </summary>
    public static unsafe NativeStrideSpan FromSpan<T>([Fixed] ReadOnlySpan<T> span)
        where T : unmanaged
    {
        return new NativeStrideSpan(span.AsPointer(), span.Length, ByteSize.Of<T>());
    }

    /// <summary>
    /// Create a new raw span from a managed span.
    /// </summary>
    public static unsafe NativeStrideSpan FromSpan<T>([Fixed] Span<T> span)
        where T : unmanaged
    {
        return new NativeStrideSpan(span.AsPointer(), span.Length, ByteSize.Of<T>());
    }

    /// <summary>
    /// Slice the span into a new raw span.
    /// </summary>
    public NativeStrideSpan this[int start, int end] => Slice(start, end - start);

    [return: Fixed]
    public unsafe Span<T> AsSpan<T>()
        where T : unmanaged
    {
        if (typeof(T) == typeof(byte))
            return new Span<T>(Ptr.Cast<T>(), ElementCount.Of(Length * Stride));

        var size = ByteSize.Of<T>();
        if (size != Stride)
            throw new InvalidOperationException("Stride must be equal to the size of the type, or type must be byte.");

        return new Span<T>(Ptr.Cast<T>(), Length);
    }

    public NativeStrideSpan this[Range start] => Slice(start.Start.Value, start.End.Value - start.Start.Value);
}
