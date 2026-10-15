using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

public partial struct AdvancedSettings
{
    /// <summary>
    ///
    /// </summary>
    public unsafe AdvancedSettings()
    {
        CbSize = sizeof(AdvancedSettings);
    }
}
