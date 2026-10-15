namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilityFlagBitsKHR.html">VkVideoEncodeAV1CapabilityFlagBitsKHR</see> - AV1 encode capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeAV1CapabilitiesKHR::flags</c>, indicating the AV1
    ///         encoding capabilities supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1CapabilityFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_PER_RATE_CONTROL_GROUP_MIN_MAX_Q_INDEX_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_GENERATE_OBU_EXTENSION_HEADER_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_PRIMARY_REFERENCE_CDF_ONLY_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR = 0x00000008,
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_MOTION_VECTOR_SCALING_BIT_KHR = 0x00000010,
    ///             // Provided by VK_KHR_video_encode_av1 with VK_KHR_video_encode_intra_refresh
    ///             VK_VIDEO_ENCODE_AV1_CAPABILITY_COMPOUND_PREDICTION_INTRA_REFRESH_BIT_KHR = 0x00000020,
    ///         } VkVideoEncodeAV1CapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeAV1CapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PerRateControlGroupMinMaxQIndexBitKHR</c>  specifies support for specifying different quantizer index values in the members of <c>VkVideoEncodeAV1QIndexKHR</c>.
        /// </summary>
        PerRateControlGroupMinMaxQIndexBitKHR = 0x00000001,

        /// <summary>
        ///     <c>GenerateObuExtensionHeaderBitKHR</c>  specifies support for generating OBU extension headers, as defined in section 5.3.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        GenerateObuExtensionHeaderBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PrimaryReferenceCdfOnlyBitKHR</c>  specifies support for using the primary reference frame indicated by the value of <c>StdVideoEncodeAV1PictureInfo::primary_ref_frame</c> in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-picture-info">AV1 picture information^</see> only for CDF data reference, as defined in section 6.8.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        PrimaryReferenceCdfOnlyBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FrameSizeOverrideBitKHR</c>  specifies support for encoding a picture with a frame size different from the maximum frame size defined in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-active-sequence-header">active AV1 sequence header^</see>. If this capability is not supported, then <c>frame_size_override_flag</c> <i>must</i> not be set in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-picture-info">AV1 picture information^</see> of the encoded frame and the coded extent of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see> <i>must</i> match the maximum coded extent allowed by the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-active-sequence-header">active AV1 sequence header^</see>, i.e. <c>(<c>max_frame_width_minus_1</c> {plus} 1, <c>max_frame_height_minus_1</c> {plus} 1)</c>.
        /// </summary>
        FrameSizeOverrideBitKHR = 0x00000008,

        /// <summary>
        ///     <c>MotionVectorScalingBitKHR</c>  specifies support for motion vector scaling, as defined in section 7.11.3.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>. If this capability is not supported, then the coded extent of all <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see> <i>must</i> match the coded extent of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see>. This capability may: only be supported by a video profile when <c>VK_VIDEO_ENCODE_AV1_CAPABILITY_FRAME_SIZE_OVERRIDE_BIT_KHR</c> is also supported.
        /// </summary>
        MotionVectorScalingBitKHR = 0x00000010,

        /// <summary>
        ///     <c>CompoundPredictionIntraRefreshBitKHR</c>
        /// </summary>
        CompoundPredictionIntraRefreshBitKHR = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
