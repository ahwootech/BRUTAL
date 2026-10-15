#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [System.Flags]
    public enum KtxTranscodeFlagBits : int
    {
        PvrtcDecodeToNextPow2 = 2,
        TranscodeAlphaDataToOpaqueFormats = 4,
        HighQuality = 32,
    }
}
#pragma warning restore 1591
