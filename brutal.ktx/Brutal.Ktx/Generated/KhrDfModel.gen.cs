#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KhrDfModel : int
    {
        /// <summary>No interpretation of color channels defined</summary>
        Unspecified = 0,

        /// <summary>Color primaries (red, green, blue) + alpha, depth and stencil</summary>
        Rgbsda = 1,

        /// <summary>Color differences (Y', Cb, Cr) + alpha, depth and stencil</summary>
        Yuvsda = 2,

        /// <summary>Color differences (Y', I, Q) + alpha, depth and stencil</summary>
        Yiqsda = 3,

        /// <summary>Perceptual color (CIE L*a*b*) + alpha, depth and stencil</summary>
        Labsda = 4,

        /// <summary>Subtractive colors (cyan, magenta, yellow, black) + alpha</summary>
        Cmyka = 5,

        /// <summary>Non-color coordinate data (X, Y, Z, W)</summary>
        Xyzw = 6,

        /// <summary>Hue, saturation, value, hue angle on color circle, plus alpha</summary>
        HsvaAng = 7,

        /// <summary>Hue, saturation, lightness, hue angle on color circle, plus alpha</summary>
        HslaAng = 8,

        /// <summary>Hue, saturation, value, hue on color hexagon, plus alpha</summary>
        HsvaHex = 9,

        /// <summary>Hue, saturation, lightness, hue on color hexagon, plus alpha</summary>
        HslaHex = 10,

        /// <summary>Lightweight approximate color difference (luma, orange, green)</summary>
        Ycgcoa = 11,

        /// <summary>ITU BT.2020 constant luminance YcCbcCrc</summary>
        Yccbccrc = 12,

        /// <summary>ITU BT.2100 constant intensity ICtCp</summary>
        Ictcp = 13,

        /// <summary>CIE 1931 XYZ color coordinates (X, Y, Z)</summary>
        Ciexyz = 14,

        /// <summary>CIE 1931 xyY color coordinates (X, Y, Y)</summary>
        Ciexyy = 15,

        /// <summary>Compressed formats start at 128.</summary>
        /// These compressed formats should generally have a single sample,sited at the 0,0 position of the texel block. Where multiplechannels are used to distinguish formats, these should be cosited.
        /// Direct3D (and S3) compressed formats
        /// Note that premultiplied status is recorded separately
        /// DXT1 "channels" are RGB (0), Alpha (1)
        /// DXT1/BC1 with one channel is opaque
        /// DXT1/BC1 with a cosited alpha sample is transparent
        Dxt1A = 128,

        /// <summary>Compressed formats start at 128.</summary>
        /// These compressed formats should generally have a single sample,sited at the 0,0 position of the texel block. Where multiplechannels are used to distinguish formats, these should be cosited.
        /// Direct3D (and S3) compressed formats
        /// Note that premultiplied status is recorded separately
        /// DXT1 "channels" are RGB (0), Alpha (1)
        /// DXT1/BC1 with one channel is opaque
        /// DXT1/BC1 with a cosited alpha sample is transparent
        Bc1A = 128,

        /// <summary>DXT2/DXT3/BC2, with explicit 4-bit alpha</summary>
        Dxt2 = 129,

        /// <summary>DXT2/DXT3/BC2, with explicit 4-bit alpha</summary>
        Dxt3 = 129,

        /// <summary>DXT2/DXT3/BC2, with explicit 4-bit alpha</summary>
        Bc2 = 129,

        /// <summary>DXT4/DXT5/BC3, with interpolated alpha</summary>
        Dxt4 = 130,

        /// <summary>DXT4/DXT5/BC3, with interpolated alpha</summary>
        Dxt5 = 130,

        /// <summary>DXT4/DXT5/BC3, with interpolated alpha</summary>
        Bc3 = 130,

        /// <summary>ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Ati1N = 131,

        /// <summary>ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Dxt5A = 131,

        /// <summary>ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Bc4 = 131,

        /// <summary>ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Ati2NXy = 132,

        /// <summary>ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Dxn = 132,

        /// <summary>ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data</summary>
        /// (The UNORM/SNORM variation is recorded in the channel data)
        Bc5 = 132,

        /// <summary>BC6H - DX11 format for 16-bit float channels</summary>
        Bc6H = 133,

        /// <summary>BC7 - DX11 format</summary>
        Bc7 = 134,

        /// <summary>Mobile compressed formats follow</summary>
        /// A format of ETC1 indicates that the format shall be decodableby an ETC1-compliant decoder and not rely on ETC2 features
        Etc1 = 160,

        /// <summary>A format of ETC2 is permitted to use ETC2 encodings on top ofthe baseline ETC1 specification</summary>
        /// The ETC2 format has channels "red", "green", "RGB" and "alpha",which should be cosited samples
        /// Punch-through alpha can be distinguished from full alpha bythe plane size in bytes required for the texel block
        Etc2 = 161,

        /// <summary>Adaptive Scalable Texture Compression</summary>
        /// ASTC HDR vs LDR is determined by the float flag in the channel
        /// ASTC block size can be distinguished by texel block size
        Astc = 162,

        /// <summary>ETC1S is a simplified subset of ETC1</summary>
        Etc1S = 163,

        /// <summary>PowerVR Texture Compression</summary>
        Pvrtc = 164,

        /// <summary>PowerVR Texture Compression</summary>
        Pvrtc2 = 165,

        /// <summary>PowerVR Texture Compression</summary>
        Uastc = 166,

        /// <summary>Proprietary formats (ATITC, etc.) should follow</summary>
        Max = 255,
    }
}
#pragma warning restore 1591
