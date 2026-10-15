#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public unsafe partial struct KtxBasisParams
    {
        [FieldOffset(0)]
        public uint StructSize;

        [FieldOffset(4)]
        public Bool8 Uastc;

        [FieldOffset(5)]
        public Bool8 Verbose;

        [FieldOffset(6)]
        public Bool8 NoSse;

        [FieldOffset(8)]
        public uint ThreadCount;

        /// <summary>ETC1S params</summary>
        [FieldOffset(12)]
        public uint CompressionLevel;

        [FieldOffset(16)]
        public uint QualityLevel;

        [FieldOffset(20)]
        public uint MaxEndpoints;

        [FieldOffset(24)]
        public float EndpointRdoThreshold;

        [FieldOffset(28)]
        public uint MaxSelectors;

        [FieldOffset(32)]
        public float SelectorRdoThreshold;

        [FieldOffset(36)]
        public unsafe fixed byte InputSwizzle[4];

        [FieldOffset(40)]
        public Bool8 NormalMap;

        [FieldOffset(41)]
        public Bool8 SeparateRgtORgbA;

        [FieldOffset(42)]
        public Bool8 PreSwizzle;

        [FieldOffset(43)]
        public Bool8 NoEndpointRdo;

        [FieldOffset(44)]
        public Bool8 NoSelectorRdo;

        /// <summary>UASTC params</summary>
        [FieldOffset(48)]
        public KtxPackUastcFlagBits UastcFlags;

        [FieldOffset(52)]
        public Bool8 UastcRdo;

        [FieldOffset(56)]
        public float UastcRdoQualityScalar;

        [FieldOffset(60)]
        public uint UastcRdoDictSize;

        [FieldOffset(64)]
        public float UastcRdoMaxSmoothBlockErrorScale;

        [FieldOffset(68)]
        public float UastcRdoMaxSmoothBlockStdDev;

        [FieldOffset(72)]
        public Bool8 UastcRdoDontFavorSimplerModes;

        [FieldOffset(73)]
        public Bool8 UastcRdoNoMultithreading;
    }
}
#pragma warning restore 1591
