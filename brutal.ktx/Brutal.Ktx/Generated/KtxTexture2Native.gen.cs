#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public unsafe partial struct KtxTexture2Native
    {
        [FieldOffset(0)]
        public readonly ClassId ClassId;

        [FieldOffset(24)]
        public readonly KtxTextureProtected* Protected;

        [FieldOffset(32)]
        public readonly Bool8 IsArray;

        [FieldOffset(33)]
        public readonly Bool8 IsCubemap;

        [FieldOffset(34)]
        public readonly Bool8 IsCompressed;

        [FieldOffset(35)]
        public readonly Bool8 GenerateMipmaps;

        [FieldOffset(36)]
        public readonly uint BaseWidth;

        [FieldOffset(40)]
        public readonly uint BaseHeight;

        [FieldOffset(44)]
        public readonly uint BaseDepth;

        [FieldOffset(48)]
        public readonly uint NumDimensions;

        [FieldOffset(52)]
        public readonly uint NumLevels;

        [FieldOffset(56)]
        public readonly uint NumLayers;

        [FieldOffset(60)]
        public readonly uint NumFaces;

        [FieldOffset(64)]
        public readonly Orientation Orientation;

        [FieldOffset(104)]
        public readonly ulong DataSize;

        [FieldOffset(112)]
        public readonly byte* PData;

        [FieldOffset(120)]
        public readonly uint VkFormat;

        [FieldOffset(128)]
        public readonly uint* PDfd;

        [FieldOffset(136)]
        public readonly KtxSupercmpScheme SupercompressionScheme;

        [FieldOffset(140)]
        public readonly Bool8 IsVideo;

        [FieldOffset(144)]
        public readonly uint Duration;

        [FieldOffset(148)]
        public readonly uint Timescale;

        [FieldOffset(152)]
        public readonly uint Loopcount;
    }
}
#pragma warning restore 1591
