global using unsafe VkDebugUtilsMessengerCallbackEXT = delegate* unmanaged[Cdecl]<
    Brutal.VulkanApi.VkDebugUtilsMessageSeverityFlagsEXT,
    Brutal.VulkanApi.VkDebugUtilsMessageTypeFlagsEXT,
    Brutal.VulkanApi.VkDebugUtilsMessengerCallbackDataEXT*,
    void*,
    Brutal.Bool32>;
using System.Runtime.InteropServices;

namespace Brutal.VulkanApi.Abstractions;

public static partial class VulkanHelpers
{
    // variant << 29 | major << 22 | minor << 12 | patch;
    public enum Api
    {
        VERSION_1_0 = 1 << 22,
        VERSION_1_1 = 1 << 22 | 1 << 12,
        VERSION_1_2 = 1 << 22 | 2 << 12,
        VERSION_1_3 = 1 << 22 | 3 << 12,
        VERSION_1_4 = 1 << 22 | 4 << 12,
    }

    public static class Validation
    {
        static Validation()
        {
            IsSupported = CheckSupport();
        }

        /// <summary>
        /// True if validation layers are supported
        /// </summary>
        public static readonly bool IsSupported;

        /// <summary>
        /// Checks if validation layers are supported
        /// </summary>
        private static unsafe bool CheckSupport()
        {
            Span<VkLayerProperties> layers =
                stackalloc VkLayerProperties[Vulkan.EnumerateInstanceLayerProperties_Count()];
            Vulkan.EnumerateInstanceLayerProperties_Write(layers);

            foreach (var layer in layers)
            {
                // Compare the UTF-8 bytes directly rather than allocating a managed string per layer
                var name = Utf8.GetNullTerminatedSpan(layer.LayerName);
                if (name.SequenceEqual(VK.LAYER_KHRONOS_VALIDATION_UTF8))
                    return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Adds the instance extensions which are required on the current operating system
    /// </summary>
    public static void AddPlatformRequiredExtensions(HashSet<string> extensions)
    {
        if (OperatingSystem.IsMacOS())
        {
            AddMetalRequiredExtensions(extensions);
        }
    }

    /// <summary>
    /// Adds the instance extensions which are required by Metal
    /// </summary>
    public static void AddMetalRequiredExtensions(HashSet<string> extensions)
    {
        Span<string> metalRequiredExtensions =
        [
            VK.KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME,
            VK.KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME,
        ];

        foreach (var extension in metalRequiredExtensions)
            extensions.Add(extension);
    }

    /// <summary>
    /// Adds the extensions required for debug functionality
    /// </summary>
    public static void AddDebugExtensions(HashSet<string> extensions)
    {
        Span<string> debugRequiredExtensions = [VK.EXT_DEBUG_UTILS_EXTENSION_NAME, VK.EXT_DEBUG_REPORT_EXTENSION_NAME];

        foreach (var extension in debugRequiredExtensions)
            extensions.Add(extension);
    }

    /// <summary>
    /// Adds the instance extensions required to use a surface, i.e. for windowed rendering
    /// </summary>
    public static void AddSurfaceExtensions(HashSet<string> extensions)
    {
        extensions.Add(VK.KHR_SURFACE_EXTENSION_NAME);
    }

    /// <summary>
    /// Adds the device extensions required to use a swapchain, i.e. for windowed rendering
    /// </summary>
    public static void AddSwapchainExtensions(HashSet<string> extensions)
    {
        extensions.Add(VK.KHR_SWAPCHAIN_EXTENSION_NAME);
    }

    /// <summary>
    /// Adds the Vulkan validation layer
    /// </summary>
    public static void AddValidationLayers(HashSet<string> layers)
    {
        layers.Add(VK.LAYER_KHRONOS_VALIDATION);
    }

    /// <summary>
    /// Gets the VkInstanceCreateFlags required on the current platform
    /// </summary>
    public static VkInstanceCreateFlags GetPlatformRequiredInstanceCreateFlags()
    {
        var flags = VkInstanceCreateFlags.None;
        if (OperatingSystem.IsMacOS())
            flags |= VkInstanceCreateFlags.EnumeratePortabilityBitKHR;
        return flags;
    }

    private static readonly string[] MandatoryIfSupportedDeviceExtensions = [VK.KHR_PORTABILITY_SUBSET_EXTENSION_NAME];

    /// <summary>
    /// Gets the device extensions which MUST be loaded IF they are supported by a physical device
    /// </summary>
    public static string[] GetMandatoryIfSupportedDeviceExtensions()
    {
        return MandatoryIfSupportedDeviceExtensions;
    }

    /// <summary>
    /// Adds the device extensions which MUST be loaded IF they are supported on the given physical device
    /// </summary>
    public static void AddMandatoryIfSupportedDeviceExtensions(
        HashSet<string> extensions,
        PhysicalDevice physicalDevice
    )
    {
        // Plain loop instead of a LINQ Where enumerator/closure
        foreach (var extension in MandatoryIfSupportedDeviceExtensions)
            if (physicalDevice.SupportsExtension(extension))
                extensions.Add(extension);
    }

    /// <summary>
    /// Returns a VkDebugUtilsMessengerCreateInfoEXT struct using the provided message callback,
    /// and populated with default message settings flags and user data
    /// </summary>
    public static unsafe VkDebugUtilsMessengerCreateInfoEXT BuildDefaultDebugMessengerCreateInfo(
        PfnVkDebugUtilsMessengerCallbackEXT callback
    )
    {
        return new VkDebugUtilsMessengerCreateInfoEXT
        {
            MessageSeverity =
                VkDebugUtilsMessageSeverityFlagsEXT.ErrorBitEXT
                | VkDebugUtilsMessageSeverityFlagsEXT.WarningBitEXT
                | VkDebugUtilsMessageSeverityFlagsEXT.InfoBitEXT
                | VkDebugUtilsMessageSeverityFlagsEXT.VerboseBitEXT,
            MessageType =
                VkDebugUtilsMessageTypeFlagsEXT.GeneralBitEXT
                | VkDebugUtilsMessageTypeFlagsEXT.ValidationBitEXT
                | VkDebugUtilsMessageTypeFlagsEXT.PerformanceBitEXT,
            //| DebugUtilsMessageTypeFlagsEXT.DebugUtilsMessageTypeDeviceAddressBinding,
            PfnUserCallback = callback,
            UserData = DefaultCallbackUserData,
        };
    }

    private static readonly PtrOwner<bool> DefaultCallbackUserData = new(false);

    /// <summary>
    /// Gets or sets a value indicating whether verbose logging is enabled.
    /// </summary>
    public static bool VerboseLoggingEnabled
    {
        get => DefaultCallbackUserData.Value;
        set => DefaultCallbackUserData.Value = value;
    }

    public static class DebugUtilsMessengerCallbacks
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="messageSeverity"></param>
        /// <param name="messageTypes"></param>
        /// <param name="pCallbackData"></param>
        /// <param name="pUserData"></param>
        /// <returns></returns>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe Bool32 Quiet(
            VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
            void* pUserData
        )
        {
            var message = Utf8.GetString(pCallbackData->Message);
            if (string.IsNullOrEmpty(message))
                return false;

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.ErrorBitEXT))
            {
                Vulkan.Log.Error(message);
                return false;
            }

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.WarningBitEXT))
            {
                Vulkan.Log.Warning(message);
                return false;
            }

            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="messageSeverity"></param>
        /// <param name="messageTypes"></param>
        /// <param name="pCallbackData"></param>
        /// <param name="pUserData"></param>
        /// <returns></returns>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe Bool32 Default(
            VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
            void* pUserData
        )
        {
            var message = Utf8.GetString(pCallbackData->Message);
            if (string.IsNullOrEmpty(message))
                return false;

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.ErrorBitEXT))
            {
                Vulkan.Log.Error(message);
                return false;
            }

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.WarningBitEXT))
            {
                Vulkan.Log.Warning(message);
                return false;
            }

            if (pUserData != null && *(bool*)pUserData)
            {
                if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.InfoBitEXT))
                {
                    Vulkan.Log.Info(message);
                    return false;
                }

                if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.VerboseBitEXT))
                {
                    Vulkan.Log.Debug(message);
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="messageSeverity"></param>
        /// <param name="messageTypes"></param>
        /// <param name="pCallbackData"></param>
        /// <param name="pUserData"></param>
        /// <returns></returns>
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe Bool32 Verbose(
            VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
            void* pUserData
        )
        {
            var message = Utf8.GetString(pCallbackData->Message);
            if (string.IsNullOrEmpty(message))
                return false;

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.ErrorBitEXT))
            {
                Vulkan.Log.Error(message);
                return false;
            }

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.WarningBitEXT))
            {
                Vulkan.Log.Warning(message);
                return false;
            }

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.InfoBitEXT))
            {
                Vulkan.Log.Info(message);
                return false;
            }

            if (messageSeverity.HasFlag(VkDebugUtilsMessageSeverityFlagsEXT.VerboseBitEXT))
            {
                Vulkan.Log.Debug(message);
                return false;
            }

            return false;
        }
    }
}
