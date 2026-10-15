using System.Diagnostics.CodeAnalysis;
using Brutal.Attributes;
using Brutal.Collections;
using Brutal.Memory;

namespace Brutal.Render.Mesh;

/// <summary>
/// Interface for an object that maps vertex buffers by a key
/// </summary>
/// <typeparam name="TKey">Key used to map vertex buffers</typeparam>
public interface IVertexBufferMap<TKey>
{
    /// Get vertex list by key
    public NativeStrideList GetVertexList(TKey key);

    /// Set vertex list by key
    public void SetVertexList(TKey key, NativeStrideList vertexList);

    /// Remove a vertex channel at key
    public bool RemoveVertexList(TKey key);

    /// True if key is present in map
    public bool ContainsKey(TKey key);

    /// Try-get list by key
    public bool TryGetVertexList(TKey key, [MaybeNullWhen(false)] out NativeStrideList value);

    /// <summary>
    /// Enumerate through all keys
    /// </summary>
    /// <returns>IEnumerable of keys</returns>
    public IEnumerable<TKey> GetVertexKeys();

    /// Official number of vertices
    int VertexCount { get; }
}

/// <summary>
/// Interface for a mesh object that may store an index buffer
/// </summary>
public interface IIndexBufferStorage
{
    /// Index buffer
    public NativeStrideList? IndexBuffer { get; }

    /// Set index buffer
    public void SetIndexBuffer(NativeStrideList indexList);

    /// Remove index buffer
    public void RemoveIndexBuffer();

    /// Number of indices in index buffer, if any
    int IndexCount { get; }
}

/// <summary>
/// Combined vertex/index mesh buffer interface
/// </summary>
/// <typeparam name="TKey">Vertex channel key</typeparam>
public interface IMeshStorage<TKey> : IVertexBufferMap<TKey>, IIndexBufferStorage { }

/// <summary>
/// Simple, generic mesh class that maps vertex channel buffers by a key for easy serialisation, modification and uploading to GPU
/// </summary>
/// <typeparam name="TKey">Key used to track vertex channels, can be an int, or a game specific enum</typeparam>
public class Mesh<TKey> : IDisposable, IMeshStorage<TKey>
    where TKey : unmanaged
{
    /// <summary>
    /// Index buffer (optional)
    /// </summary>
    public NativeStrideList? IndexBuffer { get; protected set; }

    /// <summary>
    /// Vertex buffers, mapped by a key, usually corresponding to a channel (eg: position, normals)
    /// </summary>
    public Dictionary<TKey, NativeStrideList> VertexBufferMap { get; protected set; } = new();

    /// <summary>
    /// Official number of vertices
    /// </summary>
    public int VertexCount { get; set; }

    /// <summary>
    /// Number of indices in index buffer, if any
    /// </summary>
    public int IndexCount => IndexBuffer?.Count ?? 0;

    /// <summary>
    /// Dictionary style Try-Get function
    /// </summary>
    /// <param name="key">Vertex channel key</param>
    /// <param name="value">NativeStrideList of vertices</param>
    /// <returns>True if found</returns>
    public bool TryGetVertexList(TKey key, [MaybeNullWhen(false)] out NativeStrideList value) =>
        VertexBufferMap.TryGetValue(key, out value);

    /// <summary>
    /// Returns true if vertex map contains the key
    /// </summary>
    /// <param name="key">Vertex channel key</param>
    /// <returns>True if key is present</returns>
    public bool ContainsKey(TKey key) => VertexBufferMap.ContainsKey(key);

    /// <summary>
    /// Get all the keys for vertex channels present
    /// </summary>
    /// <returns>IEnumerable of keys</returns>
    public IEnumerable<TKey> GetVertexKeys()
    {
        return VertexBufferMap.Keys;
    }

    /// <summary>
    /// Set or safely replace IndexBuffer
    /// </summary>
    /// <param name="indexList">List of index data</param>
    public void SetIndexBuffer(NativeStrideList indexList)
    {
        IndexBuffer?.Dispose();
        IndexBuffer = indexList;
    }

    /// <summary>
    /// Safely remove IndexBuffer
    /// </summary>
    public void RemoveIndexBuffer()
    {
        IndexBuffer?.Dispose();
        IndexBuffer = null;
    }

    /// <summary>
    /// Returns a vertex channel via span
    /// </summary>
    /// <param name="key">Key that maps to vertex channels</param>
    /// <typeparam name="T">Type we want to use for span</typeparam>
    /// <returns>Vertex buffer cast as span</returns>
    public Span<T> GetVertexSpan<T>(TKey key)
        where T : unmanaged
    {
        if (!VertexBufferMap.TryGetValue(key, out var nativeList))
            return default;
        return nativeList.ToSpan<T>();
    }

    /// <summary>
    /// Returns a NativeStrideList corresponding to a vertex channel
    /// </summary>
    /// <param name="key">Vertex channel key</param>
    /// <returns>Vertex buffer as a NativeStrideList</returns>
    /// <exception cref="Exception"></exception>
    public NativeStrideList GetVertexList(TKey key)
    {
        if (!VertexBufferMap.TryGetValue(key, out var nativeList))
            throw new Exception($"Vertex list for key {key} not found");
        return nativeList;
    }

    /// <summary>
    /// Remove and safely dispose a channel from Mesh
    /// </summary>
    /// <param name="key">Vertex channel key</param>
    /// <returns>True if successfully removed</returns>
    public bool RemoveVertexList(TKey key)
    {
        if (VertexBufferMap.TryGetValue(key, out var nativeList))
        {
            nativeList.Dispose();
            VertexBufferMap.Remove(key);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Map a vertex channel key to an existing NativeStrideList
    /// </summary>
    /// <param name="key">Vertex channel key</param>
    /// <param name="vertexList">Vertex buffer as a NativeStrideList</param>
    public void SetVertexList(TKey key, NativeStrideList vertexList)
    {
        VertexBufferMap[key] = vertexList;
    }

    /// <summary>
    /// Clear all buffers present
    /// </summary>
    public void Clear()
    {
        VertexCount = 0;
        IndexBuffer?.Clear();
        foreach (var data in VertexBufferMap)
            data.Value.Clear();
    }

    /// <summary>
    /// Release all buffers present
    /// </summary>
    public void Release()
    {
        VertexCount = 0;
        IndexBuffer?.Dispose();
        IndexBuffer = null;
        foreach (var data in VertexBufferMap)
            data.Value.Dispose();
        VertexBufferMap.Clear();
    }

    /// <summary>
    /// Dispose pattern
    /// </summary>
    public void Dispose()
    {
        Release();
    }
}

/// <summary>
/// Extension methods for meshes
/// </summary>
public static partial class MeshExtensions
{
    /// Creates empty vertex buffer if needed, or resizes existing buffer. Either way ensures a buffer of specified size exists and returns it
    public static NativeStrideList EnsureVertexBuffer<TKey>(
        this IVertexBufferMap<TKey> mesh,
        TKey key,
        ElementCount size,
        ByteSize stride
    )
    {
        if (mesh.TryGetVertexList(key, out NativeStrideList? nativeList))
        {
            if (stride != nativeList.Stride)
            {
                nativeList = new NativeStrideList(stride, nativeList.Capacity);
                mesh.SetVertexList(key, nativeList);
            }
        }
        else
        {
            nativeList = new NativeStrideList(stride, size);
            mesh.SetVertexList(key, nativeList);
        }
        nativeList.Count = size;
        return nativeList;
    }

    /// Creates empty index buffer if needed, or resizes existing buffer. Either way ensures a buffer of specified size exists and returns it
    public static NativeStrideList EnsureIndexBuffer(this IIndexBufferStorage mesh, ElementCount size, ByteSize stride)
    {
        if (mesh.IndexBuffer != null)
        {
            if (stride != mesh.IndexBuffer.Stride)
                mesh.SetIndexBuffer(new NativeStrideList(stride, mesh.IndexBuffer.Capacity));
            mesh.IndexBuffer.Count = size;
            return mesh.IndexBuffer;
        }
        var buffer = new NativeStrideList(stride, size);
        buffer.Count = size;
        mesh.SetIndexBuffer(buffer);
        return buffer;
    }

    /// Convenience function to set/replace vertices via NativeStrideSpan
    public static void SetIndicesFromData(this IIndexBufferStorage mesh, NativeStrideSpan data)
    {
        mesh.SetIndexBuffer(NativeStrideList.FromSpan(data));
    }

    /// Convenience function to set/replace vertices via Span
    public static void SetIndicesFromData<T>(this IIndexBufferStorage mesh, [Fixed] Span<T> data)
        where T : unmanaged
    {
        mesh.SetIndicesFromData(NativeStrideSpan.FromSpan(data));
    }

    /// Convenience function to set/replace vertices via NativeStrideSpan
    public static void SetVerticesFromData<TKey>(this IVertexBufferMap<TKey> mesh, TKey key, NativeStrideSpan data)
    {
        mesh.SetVertexList(key, NativeStrideList.FromSpan(data));
    }

    /// Convenience function to set/replace vertices via Span
    public static void SetVerticesFromData<TKey, T>(this IVertexBufferMap<TKey> mesh, TKey key, [Fixed] Span<T> data)
        where T : unmanaged
    {
        mesh.SetVerticesFromData(key, NativeStrideSpan.FromSpan(data));
    }

    /// Convenience function to add vertices via NativeStrideSpan
    public static void AddVerticesFromData<TKey>(this IVertexBufferMap<TKey> mesh, TKey key, NativeStrideSpan data)
    {
        if (mesh.TryGetVertexList(key, out var nativeList))
        {
            nativeList.AddData(data);
        }
        else
        {
            mesh.SetVertexList(key, NativeStrideList.FromSpan(data));
        }
    }

    /// Convenience function to add vertices via Span
    public static void AddVerticesFromData<TKey, T>(this IVertexBufferMap<TKey> mesh, TKey key, [Fixed] Span<T> data)
        where T : unmanaged
    {
        mesh.AddVerticesFromData(key, NativeStrideSpan.FromSpan(data));
    }

    /// Convenience function to add indices via NativeStrideSpan
    public static void AddIndicesFromData(this IIndexBufferStorage mesh, NativeStrideSpan data)
    {
        if (mesh.IndexBuffer != null)
            mesh.IndexBuffer.AddData(data);
        else
            mesh.SetIndexBuffer(NativeStrideList.FromSpan(data));
    }

    /// Convenience function to add vertices via Span
    public static void AddIndicesFromData<T>(this IIndexBufferStorage mesh, [Fixed] Span<T> data)
        where T : unmanaged
    {
        mesh.AddIndicesFromData(NativeStrideSpan.FromSpan(data));
    }

    /// Convenience function for quickly accessing vertex data as span
    public static bool TryGetVertexSpan<TKey, T>(this IVertexBufferMap<TKey> mesh, TKey key, out Span<T> data)
        where T : unmanaged
    {
        if (mesh.TryGetVertexList(key, out var nativeList))
        {
            data = nativeList.ToSpan<T>();
            return true;
        }
        data = default;
        return false;
    }

    /// Convenience function for quickly accessing vertex data as span
    public static bool TryGetIndexSpan<T>(this IIndexBufferStorage mesh, out Span<T> data)
        where T : unmanaged
    {
        if (mesh.IndexBuffer != null)
        {
            data = mesh.IndexBuffer.ToSpan<T>();
            return true;
        }
        data = default;
        return false;
    }
}

/// <summary>
/// Functions added to assist with updating Brutal.Core to 0.2.2 (and dependent packages)
/// </summary>
public static class NativeStrideListExtensions
{
    public static void AddData(this NativeStrideList list, NativeStrideSpan data)
    {
        ValidateSameStrides(data.Stride, list.Stride);
        list.AddRange(data.AsSpan<byte>().ToArray());
    }

    public static Span<T> ToSpan<T>(this NativeStrideList list)
        where T : unmanaged
    {
        if (list.Stride != ByteSize.Of<T>())
            throw new Exception(
                $"Invalid conversion: buffer stored with stride {list.Stride} but converting to type with stride {ByteSize.Of<T>()}"
            );
        return list.AsSpan<T>();
    }

    public static void ValidateSameStrides(ByteSize first, ByteSize second)
    {
        if (first != second)
            throw new ArgumentException($"Strides not equal");
    }
}
