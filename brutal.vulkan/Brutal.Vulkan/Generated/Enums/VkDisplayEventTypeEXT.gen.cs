namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayEventTypeEXT.html">VkDisplayEventTypeEXT</see> - Events that can occur on a display object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDisplayEventInfoEXT::displayEvent</c>,
    ///         specifying when a fence will be signaled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef enum VkDisplayEventTypeEXT {
    ///             VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT = 0,
    ///         } VkDisplayEventTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDisplayEventTypeEXT : int
    {
        /// <summary>
        ///     <c>FirstPixelOutEXT</c> specifies that the fence is signaled when the first pixel of the next display refresh cycle leaves the display engine for the display.
        /// </summary>
        FirstPixelOutEXT = 0,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
