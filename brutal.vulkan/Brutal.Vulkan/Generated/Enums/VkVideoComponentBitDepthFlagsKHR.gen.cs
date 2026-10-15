namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoComponentBitDepthFlagBitsKHR.html">VkVideoComponentBitDepthFlagBitsKHR</see> - Video format component bit depth
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values for the video format component bit depth are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoComponentBitDepthFlagBitsKHR {
    ///             VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = 0,
    ///             VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = 0x00000010,
    ///         } VkVideoComponentBitDepthFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoComponentBitDepthFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InvalidKHR</c>
        /// </summary>
        InvalidKHR = 0,

        /// <summary>
        ///     <c>_8BitKHR</c> specifies a component bit depth of 8 bits.
        /// </summary>
        _8BitKHR = 0x00000001,

        /// <summary>
        ///     <c>_10BitKHR</c> specifies a component bit depth of 10 bits.
        /// </summary>
        _10BitKHR = 0x00000004,

        /// <summary>
        ///     <c>_12BitKHR</c> specifies a component bit depth of 12 bits.
        /// </summary>
        _12BitKHR = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
