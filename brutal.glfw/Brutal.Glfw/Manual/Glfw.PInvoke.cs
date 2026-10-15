namespace Brutal.GlfwApi;

public static unsafe partial class Glfw
{
    public static partial class PInvoke
    {
        [LibraryImport(Dll, EntryPoint = "glfwGetCurrentContext")]
        private static partial GlfwWindowHandle* _GetCurrentContext();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GlfwWindowHandle* GetCurrentContext()
        {
            Log.Trace();
            return _GetCurrentContext();
        }

        [LibraryImport(Dll, EntryPoint = "glfwGetProcAddress")]
        private static partial nint _GetProcAddress(byte* procName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint GetProcAddress(byte* procName)
        {
            Log.Trace();
            return _GetProcAddress(procName);
        }

        // PFN_vkGetInstanceProcAddr is a function pointer value; the generator emits `nint*`
        // for typedef'd function pointers, which is incorrect for a by-value parameter.
        [LibraryImport(Dll, EntryPoint = "glfwInitVulkanLoader")]
        private static partial void _InitVulkanLoader(nint loader);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InitVulkanLoader(nint loader)
        {
            Log.Trace();
            _InitVulkanLoader(loader);
        }

        // This one is implemented manually to avoid the need for difficult marshaling
        [LibraryImport(
            Dll,
            EntryPoint = "glfwCreateWindow",
            StringMarshalling = StringMarshalling.Custom,
            StringMarshallingCustomType = typeof(CustomStringMarshaller)
        )]
        private static unsafe partial GlfwWindowHandle* _CreateWindow(
            int width,
            int height,
            string title,
            GlfwMonitor monitor,
            GlfwWindowHandle* share
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GlfwWindowHandle* CreateWindow(
            int width,
            int height,
            string title,
            GlfwMonitor monitor,
            GlfwWindowHandle* share
        )
        {
            Log.Trace();
            return _CreateWindow(width, height, title, monitor, share);
        }

        [LibraryImport(
            Dll,
            EntryPoint = "glfwSetClipboardString",
            StringMarshalling = StringMarshalling.Custom,
            StringMarshallingCustomType = typeof(CustomStringMarshaller)
        )]
        private static unsafe partial void _SetClipboardString(GlfwWindowHandle* window, string @string);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetClipboardString(GlfwWindowHandle* window, string @string)
        {
            Log.Trace();
            _SetClipboardString(window, @string);
        }

        [LibraryImport(
            Dll,
            EntryPoint = "glfwGetClipboardString",
            StringMarshalling = StringMarshalling.Custom,
            StringMarshallingCustomType = typeof(CustomStringMarshaller)
        )]
        private static unsafe partial string? _GetClipboardString(GlfwWindowHandle* window);

        // Returns null when the clipboard is empty or its contents cannot be converted to UTF-8
        // (GlfwErrorCode.FormatUnavailable) - the CustomStringMarshaller preserves GLFW's NULL
        // failure sentinel rather than collapsing it to an empty string.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetClipboardString(GlfwWindowHandle* window)
        {
            Log.Trace();
            return _GetClipboardString(window);
        }
    }
}
