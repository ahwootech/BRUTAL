#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public unsafe partial struct KtxAstcParams
    {
        [FieldOffset(0)]
        public uint StructSize;

        [FieldOffset(4)]
        public Bool8 Verbose;

        [FieldOffset(8)]
        public uint ThreadCount;

        /// <summary>astcenc params</summary>
        [FieldOffset(12)]
        public uint BlockDimension;

        [FieldOffset(16)]
        public uint Mode;

        [FieldOffset(20)]
        public uint QualityLevel;

        [FieldOffset(24)]
        public Bool8 NormalMap;

        [FieldOffset(25)]
        public Bool8 Perceptual;

        [FieldOffset(26)]
        public unsafe fixed byte InputSwizzle[4];
    }
}
#pragma warning restore 1591
