#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KhrDfTransfer : int
    {
        /// <summary>No transfer function defined</summary>
        Unspecified = 0,

        /// <summary>Linear transfer function (value proportional to intensity)</summary>
        Linear = 1,

        /// <summary>Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB</summary>
        Srgb = 2,

        /// <summary>Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB</summary>
        SrgbEotf = 2,

        /// <summary>Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB</summary>
        Scrgb = 2,

        /// <summary>Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB</summary>
        ScrgbEotf = 2,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Itu = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        ItuOetf = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt601 = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt601Oetf = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt709 = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt709Oetf = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt2020 = 3,

        /// <summary>Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45)</summary>
        Bt2020Oetf = 3,

        /// <summary>SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF</summary>
        Smtpe170M = 3,

        /// <summary>SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF</summary>
        Smtpe170MOetf = 3,

        /// <summary>SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF</summary>
        Smtpe170MEotf = 3,

        /// <summary>Perceptually-linear gamma function of original NTSC (simple 2.2 gamma)</summary>
        Ntsc = 4,

        /// <summary>Perceptually-linear gamma function of original NTSC (simple 2.2 gamma)</summary>
        NtscEotf = 4,

        /// <summary>Sony S-log used by Sony video cameras</summary>
        Slog = 5,

        /// <summary>Sony S-log used by Sony video cameras</summary>
        SlogOetf = 5,

        /// <summary>Sony S-log 2 used by Sony video cameras</summary>
        Slog2 = 6,

        /// <summary>Sony S-log 2 used by Sony video cameras</summary>
        Slog2Oetf = 6,

        /// <summary>ITU BT.1886 EOTF</summary>
        Bt1886 = 7,

        /// <summary>ITU BT.1886 EOTF</summary>
        Bt1886Eotf = 7,

        /// <summary>ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..1</summary>
        HlgOetf = 8,

        /// <summary>ITU BT.2100 HLG EOTF (nominal HDR display of HLG content), linear light normalized 0..1</summary>
        HlgEotf = 9,

        /// <summary>ITU BT.2100 PQ EOTF (typical HDR display-referred PQ content)</summary>
        PqEotf = 10,

        /// <summary>ITU BT.2100 PQ OETF (nominal scene described by PQ HDR content)</summary>
        PqOetf = 11,

        /// <summary>DCI P3 transfer function</summary>
        Dcip3 = 12,

        /// <summary>DCI P3 transfer function</summary>
        Dcip3Eotf = 12,

        /// <summary>Legacy PAL OETF</summary>
        PalOetf = 13,

        /// <summary>Legacy PAL 625-line EOTF</summary>
        Pal625Eotf = 14,

        /// <summary>Legacy ST240 transfer function</summary>
        St240 = 15,

        /// <summary>Legacy ST240 transfer function</summary>
        St240Oetf = 15,

        /// <summary>Legacy ST240 transfer function</summary>
        St240Eotf = 15,

        /// <summary>ACEScc transfer function</summary>
        Acescc = 16,

        /// <summary>ACEScc transfer function</summary>
        AcesccOetf = 16,

        /// <summary>ACEScct transfer function</summary>
        Acescct = 17,

        /// <summary>ACEScct transfer function</summary>
        AcescctOetf = 17,

        /// <summary>Adobe RGB (1998) transfer function</summary>
        Adobergb = 18,

        /// <summary>Adobe RGB (1998) transfer function</summary>
        AdobergbEotf = 18,

        /// <summary>Legacy ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..12</summary>
        HlgUnnormalizedOetf = 19,

        /// <summary>Legacy ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..12</summary>
        Max = 255,
    }
}
#pragma warning restore 1591
