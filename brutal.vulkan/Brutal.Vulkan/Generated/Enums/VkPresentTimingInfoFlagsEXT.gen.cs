namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimingInfoFlagBitsEXT.html">VkPresentTimingInfoFlagBitsEXT</see> - Bitmask specifying present timing info flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkPresentTimingInfoEXT::flags</c>,
    ///         specifying options for how to interpret timing information:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef enum VkPresentTimingInfoFlagBitsEXT {
    ///             VK_PRESENT_TIMING_INFO_PRESENT_AT_RELATIVE_TIME_BIT_EXT = 0x00000001,
    ///             VK_PRESENT_TIMING_INFO_PRESENT_AT_NEAREST_REFRESH_CYCLE_BIT_EXT = 0x00000002,
    ///         } VkPresentTimingInfoFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPresentTimingInfoFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PresentAtRelativeTimeBitEXT</c> specifies that <c>VkPresentTimingInfoEXT::targetTime</c> is to be interpreted as a relative time from the previous presentation&apos;s <c>VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_VISIBLE_BIT_EXT</c> stage. If the <c>swapchain</c> has never been used to present an image, the provided <c>targetTime</c> is ignored.
        /// </summary>
        PresentAtRelativeTimeBitEXT = 0x00000001,

        /// <summary>
        ///     <c>PresentAtNearestRefreshCycleBitEXT</c>  specifies that the application would prefer the image to be presented earlier than the time specified in <c>VkPresentTimingInfoEXT::targetTime</c> if that time falls within the first half of a refresh cycle. In that case, the presentation engine may: choose to display the image at the start of that refresh cycle.
        /// </summary>
        PresentAtNearestRefreshCycleBitEXT = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
