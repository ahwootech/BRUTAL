using System.Runtime.InteropServices;

namespace Brutal.OpenGlApi;

public static partial class Glad
{
    /// <summary>
    /// Initializes OpenGL by loading the GLAD library and setting up the function pointers for use in C#.
    /// </summary>
    /// <returns>True if initialization was successful, otherwise false.</returns>
    public static unsafe bool Initialize(GlGetProcAddressFunc loader)
    {
        var loaderPtr = Marshal.GetFunctionPointerForDelegate(loader);
        if (LoadGlLoader((nint*)loaderPtr) == 0)
            return false;

        OpenGl.LoadPointers(entrypointU8 =>
        {
            fixed (byte* ptr = entrypointU8)
                return loader(ptr);
        });

        return true;
    }
}
