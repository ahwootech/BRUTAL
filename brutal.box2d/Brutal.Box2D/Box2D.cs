using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Brutal.Box2DApi;

/// <summary>
/// A 2D physics engine.
/// </summary>
public static partial class Box2D
{
    private const string Dll =
#if DEBUG
        "box2dd";
#else
        "box2d";
#endif

    static Box2D()
    {
        // Load the GLFW native library
        var glfwNative = NativeLibrary.Load(Dll, typeof(Box2D).Assembly, DllImportSearchPath.AssemblyDirectory);

        // Assign the native library to the assembly resolver
        NativeLibrary.SetDllImportResolver(
            typeof(Box2D).Assembly,
            (libraryName, _, _) =>
            {
                return glfwNative;
            }
        );
    }
}
