#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KhrDfPrimaries : int
    {
        /// <summary>No color primaries defined</summary>
        Unspecified = 0,

        /// <summary>Color primaries of ITU-R BT.709 and sRGB</summary>
        Bt709 = 1,

        /// <summary>Synonym for KHR_DF_PRIMARIES_BT709</summary>
        Srgb = 1,

        /// <summary>Color primaries of ITU-R BT.601 (625-line EBU variant)</summary>
        Bt601Ebu = 2,

        /// <summary>Color primaries of ITU-R BT.601 (525-line SMPTE C variant)</summary>
        Bt601Smpte = 3,

        /// <summary>Color primaries of ITU-R BT.2020</summary>
        Bt2020 = 4,

        /// <summary>ITU-R BT.2100 uses the same primaries as BT.2020</summary>
        Bt2100 = 4,

        /// <summary>CIE theoretical color coordinate space</summary>
        Ciexyz = 5,

        /// <summary>Academy Color Encoding System primaries</summary>
        Aces = 6,

        /// <summary>Color primaries of ACEScc</summary>
        Acescc = 7,

        /// <summary>Legacy NTSC 1953 primaries</summary>
        Ntsc1953 = 8,

        /// <summary>Legacy PAL 525-line primaries</summary>
        Pal525 = 9,

        /// <summary>Color primaries of Display P3</summary>
        Displayp3 = 10,

        /// <summary>Color primaries of Adobe RGB (1998)</summary>
        Adobergb = 11,

        /// <summary>Color primaries of Adobe RGB (1998)</summary>
        Max = 255,
    }
}
#pragma warning restore 1591
