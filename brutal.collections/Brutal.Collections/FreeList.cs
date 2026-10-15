using System.Runtime.CompilerServices;

namespace Brutal.Collections;

/// <summary>
/// Interface for a free list index pool, a lightweight allocator that tracks free elements
/// See: https://en.wikipedia.org/wiki/Free_list
/// </summary>
public interface IFreeListIndexPool
{
    /// <summary>
    /// Total backing capacity
    /// </summary>
    public int Capacity { get; set; }

    /// <summary>
    /// Add element to list, returns index/key to element
    /// </summary>
    /// <returns>Index to element</returns>
    public int Add();

    /// <summary>
    /// Check if element at index is empty
    /// </summary>
    public bool IsEmpty(int index);

    /// <summary>
    /// Remove element at index
    /// </summary>
    public void Remove(int index);

    /// <summary>
    /// Reset list as empty
    /// </summary>
    public void Clear();
}

/// <summary>
/// Pool/allocator of indices that tracks free elements to avoid reallocation.
/// Can be used as the allocator for a FreeList. See: https://en.wikipedia.org/wiki/Free_list
/// </summary>
public class FreeListIndexPool : IFreeListIndexPool
{
    /// <summary>
    /// Empty element index not part of linked list of free elements
    /// </summary>
    const int OCCUPIED = -1;

    /// <summary>
    /// Construct a new free list, that is empty and can grow
    /// </summary>
    public FreeListIndexPool()
    {
        _list = new();
        AllowResize = true;
    }

    /// <summary>
    /// Construct a new free list with a given capacity
    /// </summary>
    /// <param name="capacity">Initial capacity</param>
    /// <param name="allowResize">If false, will throw instead of growing capacity when backing list is full</param>
    public FreeListIndexPool(int capacity, bool allowResize)
    {
        _list = new(capacity);
        AllowResize = allowResize;
    }

    private readonly List<int> _list;
    private int _firstFree = OCCUPIED;

    /// <summary>
    /// If true, the list will grow when full, if false, it will throw an exception
    /// </summary>
    public readonly bool AllowResize;

    /// <inheritdoc/>
    public int Capacity
    {
        get => _list.Capacity;
        set => _list.Capacity = value;
    }

    /// <summary>
    /// Access element by index
    /// </summary>
    public int this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _list[index];
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => _list[index] = value;
    }

    /// <inheritdoc/>
    public bool IsEmpty(int index)
    {
        return _list[index] == OCCUPIED;
    }

    public bool TryAdd(out int index)
    {
        if (_firstFree != OCCUPIED)
        {
            index = _firstFree;
            _firstFree = _list[index];
            _list[index] = OCCUPIED;
        }
        else
        {
            if (!AllowResize && _list.Count == _list.Capacity)
            {
                index = -1;
                return false;
            }

            _list.Add(OCCUPIED);
            index = _list.Count - 1;
        }

        return true;
    }

    /// <inheritdoc/>
    public int Add()
    {
        if (!TryAdd(out var index))
            throw new Exception("FreeListIndexPool is full, and is not allowed to grow");
        return index;
    }

    /// <inheritdoc/>
    public void Remove(int index)
    {
        _list[index] = _firstFree;
        _firstFree = index;
    }

    /// <inheritdoc/>
    public void Clear()
    {
        _list.Clear();
        _firstFree = OCCUPIED;
    }
}
