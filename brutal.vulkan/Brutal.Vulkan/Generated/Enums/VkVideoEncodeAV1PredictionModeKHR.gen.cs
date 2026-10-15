namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1PredictionModeKHR.html">VkVideoEncodeAV1PredictionModeKHR</see> - AV1 encode prediction mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible AV1 encode prediction modes are as follows:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1PredictionModeKHR {
    ///             VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR = 0,
    ///             VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR = 1,
    ///             VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR = 2,
    ///             VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR = 3,
    ///         } VkVideoEncodeAV1PredictionModeKHR;
    ///     </code>
    /// </remarks>
    public enum VkVideoEncodeAV1PredictionModeKHR : int
    {
        /// <summary>
        ///     <c>IntraOnlyKHR</c> specifies the use of _intra-only prediction mode_, used when encoding AV1 frames of type <c>STD_VIDEO_AV1_FRAME_TYPE_KEY</c> or <c>STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY</c>.
        /// </summary>
        IntraOnlyKHR = 0,

        /// <summary>
        ///     <c>SingleReferenceKHR</c> specifies the use of <i>single reference prediction mode</i>, used when encoding AV1 frames of type <c>STD_VIDEO_AV1_FRAME_TYPE_INTER</c> or <c>STD_VIDEO_AV1_FRAME_TYPE_SWITCH</c> with <c>reference_select</c>, as defined in section 6.8.23 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, equal to 0. When using this prediction mode, the application <i>must</i> specify a reference picture for at least one <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference name^</see> in <c>VkVideoEncodeAV1PictureInfoKHR::referenceNameSlotIndices</c> that is supported by the implementation, as reported in <c>VkVideoEncodeAV1CapabilitiesKHR::singleReferenceNameMask</c>.
        /// </summary>
        SingleReferenceKHR = 1,

        /// <summary>
        ///     <c>UnidirectionalCompoundKHR</c>  specifies the use of <i>unidirectional compound prediction mode</i>, used when encoding AV1 frames of type <c>STD_VIDEO_AV1_FRAME_TYPE_INTER</c> or <c>STD_VIDEO_AV1_FRAME_TYPE_SWITCH</c> with <c>reference_select</c>, as defined in section 6.8.23 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, equal to 1, and both <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">reference names^</see> used for prediction are from the same reference frame group, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>. When using this prediction mode, the application <i>must</i> specify a reference picture for at least two <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> in <c>VkVideoEncodeAV1PictureInfoKHR::referenceNameSlotIndices</c> that is supported by the implementation, as reported in <c>VkVideoEncodeAV1CapabilitiesKHR::unidirectionalCompoundReferenceNameMask</c>, where those two reference names are one of the allowed pairs of reference names, as defined in section 5.11.25 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, listed below:
        /// </summary>
        UnidirectionalCompoundKHR = 2,

        /// <summary>
        ///     <c>BidirectionalCompoundKHR</c>  specifies the use of <i>bidirectional compound prediction mode</i>, used when encoding AV1 frames of type <c>STD_VIDEO_AV1_FRAME_TYPE_INTER</c> or <c>STD_VIDEO_AV1_FRAME_TYPE_SWITCH</c> with <c>reference_select</c>, as defined in section 6.8.23 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, equal to 1, and the two <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">reference names^</see> used for prediction are from different reference frame groups, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>. When using this prediction mode, the application <i>must</i> specify a reference picture for at least one <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference name^</see> from each reference frame group in <c>VkVideoEncodeAV1PictureInfoKHR::referenceNameSlotIndices</c> that is supported by the implementation, as reported in <c>VkVideoEncodeAV1CapabilitiesKHR::bidirectionalCompoundReferenceNameMask</c>.  The effective prediction mode used to encode individual AV1 mode info blocks may: use simpler prediction modes than the one set by the application for the frame, as allowed by the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, in particular:
        /// </summary>
        BidirectionalCompoundKHR = 3,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
