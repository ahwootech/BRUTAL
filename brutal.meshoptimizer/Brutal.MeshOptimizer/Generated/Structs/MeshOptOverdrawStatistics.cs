using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public unsafe partial struct MeshOptOverdrawStatistics
    {
        [FieldOffset(0)]
        public int PixelsCovered;

        [FieldOffset(4)]
        public int PixelsShaded;

        /// shaded pixels / covered pixels; best case 1.0
        [FieldOffset(8)]
        public float Overdraw;
    }
}
