using System.Buffers;
using System.Runtime.InteropServices;

namespace Brutal.GltfApi;

public static partial class GltfLoaderExtensions
{
    // Byte offsets within a float element for each component
    private const int OffX = 0;
    private const int OffY = 4;
    private const int OffZ = 8;
    private const int OffW = 12;

    // Per-element strides for common GLTF accessor types
    private const int StrideFloat3 = 12; // vec3
    private const int StrideFloat4 = 16; // vec4 / quaternion
    private const int StrideMatrix = 64; // mat4

    // Byte offsets of each Mij within a row-major float4x4 (System.Numerics layout)
    //   Row 1:  M11= 0  M12= 4  M13= 8  M14=12
    //   Row 2:  M21=16  M22=20  M23=24  M24=28
    //   Row 3:  M31=32  M32=36  M33=40  M34=44
    //   Row 4:  M41=48  M42=52  M43=56  M44=60
    private const int M11 = 0;
    private const int M12 = 4;
    private const int M13 = 8;
    private const int M14 = 12;
    private const int M21 = 16;
    private const int M22 = 20;
    private const int M23 = 24;
    private const int M24 = 28;
    private const int M31 = 32;
    private const int M32 = 36;
    private const int M33 = 40;
    private const int M34 = 44;
    private const int M41 = 48;
    private const int M42 = 52;
    private const int M43 = 56;

    /// <summary>
    /// Flips all loaded GLTF data from right-handed (GLTF standard) to left-handed coordinates
    /// by negating the Z axis. Call immediately after loading, before extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (Z negated) and rotations (X, Y components negated)</item>
    ///   <item>Node explicit matrix transforms (Z row and Z column negated)</item>
    ///   <item>Mesh vertex positions and normals (Z negated)</item>
    ///   <item>Mesh tangents (Z negated, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (Z row and Z column negated)</item>
    ///   <item>Animation translation tracks (Z negated)</item>
    ///   <item>Animation rotation tracks (X, Y components negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void FlipHandedness(this GltfLoader loader) => FlipZAxis(loader);

    /// <summary>
    /// Flips all loaded GLTF data from right-handed (GLTF standard) to left-handed coordinates
    /// by negating the Z axis. Call immediately after loading, before extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (Z negated) and rotations (X, Y components negated)</item>
    ///   <item>Node explicit matrix transforms (Z row and Z column negated)</item>
    ///   <item>Mesh vertex positions and normals (Z negated)</item>
    ///   <item>Mesh tangents (Z negated, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (Z row and Z column negated)</item>
    ///   <item>Animation translation tracks (Z negated)</item>
    ///   <item>Animation rotation tracks (X, Y components negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void FlipZAxis(this GltfLoader loader) =>
        FlipAxisImpl(loader, OffZ, OffX, OffY, [M31, M32, M34, M13, M23, M43]);

    /// <summary>
    /// Inverts the X axis of all loaded GLTF data. Call immediately after loading, before
    /// extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (X negated) and rotations (Y, Z components negated)</item>
    ///   <item>Node explicit matrix transforms (X row and X column negated)</item>
    ///   <item>Mesh vertex positions and normals (X negated)</item>
    ///   <item>Mesh tangents (X negated, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (X row and X column negated)</item>
    ///   <item>Animation translation tracks (X negated)</item>
    ///   <item>Animation rotation tracks (Y, Z components negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void FlipXAxis(this GltfLoader loader) =>
        FlipAxisImpl(loader, OffX, OffY, OffZ, [M12, M13, M14, M21, M31, M41]);

    /// <summary>
    /// Inverts the Y axis of all loaded GLTF data. Call immediately after loading, before
    /// extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (Y negated) and rotations (X, Z components negated)</item>
    ///   <item>Node explicit matrix transforms (Y row and Y column negated)</item>
    ///   <item>Mesh vertex positions and normals (Y negated)</item>
    ///   <item>Mesh tangents (Y negated, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (Y row and Y column negated)</item>
    ///   <item>Animation translation tracks (Y negated)</item>
    ///   <item>Animation rotation tracks (X, Z components negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void FlipYAxis(this GltfLoader loader) =>
        FlipAxisImpl(loader, OffY, OffX, OffZ, [M21, M23, M24, M12, M32, M42]);

    /// <summary>
    /// Swaps the Y and Z axes of all loaded GLTF data. Call immediately after loading, before
    /// extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (Y and Z swapped) and rotations (Y and Z components swapped, W negated)</item>
    ///   <item>Node explicit matrix transforms (Y and Z rows and columns swapped)</item>
    ///   <item>Mesh vertex positions and normals (Y and Z swapped)</item>
    ///   <item>Mesh tangents (Y and Z swapped, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (Y and Z rows and columns swapped)</item>
    ///   <item>Animation translation tracks (Y and Z swapped)</item>
    ///   <item>Animation rotation tracks (Y and Z components swapped, W negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void SwapYZAxes(this GltfLoader loader) =>
        SwapAxesImpl(loader, OffY, OffZ, [M12, M13, M21, M31, M22, M33, M23, M32, M24, M34, M42, M43]);

    /// <summary>
    /// Swaps the X and Y axes of all loaded GLTF data. Call immediately after loading, before
    /// extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (X and Y swapped) and rotations (X and Y components swapped, W negated)</item>
    ///   <item>Node explicit matrix transforms (X and Y rows and columns swapped)</item>
    ///   <item>Mesh vertex positions and normals (X and Y swapped)</item>
    ///   <item>Mesh tangents (X and Y swapped, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (X and Y rows and columns swapped)</item>
    ///   <item>Animation translation tracks (X and Y swapped)</item>
    ///   <item>Animation rotation tracks (X and Y components swapped, W negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void SwapXYAxes(this GltfLoader loader) =>
        SwapAxesImpl(loader, OffX, OffY, [M11, M22, M12, M21, M13, M23, M14, M24, M31, M32, M41, M42]);

    /// <summary>
    /// Swaps the X and Z axes of all loaded GLTF data. Call immediately after loading, before
    /// extracting any assets.
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (X and Z swapped) and rotations (X and Z components swapped, W negated)</item>
    ///   <item>Node explicit matrix transforms (X and Z rows and columns swapped)</item>
    ///   <item>Mesh vertex positions and normals (X and Z swapped)</item>
    ///   <item>Mesh tangents (X and Z swapped, handedness sign W negated)</item>
    ///   <item>Index buffers (triangle winding reversed)</item>
    ///   <item>Skin inverse bind matrices (X and Z rows and columns swapped)</item>
    ///   <item>Animation translation tracks (X and Z swapped)</item>
    ///   <item>Animation rotation tracks (X and Z components swapped, W negated)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void SwapXZAxes(this GltfLoader loader) =>
        SwapAxesImpl(loader, OffX, OffZ, [M11, M33, M12, M32, M13, M31, M14, M34, M21, M23, M41, M43]);

    /// <summary>
    /// Uniformly scales all loaded GLTF positional data by <paramref name="scale"/>. Call immediately
    /// after loading, before extracting any assets.
    /// <para>
    /// Rotations, local TRS scale values, normals, and tangents are left unchanged — they are
    /// dimensionless direction vectors unaffected by a unit change.
    /// </para>
    /// <para>
    /// Affects:
    /// <list type="bullet">
    ///   <item>Node TRS translations (multiplied by scale)</item>
    ///   <item>Node explicit matrix transforms (translation row multiplied by scale)</item>
    ///   <item>Mesh vertex positions (multiplied by scale)</item>
    ///   <item>Skin inverse bind matrices (translation row multiplied by scale)</item>
    ///   <item>Animation translation tracks (multiplied by scale)</item>
    /// </list>
    /// </para>
    /// </summary>
    public static void Scale(this GltfLoader loader, float scale)
    {
        var gltf = loader.GltfJson;
        var processedAccessors = ArrayPool<bool>.Shared.Rent(gltf.Accessors.Length);
        Array.Clear(processedAccessors, 0, gltf.Accessors.Length);

        // Nodes: scale TRS translation and explicit matrix translation row
        foreach (var node in gltf.Nodes)
        {
            var t = node.Translation;
            node.Translation = new float3(t.X * scale, t.Y * scale, t.Z * scale);
            node.Matrix = ScaleMatrixTranslation(node.Matrix, scale);
        }

        // Mesh accessor data: positions only (normals and tangents are direction vectors)
        foreach (var mesh in gltf.Meshes)
        foreach (var prim in mesh.Primitives)
        {
            if (prim == null)
                continue;

            if (prim.Attributes.TryGetValue("POSITION", out var posIdx) && AddToSet(processedAccessors, posIdx))
            {
                var span = loader.GetAccessorBufferSpan(posIdx);
                ScaleComponent(span, StrideFloat3, OffX, scale);
                ScaleComponent(span, StrideFloat3, OffY, scale);
                ScaleComponent(span, StrideFloat3, OffZ, scale);
            }
        }

        // Skin inverse bind matrices: translation row only
        if (gltf.Skins != null)
            foreach (var skin in gltf.Skins)
                if (skin.InverseBindMatrices.HasValue && AddToSet(processedAccessors, skin.InverseBindMatrices.Value))
                    ScaleMatrixTranslationArray(loader.GetAccessorBufferSpan(skin.InverseBindMatrices.Value), scale);

        // Animation translation tracks
        if (gltf.Animations != null)
            foreach (var anim in gltf.Animations)
            foreach (var channel in anim.Channels)
            {
                if (channel.Target.Node == null)
                    continue;
                var sampler = anim.Samplers[channel.Sampler];
                if (
                    channel.Target.Path == AnimationChannelTarget.PathEnum.Translation
                    && AddToSet(processedAccessors, sampler.Output)
                )
                {
                    var span = loader.GetAccessorBufferSpan(sampler.Output);
                    ScaleComponent(span, StrideFloat3, OffX, scale);
                    ScaleComponent(span, StrideFloat3, OffY, scale);
                    ScaleComponent(span, StrideFloat3, OffZ, scale);
                }
            }

        ArrayPool<bool>.Shared.Return(processedAccessors);
    }

    #region Private helpers

    /// <summary>
    /// Iterates over a raw accessor buffer treating it as an array of fixed-size elements and
    /// negates one float at <paramref name="componentByteOffset"/> within each element.
    /// Works for any element size and any float component inside it.
    /// </summary>
    private static unsafe void NegateComponent(
        ReadOnlySpan<byte> buffer,
        int elementByteStride,
        int componentByteOffset
    )
    {
        fixed (byte* basePtr = &MemoryMarshal.GetReference(buffer))
        {
            var ptr = basePtr + componentByteOffset;
            var end = basePtr + buffer.Length;
            while (ptr < end)
            {
                *(float*)ptr = -*(float*)ptr;
                ptr += elementByteStride;
            }
        }
    }

    /// <summary>
    /// Iterates over a raw accessor buffer and swaps two float components within each element.
    /// </summary>
    private static unsafe void SwapComponents(
        ReadOnlySpan<byte> buffer,
        int elementByteStride,
        int componentByteOffsetA,
        int componentByteOffsetB
    )
    {
        fixed (byte* basePtr = &MemoryMarshal.GetReference(buffer))
        {
            var ptrA = basePtr + componentByteOffsetA;
            var ptrB = basePtr + componentByteOffsetB;
            var end = basePtr + buffer.Length;
            while (ptrA < end)
            {
                (*(float*)ptrA, *(float*)ptrB) = (*(float*)ptrB, *(float*)ptrA);
                ptrA += elementByteStride;
                ptrB += elementByteStride;
            }
        }
    }

    private static unsafe void ScaleComponent(
        ReadOnlySpan<byte> buffer,
        int elementByteStride,
        int componentByteOffset,
        float scale
    )
    {
        fixed (byte* basePtr = &MemoryMarshal.GetReference(buffer))
        {
            var ptr = basePtr + componentByteOffset;
            var end = basePtr + buffer.Length;
            while (ptr < end)
            {
                *(float*)ptr *= scale;
                ptr += elementByteStride;
            }
        }
    }

    private static float4x4 ScaleMatrixTranslation(float4x4 m, float scale)
    {
        m.M41 *= scale;
        m.M42 *= scale;
        m.M43 *= scale;
        return m;
    }

    private static void ScaleMatrixTranslationArray(ReadOnlySpan<byte> buffer, float scale)
    {
        ScaleComponent(buffer, StrideMatrix, M41, scale);
        ScaleComponent(buffer, StrideMatrix, M42, scale);
        ScaleComponent(buffer, StrideMatrix, M43, scale);
    }

    // Shared implementation for FlipXAxis / FlipYAxis / FlipZAxis.
    //   vecOff          — byte offset of the vector component to negate (OffX / OffY / OffZ)
    //   quatOffA/B      — byte offsets of the two OTHER quat imaginary components to negate
    //   matOffsets      — 6 matrix byte offsets: 3 off-diagonal row elements + 3 off-diagonal
    //                     col elements for the negated axis (diagonal is double-negated → +ve)
    private static void FlipAxisImpl(
        GltfLoader loader,
        int vecOff,
        int quatOffA,
        int quatOffB,
        ReadOnlySpan<int> matOffsets
    )
    {
        var gltf = loader.GltfJson;
        var processedAccessors = ArrayPool<bool>.Shared.Rent(gltf.Accessors.Length);
        Array.Clear(processedAccessors, 0, gltf.Accessors.Length);

        // Nodes: negate the relevant TRS translation component, rotate quaternion, flip matrix
        foreach (var node in gltf.Nodes)
        {
            node.Translation = NegateFloat3Component(node.Translation, vecOff);
            node.Rotation = NegateQuatComponents(node.Rotation, quatOffA, quatOffB);
            node.Matrix = NegateMatrixElements(node.Matrix, matOffsets);
        }

        // Mesh accessor data: positions, normals, tangents, index winding
        foreach (var mesh in gltf.Meshes)
        foreach (var prim in mesh.Primitives)
        {
            if (prim == null)
                continue;

            if (prim.Attributes.TryGetValue("POSITION", out var posIdx) && AddToSet(processedAccessors, posIdx))
                NegateComponent(loader.GetAccessorBufferSpan(posIdx), StrideFloat3, vecOff);

            if (prim.Attributes.TryGetValue("NORMAL", out var normIdx) && AddToSet(processedAccessors, normIdx))
                NegateComponent(loader.GetAccessorBufferSpan(normIdx), StrideFloat3, vecOff);

            if (prim.Attributes.TryGetValue("TANGENT", out var tangIdx) && AddToSet(processedAccessors, tangIdx))
            {
                // Negate the axis component and the handedness sign W: reflecting one axis flips
                // the tangent frame orientation
                NegateComponent(loader.GetAccessorBufferSpan(tangIdx), StrideFloat4, vecOff);
                NegateComponent(loader.GetAccessorBufferSpan(tangIdx), StrideFloat4, OffW);
            }

            if (prim.Indices.HasValue && AddToSet(processedAccessors, prim.Indices.Value))
                FlipTriangleWinding(
                    loader.GetAccessorBufferSpan(prim.Indices.Value),
                    gltf.Accessors[prim.Indices.Value].ComponentType
                );
        }

        // Skin inverse bind matrices
        if (gltf.Skins != null)
            foreach (var skin in gltf.Skins)
                if (skin.InverseBindMatrices.HasValue && AddToSet(processedAccessors, skin.InverseBindMatrices.Value))
                    NegateMatrixElementsArray(loader.GetAccessorBufferSpan(skin.InverseBindMatrices.Value), matOffsets);

        // Animation translation and rotation tracks
        if (gltf.Animations != null)
            foreach (var anim in gltf.Animations)
            foreach (var channel in anim.Channels)
            {
                if (channel.Target.Node == null)
                    continue;
                var sampler = anim.Samplers[channel.Sampler];
                if (
                    channel.Target.Path == AnimationChannelTarget.PathEnum.Translation
                    && AddToSet(processedAccessors, sampler.Output)
                )
                    NegateComponent(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat3, vecOff);
                else if (
                    channel.Target.Path == AnimationChannelTarget.PathEnum.Rotation
                    && AddToSet(processedAccessors, sampler.Output)
                )
                {
                    NegateComponent(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat4, quatOffA);
                    NegateComponent(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat4, quatOffB);
                }
            }

        ArrayPool<bool>.Shared.Return(processedAccessors);
    }

    // Negates the float3 component at the given byte offset (OffX / OffY / OffZ).
    private static float3 NegateFloat3Component(float3 v, int off) =>
        off switch
        {
            OffX => new float3(-v.X, v.Y, v.Z),
            OffY => new float3(v.X, -v.Y, v.Z),
            _ => new float3(v.X, v.Y, -v.Z),
        };

    // Negates the two imaginary quaternion components at offA and offB.
    // Used when reflecting through an axis: the other two imaginaries are negated, W is unchanged.
    private static floatQuat NegateQuatComponents(floatQuat r, int offA, int offB) =>
        new floatQuat(
            offA == OffX || offB == OffX ? -r.X : r.X,
            offA == OffY || offB == OffY ? -r.Y : r.Y,
            offA == OffZ || offB == OffZ ? -r.Z : r.Z,
            r.W
        );

    // Negates the 6 float4x4 elements at the given byte offsets (row + column of the flipped axis,
    // excluding the diagonal which is double-negated back to positive).
    private static unsafe float4x4 NegateMatrixElements(float4x4 m, ReadOnlySpan<int> byteOffsets)
    {
        var mPtr = (byte*)&m;
        foreach (var off in byteOffsets)
            *(float*)(mPtr + off) = -*(float*)(mPtr + off);
        return m;
    }

    private static void NegateMatrixElementsArray(ReadOnlySpan<byte> buffer, ReadOnlySpan<int> byteOffsets)
    {
        foreach (var off in byteOffsets)
            NegateComponent(buffer, StrideMatrix, off);
    }

    // Shared implementation for SwapXYAxes / SwapXZAxes / SwapYZAxes.
    //   vecOffA / vecOffB  — byte offsets of the two vector components to swap (OffX/OffY/OffZ)
    //   matSwapPairs       — interleaved pairs of matrix byte offsets to swap:
    //                        elements at index 2i and 2i+1 form one swap pair.
    //                        Encodes P*mat*P for the corresponding axis permutation P.
    private static void SwapAxesImpl(GltfLoader loader, int vecOffA, int vecOffB, ReadOnlySpan<int> matSwapPairs)
    {
        var gltf = loader.GltfJson;
        var processedAccessors = ArrayPool<bool>.Shared.Rent(gltf.Accessors.Length);
        Array.Clear(processedAccessors, 0, gltf.Accessors.Length);

        // Nodes: swap the relevant TRS translation components, rotate quaternion, permute matrix
        foreach (var node in gltf.Nodes)
        {
            node.Translation = SwapFloat3Components(node.Translation, vecOffA, vecOffB);
            node.Rotation = SwapQuatComponentsNegateW(node.Rotation, vecOffA, vecOffB);
            node.Matrix = SwapMatrixElements(node.Matrix, matSwapPairs);
        }

        // Mesh accessor data: positions, normals, tangents, index winding
        foreach (var mesh in gltf.Meshes)
        foreach (var prim in mesh.Primitives)
        {
            if (prim == null)
                continue;

            if (prim.Attributes.TryGetValue("POSITION", out var posIdx) && AddToSet(processedAccessors, posIdx))
                SwapComponents(loader.GetAccessorBufferSpan(posIdx), StrideFloat3, vecOffA, vecOffB);

            if (prim.Attributes.TryGetValue("NORMAL", out var normIdx) && AddToSet(processedAccessors, normIdx))
                SwapComponents(loader.GetAccessorBufferSpan(normIdx), StrideFloat3, vecOffA, vecOffB);

            if (prim.Attributes.TryGetValue("TANGENT", out var tangIdx) && AddToSet(processedAccessors, tangIdx))
            {
                // Swap the two axis components; negate handedness sign W because any axis swap
                // is a reflection (det = -1), which flips the tangent frame orientation
                SwapComponents(loader.GetAccessorBufferSpan(tangIdx), StrideFloat4, vecOffA, vecOffB);
                NegateComponent(loader.GetAccessorBufferSpan(tangIdx), StrideFloat4, OffW);
            }

            if (prim.Indices.HasValue && AddToSet(processedAccessors, prim.Indices.Value))
                FlipTriangleWinding(
                    loader.GetAccessorBufferSpan(prim.Indices.Value),
                    gltf.Accessors[prim.Indices.Value].ComponentType
                );
        }

        // Skin inverse bind matrices
        if (gltf.Skins != null)
            foreach (var skin in gltf.Skins)
                if (skin.InverseBindMatrices.HasValue && AddToSet(processedAccessors, skin.InverseBindMatrices.Value))
                    SwapMatrixElementsArray(loader.GetAccessorBufferSpan(skin.InverseBindMatrices.Value), matSwapPairs);

        // Animation translation and rotation tracks
        if (gltf.Animations != null)
            foreach (var anim in gltf.Animations)
            foreach (var channel in anim.Channels)
            {
                if (channel.Target.Node == null)
                    continue;
                var sampler = anim.Samplers[channel.Sampler];
                if (
                    channel.Target.Path == AnimationChannelTarget.PathEnum.Translation
                    && AddToSet(processedAccessors, sampler.Output)
                )
                    SwapComponents(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat3, vecOffA, vecOffB);
                else if (
                    channel.Target.Path == AnimationChannelTarget.PathEnum.Rotation
                    && AddToSet(processedAccessors, sampler.Output)
                )
                {
                    // GLTF stores quaternions as float4(X, Y, Z, W): swap the two imaginary
                    // components and negate W (same reflection logic as the tangent handedness)
                    SwapComponents(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat4, vecOffA, vecOffB);
                    NegateComponent(loader.GetAccessorBufferSpan(sampler.Output), StrideFloat4, OffW);
                }
            }

        ArrayPool<bool>.Shared.Return(processedAccessors);
    }

    // Swaps the two float3 components at the given byte offsets (OffX / OffY / OffZ).
    private static float3 SwapFloat3Components(float3 v, int offA, int offB) =>
        (offA, offB) switch
        {
            (OffX, OffY) or (OffY, OffX) => new float3(v.Y, v.X, v.Z),
            (OffX, OffZ) or (OffZ, OffX) => new float3(v.Z, v.Y, v.X),
            _ => new float3(v.X, v.Z, v.Y), // Y↔Z
        };

    // Swaps two imaginary quaternion components at offA / offB and negates W.
    // Used for axis swaps: any swap of two axes is a reflection (det = -1), which requires
    // swapping the corresponding imaginary parts and reversing the rotation sense via -W.
    private static floatQuat SwapQuatComponentsNegateW(floatQuat r, int offA, int offB) =>
        (offA, offB) switch
        {
            (OffX, OffY) or (OffY, OffX) => new floatQuat(r.Y, r.X, r.Z, -r.W),
            (OffX, OffZ) or (OffZ, OffX) => new floatQuat(r.Z, r.Y, r.X, -r.W),
            _ => new floatQuat(r.X, r.Z, r.Y, -r.W), // Y↔Z
        };

    // Swaps float4x4 element pairs at the given interleaved byte offsets (pair i = [2i], [2i+1]).
    // Encodes the P*mat*P permutation for whichever axis pair is being swapped.
    private static unsafe float4x4 SwapMatrixElements(float4x4 m, ReadOnlySpan<int> swapPairs)
    {
        var mPtr = (byte*)&m;
        for (var i = 0; i < swapPairs.Length; i += 2)
        {
            var a = (float*)(mPtr + swapPairs[i]);
            var b = (float*)(mPtr + swapPairs[i + 1]);
            (*a, *b) = (*b, *a);
        }
        return m;
    }

    private static void SwapMatrixElementsArray(ReadOnlySpan<byte> buffer, ReadOnlySpan<int> swapPairs)
    {
        for (var i = 0; i < swapPairs.Length; i += 2)
            SwapComponents(buffer, StrideMatrix, swapPairs[i], swapPairs[i + 1]);
    }

    /// <summary>Reverse triangle winding by swapping the second and third index of every triple.</summary>
    private static unsafe void FlipTriangleWinding(ReadOnlySpan<byte> buffer, Accessor.ComponentTypeEnum componentType)
    {
        fixed (byte* ptr = &MemoryMarshal.GetReference(buffer))
        {
            switch (componentType)
            {
                case Accessor.ComponentTypeEnum.UnsignedInt:
                {
                    var span = new Span<uint>(ptr, buffer.Length / sizeof(uint));
                    for (var i = 0; i + 2 < span.Length; i += 3)
                        (span[i + 1], span[i + 2]) = (span[i + 2], span[i + 1]);
                    break;
                }
                case Accessor.ComponentTypeEnum.UnsignedShort:
                {
                    var span = new Span<ushort>(ptr, buffer.Length / sizeof(ushort));
                    for (var i = 0; i + 2 < span.Length; i += 3)
                        (span[i + 1], span[i + 2]) = (span[i + 2], span[i + 1]);
                    break;
                }
                case Accessor.ComponentTypeEnum.UnsignedByte:
                {
                    var span = new Span<byte>(ptr, buffer.Length);
                    for (var i = 0; i + 2 < span.Length; i += 3)
                        (span[i + 1], span[i + 2]) = (span[i + 2], span[i + 1]);
                    break;
                }
            }
        }
    }

    private static bool AddToSet(Span<bool> set, int index)
    {
        if (set[index])
            return false;
        set[index] = true;
        return true;
    }

    #endregion
}
