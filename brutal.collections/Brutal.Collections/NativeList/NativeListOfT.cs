using System.Collections;
using Brutal.Attributes;
using Brutal.Memory;
using Brutal.Pointers;

namespace Brutal.Collections;

/// <summary>
/// A native-memory backed list with a fixed type
/// </summary>
/// <typeparam name="TValueType">Element type</typeparam>
public class NativeList<TValueType> : INativeList<TValueType>
    where TValueType : unmanaged
{
    ~NativeList()
    {
        Dispose();
    }

    private readonly NativeStrideList _nativeList;

    public NativeList(ElementCount capacity = default)
    {
        _nativeList = new NativeStrideList(Stride, capacity);
    }

    public NativeList(ReadOnlySpan<TValueType> nativeList)
    {
        _nativeList = NativeStrideList.FromSpan(Stride, nativeList);
    }

    public void Dispose()
    {
        _nativeList.Dispose();
        GC.SuppressFinalize(this);
    }

    public bool IsNull()
    {
        return _nativeList.IsNull();
    }

    public ByteSize Stride => ByteSize.Of<TValueType>();
    public bool IsEmpty => Count == 0;

    public ref TValueType this[Index index]
    {
        get
        {
            var actualIndex = index.GetOffset(Count);
            return ref _nativeList.AsSpan<TValueType>()[actualIndex];
        }
    }

    public void Add(TValueType item)
    {
        _nativeList.Add(item);
    }

    public void AddRange(Span<TValueType> items)
    {
        _nativeList.AddRange(items);
    }

    public void AddRange(ReadOnlySpan<TValueType> items)
    {
        _nativeList.AddRange(items);
    }

    /// <summary>
    /// Adds a range of bytes to the end of the list. The length of items must be a multiple of stride
    /// </summary>
    public void AddRange<T>(T items)
        where T : ISpanLike<TValueType>
    {
        _nativeList.AddRange(items.AsSpan());
    }

    public void Insert(ElementCount index, TValueType item)
    {
        _nativeList.Insert(index, item);
    }

    public void RemoveAt(ElementCount index)
    {
        _nativeList.RemoveAt<TValueType>(index);
    }

    public Ptr<TValueType> Ptr => _nativeList.Ptr.Cast<TValueType>();

    Ptr ISpanLike.Ptr => Ptr;
    ElementCount ISpanLike.Length => Count;

    public ElementCount Count
    {
        get => _nativeList.Count;
        set => _nativeList.Count = value;
    }

    public ElementCount Capacity
    {
        get => _nativeList.Capacity;
        set => _nativeList.Capacity = value;
    }

    public void Clear()
    {
        _nativeList.Clear();
    }

    public void TrimExcess()
    {
        _nativeList.TrimExcess();
    }

    public void EnsureCapacity(ElementCount capacity)
    {
        _nativeList.EnsureCapacity(capacity);
    }

    public void Free()
    {
        _nativeList.Free();
    }

    public IEnumerator<TValueType> GetEnumerator()
    {
        for (var i = 0; i < Count; ++i)
            yield return this[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Span<TValueType> Slice(ElementCount start, ElementCount length)
    {
        return AsSpan().Slice(start, length);
    }

    public Span<TValueType> Slice(ElementCount start)
    {
        return AsSpan()[(int)start..];
    }

    [Fixed]
    public Span<TValueType> this[Range range] => AsSpan()[range];

    [return: Fixed]
    public Span<TValueType> AsSpan()
    {
        return _nativeList.AsSpan<TValueType>();
    }

    Span<TCastType> ISpanLike.AsSpan<TCastType>()
    {
        return _nativeList.AsSpan<TCastType>();
    }

    public NativeStrideSpan AsNativeSpan()
    {
        return new NativeStrideSpan(Ptr, Count, Stride);
    }

    protected virtual void Dispose(bool isDisposing)
    {
        if (!isDisposing)
            return;

        _nativeList.Dispose();
    }

    public ref TValueType GetPinnableReference()
    {
        return ref this[0];
    }
}
