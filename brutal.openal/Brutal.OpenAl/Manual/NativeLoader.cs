// Maps the logical library name "openal" (the `Dll` const in Al.cs / Alc.cs) onto openal-soft's
// per-platform file name via a DllImportResolver.
//
// Registration MUST happen before the first P/Invoke. Accessing a nested type (Al.PInvoke) does
// not trigger the containing type's static constructor, so a static ctor on Al/Alc would not fire
// for a direct raw call; a [ModuleInitializer] runs at assembly load, before any managed access.

using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Brutal.OpenAlApi;

internal static class NativeLoader
{
    // The logical name the generated [LibraryImport] entries request. Must match the `Dll` const.
    private const string LogicalName = "openal";

    // Deliberate despite CA2255 - see the file header for why module-init is the only correct hook.
    [SuppressMessage(
        "Usage",
        "CA2255:The 'ModuleInitializer' attribute should not be used in libraries",
        Justification = "Resolver must register before any nested-type P/Invoke; static ctor is not triggered by nested-type access."
    )]
    [ModuleInitializer]
    internal static void Register()
    {
        NativeLibrary.SetDllImportResolver(typeof(NativeLoader).Assembly, Resolve);
    }

    private static nint Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (libraryName != LogicalName)
            return nint.Zero;

        // openal-soft installed file names:
        //   Windows : OpenAL32.dll
        //   Linux   : libopenal.so.1 (SONAME)
        //   macOS   : libopenal.1.dylib (install_name @rpath/libopenal.1.dylib)
        var fileName = Platform.CurrentFamily switch
        {
            Platform.Family.Windows => "OpenAL32.dll",
            Platform.Family.MacOS => "libopenal.1.dylib",
            _ => "libopenal.so.1",
        };

        return NativeLibrary.Load(fileName, assembly, DllImportSearchPath.AssemblyDirectory);
    }
}
