#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KtxTranscodeFmt : int
    {
        /// <summary>ETC1-2</summary>
        Etc1Rgb = 0,
        Etc2Rgba = 1,

        /// <summary>BC1-5, BC7 (desktop, some mobile devices)</summary>
        Bc1Rgb = 2,
        Bc3Rgba = 3,
        Bc4R = 4,
        Bc5Rg = 5,
        Bc7Rgba = 6,

        /// <summary>PVRTC1 4bpp (mobile, PowerVR devices)</summary>
        Pvrtc14Rgb = 8,
        Pvrtc14Rgba = 9,

        /// <summary>ASTC (mobile, Intel devices, hopefully all desktop GPU's one day)</summary>
        Astc4X4Rgba = 10,

        /// <summary>ATC and FXT1 formats are not supported by KTX2 as thereare no equivalent VkFormats.</summary>
        Pvrtc24Rgb = 18,
        Pvrtc24Rgba = 19,
        Etc2EacR11 = 20,
        Etc2EacRg11 = 21,

        /// <summary>Uncompressed (raw pixel) formats</summary>
        Rgba32 = 13,
        Rgb565 = 14,
        Bgr565 = 15,
        Rgba4444 = 16,

        /// <summary>Values for automatic selection of RGB or RGBA depending if alphapresent.</summary>
        Etc = 22,
        Bc1Or3 = 23,
        Noselection = 2147483647,

        /// <summary>Old enums for compatibility with code compiled against previousversions of libktx.</summary>
        Etc1 = 0,
        Etc2 = 22,
        Bc1 = 2,
        Bc3 = 3,
        Bc4 = 4,
        Bc5 = 5,
        Bc7M6Rgb = 6,
        Bc7M5Rgba = 6,
        Bc7M6OpaqueOnly = 6,
        Pvrtc14OpaqueOnly = 8,
    }
}
#pragma warning restore 1591
