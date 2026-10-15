using System.Diagnostics;
using Brutal.Attributes;
using Brutal.Memory;
using Brutal.Pointers;
using Brutal.Pointers.Extensions;
using CommunityToolkit.HighPerformance;

namespace Brutal.Collections;

/// <summary>
/// A native-memory backed list with no fixed type or stride
/// </summary>
public sealed class NativeList : INativeList
{
    /// <summary>
    /// The default capacity of the array (in elements) when first growing from 0
    /// </summary>
    private const int DEFAULT_CAPACITY = 4;

    /// <summary>
    /// The capacity of the array (in elements) we can hold without reallocating
    /// </summary>
    private ByteSize _byteCapacity;

    /// <summary>
    /// The actual number of elements in the array
    /// </summary>
    private ByteSize _byteSize;

    /// <summary>
    /// Free memory
    /// </summary>
    ~NativeList()
    {
        Free();
    }

    /// <inheritdoc />
    public bool IsNull()
    {
        return Ptr.IsNull();
    }

    private void _Reallocate(ByteSize byteSize)
    {
        unsafe
        {
            if (byteSize == 0)
            {
                Free();
                _byteCapacity = ByteSize.Zero;
                _byteSize = ByteSize.Zero;
                return;
            }

            void* oldMem = Ptr;
            Ptr = Mem.Alloc(byteSize);

            if (oldMem != null)
            {
                Mem.Copy(oldMem, Ptr, _byteSize);
                Mem.Free(oldMem);
            }

            _byteCapacity = byteSize;
        }
    }

    internal void GrowInternal(ByteSize bytes)
    {
        Debug.Assert(_byteCapacity < bytes);

        var newCapacity = _byteCapacity == 0 ? ByteSize.Of(DEFAULT_CAPACITY) : 2 * _byteCapacity;

        // Allow the list to grow to the maximum possible capacity (~2G elements) before encountering overflow.
        // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
        if ((uint)newCapacity > Array.MaxLength)
            newCapacity = ByteSize.Of(Array.MaxLength);

        // If the computed capacity is still less than specified, set to the original argument.
        // Capacities exceeding Array.MaxLength will be surfaced as OutOfMemoryException by Array.Resize.
        if (newCapacity < bytes)
            newCapacity = bytes;

        Capacity = newCapacity;
    }

    /// <summary>
    /// Reallocate the array to match the number of elements
    /// </summary>
    public void TrimExcess()
    {
        if (_byteSize != _byteCapacity)
            _Reallocate(_byteSize);
    }

    void INativeList.EnsureCapacity(ElementCount capacity)
    {
        EnsureCapacity(ByteSize.Of(capacity));
    }

    /// <summary>
    /// Frees any unmanaged resources.
    /// </summary>
    /// <remarks>
    /// This function MUST not cause problems if called more than once on the same instance.
    /// This class does not implement the Dispose pattern which is fine, but only because
    /// Free is able to handle being called from Dispose() and then called from the finaliser.
    /// </remarks>
    public void Free()
    {
        Mem.Free(Ptr);
        Ptr = null;
        _byteCapacity = ByteSize.Zero;
        _byteSize = ByteSize.Zero;
    }

    /// <summary>
    /// Dispose of the resources. This function can be called multiple times safely.
    /// </summary>
    public void Dispose()
    {
        Free();
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc />
    public Ptr Ptr { get; private set; }

    ElementCount ISpanLike.Length => ElementCount.Of(Size);

    ElementCount INativeList.Count
    {
        get => ElementCount.Of(_byteSize.Bytes);
        set => Size = ByteSize.Of(value);
    }

    ElementCount INativeList.Capacity
    {
        get => ElementCount.Of(_byteSize.Bytes);
        set => Size = ByteSize.Of(value);
    }

    /// <summary>
    /// The number of elements in the list
    /// </summary>
    public ByteSize Size
    {
        get => new(_byteSize.Bytes);
        set
        {
            if (value == Size)
                return;

            if (value > Capacity)
                GrowInternal(value);

            if (value > Size)
            {
                Mem.Fill(Ptr.Offset(Size), value - Size, 0);
            }

            _byteSize = value;
        }
    }

    /// <summary>
    /// The capacity of the array
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">If the new capacity is less than Count</exception>
    public ByteSize Capacity
    {
        get => _byteCapacity;
        set
        {
            if (_byteCapacity == value)
                return;

            if (value < Size)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Capacity must be greater than or equal to Count."
                );
            }

            _byteCapacity = value;
            _Reallocate(_byteCapacity);
        }
    }

    /// <summary>
    /// Create an untyped native list with a given stride and initial capacity
    /// </summary>
    public NativeList(ByteSize initialCapacity = default)
    {
        Capacity = initialCapacity;
    }

    /// <summary>
    /// Constructs a new NativeList and copies the contents of the given span
    /// </summary>
    public unsafe NativeList(ReadOnlySpan<byte> initialData)
    {
        if (initialData.Length > 0)
        {
            _byteCapacity = ByteSize.Of(initialData.Length);
            _byteSize = ByteSize.Of(initialData.Length);
            Ptr = Mem.AllocAndCopy(initialData).AsPointer();
        }
    }

    /// <summary>
    /// Adds any unmanaged type to the list
    /// </summary>
    /// <remarks>
    /// Does not check for stride, use it with caution
    /// </remarks>
    /// <param name="data">Unmanaged struct to copy over</param>
    /// <typeparam name="T">Data type, size should match the list's size</typeparam>
    public void Add<T>(T data)
        where T : unmanaged
    {
        var offset = Size;
        var stride = ByteSize.Of<T>();
        if (Capacity - Size < stride)
        {
            GrowInternal(Size == 0 ? ByteSize.Of<T>(DEFAULT_CAPACITY) : Size * 2);
        }
        _byteSize = _byteSize + stride;
        Ptr.Offset(offset).Cast<T>().Value = data;
    }

    ByteSize ISpanLike.Stride => ByteSize.Zero;
    public bool IsEmpty => Size == 0;

    [return: Fixed]
    public Span<T> AsSpan<T>()
        where T : unmanaged
    {
        return Ptr.AsSpan<byte>(ElementCount.Of(Size)).Cast<byte, T>();
    }

    /// <summary>
    /// Get an element at index as a specific unmanaged type
    /// </summary>
    /// <remarks>
    /// Does not check for stride, use it with caution
    /// </remarks>
    /// <exception cref="IndexOutOfRangeException">If the index is out of range</exception>
    public byte this[int index]
    {
        get
        {
            if (index < 0 || index >= (int)Size.Bytes)
                throw new IndexOutOfRangeException();
            return Ptr.Offset(ByteSize.Of(index)).Cast<byte>().Value;
        }
        set => throw new NotImplementedException();
    }

    public void AddRange<T>(ReadOnlySpan<T> items)
        where T : unmanaged
    {
        var byteSize = ByteSize.Of(items);
        var newCount = Size + byteSize;
        if (Capacity < newCount)
            GrowInternal(newCount);
        Mem.Copy(items, Ptr.Offset(Size).AsSpan<T>(items.Length));
        _byteSize += byteSize;
    }

    public void AddRange<T>(T items)
        where T : ISpanLike, allows ref struct
    {
        var byteSize = ByteSize.Of(items);
        var newCount = Size + byteSize;
        if (Capacity < newCount)
            GrowInternal(newCount);
        Mem.Copy(items.AsSpan<byte>(), Ptr.Offset(Size).AsSpan<byte>(ElementCount.Of(byteSize)));
        _byteSize += byteSize;
    }

    public void Add(byte item)
    {
        Add<byte>(item);
    }

    public void Insert(ByteSize index, byte item)
    {
        if (index.Bytes < 0 || index.Bytes > Size)
            throw new IndexOutOfRangeException();

        if (Size + 1 <= Capacity)
        {
            Mem.Copy(Ptr.Offset(index), Ptr.Offset(index + 1), Size - index);
            Ptr.Offset(index).Cast<byte>().Value = item;
        }
        else
        {
            var newPtr = Mem.Alloc(Size + 1);
            Mem.Copy(Ptr, newPtr, index);
            newPtr.Offset(index).Cast<byte>().Value = item;
            Mem.Copy(Ptr.Offset(index), newPtr.Offset(index + 1), Size - index);
            Mem.Free(Ptr);
            Ptr = newPtr;
        }
    }

    /// <summary>
    /// Insert an item at the given index, shifting all later elements up
    /// </summary>
    public void Insert<T>(ByteSize index, T item)
        where T : unmanaged
    {
        if (index > Size)
            throw new IndexOutOfRangeException();

        var stride = ByteSize.Of<T>();

        if (Size + stride <= Capacity)
        {
            Mem.Copy(Ptr.Offset(index), Ptr.Offset(index + stride), Size - index);
            Ptr.Offset(index).Cast<T>().Value = item;
        }
        else
        {
            var newPtr = Mem.Alloc(Size + stride);
            Mem.Copy(Ptr, newPtr, index);
            newPtr.Offset(index).Cast<T>().Value = item;
            Mem.Copy(Ptr.Offset(index), newPtr.Offset(index + stride), Size - index);
            Mem.Free(Ptr);
            Ptr = newPtr;
        }

        _byteSize += stride;
    }

    /// <summary>
    /// Remove a byte at an index, shifting all later elements down
    /// </summary>
    public void RemoveAt(ByteSize index)
    {
        RemoveAt(index, ByteSize.One);
    }

    /// <summary>
    /// Remove a number of bytes at an index, shifting all later elements down
    /// </summary>
    public void RemoveAt(ByteSize index, ByteSize numBytes)
    {
        if (index >= Size)
            throw new IndexOutOfRangeException();

        if (index < Size - numBytes)
        {
            Mem.Copy(Ptr.Offset(index + numBytes), Ptr.Offset(index), Size - index - numBytes);
        }

        _byteSize -= numBytes;
    }

    /// <summary>
    /// Clear NativeList and optionally change the element stride.
    /// </summary>
    /// <exception cref="DivideByZeroException">If newStride is less than or equal to zero</exception>
    public void Clear()
    {
        _byteSize = ByteSize.Zero;
    }

    /// <summary>
    /// Ensure the list has enough capacity to hold the given number of elements
    /// </summary>
    public void EnsureCapacity(ByteSize capacity)
    {
        if (_byteCapacity < capacity)
            GrowInternal(capacity);
    }
}
