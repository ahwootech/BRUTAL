#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public unsafe partial struct KtxTextureNative
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
    }
}
#pragma warning restore 1591
