namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceEventTypeEXT.html">VkDeviceEventTypeEXT</see> - Events that can occur on a device object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDeviceEventInfoEXT::deviceEvent</c>, specifying
    ///         when a fence will be signaled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef enum VkDeviceEventTypeEXT {
    ///             VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT = 0,
    ///         } VkDeviceEventTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDeviceEventTypeEXT : int
    {
        /// <summary>
        ///     <c>DisplayHotplugEXT</c> specifies that the fence is signaled when a display is plugged into or unplugged from the specified device. Applications <i>can</i> use this notification to determine when they need to re-enumerate the available displays on a device.
        /// </summary>
        DisplayHotplugEXT = 0,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
