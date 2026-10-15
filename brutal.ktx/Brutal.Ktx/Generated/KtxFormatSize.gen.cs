#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public unsafe partial struct KtxFormatSize
    {
        [FieldOffset(0)]
        public readonly uint Flags;

        /// <summary>For KTX1.</summary>
        [FieldOffset(4)]
        public readonly uint PaletteSizeInBits;

        [FieldOffset(8)]
        public readonly uint BlockSizeInBits;

        /// <summary>in texels</summary>
        [FieldOffset(12)]
        public readonly uint BlockWidth;

        /// <summary>in texels</summary>
        [FieldOffset(16)]
        public readonly uint BlockHeight;

        /// <summary>in texels</summary>
        [FieldOffset(20)]
        public readonly uint BlockDepth;

        /// <summary>Minimum required number of blocks</summary>
        [FieldOffset(24)]
        public readonly uint MinBlocksX;

        [FieldOffset(28)]
        public readonly uint MinBlocksY;
    }
}
#pragma warning restore 1591
