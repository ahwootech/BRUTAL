using Brutal.Attributes;
using Brutal.Memory;
using Brutal.Pointers;

namespace Brutal.Collections;

/// <summary>
/// A native-memory backed list with a fixed stride
/// </summary>
public class NativeStrideList : INativeList
{
    ~NativeStrideList()
    {
        Dispose(false);
    }

    private readonly NativeList _nativeList;

    /// <summary>
    /// The size of each element in bytes
    /// </summary>
    public ByteSize Stride { get; }

    public bool IsEmpty => Count == 0;

    /// <summary>
    /// A raw pointer to the underlying memory
    /// </summary>
    public Ptr Ptr => _nativeList.Ptr;

    ElementCount ISpanLike.Length => Count;

    /// <summary>
    /// The number of elements in the list
    /// </summary>
    public ElementCount Count
    {
        get => _nativeList.Size.ToElementCount(Stride);
        set => _nativeList.Size = value * Stride;
    }

    /// <summary>
    /// The number of elements that can be stored in the list without resizing
    /// </summary>
    public ElementCount Capacity
    {
        get => _nativeList.Capacity.ToElementCount(Stride);
        set => _nativeList.Capacity = value * Stride;
    }

    // ReSharper disable once UnusedMember.Local
    private NativeStrideList() => throw new InvalidOperationException("NativeStrideList cannot be default constructed");

    /// <summary>
    /// Constructs a new NativeStrideList with the given stride and initial capacity
    /// </summary>
    public NativeStrideList(ByteSize stride, ElementCount capacity = default)
    {
        Stride = stride;
        _nativeList = new NativeList();

        if (stride < 1)
            throw new ArgumentOutOfRangeException(nameof(stride), stride, "stride must be greater than 0");

        _nativeList.EnsureCapacity(Stride * capacity);
    }

    public static NativeStrideList FromSpan<TSpanLike>(ByteSize stride, TSpanLike span)
        where TSpanLike : ISpanLike, allows ref struct
    {
        var outList = new NativeStrideList(stride);
        outList.AddRange(span.AsSpan<byte>());
        return outList;
    }

    public static NativeStrideList FromSpan<TSpanLike>(TSpanLike span)
        where TSpanLike : ISpanLike, allows ref struct
    {
        return FromSpan(span.Stride, span);
    }

    public static NativeStrideList FromSpan<TValueType>(ByteSize stride, ReadOnlySpan<TValueType> span)
        where TValueType : unmanaged
    {
        var outList = new NativeStrideList(stride);
        outList.AddRange(span);
        return outList;
    }

    public static NativeStrideList FromSpan<TValueType>(ReadOnlySpan<TValueType> span)
        where TValueType : unmanaged
    {
        return FromSpan(ByteSize.Of<TValueType>(), span);
    }

    // This class does not track if it's been disposed of before, because
    // _nativeList.Dispose() is idempotent. Should that or out implementation
    // change, then you may need to implement the Dispose pattern in this class.
    /// <summary>
    /// Disposes the native memory.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Checks if the native list is null
    /// </summary>
    public bool IsNull()
    {
        return _nativeList.IsNull();
    }

    /// <summary>
    /// Clears the list, setting count to 0 but preserving capacity
    /// </summary>
    public void Clear()
    {
        _nativeList.Clear();
    }

    /// <summary>
    /// Trim the capacity to the actual number of elements in the list
    /// </summary>
    public void TrimExcess()
    {
        _nativeList.TrimExcess();
    }

    /// <summary>
    /// Ensure the list can hold at least capacity elements without resizing
    /// </summary>
    public void EnsureCapacity(ElementCount capacity)
    {
        _nativeList.EnsureCapacity(capacity * Stride);
    }

    /// <summary>
    /// Frees the native memory and resets the list
    /// </summary>
    public void Free()
    {
        _nativeList.Free();
    }

    public NativeStrideSpan AsNativeSpan()
    {
        return new NativeStrideSpan(Ptr, Count, Stride);
    }

    public void AddRange(Span<byte> items)
    {
        AddRange((ReadOnlySpan<byte>)items);
    }

    /// <summary>
    /// Adds a range of bytes to the end of the list. The length of items must be a multiple of stride
    /// </summary>
    public void AddRange(ReadOnlySpan<byte> items)
    {
        if (ByteSize.Of(items) % Stride != 0)
            throw new ArgumentException("Items length must be a multiple of stride", nameof(items));

        _nativeList.AddRange(items);
    }

    /// <summary>
    /// Adds a range of bytes to the end of the list. The length of items must be a multiple of stride
    /// </summary>
    public void AddRange<T>(T items)
        where T : ISpanLike, allows ref struct
    {
        if (ByteSize.Of(items) % Stride != 0)
            throw new ArgumentException("Items length must be a multiple of stride", nameof(items));

        _nativeList.AddRange(items);
    }

    /// <summary>
    /// Adds an item to the end of the list
    /// </summary>
    public void Add<T>(T item)
        where T : unmanaged
    {
        CheckStride<T>();
        _nativeList.Add(item);
    }

    public void AddRange<T>(Span<T> items)
        where T : unmanaged
    {
        AddRange((ReadOnlySpan<T>)items);
    }

    /// <summary>
    /// Adds a range of items to the end of the list
    /// </summary>
    public void AddRange<T>(ReadOnlySpan<T> items)
        where T : unmanaged
    {
        CheckStride<T>();
        _nativeList.AddRange(items);
    }

    /// <summary>
    /// Inserts an item at the given index, shifting all later items up by one
    /// </summary>
    public void Insert<T>(ElementCount index, T item)
        where T : unmanaged
    {
        CheckStride<T>();
        _nativeList.Insert(Stride * index, item);
    }

    /// <summary>
    /// Removes the item at the given index, shifting all later items down by one
    /// </summary>
    public void RemoveAt<T>(ElementCount index)
        where T : unmanaged
    {
        CheckStride<T>();
        _nativeList.RemoveAt(Stride * index, Stride);
    }

    private void CheckStride<T>()
        where T : unmanaged
    {
        CheckStride(ByteSize.Of<T>());
    }

    private void CheckStride(ByteSize stride)
    {
        if (Stride != stride)
            throw new ArgumentException($"NativeStrideList expected stride: {Stride}, but got: {stride}");
    }

    [return: Fixed]
    public Span<T> AsSpan<T>()
        where T : unmanaged
    {
        return _nativeList.AsSpan<T>();
    }

    protected virtual void Dispose(bool isDisposing)
    {
        if (!isDisposing)
            return;

        _nativeList.Dispose();
    }
}
