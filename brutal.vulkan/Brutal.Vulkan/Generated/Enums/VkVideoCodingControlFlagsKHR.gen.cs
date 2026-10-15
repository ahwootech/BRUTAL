namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlFlagBitsKHR.html">VkVideoCodingControlFlagBitsKHR</see> - Video coding control flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkVideoCodingControlInfoKHR::flags</c>,
    ///         specifying the video coding control parameters to be modified, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoCodingControlFlagBitsKHR {
    ///             VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR = 0x00000004,
    ///         } VkVideoCodingControlFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoCodingControlFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ResetBitKHR</c> specifies a request for the bound video session to be reset before other coding control parameters are applied.
        /// </summary>
        ResetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>EncodeRateControlBitKHR</c>
        /// </summary>
        EncodeRateControlBitKHR = 0x00000002,

        /// <summary>
        ///     <c>EncodeQualityLevelBitKHR</c>
        /// </summary>
        EncodeQualityLevelBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
