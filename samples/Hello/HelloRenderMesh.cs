/*
 * HelloRenderMesh
 *
 * Generates a procedural sphere mesh and prints its vertex and triangle counts.
 */

#:package Ahwoo.Brutal.Render.Mesh@2026.10.2
#:package Ahwoo.Brutal.Collections@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Numerics@2026.10.2

using Brutal;
using Brutal.Collections;
using Brutal.Numerics;
using Brutal.Render.Mesh;

Run();

static void Run()
{
    using var positions = new NativeStrideList(ByteSize.Of<float3>(), 0);
    using var normals = new NativeStrideList(ByteSize.Of<float3>(), 0);
    using var indices = new NativeStrideList(ByteSize.Of<int>(), 0);

    var sphere = new ProcGenMesh(positions, indices, normals);
    ProcGenMeshLibrary.GenerateSphere(sphere, origin: float3.Zero, radius: 1.0f, resolution: 16);

    Console.WriteLine($"Generated a sphere with {sphere.VertexCount} vertices and {sphere.IndexCount / 3} triangles");
}
