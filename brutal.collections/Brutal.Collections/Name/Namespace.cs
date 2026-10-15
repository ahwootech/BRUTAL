using System.Diagnostics.CodeAnalysis;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.Collections;

/// <summary>
/// A pool of unique identifiers
/// </summary>
public class Namespace<T>
{
    private readonly Lock _lock = new();

    /// <summary>
    /// A global shared pool
    /// </summary>
    public static Namespace<T> Shared { get; } = new();

    private readonly StringPool _pool = new();

    internal string GetOrAdd(ReadOnlySpan<char> id)
    {
        lock (_lock)
        {
            return _pool.GetOrAdd(id);
        }
    }

    /// <summary>
    /// Try to get an existing ID from the pool
    /// </summary>
    public bool TryGet(ReadOnlySpan<char> id, [NotNullWhen(true)] out Name<T>? existing)
    {
        lock (_lock)
        {
            if (_pool.TryGet(id, out var key))
            {
                existing = new Name<T>(key);
                return true;
            }

            existing = null;
            return false;
        }
    }

    /// <summary>
    /// Check if the pool contains the given ID
    /// </summary>
    public bool Contains(ReadOnlySpan<char> id)
    {
        lock (_lock)
        {
            return _pool.TryGet(id, out _);
        }
    }
}
