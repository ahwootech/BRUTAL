using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct MeshOptCoverageStatistics
    {
        [FieldOffset(0)]
        public float3 Coverage;

        /// viewport size in mesh coordinates
        [FieldOffset(12)]
        public float Extent;
    }
}
