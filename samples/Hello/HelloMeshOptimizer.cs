/*
 * HelloMeshOptimizer
 *
 * Shuffles a grid mesh's triangles, reorders them with meshoptimizer and compares cache efficiency.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.MeshOptimizer@2026.10.2
#:package Ahwoo.Brutal.Core@2026.10.4

using Brutal.MeshOptimizer;

const int GRID_SIZE = 32;
const int VERTEX_COUNT = (GRID_SIZE + 1) * (GRID_SIZE + 1);

// Build a grid of triangles, then shuffle them to make a cache-unfriendly index buffer.
var triangles = new List<int[]>();
for (var y = 0; y < GRID_SIZE; y++)
for (var x = 0; x < GRID_SIZE; x++)
{
    var i = y * (GRID_SIZE + 1) + x;
    triangles.Add([i, i + 1, i + GRID_SIZE + 1]);
    triangles.Add([i + 1, i + GRID_SIZE + 2, i + GRID_SIZE + 1]);
}

var indices = triangles.OrderBy(_ => Random.Shared.Next()).SelectMany(t => t).ToArray();

unsafe
{
    fixed (int* p = indices)
    {
        // AnalyzeVertexCache arguments: cache size 16, warp size 0, primitive group size 0.
        var before = MeshOptimizer.AnalyzeVertexCache(p, indices.Length, VERTEX_COUNT, 16, 0, 0);
        MeshOptimizer.OptimizeVertexCache(p, p, indices.Length, VERTEX_COUNT);
        var after = MeshOptimizer.AnalyzeVertexCache(p, indices.Length, VERTEX_COUNT, 16, 0, 0);

        Console.WriteLine($"{indices.Length / 3} triangles, {VERTEX_COUNT} vertices");
        Console.WriteLine($"ACMR (vertex transforms per triangle): {before.Acmr:F2} -> {after.Acmr:F2}");
    }
}
