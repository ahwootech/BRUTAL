using System.Collections;
using Brutal.Memory;

namespace Brutal.ImGuiApi;

[StructLayout(LayoutKind.Sequential)]
public struct ImVector<T> : IList<T>
    where T : unmanaged
{
    private const int DEFAULT_CAPACITY = 8;

    private int _size;
    private int _capacity;
    private Ptr<T> _data;

    public int Count
    {
        get => _size;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);

            if (value == _size)
                return;

            EnsureCapacity(value);

            if (value > _size)
            {
                Mem.Clear(Data.Offset(_size), ElementCount.Of(value - _size));
            }

            _size = value;
        }
    }

    public int Capacity => _capacity;

    public unsafe void EnsureCapacity(int capacity)
    {
        if (capacity <= _capacity)
            return;

        var newCapacity = GetGrownCapacity(capacity);

        var newData = (T*)ImGui.MemAlloc((nuint)newCapacity * (nuint)Stride);

        if (_data.IsNotNull())
        {
            Mem.Copy(_data, newData, _size);
            ImGui.MemFree(_data.Pointer);
        }

        _data = new Ptr<T>(newData);
        _capacity = newCapacity;
    }

    public Ptr<T> Data => _data;
    public unsafe T* DataRaw => _data;
    public Span<T> Span => _data.AsSpan(_size);

    public T this[int i]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfNegative(i);
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(i, _size);

            return Data[i];
        }
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(i);
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(i, _size);

            Data[i] = value;
        }
    }

    public int IndexOf(T item)
    {
        return Span.IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(index, _size);

        EnsureCapacity(_size + 1);

        // Shift elements right to open a slot; Mem.Copy has memmove semantics, so the overlapping
        // copy is safe.
        if (index < _size)
            Mem.Copy(Data.Offset(index), Data.Offset(index + 1), _size - index);

        Data[index] = item;

        _size++;
    }

    public void RemoveAt(int index)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, _size);

        _size--;
        if (index < _size)
        {
            // Shift elements left over the removed slot; Mem.Copy has memmove semantics, so the
            // overlapping copy is safe.
            Mem.Copy(Data.Offset(index + 1), Data.Offset(index), _size - index);
        }
    }

    // Pattern-based GetEnumerator to enable foreach without boxing
    public unsafe ImVectorEnumerator<T> GetEnumerator() => new(Data, _size);

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        unsafe
        {
            return new ImVectorEnumerator<T>(Data, _size);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        EnsureCapacity(_size + 1);
        Data[_size] = item;
        _size++;
    }

    public unsafe void Clear()
    {
        if (_data.IsNull())
            return;

        _size = _capacity = 0;
        ImGui.MemFree(_data.Pointer);
        _data = null;
    }

    /// Resets the count to zero but keeps the allocated buffer so we can re-use it without freeing/allocating
    public void Reset() => _size = 0;

    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        unsafe
        {
            fixed (T* ptr = array)
            {
                Mem.Copy(Data, ptr + arrayIndex, _size);
            }
        }
    }

    public bool Remove(T item)
    {
        var index = IndexOf(item);
        if (index < 0)
            return false;

        RemoveAt(index);
        return true;
    }

    public bool IsReadOnly => false;

    private static unsafe int Stride => sizeof(T);

    private readonly int GetGrownCapacity(int requiredCapacity)
    {
        var newCapacity = _capacity is 0 ? DEFAULT_CAPACITY : _capacity + _capacity / 2;
        return newCapacity > requiredCapacity ? newCapacity : requiredCapacity;
    }
}

public struct ImVectorEnumerator<T> : IEnumerator<T>
    where T : unmanaged
{
    private readonly unsafe T* _start;
    private readonly int _length;
    private int _index;

    public unsafe ImVectorEnumerator(T* start, int length)
    {
        _start = start;
        _length = length;
        _index = -1;
    }

    public bool MoveNext()
    {
        var i = _index + 1;

        if ((uint)i < (uint)_length)
        {
            _index = i;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _index = -1;
    }

    public unsafe T Current => _start[_index];

    object IEnumerator.Current => Current;

    public void Dispose() { }
}
