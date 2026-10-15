namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentModeFlagBitsKHR.html">VkDeviceGroupPresentModeFlagBitsKHR</see> - Bitmask specifying supported device group present modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkDeviceGroupPresentCapabilitiesKHR::modes</c>, indicating which
    ///         device group presentation modes are supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_surface
    ///         typedef enum VkDeviceGroupPresentModeFlagBitsKHR {
    ///             VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = 0x00000001,
    ///             VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = 0x00000002,
    ///             VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = 0x00000004,
    ///             VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = 0x00000008,
    ///         } VkDeviceGroupPresentModeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDeviceGroupPresentModeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>LocalBitKHR</c> specifies that any physical device with a presentation engine <i>can</i> present its own swapchain images.
        /// </summary>
        LocalBitKHR = 0x00000001,

        /// <summary>
        ///     <c>RemoteBitKHR</c> specifies that any physical device with a presentation engine <i>can</i> present swapchain images from any physical device in its <c>presentMask</c>.
        /// </summary>
        RemoteBitKHR = 0x00000002,

        /// <summary>
        ///     <c>SumBitKHR</c> specifies that any physical device with a presentation engine <i>can</i> present the sum of swapchain images from any physical devices in its <c>presentMask</c>.
        /// </summary>
        SumBitKHR = 0x00000004,

        /// <summary>
        ///     <c>LocalMultiDeviceBitKHR</c> specifies that multiple physical devices with a presentation engine <i>can</i> each present their own swapchain images.
        /// </summary>
        LocalMultiDeviceBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
