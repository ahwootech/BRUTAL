using System.Runtime.InteropServices;

namespace Brutal.FmodApi.Studio;

public static partial class FmodStudio
{
    static FmodStudio()
    {
        // Load required dependency on fmod core lib prior to any studio LibraryImport
        NativeLibrary.Load("fmod", typeof(FmodStudio).Assembly, DllImportSearchPath.AssemblyDirectory);
    }
}
