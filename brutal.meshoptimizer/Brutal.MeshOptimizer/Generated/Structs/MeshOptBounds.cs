using Brutal.Interop;
using Brutal.Numerics;
using Brutal.Pointers;

namespace Brutal.MeshOptimizer
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct MeshOptBounds
    {
        /// bounding sphere, useful for frustum and occlusion culling
        [FieldOffset(0)]
        public float3 Center;

        [FieldOffset(12)]
        public float Radius;

        /// normal cone, useful for backface culling
        [FieldOffset(16)]
        public float3 ConeApex;

        [FieldOffset(28)]
        public float3 ConeAxis;

        /// = cos(angle/2)
        [FieldOffset(40)]
        public float ConeCutoff;

        /// normal cone axis and cutoff, stored in 8-bit SNORM format; decode using x/127.0
        [FieldOffset(44)]
        public byte3 ConeAxisS8;

        [FieldOffset(47)]
        public byte ConeCutoffS8;
    }
}
