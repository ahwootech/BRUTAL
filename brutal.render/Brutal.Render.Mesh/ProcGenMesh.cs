using System.Linq.Expressions;
using Brutal.Collections;
using Brutal.Memory;
using Brutal.Numerics;
using Brutal.Pointers.Extensions;

namespace Brutal.Render.Mesh;

/// <summary>
/// Output mesh structure that can optionally output to required vertex attributes
/// </summary>
public readonly struct ProcGenMesh
{
    /// <summary>
    /// Vertex positions as Vec3 (always required)
    /// </summary>
    public readonly NativeStrideList OutPositions;

    /// <summary>
    /// Vertex normals as Vec3 (optional)
    /// </summary>
    public readonly NativeStrideList? OutNormals;

    /// <summary>
    /// Vertex UVs as Vec2 (optional)
    /// </summary>
    public readonly NativeStrideList? OutUVs;

    /// <summary>
    /// Indices (optional)
    /// </summary>
    public readonly NativeStrideList? OutIndices;

    /// Construct a new ProcGenMesh structure from the given output lists
    public ProcGenMesh(
        NativeStrideList outPositions,
        NativeStrideList? outIndices = null,
        NativeStrideList? outNormals = null,
        NativeStrideList? outUVs = null
    )
    {
        OutPositions = outPositions;
        OutNormals = outNormals;
        OutUVs = outUVs;
        OutIndices = outIndices;
    }

    /// <summary>
    /// Vertex count
    /// </summary>
    public int VertexCount => OutPositions.Count;

    /// <summary>
    /// Index count
    /// </summary>
    public int IndexCount => OutIndices?.Count ?? 0;

    /// <summary>
    /// If true, indices are 16-bit shorts
    /// </summary>
    public bool Indices16Bit => OutIndices?.Stride == ByteSize.Of<ushort>();

    /// <summary>
    /// If true, indices are 32-bit ints
    /// </summary>
    public bool Indices32Bit => OutIndices?.Stride == ByteSize.Of<uint>();
}

/// <summary>
/// Procedural generation mesh library
/// Functions in this library support generating meshes with a variety vertex and index attributes
/// </summary>
public static partial class ProcGenMeshLibrary
{
    /// Global right direction assumed in generation. Change this if you are using a different coordinate system
    public static float3 GlobalRight = float3.UnitX;

    /// Global up direction assumed in generation. Change this if you are using a different coordinate system
    public static float3 GlobalUp = float3.UnitY;

    /// <summary>
    /// Ensures space for the given number of vertices in the output buffer,
    /// increases count and returns a pointer to the start of the new vertices.
    /// Pointer is only valid until the next modification of the buffer.
    /// </summary>
    /// <param name="list">NativeStrideList</param>
    /// <param name="count">Number of new elements to allocate</param>
    /// <typeparam name="T">Vertex struct type</typeparam>
    /// <returns>Pointer to first element in updated buffer</returns>
    public static unsafe T* AllocateAtEnd<T>(INativeList<T> list, int count)
        where T : unmanaged
    {
        if (list.Stride != ByteSize.Of<T>())
            throw new System.Exception($"Stride mismatch: {list.Stride} != {ByteSize.Of<T>()}");

        var oldSize = ByteSize.Of(list);
        list.Count += count;
        return (T*)((byte*)list.Ptr + oldSize);
    }

    public static unsafe T* AllocateAtEnd<T>(NativeStrideList list, int count)
        where T : unmanaged
    {
        if (list.Stride != ByteSize.Of<T>())
            throw new System.Exception($"Stride mismatch: {list.Stride} != {ByteSize.Of<T>()}");

        var oldSize = ByteSize.Of(list);
        list.Count += count;
        return (T*)(((byte*)list.Ptr) + oldSize);
    }

    /// <summary>
    /// General function for swizzling around vertex data
    /// Example offsets to swizzle: XZY: [0,2,1], XXX: [0,0,0], YX: [1,0], WXYZ: [3,0,1,2]
    /// </summary>
    /// <param name="inList">Input list of vertex elements to swizzle.</param>
    /// <param name="outList">Output list of vertex elements to swizzle (can be same as input)</param>
    /// <param name="offsets">List of offsets to target index. MUST be same length as expected vector</param>
    /// <typeparam name="T">Vector element type (usually float). NOT things like Vec3, you must cast these lists to their element type</typeparam>
    public static unsafe void SwizzleVertices<T>(Span<T> inList, Span<T> outList, Span<int> offsets)
        where T : unmanaged
    {
        if (inList.Length != outList.Length)
            throw new System.Exception($"Length mismatch: {inList.Length} != {outList.Length}");

        var vectorLength = offsets.Length;
        var buffer = stackalloc T[vectorLength];

        var vCount = inList.Length / vectorLength;
        var ptr = inList.AsPointer();
        for (var i = 0; i < vCount; i++)
        {
            var vI = i * vectorLength;
            for (var ii = 0; ii < vectorLength; ii++)
                buffer[ii] = ptr[vI + offsets[ii]];
            for (var ii = 0; ii < vectorLength; ii++)
                ptr[vI + ii] = buffer[ii];
        }
    }

    /// <summary>
    /// Add indices assuming triangles are generated in a clockwise order
    /// Supports both 16 and 32bit indices as output
    /// </summary>
    /// <param name="indices">Output indices, if null, ignore</param>
    /// <param name="start">First vertex</param>
    /// <param name="count">Number of indices to generate</param>
    public static unsafe void AddOrderedIndices(NativeStrideList? indices, int start, int count)
    {
        if (indices == null)
            return;
        var oldSize = ByteSize.Of(indices);
        indices.Count += count;
        var bytePtr = indices.Ptr.Offset(oldSize);
        var startU = (uint)start;

        // Support 16 and 32 bit indices
        if (indices.Stride == ByteSize.Of<ushort>())
        {
            var ptr = (ushort*)bytePtr;
            for (uint i = 0; i < count; ++i)
                ptr[i] = (ushort)(startU + i);
        }
        else if (indices.Stride == ByteSize.Of<uint>())
        {
            var ptr = (uint*)bytePtr;
            for (uint i = 0; i < count; ++i)
                ptr[i] = startU + i;
        }
        else
        {
            throw new Exception($"Unsupported index stride: {indices.Stride}");
        }
    }

    public static unsafe void AddGridIndices(
        NativeStrideList indices,
        int start,
        int resolutionX,
        int resolutionY,
        bool flip = false
    )
    {
        var oldSize = ByteSize.Of(indices);
        indices.Count += (resolutionX * resolutionY * 6);
        // Vertex resolution is one more than the grid resolution
        var realResX = resolutionX + 1;
        var bytePtr = indices.Ptr.Offset(oldSize);
        var flipOffset = flip ? 1 : 0;
        var p0 = flipOffset;
        var p1 = 1 - flipOffset;
        var p2 = (realResX + flipOffset);
        var p3 = (realResX + 1 - flipOffset);

        // Support 16 and 32 bit indices
        if (indices.Stride == ByteSize.Of<ushort>())
        {
            var ptr = (ushort*)bytePtr;
            var index = 0;
            for (var i = 0; i < resolutionY; i++)
            {
                for (var j = 0; j < resolutionX; j++)
                {
                    var i0 = start + i * realResX + j;
                    ptr[index++] = (ushort)(i0 + p0);
                    ptr[index++] = (ushort)(i0 + p1);
                    ptr[index++] = (ushort)(i0 + p3);

                    ptr[index++] = (ushort)(i0 + p0);
                    ptr[index++] = (ushort)(i0 + p3);
                    ptr[index++] = (ushort)(i0 + p2);
                }
            }
        }
        else if (indices.Stride == ByteSize.Of<uint>())
        {
            var ptr = (uint*)bytePtr;
            var index = 0;
            for (var i = 0; i < resolutionY; i++)
            {
                for (var j = 0; j < resolutionX; j++)
                {
                    var i0 = start + i * realResX + j;
                    ptr[index++] = (uint)(i0 + p0);
                    ptr[index++] = (uint)(i0 + p1);
                    ptr[index++] = (uint)(i0 + p3);

                    ptr[index++] = (uint)(i0 + p0);
                    ptr[index++] = (uint)(i0 + p3);
                    ptr[index++] = (uint)(i0 + p2);
                }
            }
        }
        else
        {
            throw new Exception($"Unsupported index stride: {indices.Stride}");
        }
    }

    /// <summary>
    /// Add a flat repeated value to the end of the list
    /// </summary>
    /// <param name="list">target NativeStrideList</param>
    /// <param name="value">Value to use</param>
    /// <param name="count">Number of repeats</param>
    /// <typeparam name="T">Value type, must be correct stride</typeparam>
    private static unsafe void AppendFlatValue<T>(NativeStrideList list, T value, int count)
        where T : unmanaged
    {
        var ptr = AllocateAtEnd<T>(list, count);
        for (var i = 0; i < count; ++i)
            ptr[i] = value;
    }

    /// <summary>
    /// Add a triangle to a vertex buffer
    /// </summary>
    /// <param name="positions">Position buffer</param>
    /// <param name="p0">Point in triangle</param>
    /// <param name="p1">Point in triangle</param>
    /// <param name="p2">Point in triangle</param>
    /// <typeparam name="T">Vertex type</typeparam>
    public static unsafe void AddTriangle<T>(NativeStrideList positions, T p0, T p1, T p2)
        where T : unmanaged
    {
        var ptr = AllocateAtEnd<T>(positions, 3);
        ptr[0] = p0;
        ptr[1] = p1;
        ptr[2] = p2;
    }

    /// <summary>
    /// Adds a quad as two triangles to the output mesh.
    /// Assumes points are organised in clockwise or anticlockwise order (p0 and p2 should be opposite corners, as with p1 and p3)
    /// </summary>
    /// <param name="positions">Output buffer</param>
    /// <param name="p0">Point in quad</param>
    /// <param name="p1">Point in quad</param>
    /// <param name="p2">Point in quad</param>
    /// <param name="p3">Point in quad</param>
    /// <typeparam name="T">Vertex type</typeparam>
    public static unsafe void AddQuad<T>(NativeStrideList positions, T p0, T p1, T p2, T p3)
        where T : unmanaged
    {
        var ptr = AllocateAtEnd<T>(positions, 6);
        ptr[0] = p0;
        ptr[1] = p1;
        ptr[2] = p2;

        ptr[3] = p0;
        ptr[4] = p2;
        ptr[5] = p3;
    }

    /// <summary>
    /// Adds a quad as two triangles to the output mesh, with efficient index generation.
    /// Assumes points are organised in clockwise or anticlockwise order (p0 and p2 should be opposite corners, as with p1 and p3)
    /// </summary>
    /// <param name="positions">Output position buffer</param>
    /// <param name="indices">Output indices</param>
    /// <param name="p0">Point in quad</param>
    /// <param name="p1">Point in quad</param>
    /// <param name="p2">Point in quad</param>
    /// <param name="p3">Point in quad</param>
    /// <typeparam name="T">Vertex type</typeparam>
    public static unsafe void AddQuad<T>(NativeStrideList positions, NativeStrideList indices, T p0, T p1, T p2, T p3)
        where T : unmanaged
    {
        var vCount = positions.Count;
        var ptr = AllocateAtEnd<T>(positions, 4);
        ptr[0] = p0;
        ptr[1] = p1;
        ptr[2] = p2;
        ptr[3] = p3;
        AddGridIndices(indices, vCount, 2, 2);
    }

    /// <summary>
    /// Add a triangle to an output mesh
    /// </summary>
    /// <param name="output">Output mesh object</param>
    /// <param name="p0">Point in triangle</param>
    /// <param name="p1">Point in triangle</param>
    /// <param name="p2">Point in triangle</param>
    public static void AddTriangle(in ProcGenMesh output, float3 p0, float3 p1, float3 p2)
    {
        var vCount = output.VertexCount;
        AddTriangle(output.OutPositions, p0, p1, p2);
        if (output.OutUVs != null)
            AppendFlatValue(output.OutUVs, float2.Zero, 3);
        if (output.OutNormals != null)
        {
            var normal = float3.Normalize(float3.Cross(p1 - p0, p2 - p0));
            AppendFlatValue(output.OutNormals, normal, 3);
        }
        AddOrderedIndices(output.OutIndices, vCount, 3);
    }

    /// <summary>
    /// Add a quad to an output mesh. Assumes quad is planar for normals, and UVs are normalised
    /// Assumes points are organised in clockwise or anticlockwise order (p0 and p2 should be opposite corners, as with p1 and p3)
    /// </summary>
    /// <param name="output">Output mesh target</param>
    /// <param name="p0">Point in quad</param>
    /// <param name="p1">Point in quad</param>
    /// <param name="p2">Point in quad</param>
    /// <param name="p3">Point in quad</param>
    public static void AddQuad(in ProcGenMesh output, float3 p0, float3 p1, float3 p2, float3 p3)
    {
        if (output.OutIndices != null)
        {
            // AddQuad with indices: Use efficient index generation
            AddQuad(output.OutPositions, output.OutIndices, p0, p1, p2, p3);
            if (output.OutUVs != null)
            {
                output.OutUVs.AddRange([new float2(0, 0), new float2(0, 1), new float2(1, 1), new float2(1, 0)]);
            }
        }
        else
        {
            // AddQuad without indices: Add vertices directly
            AddQuad(output.OutPositions, p0, p1, p2, p3);
            if (output.OutUVs != null)
            {
                output.OutUVs.AddRange(
                    [
                        new float2(0, 0),
                        new float2(0, 1),
                        new float2(1, 1),
                        new float2(0, 0),
                        new float2(1, 1),
                        new float2(1, 0),
                    ]
                );
            }
        }
        // Normals are the same for all vertices in a quad
        if (output.OutNormals != null)
        {
            var normal = float3.Normalize(float3.Cross(p1 - p0, p2 - p0));
            AppendFlatValue(output.OutNormals, normal, output.OutIndices != null ? 4 : 6);
        }
    }

    /// Calculate tangents for a mesh from UV data
    public static unsafe void CalculateTangents(
        NativeStrideList outTangents,
        Span<float3> positions,
        Span<int> indices,
        Span<float3> normals,
        Span<float2> uvs
    )
    {
        var vCount = positions.Length;
        var tangents = AllocateAtEnd<float4>(outTangents, vCount);

        // Temporary tangent lists
        using var tan1 = new NativeList<float3>();
        tan1.Count = vCount;
        using var tan2 = new NativeList<float3>();
        tan2.Count = vCount;

        var iCount = indices.Length;
        for (var a = 0; a < iCount; a += 3)
        {
            var i1 = indices[a];
            var i2 = indices[a + 1];
            var i3 = indices[a + 2];
            var v1 = positions[i1];
            var v2 = positions[i2];
            var v3 = positions[i3];
            var w1 = uvs[i1];
            var w2 = uvs[i2];
            var w3 = uvs[i3];
            var x1 = v2.X - v1.X;
            var x2 = v3.X - v1.X;
            var y1 = v2.Y - v1.Y;
            var y2 = v3.Y - v1.Y;
            var z1 = v2.Z - v1.Z;
            var z2 = v3.Z - v1.Z;
            var s1 = w2.X - w1.X;
            var s2 = w3.X - w1.X;
            var t1 = w2.Y - w1.Y;
            var t2 = w3.Y - w1.Y;
            var div = s1 * t2 - s2 * t1;
            var r = div == 0.0f ? 0.0f : 1.0f / div;
            var sDir = new float3((t2 * x1 - t1 * x2) * r, (t2 * y1 - t1 * y2) * r, (t2 * z1 - t1 * z2) * r);
            var tDir = new float3((s1 * x2 - s2 * x1) * r, (s1 * y2 - s2 * y1) * r, (s1 * z2 - s2 * z1) * r);
            tan1[i1] += sDir;
            tan1[i2] += sDir;
            tan1[i3] += sDir;
            tan2[i1] += tDir;
            tan2[i2] += tDir;
            tan2[i3] += tDir;
        }

        // Calculate final tangents from normals and temporary tangents
        for (var a = 0; a < vCount; a++)
        {
            var n = normals[a];
            var t = tan1[a];
            // Gram-Schmidt orthogonalize
            var tmp = (t - n * float3.Dot(n, t));
            tmp = float3.Normalize(tmp);
            // Calculate handedness
            var w = float3.Dot(float3.Cross(n, t), tan2[a]) < 0.0f ? -1.0f : 1.0f;
            tangents[a] = new float4(tmp, w);
        }
    }

    /// Calculate tangents for a mesh purely from normals
    public static unsafe void CalculateTangents(NativeStrideList outTangents, Span<float3> normals)
    {
        //No UVs, calculate tangents from world up direction
        var tangents = AllocateAtEnd<float4>(outTangents, normals.Length);
        var count = normals.Length;
        for (var i = 0; i < count; i++)
        {
            var normal = normals[i];
            if (normal.Y >= 1.0f)
            {
                tangents[i] = new float4(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else
            {
                var biTangent = float3.Cross(normal, GlobalUp);
                tangents[i] = new float4(float3.Normalize(float3.Cross(normal, biTangent)), 1.0f);
            }
        }
    }

    /// <summary>
    /// Calculate the tangents of a mesh
    /// </summary>
    /// <param name="mesh">Source mesh to calculate tangents from</param>
    /// <param name="outTangents">Tangent buffer to output to</param>
    /// <exception cref="Exception">Thrown if insufficient mesh data present</exception>
    public static void CalculateTangents(in ProcGenMesh mesh, NativeStrideList outTangents)
    {
        if (mesh is { OutIndices: not null, OutUVs: not null, OutNormals: not null })
            CalculateTangents(
                outTangents,
                mesh.OutPositions.ToSpan<float3>(),
                mesh.OutIndices.ToSpan<int>(),
                mesh.OutNormals.ToSpan<float3>(),
                mesh.OutUVs.ToSpan<float2>()
            );
        else if (mesh.OutNormals != null)
            CalculateTangents(outTangents, mesh.OutNormals.ToSpan<float3>());
        else
            throw new Exception("Insufficient data to calculate tangents");
    }

    /// <summary>
    /// Swizzle XYZ coords of a generated mesh. Helpful if you are using different coordinate systems
    /// </summary>
    /// <param name="mesh">Target mesh data</param>
    /// <param name="offsets">Offset of swizzle data for XYZ</param>
    /// <exception cref="Exception"></exception>
    public static void SwizzleWorldCoords(in ProcGenMesh mesh, Span<int> offsets)
    {
        if (offsets.Length != 3)
            throw new Exception("Insufficient data to calculate world coords");
        var positions = mesh.OutPositions.AsSpan<float>();
        SwizzleVertices(positions, positions, offsets);
        if (mesh.OutNormals != null)
        {
            var normals = mesh.OutNormals.AsSpan<float>();
            SwizzleVertices(normals, normals, offsets);
        }
    }

    /// <summary>
    /// Offset all position values by a translation value
    /// </summary>
    /// <param name="mesh">Target mesh</param>
    /// <param name="translation">Translation offset</param>
    public static unsafe void OffsetWorldCoords(in ProcGenMesh mesh, float3 translation)
    {
        var positions = mesh.OutPositions.ToSpan<float3>();
        var vCount = positions.Length;
        var ptr = positions.AsPointer();
        for (var i = 0; i < vCount; i++)
            ptr[i] += translation;
    }

    /// <summary>
    /// Scale all position/normal values by a value
    /// </summary>
    /// <param name="mesh">Target mesh</param>
    /// <param name="scale">Scaler</param>
    public static unsafe void ScaleWorldCoords(in ProcGenMesh mesh, float3 scale)
    {
        var positions = mesh.OutPositions.ToSpan<float3>();
        var vCount = positions.Length;
        var ptr = positions.AsPointer();
        for (var i = 0; i < vCount; i++)
            ptr[i] *= scale;
        if (mesh.OutNormals != null)
        {
            var normals = mesh.OutNormals.ToSpan<float3>();
            vCount = normals.Length;
            ptr = normals.AsPointer();
            for (var i = 0; i < vCount; i++)
                ptr[i] *= scale;
        }
    }

    /// <summary>
    /// Transform all position/normal values by a value
    /// </summary>
    /// <param name="mesh">Target mesh</param>
    /// <param name="matrix">Transform matrix</param>
    public static unsafe void TransformWorldCoords(in ProcGenMesh mesh, float4x4 matrix)
    {
        var positions = mesh.OutPositions.ToSpan<float3>();
        var vCount = positions.Length;
        var ptr = positions.AsPointer();
        for (var i = 0; i < vCount; i++)
            ptr[i] = float3.Transform(ptr[i], matrix);
        if (mesh.OutNormals != null)
        {
            var normals = mesh.OutNormals.ToSpan<float3>();
            vCount = normals.Length;
            ptr = normals.AsPointer();
            for (var i = 0; i < vCount; i++)
                ptr[i] = float3.TransformNormal(ptr[i], matrix);
        }
    }
}
