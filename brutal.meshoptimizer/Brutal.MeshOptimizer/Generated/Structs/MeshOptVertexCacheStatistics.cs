using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct MeshOptVertexCacheStatistics
    {
        [FieldOffset(0)]
        public int VerticesTransformed;

        [FieldOffset(4)]
        public int WarpsExecuted;

        /// transformed vertices / triangle count; best case 0.5, worst case 3.0, optimum depends on topology
        [FieldOffset(8)]
        public float Acmr;

        /// transformed vertices / vertex count; best case 1.0, worst case 6.0, optimum is 1.0 (each vertex is transformed once)
        [FieldOffset(12)]
        public float Atvr;
    }
}
