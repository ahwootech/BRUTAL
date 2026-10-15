#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [System.Flags]
    public enum KtxPackUastcFlagBits : int
    {
        LevelFastest = 0,
        LevelFaster = 1,
        LevelDefault = 2,
        LevelSlower = 3,
        LevelVeryslow = 4,
        MaxLevel = 4,
        LevelMask = 15,
        FavorUastcError = 8,
        FavorBc7Error = 16,
        Etc1FasterHints = 64,
        Etc1FastestHints = 128,
        Etc1DisableFlipAndIndividual = 256,
    }
}
#pragma warning restore 1591
