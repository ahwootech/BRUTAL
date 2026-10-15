namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeCapabilityFlagBitsKHR.html">VkVideoEncodeCapabilityFlagBitsKHR</see> - Video encode capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkVideoEncodeCapabilitiesKHR::flags</c>,
    ///         indicating the encoding tools supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeCapabilityFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_CAPABILITY_PRECEDING_EXTERNALLY_ENCODED_BYTES_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_CAPABILITY_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_DETECTION_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_CAPABILITY_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x00000004,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_CAPABILITY_EMPHASIS_MAP_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeCapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeCapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PrecedingExternallyEncodedBytesBitKHR</c>  specifies that the implementation supports the use of <c>VkVideoEncodeInfoKHR::precedingExternallyEncodedBytes</c>.
        /// </summary>
        PrecedingExternallyEncodedBytesBitKHR = 0x00000001,

        /// <summary>
        ///     <c>InsufficientBitstreamBufferRangeDetectionBitKHR</c>  specifies that the implementation is able to detect and report when the destination video bitstream buffer range provided by the application is not sufficiently large to fit the encoded bitstream data produced by a video encode operation by reporting the <c>VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR</c> <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#query-result-status-codes">query result status code^</see>. + [NOTE]
        /// </summary>
        InsufficientBitstreamBufferRangeDetectionBitKHR = 0x00000002,

        /// <summary>
        ///     <c>QuantizationDeltaMapBitKHR</c>
        /// </summary>
        QuantizationDeltaMapBitKHR = 0x00000004,

        /// <summary>
        ///     <c>EmphasisMapBitKHR</c>
        /// </summary>
        EmphasisMapBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
