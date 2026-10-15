namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlFlagBitsKHR.html">VkVideoEncodeH264RateControlFlagBitsKHR</see> - H.264 encode rate control bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkVideoEncodeH264RateControlInfoKHR::flags</c>, specifying H.264
    ///         rate control flags, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef enum VkVideoEncodeH264RateControlFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR = 0x00000010,
    ///         } VkVideoEncodeH264RateControlFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH264RateControlFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AttemptHrdComplianceBitKHR</c>  specifies that rate control <i>should</i> attempt to produce an HRD compliant bitstream, as defined in annex C of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        AttemptHrdComplianceBitKHR = 0x00000001,

        /// <summary>
        ///     <c>RegularGopBitKHR</c> specifies that the application intends to use a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-regular-gop">regular GOP structure^</see> according to the parameters specified in the <c>gopFrameCount</c>, <c>idrPeriod</c>, and <c>consecutiveBFrameCount</c> members of the <c>VkVideoEncodeH264RateControlInfoKHR</c> structure.
        /// </summary>
        RegularGopBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ReferencePatternFlatBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-ref-pattern-flat">flat reference pattern^</see> in the GOP.
        /// </summary>
        ReferencePatternFlatBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ReferencePatternDyadicBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-ref-pattern-dyadic">dyadic reference pattern^</see> in the GOP.
        /// </summary>
        ReferencePatternDyadicBitKHR = 0x00000008,

        /// <summary>
        ///     <c>TemporalLayerPatternDyadicBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-layer-pattern-dyadic">dyadic temporal layer pattern^</see>.
        /// </summary>
        TemporalLayerPatternDyadicBitKHR = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
