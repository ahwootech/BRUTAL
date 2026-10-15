namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeTuningModeKHR.html">VkVideoEncodeTuningModeKHR</see> - Video encode tuning mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible video encode tuning mode values are as follows:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeTuningModeKHR {
    ///             VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR = 0,
    ///             VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR = 1,
    ///             VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR = 2,
    ///             VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR = 3,
    ///             VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR = 4,
    ///         } VkVideoEncodeTuningModeKHR;
    ///     </code>
    /// </remarks>
    public enum VkVideoEncodeTuningModeKHR : int
    {
        /// <summary>
        ///     <c>DefaultKHR</c> specifies the default tuning mode.
        /// </summary>
        DefaultKHR = 0,

        /// <summary>
        ///     <c>HighQualityKHR</c> specifies that video encoding is tuned for high quality. When using this tuning mode, the implementation may: compromise the latency of video encoding operations to improve quality.
        /// </summary>
        HighQualityKHR = 1,

        /// <summary>
        ///     <c>LowLatencyKHR</c> specifies that video encoding is tuned for low latency. When using this tuning mode, the implementation may: compromise quality to increase the performance and lower the latency of video encode operations.
        /// </summary>
        LowLatencyKHR = 2,

        /// <summary>
        ///     <c>UltraLowLatencyKHR</c> specifies that video encoding is tuned for ultra-low latency. When using this tuning mode, the implementation may: compromise quality to maximize the performance and minimize the latency of video encoding operations.
        /// </summary>
        UltraLowLatencyKHR = 3,

        /// <summary>
        ///     <c>LosslessKHR</c> specifies that video encoding is tuned for lossless encoding. When using this tuning mode, video encode operations produce lossless output.
        /// </summary>
        LosslessKHR = 4,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
