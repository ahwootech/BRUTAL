namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeUsageFlagBitsKHR.html">VkVideoDecodeUsageFlagBitsKHR</see> - Video decode usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The following bits <i>can</i> be specified in
    ///         <c>VkVideoDecodeUsageInfoKHR::videoUsageHints</c> as a hint about the
    ///         video decode use case:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_queue
    ///         typedef enum VkVideoDecodeUsageFlagBitsKHR {
    ///             VK_VIDEO_DECODE_USAGE_DEFAULT_KHR = 0,
    ///             VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR = 0x00000004,
    ///         } VkVideoDecodeUsageFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoDecodeUsageFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DefaultKHR</c>
        /// </summary>
        DefaultKHR = 0,

        /// <summary>
        ///     <c>TranscodingBitKHR</c> specifies that video decoding is intended to be used in conjunction with video encoding to transcode a video bitstream with the same and/or different codecs.
        /// </summary>
        TranscodingBitKHR = 0x00000001,

        /// <summary>
        ///     <c>OfflineBitKHR</c> specifies that video decoding is intended to be used to consume a local video bitstream.
        /// </summary>
        OfflineBitKHR = 0x00000002,

        /// <summary>
        ///     <c>StreamingBitKHR</c> specifies that video decoding is intended to be used to consume a video bitstream received as a continuous flow over network.  [NOTE]
        /// </summary>
        StreamingBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
