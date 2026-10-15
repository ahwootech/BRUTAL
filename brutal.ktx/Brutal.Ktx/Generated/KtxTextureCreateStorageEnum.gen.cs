#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public enum KtxTextureCreateStorageEnum : int
    {
        /// <summary>Don't allocate any image storage.</summary>
        TextureCreateNoStorage = 0,

        /// <summary>Allocate image storage.</summary>
        TextureCreateAllocStorage = 1,
    }
}
#pragma warning restore 1591
