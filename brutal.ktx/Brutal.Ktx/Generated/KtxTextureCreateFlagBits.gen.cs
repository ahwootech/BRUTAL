#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [System.Flags]
    public enum KtxTextureCreateFlagBits : int
    {
        NoFlags = 0,
        LoadImageDataBit = 1,
        RawKvdataBit = 2,
        SkipKvdataBit = 4,
        CheckGltfBasisuBit = 8,
    }
}
#pragma warning restore 1591
