namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodePerPartitionFeedbackFlagBitsKHR.html">VkVideoEncodePerPartitionFeedbackFlagBitsKHR</see> - Bits specifying queried per picture partition video encode feedback values
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR::perPartitionEncodeFeedbackFlags</c>
    ///         for video encode feedback query pools are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_feedback2
    ///         typedef enum VkVideoEncodePerPartitionFeedbackFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_STATUS_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR = 0x00000004,
    ///         } VkVideoEncodePerPartitionFeedbackFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodePerPartitionFeedbackFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>StatusBitKHR</c> specifies that queries managed by the pool will capture the result status of each encoded picture partition. These result status values are reported as <c>VkQueryResultStatusKHR</c> values, similar to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-result-status-only">result status queries^</see> but indicate the result status of the encoding of individual picture partitions instead of that of the whole video encode operation.
        /// </summary>
        StatusBitKHR = 0x00000001,

        /// <summary>
        ///     <c>BitstreamBufferOffsetBitKHR</c>  specifies that queries managed by the pool will capture the byte offset of the bitstream data of the corresponding picture partition written to the bitstream buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c> relative to the offset specified in <c>VkVideoEncodeInfoKHR::dstBufferOffset</c>.
        /// </summary>
        BitstreamBufferOffsetBitKHR = 0x00000002,

        /// <summary>
        ///     <c>BitstreamBytesWrittenBitKHR</c>  specifies that queries managed by the pool will capture the number of bytes written by the video encode operation for the corresponding picture partition to the bitstream buffer specified in <c>VkVideoEncodeInfoKHR::dstBuffer</c>.  The bitstream offsets reported for subsequent picture partitions are always monotonically increasing and the bitstream buffer ranges corresponding to individual picture partitions do not overlap.  [NOTE]
        /// </summary>
        BitstreamBytesWrittenBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
