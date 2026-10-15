using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct MeshOptMeshlet
    {
        /// offsets within meshlet_vertices and meshlet_triangles arrays with meshlet data
        [FieldOffset(0)]
        public int VertexOffset;

        [FieldOffset(4)]
        public int TriangleOffset;

        /// number of vertices and triangles used in the meshlet; data is stored in consecutive range [offset..offset+count) for vertices and [offset..offset+count*3) for triangles
        [FieldOffset(8)]
        public int VertexCount;

        [FieldOffset(12)]
        public int TriangleCount;
    }
}
