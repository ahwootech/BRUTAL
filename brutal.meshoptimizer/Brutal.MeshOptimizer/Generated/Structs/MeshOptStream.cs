using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct MeshOptStream
    {
        [FieldOffset(0)]
        public Ptr Data;

        [FieldOffset(8)]
        public ByteSize64 Size;

        [FieldOffset(16)]
        public ByteSize64 Stride;
    }
}
