using System.Collections;

namespace Brutal.Collections;

/// <summary>
///  Enumerator class for generic NativeList
/// </summary>
public struct NativeListEnumerator<T> : IEnumerator<T>
    where T : unmanaged
{
    private readonly NativeList<T> _list;
    private int _index;

    /// <summary>
    /// Construct enumerator from the list
    /// </summary>
    /// <param name="list">Source list</param>
    public NativeListEnumerator(NativeList<T> list)
    {
        _list = list;
        _index = -1;
    }

    /// <summary>
    /// Iterate next element
    /// </summary>
    /// <returns>True if enumerator still running</returns>
    public bool MoveNext()
    {
        _index++;
        return _index < _list.Count;
    }

    /// <summary>
    /// Reset enumerator
    /// </summary>
    public void Reset()
    {
        _index = -1;
    }

    /// <summary>
    /// Index enumerator
    /// </summary>
    public T Current => _list[_index];

    object IEnumerator.Current => Current;

    /// <summary>
    /// Dispose of enumerator
    /// </summary>
    public void Dispose() { }
}
