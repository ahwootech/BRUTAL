using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

public partial struct CreateSoundExInfo
{
    /// <summary>
    ///
    /// </summary>
    public unsafe CreateSoundExInfo()
    {
        CbSize = sizeof(CreateSoundExInfo);
    }

    public static CreateSoundExInfo Default => new();
}
