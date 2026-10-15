using System.Runtime.CompilerServices;
using Brutal.Numerics;

namespace Brutal.Render.Mesh;

/// <summary>
/// Contains functions for generating procedural geometry for standard primitive shapes
/// </summary>
public static partial class ProcGenMeshLibrary
{
    /// <summary>
    /// Get right and up directions for a plane
    /// </summary>
    /// <param name="normal">Normal of plane</param>
    /// <param name="right">Outputs right direction</param>
    /// <param name="up">Outputs up direction</param>
    private static void GetRightUp(float3 normal, out float3 right, out float3 up)
    {
        right = float3.Cross(normal, GlobalUp);
        var dot = float3.Dot(normal, GlobalUp);
        if (MathF.Abs(dot) > 0.9999f)
            right = GlobalRight * MathF.Sign(dot);
        up = float3.Cross(right, normal);
    }

    /// <summary>
    /// Generate a plane mesh with the given origin, right, up, size and grid resolution
    /// </summary>
    /// <param name="output">Output mesh</param>
    /// <param name="origin">Plane origin</param>
    /// <param name="right">Plane right direction</param>
    /// <param name="up">Plane up direction</param>
    /// <param name="size">Size of plane</param>
    /// <param name="resolution">Resolution of grid on plane</param>
    public static unsafe void GeneratePlane(
        in ProcGenMesh output,
        float3 origin,
        float3 right,
        float3 up,
        float size,
        int resolution
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;

        GenerateGridTopology(output, resolution, resolution);

        var vPtr = vertices.Ptr.Cast<float3>().Offset(vStart);
        var vCount = vertices.Count - vStart;
        origin -= right * size / 2 + up * size / 2;
        for (var i = 0; i < vCount; ++i)
        {
            var uv = vPtr[i];
            vPtr[i] = origin + right * uv.X * size + up * uv.Y * size;
        }

        if (output.OutNormals != null)
        {
            var forward = float3.Normalize(float3.Cross(up, right));
            AppendFlatValue(output.OutNormals, forward, vCount);
        }
    }

    /// <summary>
    /// Generate a plane mesh with the given origin, normal, size and grid resolution
    /// </summary>
    /// <param name="output"></param>
    /// <param name="origin"></param>
    /// <param name="normal"></param>
    /// <param name="size"></param>
    /// <param name="resolution"></param>
    public static void GeneratePlane(in ProcGenMesh output, float3 origin, float3 normal, float size, int resolution)
    {
        GetRightUp(normal, out var right, out var up);
        GeneratePlane(in output, origin, right, up, size, resolution);
    }

    /// <summary>
    /// Generate a cube mesh with the given origin, size and grid resolution
    /// </summary>
    /// <param name="output"></param>
    /// <param name="origin"></param>
    /// <param name="size"></param>
    /// <param name="resolution"></param>
    public static void GenerateCube(in ProcGenMesh output, float3 origin, float size, int resolution)
    {
        //Use GeneratePlane to generate the 6 faces of the cube
        GeneratePlane(in output, origin + new float3(0, 0, size / 2), float3.UnitZ, size, resolution);
        GeneratePlane(in output, origin + new float3(0, 0, -size / 2), -float3.UnitZ, size, resolution);
        GeneratePlane(in output, origin + new float3(size / 2, 0, 0), float3.UnitX, size, resolution);
        GeneratePlane(in output, origin + new float3(-size / 2, 0, 0), -float3.UnitX, size, resolution);
        GeneratePlane(in output, origin + new float3(0, size / 2, 0), float3.UnitY, size, resolution);
        GeneratePlane(in output, origin + new float3(0, -size / 2, 0), -float3.UnitY, size, resolution);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float2 CartesianToSphere(in float3 cartesian)
    {
        var latitude = MathF.Asin(cartesian.Y);
        var longitude = MathF.Atan2(cartesian.X, cartesian.Z);
        return new float2(latitude, longitude);
    }

    /// <summary>
    /// Normalised spherical coordinates to cartesian coordinates
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float3 SphereToCartesian(in float latitude, in float longitude)
    {
        var a = float.Cos(longitude);
        var x = a * float.Cos(latitude);
        var y = float.Sin(longitude);
        var z = a * float.Sin(latitude);
        return new float3(x, y, z);
    }

    /// <summary>
    ///  Cartesian coordinates from toroidal coordinates
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radiusA"></param>
    ///  <param name="radiusB"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float3 ToroidialToCartesian(
        in float latitude,
        in float longitude,
        float radiusA = 1.0f,
        float radiusB = 0.5f
    )
    {
        var a = radiusA + radiusB * MathF.Cos(latitude);
        var x = a * MathF.Cos(longitude);
        var y = radiusB * MathF.Sin(latitude);
        var z = a * MathF.Sin(longitude);
        return new float3(x, y, z);
    }

    /// <summary>
    /// Generates grid topology for a mesh, which can be transformed into a conic shape or plane
    /// </summary>
    /// <param name="output"></param>
    /// <param name="resolutionX">Number of vertices on X axis</param>
    /// <param name="resolutionY">Number of vertices on Y axis</param>
    public static unsafe void GenerateGridTopology(in ProcGenMesh output, int resolutionX, int resolutionY)
    {
        var vStart = output.VertexCount;
        if (output.OutIndices == null)
        {
            var stepX = 1.0f / resolutionX;
            var stepY = 1.0f / resolutionY;

            int vCount = resolutionX * resolutionY * 6;

            var vertices = output.OutPositions;
            var vPtr = AllocateAtEnd<float3>(vertices, vCount);
            var vIndex = 0;
            for (var y = 0; y < resolutionY; ++y)
            {
                for (var x = 0; x < resolutionX; ++x)
                {
                    var x0 = x * stepX;
                    var y0 = y * stepY;
                    var x1 = (x + 1) * stepX;
                    var y1 = (y + 1) * stepY;

                    var p0 = new float3(x0, y0, 0);
                    var p1 = new float3(x1, y0, 0);
                    var p2 = new float3(x1, y1, 0);
                    var p3 = new float3(x0, y1, 0);

                    vPtr[vIndex++] = p0;
                    vPtr[vIndex++] = p1;
                    vPtr[vIndex++] = p2;

                    vPtr[vIndex++] = p0;
                    vPtr[vIndex++] = p2;
                    vPtr[vIndex++] = p3;
                }
            }
            //UVs can be generated from this topology directly
            if (output.OutUVs != null)
            {
                var uvs = output.OutUVs;
                var uvPtr = AllocateAtEnd<float2>(uvs, vCount);
                vIndex = 0;
                for (var i = 0; i < vCount; ++i)
                {
                    uvPtr[vIndex++] = vPtr[i].XY;
                }
            }
        }
        else
        {
            var stepX = 1.0f / resolutionX;
            var stepY = 1.0f / resolutionY;
            // Vertex resolution is one more than the grid resolution
            var total = (resolutionX + 1) * (resolutionY + 1);
            var vertices = output.OutPositions;
            var vPtr = AllocateAtEnd<float3>(vertices, total);
            var vIndex = 0;
            for (var y = 0; y <= resolutionY; ++y)
            {
                for (var x = 0; x <= resolutionX; ++x)
                {
                    var x0 = x * stepX;
                    var y0 = y * stepY;
                    vPtr[vIndex++] = new float3(x0, y0, 0);
                }
            }
            //UVs can be generated from this topology directly
            if (output.OutUVs != null)
            {
                var uvs = output.OutUVs;
                var uvPtr = AllocateAtEnd<float2>(uvs, total);
                vIndex = 0;
                for (var i = 0; i < total; ++i)
                {
                    uvPtr[vIndex++] = vPtr[i].XY;
                }
            }
            AddGridIndices(output.OutIndices, vStart, resolutionX, resolutionY);
        }
    }

    /// <summary>
    /// Generate a sphere mesh with the given origin, radius and resolution
    /// </summary>
    /// <param name="output">Mesh to output to</param>
    /// <param name="origin">Sphere origin</param>
    /// <param name="radius">Sphere radius</param>
    /// <param name="resolutionA">Resolution of sphere (longitude)</param>
    /// <param name="resolutionB">Resolution of sphere (latitude)</param>
    public static unsafe void GenerateSphere(
        in ProcGenMesh output,
        float3 origin,
        float radius,
        int resolutionA,
        int resolutionB
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;

        var resOffset = new float2(0, -float.Pi / 2);
        // Normalize the scale to match spherical coordinates
        var resScale = new float2(float.Tau, float.Pi);

        GenerateGridTopology(in output, resolutionA, resolutionB);

        var vPtr = vertices.Ptr.Cast<float3>().Offset(vStart);
        ;
        var vCount = vertices.Count - vStart;
        for (var i = 0; i < vCount; ++i)
        {
            var uv = vPtr[i];
            vPtr[i] =
                SphereToCartesian(uv.X * resScale.X + resOffset.X, uv.Y * resScale.Y + resOffset.Y) * radius + origin;
        }

        if (output.OutNormals != null)
        {
            var normals = output.OutNormals;

            var nPtr = AllocateAtEnd<float3>(normals, vCount);
            var vIndex = 0;
            for (var i = 0; i < vCount; ++i)
            {
                nPtr[vIndex++] = float3.Normalize(vPtr[i] - origin);
            }
        }
    }

    public static void GenerateSphere(in ProcGenMesh output, float3 origin, float radius, int resolution)
    {
        GenerateSphere(output, origin, radius, resolution, resolution / 2);
    }

    /// <summary>
    /// Generate a torus mesh with the given origin, radius and resolution
    /// </summary>
    /// <param name="output">Mesh to output to</param>
    /// <param name="origin">Torus origin</param>
    /// <param name="radiusA">Torus main radius</param>
    /// <param name="radiusB">Torus secondary radius</param>
    /// <param name="resolutionA">Resolution of torus (primary)</param>
    /// <param name="resolutionB">Resolution of torus (secondary)</param>
    public static unsafe void GenerateTorus(
        in ProcGenMesh output,
        float3 origin,
        float radiusA,
        float radiusB,
        int resolutionA,
        int resolutionB
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;

        var resOffset = new float2(0, 0);
        // Normalize the scale to match spherical coordinates
        var resScale = new float2(float.Tau, -float.Tau);

        GenerateGridTopology(in output, resolutionA, resolutionB);

        var vPtr = vertices.Ptr.Cast<float3>().Offset(vStart);
        var vCount = vertices.Count - vStart;
        for (var i = 0; i < vCount; ++i)
        {
            var uv = vPtr[i];
            vPtr[i] =
                ToroidialToCartesian(uv.X * resScale.X + resOffset.X, uv.Y * resScale.Y + resOffset.Y, radiusA, radiusB)
                + origin;
        }

        if (output.OutNormals != null)
        {
            var normals = output.OutNormals;

            var nPtr = AllocateAtEnd<float3>(normals, vCount);
            var vIndex = 0;
            for (var i = 0; i < vCount; ++i)
            {
                var uv = vPtr[i];
                var normal = float3.Normalize(uv - origin);
                nPtr[vIndex++] = normal;
            }
        }
    }

    /// <summary>
    /// Generate a circle/disk mesh with the given origin, axis, radius and resolution
    /// </summary>
    /// <param name="output">Output mesh object</param>
    /// <param name="origin">Origin of disk</param>
    /// <param name="axis">Axis/normal of disk</param>
    /// <param name="radius">Radius of disk</param>
    /// <param name="resolution">Resolution of disk</param>
    /// <param name="flip">If true, reverse disk direction</param>
    public static unsafe void GenerateDisk(
        in ProcGenMesh output,
        float3 origin,
        float3 axis,
        float radius,
        int resolution,
        bool flip = false
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;
        GetRightUp(axis, out var right, out var up);
        var step = MathF.Tau / resolution;

        var vPtr = AllocateAtEnd<float3>(vertices, resolution * 3);
        var vIndex = 0;

        for (var i = 0; i < resolution; ++i)
        {
            var angle0 = i * step;
            var angle1 = (i + 1) * step;

            var p0 = origin + right * MathF.Cos(angle0) * radius + up * MathF.Sin(angle0) * radius;
            var p1 = origin + right * MathF.Cos(angle1) * radius + up * MathF.Sin(angle1) * radius;
            var p2 = origin;

            if (flip)
            {
                vPtr[vIndex++] = p0;
                vPtr[vIndex++] = p2;
                vPtr[vIndex++] = p1;
            }
            else
            {
                vPtr[vIndex++] = p0;
                vPtr[vIndex++] = p1;
                vPtr[vIndex++] = p2;
            }
        }

        if (output.OutUVs != null)
        {
            var uvs = output.OutUVs;
            uvs.EnsureCapacity(uvs.Count + resolution * 3);
            var uvPtr = AllocateAtEnd<float2>(uvs, resolution * 3);
            vIndex = 0;

            var uvOrigin = new float2(0.5f, 0.5f);
            for (var i = 0; i < resolution; ++i)
            {
                var angle0 = i * step;
                var angle1 = (i + 1) * step;

                uvPtr[vIndex++] = uvOrigin + new float2(MathF.Cos(angle0), MathF.Sin(angle0)) * 0.5f;
                uvPtr[vIndex++] = uvOrigin + new float2(MathF.Cos(angle1), MathF.Sin(angle1)) * 0.5f;
                uvPtr[vIndex++] = uvOrigin;
            }
        }

        if (output.OutNormals != null)
            AppendFlatValue(output.OutNormals, axis, resolution * 3);

        AddOrderedIndices(output.OutIndices, vStart, resolution * 3);
    }

    /// <summary>
    /// Generate a cone mesh with the given origin, axis, radius, height and resolution
    /// </summary>
    /// <param name="output">Output mesh</param>
    /// <param name="origin">Cone origin</param>
    /// <param name="axis">Cone axis</param>
    /// <param name="radius">Cone radius</param>
    /// <param name="height">Cone height</param>
    /// <param name="resolution">Resolution of output mesh</param>
    /// <param name="addCap">If true, will add a disk to cap cone</param>
    public static unsafe void GenerateCone(
        in ProcGenMesh output,
        float3 origin,
        float3 axis,
        float radius,
        float height,
        int resolution,
        bool addCap = true
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;
        var vPtr = AllocateAtEnd<float3>(vertices, resolution * 3);
        var vIndex = 0;

        GetRightUp(axis, out var right, out var up);
        var step = MathF.Tau / resolution;
        for (var i = 0; i < resolution; ++i)
        {
            var angle0 = i * step;
            var angle1 = (i + 1) * step;

            var p0 = origin + right * MathF.Cos(angle0) * radius + up * MathF.Sin(angle0) * radius;
            var p1 = origin + right * MathF.Cos(angle1) * radius + up * MathF.Sin(angle1) * radius;
            var p2 = origin + axis * height;

            vPtr[vIndex++] = p0;
            vPtr[vIndex++] = p1;
            vPtr[vIndex++] = p2;
        }

        if (output.OutUVs != null)
        {
            var uvs = output.OutUVs;
            var uvPtr = AllocateAtEnd<float2>(uvs, resolution * 3);
            vIndex = 0;

            var invRes = 1.0f / resolution;
            for (var i = 0; i < resolution; ++i)
            {
                var u0 = i * invRes;
                var u1 = (i + 1) * invRes;

                uvPtr[vIndex++] = new float2(u0, 0);
                uvPtr[vIndex++] = new float2(u1, 0);
                uvPtr[vIndex++] = new float2(0.5f, 1);
            }
        }

        if (output.OutNormals != null)
        {
            var normals = output.OutNormals;
            var nPtr = AllocateAtEnd<float3>(normals, resolution * 3);
            vIndex = 0;
            var dir = float2.Normalize(new float2(radius, height));
            var scaleXY = dir.Y;
            var scaledAxis = axis * dir.X;
            var prevNormal = (right * MathF.Cos(0) + up * MathF.Sin(0)) * scaleXY + scaledAxis;
            for (var i = 1; i <= resolution; ++i)
            {
                var angle = i * step;
                var normal = (right * MathF.Cos(angle) + up * MathF.Sin(angle)) * scaleXY + scaledAxis;

                nPtr[vIndex++] = prevNormal;
                nPtr[vIndex++] = normal;
                nPtr[vIndex++] = (prevNormal + normal) * 0.5f;

                prevNormal = normal;
            }
        }

        AddOrderedIndices(output.OutIndices, vStart, resolution * 3);

        if (addCap)
        {
            GenerateDisk(in output, origin, -axis, radius, resolution, false);
        }
    }

    /// <summary>
    /// Generate a cylinder mesh with the given origin, axis, radius, height and resolution
    /// </summary>
    /// <param name="output">Output mesh object</param>
    /// <param name="origin">Origin to place mesh</param>
    /// <param name="axis">Axis of shape</param>
    /// <param name="radius">Radius of shape</param>
    /// <param name="height">Height of shape</param>
    /// <param name="resolution">Resolution of output mesh</param>
    /// <param name="addCaps">If true, will add disks on both ends of cylinder</param>
    public static unsafe void GenerateCylinder(
        in ProcGenMesh output,
        float3 origin,
        float3 axis,
        float radius,
        float height,
        int resolution,
        bool addCaps = true
    )
    {
        var vertices = output.OutPositions;
        var vStart = vertices.Count;

        GenerateGridTopology(in output, resolution, 2);

        const float scale = float.Tau;
        GetRightUp(axis, out var right, out var up);

        var vPtr = vertices.Ptr.Cast<float3>().Offset(vStart);
        var vCount = vertices.Count - vStart;

        if (output.OutNormals != null)
        {
            // Generate normals and warp grid to cylinder
            var normals = output.OutNormals;
            var nPtr = AllocateAtEnd<float3>(normals, vCount);
            for (var i = 0; i < vCount; ++i)
            {
                var uv = vPtr[i];
                var angle = uv.X * scale;
                var heightOffset = uv.Y * height;
                var normal = right * MathF.Cos(angle) * radius + up * MathF.Sin(angle);
                nPtr[i] = normal;
                vPtr[i] = origin + normal * radius + axis * heightOffset;
            }
        }
        else
        {
            // Warp grid to cylinder
            for (var i = 0; i < vCount; ++i)
            {
                var uv = vPtr[i];
                var angle = uv.X * scale;
                var heightOffset = uv.Y * height;
                vPtr[i] =
                    origin + right * MathF.Cos(angle) * radius + up * MathF.Sin(angle) * radius + axis * heightOffset;
            }
        }

        if (addCaps)
        {
            GenerateDisk(in output, origin, -axis, radius, resolution, false);
            GenerateDisk(in output, origin + axis * height, axis, radius, resolution, false);
        }
    }
}
