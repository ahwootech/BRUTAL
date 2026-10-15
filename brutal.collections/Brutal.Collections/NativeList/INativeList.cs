using Brutal.Memory;

namespace Brutal.Collections;

/// <summary>
/// Base class for native-memory backed lists
/// </summary>
public interface INativeList : ISpanLike, IDisposable
{
    public ElementCount Count { get; set; }
    public ElementCount Capacity { get; set; }

    /// <summary>
    /// Matching C# List's Clear(), zeroes count but preserves capacity
    /// </summary>
    public void Clear();

    /// <summary>
    /// Set the capacity to the actual number of elements in the list, if the current
    /// </summary>
    public void TrimExcess();

    /// <summary>
    /// Increase the capacity of the vector (the total number of elements that the vector can hold without requiring
    /// reallocation) to a value that's greater or equal to newCapacity. If new_cap is greater than the current
    /// Capacity, new storage is then allocated; otherwise the function does nothing.
    /// </summary>
    /// <param name="capacity">The new max size</param>
    public void EnsureCapacity(ElementCount capacity);

    /// <summary>
    /// Reset the array and free memory
    /// </summary>
    public void Free();
}

public interface INativeList<T> : INativeList, ISpanLike<T>, IEnumerable<T>
    where T : unmanaged
{
    /// <summary>
    /// Get or set an element at an index
    /// </summary>
    public ref T this[Index index] { get; }

    /// <summary>
    /// Add an element to the end of the list
    /// </summary>
    /// <param name="item">The item to add</param>
    public void Add(T item);

    /// <summary>
    /// Add a range of elements to the end of the list
    /// </summary>
    /// <param name="items">The items to add</param>
    public void AddRange(ReadOnlySpan<T> items);

    /// <summary>
    /// Insert an element at an index, shifting all later elements up by one
    /// </summary>
    /// <param name="index">The index to insert at</param>
    /// <param name="item">The item to insert</param>
    public void Insert(ElementCount index, T item);

    /// <summary>
    /// Remove an element at an index, shifting all later elements down by one
    /// </summary>
    /// <param name="index">The index to remove at</param>
    public void RemoveAt(ElementCount index);
}
