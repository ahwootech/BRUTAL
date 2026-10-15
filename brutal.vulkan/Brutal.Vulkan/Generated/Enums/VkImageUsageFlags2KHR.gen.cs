namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlagBits2KHR.html">VkImageUsageFlagBits2KHR</see> - Bitmask specifying intended use of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkImageUsageFlags2CreateInfoKHR::usage</c>, specifying intended
    ///         usage of an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         // Flag bits for VkImageUsageFlagBits2KHR
    ///         typedef VkFlags64 VkImageUsageFlagBits2KHR;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_TRANSFER_SRC_BIT_KHR = 0x00000001ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_TRANSFER_DST_BIT_KHR = 0x00000002ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_SAMPLED_BIT_KHR = 0x00000004ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_STORAGE_BIT_KHR = 0x00000008ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_COLOR_ATTACHMENT_BIT_KHR = 0x00000010ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR = 0x00000020ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_TRANSIENT_ATTACHMENT_BIT_KHR = 0x00000040ULL;
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_INPUT_ATTACHMENT_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_fragment_shading_rate
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_fragment_density_map
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x00000200ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_decode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_DECODE_DST_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_decode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_decode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_DECODE_DPB_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR = 0x00002000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_queue
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_ENCODE_DPB_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_HUAWEI_invocation_mask
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_INVOCATION_MASK_BIT_HUAWEI = 0x00040000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_attachment_feedback_loop_layout
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x00080000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_QCOM_image_processing
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_SAMPLE_WEIGHT_BIT_QCOM = 0x00100000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_QCOM_image_processing
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_SAMPLE_BLOCK_MATCH_BIT_QCOM = 0x00200000ULL;
    ///             // Provided by VK_VERSION_1_4 with VK_KHR_extended_flags
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_HOST_TRANSFER_BIT_KHR = 0x00400000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_ARM_tensors
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_TENSOR_ALIASING_BIT_ARM = 0x00800000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_quantization_map
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x02000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_quantization_map
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR = 0x04000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_QCOM_tile_memory_heap
    ///             static const VkImageUsageFlagBits2KHR VK_IMAGE_USAGE_2_TILE_MEMORY_BIT_QCOM = 0x08000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkImageUsageFlags2KHR : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TransferSrcBitKHR</c> specifies that the image <i>can</i> be used as the source of a transfer command.
        /// </summary>
        TransferSrcBitKHR = 0x00000001,

        /// <summary>
        ///     <c>TransferDstBitKHR</c> specifies that the image <i>can</i> be used as the destination of a transfer command.
        /// </summary>
        TransferDstBitKHR = 0x00000002,

        /// <summary>
        ///     <c>SampledBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying a <c>VkDescriptorSet</c> slot either of type <c>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</c> or <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c>, and be sampled by a shader.
        /// </summary>
        SampledBitKHR = 0x00000004,

        /// <summary>
        ///     <c>StorageBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying a <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</c>.
        /// </summary>
        StorageBitKHR = 0x00000008,

        /// <summary>
        ///     <c>ColorAttachmentBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a color or resolve attachment in a <c>VkFramebuffer</c>.
        /// </summary>
        ColorAttachmentBitKHR = 0x00000010,

        /// <summary>
        ///     <c>DepthStencilAttachmentBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a depth/stencil attachment in a <c>VkFramebuffer</c>.
        /// </summary>
        DepthStencilAttachmentBitKHR = 0x00000020,

        /// <summary>
        ///     <c>TransientAttachmentBitKHR</c> specifies that implementations may: support using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#memory">memory allocations^</see> with the <c>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</c> to back an image with this usage. This bit <i>can</i> be set for any image that <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a color, resolve, depth/stencil, or input attachment.
        /// </summary>
        TransientAttachmentBitKHR = 0x00000040,

        /// <summary>
        ///     <c>InputAttachmentBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</c>; be read from a shader as an input attachment; and be used as an input attachment in a framebuffer.
        /// </summary>
        InputAttachmentBitKHR = 0x00000080,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x00000100,

        /// <summary>
        ///     <c>FragmentDensityMapBitEXT</c>
        /// </summary>
        FragmentDensityMapBitEXT = 0x00000200,

        /// <summary>
        ///     <c>VideoDecodeDstBitKHR</c>
        /// </summary>
        VideoDecodeDstBitKHR = 0x00000400,

        /// <summary>
        ///     <c>VideoDecodeSrcBitKHR</c>
        /// </summary>
        VideoDecodeSrcBitKHR = 0x00000800,

        /// <summary>
        ///     <c>VideoDecodeDpbBitKHR</c>
        /// </summary>
        VideoDecodeDpbBitKHR = 0x00001000,

        /// <summary>
        ///     <c>VideoEncodeDstBitKHR</c>
        /// </summary>
        VideoEncodeDstBitKHR = 0x00002000,

        /// <summary>
        ///     <c>VideoEncodeSrcBitKHR</c>
        /// </summary>
        VideoEncodeSrcBitKHR = 0x00004000,

        /// <summary>
        ///     <c>VideoEncodeDpbBitKHR</c>
        /// </summary>
        VideoEncodeDpbBitKHR = 0x00008000,

        /// <summary>
        ///     <c>InvocationMaskBitHUAWEI</c>
        /// </summary>
        InvocationMaskBitHUAWEI = 0x00040000,

        /// <summary>
        ///     <c>AttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        AttachmentFeedbackLoopBitEXT = 0x00080000,

        /// <summary>
        ///     <c>SampleWeightBitQCOM</c>
        /// </summary>
        SampleWeightBitQCOM = 0x00100000,

        /// <summary>
        ///     <c>SampleBlockMatchBitQCOM</c>
        /// </summary>
        SampleBlockMatchBitQCOM = 0x00200000,

        /// <summary>
        ///     <c>HostTransferBitKHR</c>
        /// </summary>
        HostTransferBitKHR = 0x00400000,

        /// <summary>
        ///     <c>TensorAliasingBitARM</c>
        /// </summary>
        TensorAliasingBitARM = 0x00800000,

        /// <summary>
        ///     <c>VideoEncodeQuantizationDeltaMapBitKHR</c>
        /// </summary>
        VideoEncodeQuantizationDeltaMapBitKHR = 0x02000000,

        /// <summary>
        ///     <c>VideoEncodeEmphasisMapBitKHR</c>
        /// </summary>
        VideoEncodeEmphasisMapBitKHR = 0x04000000,

        /// <summary>
        ///     <c>TileMemoryBitQCOM</c>
        /// </summary>
        TileMemoryBitQCOM = 0x08000000,
    }
}
