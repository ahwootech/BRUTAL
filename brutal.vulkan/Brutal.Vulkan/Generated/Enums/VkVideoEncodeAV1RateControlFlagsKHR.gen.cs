namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlFlagBitsKHR.html">VkVideoEncodeAV1RateControlFlagBitsKHR</see> - AV1 encode rate control bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkVideoEncodeAV1RateControlInfoKHR::flags</c>, specifying AV1 rate
    ///         control flags, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1RateControlFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REGULAR_GOP_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeAV1RateControlFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeAV1RateControlFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>RegularGopBitKHR</c> specifies that the application intends to use a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-regular-gop">regular GOP structure^</see> according to the parameters specified in the <c>gopFrameCount</c> and <c>keyFramePeriod</c> members of the <c>VkVideoEncodeAV1RateControlInfoKHR</c> structure.
        /// </summary>
        RegularGopBitKHR = 0x00000001,

        /// <summary>
        ///     <c>TemporalLayerPatternDyadicBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-layer-pattern-dyadic">dyadic temporal layer pattern^</see>.
        /// </summary>
        TemporalLayerPatternDyadicBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ReferencePatternFlatBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-ref-pattern-flat">flat reference pattern^</see> in the GOP.
        /// </summary>
        ReferencePatternFlatBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ReferencePatternDyadicBitKHR</c>  specifies that the application intends to follow a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-ref-pattern-dyadic">dyadic reference pattern^</see> in the GOP.
        /// </summary>
        ReferencePatternDyadicBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
