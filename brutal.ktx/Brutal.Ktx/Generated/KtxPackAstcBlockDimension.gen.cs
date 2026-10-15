#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KtxPackAstcBlockDimension : int
    {
        /// <summary>: 8.00 bpp</summary>
        BlockDimension4X4,

        /// <summary>: 6.40 bpp</summary>
        BlockDimension5X4,

        /// <summary>: 5.12 bpp</summary>
        BlockDimension5X5,

        /// <summary>: 4.27 bpp</summary>
        BlockDimension6X5,

        /// <summary>: 3.56 bpp</summary>
        BlockDimension6X6,

        /// <summary>: 3.20 bpp</summary>
        BlockDimension8X5,

        /// <summary>: 2.67 bpp</summary>
        BlockDimension8X6,

        /// <summary>: 2.56 bpp</summary>
        BlockDimension10X5,

        /// <summary>: 2.13 bpp</summary>
        BlockDimension10X6,

        /// <summary>: 2.00 bpp</summary>
        BlockDimension8X8,

        /// <summary>: 1.60 bpp</summary>
        BlockDimension10X8,

        /// <summary>: 1.28 bpp</summary>
        BlockDimension10X10,

        /// <summary>: 1.07 bpp</summary>
        BlockDimension12X10,

        /// <summary>: 0.89 bpp</summary>
        BlockDimension12X12,

        /// <summary>: 4.74 bpp</summary>
        BlockDimension3X3X3,

        /// <summary>: 3.56 bpp</summary>
        BlockDimension4X3X3,

        /// <summary>: 2.67 bpp</summary>
        BlockDimension4X4X3,

        /// <summary>: 2.00 bpp</summary>
        BlockDimension4X4X4,

        /// <summary>: 1.60 bpp</summary>
        BlockDimension5X4X4,

        /// <summary>: 1.28 bpp</summary>
        BlockDimension5X5X4,

        /// <summary>: 1.02 bpp</summary>
        BlockDimension5X5X5,

        /// <summary>: 0.85 bpp</summary>
        BlockDimension6X5X5,

        /// <summary>: 0.71 bpp</summary>
        BlockDimension6X6X5,

        /// <summary>: 0.59 bpp</summary>
        BlockDimension6X6X6,
        BlockDimensionMax = 23,
    }
}
#pragma warning restore 1591
