namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageFlagBitsKHR.html">VkVideoEncodeUsageFlagBitsKHR</see> - Video encode usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The following bits <i>can</i> be specified in
    ///         <c>VkVideoEncodeUsageInfoKHR::videoUsageHints</c> as a hint about the
    ///         video encode use case:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeUsageFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR = 0,
    ///             VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeUsageFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeUsageFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DefaultKHR</c>
        /// </summary>
        DefaultKHR = 0,

        /// <summary>
        ///     <c>TranscodingBitKHR</c> specifies that video encoding is intended to be used in conjunction with video decoding to transcode a video bitstream with the same and/or different codecs.
        /// </summary>
        TranscodingBitKHR = 0x00000001,

        /// <summary>
        ///     <c>StreamingBitKHR</c> specifies that video encoding is intended to be used to produce a video bitstream that is expected to be sent as a continuous flow over network.
        /// </summary>
        StreamingBitKHR = 0x00000002,

        /// <summary>
        ///     <c>RecordingBitKHR</c> specifies that video encoding is intended to be used for real-time recording for offline consumption.
        /// </summary>
        RecordingBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ConferencingBitKHR</c> specifies that video encoding is intended to be used in a video conferencing scenario.  [NOTE]
        /// </summary>
        ConferencingBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
