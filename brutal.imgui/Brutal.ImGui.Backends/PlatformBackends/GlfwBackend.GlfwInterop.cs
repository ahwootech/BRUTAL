using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi.Backends;

public partial class GlfwBackend
{
    private static partial class GlfwInterop
    {
        private const string MacOSLibraryName = "glfw";
        private const string WindowsLibraryName = "glfw3";

        [LibraryImport(MacOSLibraryName, EntryPoint = "glfwGetCocoaWindow")]
        public static partial nint GetCocoaWindow(nint glfwWindow);

        [LibraryImport(WindowsLibraryName, EntryPoint = "glfwGetWin32Window")]
        public static partial nint GetWin32Window(nint glfwWindow);
    }
}
