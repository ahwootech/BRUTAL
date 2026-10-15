namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFeedbackFlagBitsKHR.html">VkVideoEncodeFeedbackFlagBitsKHR</see> - Bits specifying queried video encode feedback values
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkQueryPoolVideoEncodeFeedbackCreateInfoKHR::encodeFeedbackFlags</c>
    ///         for video encode feedback query pools are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeFeedbackFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR = 0x00000004,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_AVERAGE_QUANTIZATION_BIT_KHR = 0x00000008,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_MIN_QUANTIZATION_BIT_KHR = 0x00000010,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_MAX_QUANTIZATION_BIT_KHR = 0x00000020,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_INTRA_PIXELS_BIT_KHR = 0x00000040,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_INTER_PIXELS_BIT_KHR = 0x00000080,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_SKIPPED_PIXELS_BIT_KHR = 0x00000100,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_VIDEO_ENCODE_FEEDBACK_PICTURE_PARTITION_COUNT_BIT_KHR = 0x00000200,
    ///         } VkVideoEncodeFeedbackFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeFeedbackFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>BitstreamBufferOffsetBitKHR</c> specifies that queries managed by the pool will capture the byte offset of the bitstream data written by the video encode operation to the bitstream buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c> relative to the offset specified in <c>VkVideoEncodeInfoKHR::dstBufferOffset</c>. For the first video encode operation issued by any <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-encode-commands">video encode command^</see>, this value will always be zero, meaning that bitstream data is always written to the buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c> starting from the offset specified in <c>VkVideoEncodeInfoKHR::dstBufferOffset</c>.
        /// </summary>
        BitstreamBufferOffsetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>BitstreamBytesWrittenBitKHR</c> specifies that queries managed by the pool will capture the number of bytes written by the video encode operation to the bitstream buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c>.
        /// </summary>
        BitstreamBytesWrittenBitKHR = 0x00000002,

        /// <summary>
        ///     <c>BitstreamHasOverridesBitKHR</c> specifies that queries managed by the pool will capture a boolean value indicating that the data written to the bitstream buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c> contains <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden parameters^</see>.
        /// </summary>
        BitstreamHasOverridesBitKHR = 0x00000004,

        /// <summary>
        ///     <c>AverageQuantizationBitKHR</c>
        /// </summary>
        AverageQuantizationBitKHR = 0x00000008,

        /// <summary>
        ///     <c>MinQuantizationBitKHR</c>
        /// </summary>
        MinQuantizationBitKHR = 0x00000010,

        /// <summary>
        ///     <c>MaxQuantizationBitKHR</c>
        /// </summary>
        MaxQuantizationBitKHR = 0x00000020,

        /// <summary>
        ///     <c>IntraPixelsBitKHR</c>
        /// </summary>
        IntraPixelsBitKHR = 0x00000040,

        /// <summary>
        ///     <c>InterPixelsBitKHR</c>
        /// </summary>
        InterPixelsBitKHR = 0x00000080,

        /// <summary>
        ///     <c>SkippedPixelsBitKHR</c>
        /// </summary>
        SkippedPixelsBitKHR = 0x00000100,

        /// <summary>
        ///     <c>PicturePartitionCountBitKHR</c>
        /// </summary>
        PicturePartitionCountBitKHR = 0x00000200,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
