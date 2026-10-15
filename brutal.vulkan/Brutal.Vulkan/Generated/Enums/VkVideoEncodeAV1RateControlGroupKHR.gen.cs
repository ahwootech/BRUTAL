namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlGroupKHR.html">VkVideoEncodeAV1RateControlGroupKHR</see> - AV1 encode rate control group
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible AV1 encode rate control groups are as follows:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1RateControlGroupKHR {
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR = 0,
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR = 1,
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR = 2,
    ///         } VkVideoEncodeAV1RateControlGroupKHR;
    ///     </code>
    /// </remarks>
    public enum VkVideoEncodeAV1RateControlGroupKHR : int
    {
        /// <summary>
        ///     <c>IntraKHR</c> <i>should</i> be specified when encoding AV1 frames that use intra-only prediction (e.g. when encoding AV1 frames of type <c>STD_VIDEO_AV1_FRAME_TYPE_KEY</c> or <c>STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY</c>).
        /// </summary>
        IntraKHR = 0,

        /// <summary>
        ///     <c>PredictiveKHR</c> <i>should</i> be specified when encoding AV1 frames that only have forward references in display order.
        /// </summary>
        PredictiveKHR = 1,

        /// <summary>
        ///     <c>BipredictiveKHR</c> <i>should</i> be specified when encoding AV1 frames that have backward references in display order.  [NOTE]
        /// </summary>
        BipredictiveKHR = 2,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
