using System.Diagnostics;

namespace Brutal.VulkanApi.Abstractions;

public static class DebugNameExtensions
{
    private const int MAX_DEBUG_NAME_LENGTH = 256;

    /// <summary>
    /// Set a debug name for the handle.
    /// </summary>
    /// <param name="device">Handle to the device that will assign the name</param>
    /// <param name="handle">The Vulkan handle we want to assign a name to</param>
    /// <param name="name">The name to assign to the handle</param>
    [Conditional("DEBUG")]
    public static void SetDebugName<T>(this Device device, T handle, string name)
        where T : IVulkanHandle
    {
        if (!device.PhysicalDevice.Instance.IsExtensionEnabled(VK.EXT_DEBUG_UTILS_EXTENSION_NAME))
            return;

        var bytes = SpanOwner<byte>.Allocate(MAX_DEBUG_NAME_LENGTH);
        var written = Utf8.GetBytes(name, bytes.Span);
        bytes.Span[written] = 0;

        device.SetDebugName(handle.VkObjectType, handle.VkHandle, bytes.Span[..written]);
    }

    /// <summary>
    /// Set a debug name for the handle.
    /// </summary>
    /// <param name="device">Handle to the device that will assign the name</param>
    /// <param name="handle">The Vulkan handle we want to assign a name to</param>
    /// <param name="name">The name to assign to the handle</param>
    [Conditional("DEBUG")]
    public static void SetDebugName<T>(this Device device, T handle, ReadOnlySpan<byte> name)
        where T : IVulkanHandle
    {
        if (!device.PhysicalDevice.Instance.IsExtensionEnabled(VK.EXT_DEBUG_UTILS_EXTENSION_NAME))
            return;

        device.SetDebugName(handle.VkObjectType, handle.VkHandle, name);
    }

    private static unsafe void SetDebugName(
        this Device device,
        VkObjectType objectType,
        nint handle,
        ReadOnlySpan<byte> name
    )
    {
        fixed (byte* namePtr = name)
            device.SetDebugUtilsObjectNameEXT(
                new VkDebugUtilsObjectNameInfoEXT
                {
                    ObjectType = objectType,
                    ObjectHandle = handle,
                    ObjectName = namePtr,
                }
            );
    }
}
