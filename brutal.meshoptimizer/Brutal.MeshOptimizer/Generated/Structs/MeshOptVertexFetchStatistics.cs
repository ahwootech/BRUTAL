using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct MeshOptVertexFetchStatistics
    {
        [FieldOffset(0)]
        public int BytesFetched;

        /// fetched bytes / vertex buffer size; best case 1.0 (each byte is fetched once)
        [FieldOffset(4)]
        public float Overfetch;
    }
}
