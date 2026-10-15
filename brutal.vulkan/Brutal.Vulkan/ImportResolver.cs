namespace Brutal.VulkanApi;

public partial class Vulkan
{
    // The dll name we expect LibraryImport functions calling Vulkan to use
    private const string PInvokeDllName = "vulkan";

    // Cached reference to the loaded Vulkan dll
    private static readonly nint Dll;

    /// <summary>
    /// The function pointer to vkGetInstanceProcAddr, loaded from the Vulkan library.
    /// </summary>
    public static VkGetInstanceProcAddr GetInstanceProcAddr { get; }

    static Vulkan()
    {
        // Load the correct Vulkan library for the platform

        if (OperatingSystem.IsWindows())
            Dll = NativeLibrary.Load("vulkan-1", typeof(Vulkan).Assembly, DllImportSearchPath.System32);

        // TODO: This is a hack which only works if SDK is installed, we need to package the Vulkan binary on macOS
        if (OperatingSystem.IsMacOS())
            Dll = NativeLibrary.Load("VulkanEx", typeof(Vulkan).Assembly, DllImportSearchPath.LegacyBehavior);

        if (OperatingSystem.IsLinux())
            Dll = NativeLibrary.Load("vulkan", typeof(Vulkan).Assembly, DllImportSearchPath.LegacyBehavior);

        if (Dll == nint.Zero)
            throw new NullReferenceException("Failed to load Vulkan library");

        // Assign the native library to the assembly resolver
        NativeLibrary.SetDllImportResolver(
            typeof(Vulkan).Assembly,
            (libraryName, _, _) => libraryName == PInvokeDllName ? Dll : nint.Zero
        );

        // Load the vkGetInstanceProcAddr function
        unsafe
        {
            GetInstanceProcAddr = new VkGetInstanceProcAddr(
                (delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction>)
                    NativeLibrary.GetExport(Dll, "vkGetInstanceProcAddr")
            );
            if (GetInstanceProcAddr.Invoke == null)
                throw new NullReferenceException("Failed to load vkGetInstanceProcAddr from Vulkan library");
        }
    }
}
