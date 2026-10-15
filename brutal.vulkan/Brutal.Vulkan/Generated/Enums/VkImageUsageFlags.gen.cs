namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlagBits.html">VkImageUsageFlagBits</see> - Bitmask specifying intended usage of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///     </para>
    ///     <para>
    ///         * <c>VkImageCreateInfo::usage</c>
    ///     </para>
    ///     <para>
    ///         specify intended usage of an image, and are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageUsageFlagBits {
    ///             VK_IMAGE_USAGE_TRANSFER_SRC_BIT = 0x00000001,
    ///             VK_IMAGE_USAGE_TRANSFER_DST_BIT = 0x00000002,
    ///             VK_IMAGE_USAGE_SAMPLED_BIT = 0x00000004,
    ///             VK_IMAGE_USAGE_STORAGE_BIT = 0x00000008,
    ///             VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 0x00000010,
    ///             VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x00000020,
    ///             VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 0x00000040,
    ///             VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 0x00000080,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_IMAGE_USAGE_HOST_TRANSFER_BIT = 0x00400000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR = 0x00000400,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR = 0x00000800,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR = 0x00001000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x00000200,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00000100,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR = 0x00002000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = 0x00004000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR = 0x00008000,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x00080000,
    ///             // Provided by VK_HUAWEI_invocation_mask
    ///             VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI = 0x00040000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM = 0x00100000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM = 0x00200000,
    ///             // Provided by VK_ARM_tensors
    ///             VK_IMAGE_USAGE_TENSOR_ALIASING_BIT_ARM = 0x00800000,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_IMAGE_USAGE_TILE_MEMORY_BIT_QCOM = 0x08000000,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_IMAGE_USAGE_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x02000000,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_IMAGE_USAGE_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR = 0x04000000,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT = VK_IMAGE_USAGE_HOST_TRANSFER_BIT,
    ///         } VkImageUsageFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageUsageFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TransferSrcBit</c> specifies that the image <i>can</i> be used as the source of a transfer command.
        /// </summary>
        TransferSrcBit = 0x00000001,

        /// <summary>
        ///     <c>TransferDstBit</c> specifies that the image <i>can</i> be used as the destination of a transfer command.
        /// </summary>
        TransferDstBit = 0x00000002,

        /// <summary>
        ///     <c>SampledBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying a <c>VkDescriptorSet</c> slot either of type <c>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</c> or <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c>, and be sampled by a shader.
        /// </summary>
        SampledBit = 0x00000004,

        /// <summary>
        ///     <c>StorageBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying a <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</c>.
        /// </summary>
        StorageBit = 0x00000008,

        /// <summary>
        ///     <c>ColorAttachmentBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a color or resolve attachment in a <c>VkFramebuffer</c>.
        /// </summary>
        ColorAttachmentBit = 0x00000010,

        /// <summary>
        ///     <c>DepthStencilAttachmentBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a depth/stencil attachment in a <c>VkFramebuffer</c>.
        /// </summary>
        DepthStencilAttachmentBit = 0x00000020,

        /// <summary>
        ///     <c>TransientAttachmentBit</c> specifies that implementations may: support using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#memory">memory allocations^</see> with the <c>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</c> to back an image with this usage. This bit <i>can</i> be set for any image that <i>can</i> be used to create a <c>VkImageView</c> suitable for use as a color, resolve, depth/stencil, or input attachment.
        /// </summary>
        TransientAttachmentBit = 0x00000040,

        /// <summary>
        ///     <c>InputAttachmentBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> suitable for occupying <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</c>; be read from a shader as an input attachment; and be used as an input attachment in a framebuffer.
        /// </summary>
        InputAttachmentBit = 0x00000080,

        /// <summary>
        ///     <c>HostTransferBit</c>
        /// </summary>
        HostTransferBit = 0x00400000,

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
        ///     <c>FragmentDensityMapBitEXT</c>
        /// </summary>
        FragmentDensityMapBitEXT = 0x00000200,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x00000100,

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
        ///     <c>AttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        AttachmentFeedbackLoopBitEXT = 0x00080000,

        /// <summary>
        ///     <c>InvocationMaskBitHUAWEI</c>
        /// </summary>
        InvocationMaskBitHUAWEI = 0x00040000,

        /// <summary>
        ///     <c>SampleWeightBitQCOM</c>
        /// </summary>
        SampleWeightBitQCOM = 0x00100000,

        /// <summary>
        ///     <c>SampleBlockMatchBitQCOM</c>
        /// </summary>
        SampleBlockMatchBitQCOM = 0x00200000,

        /// <summary>
        ///     <c>TensorAliasingBitARM</c>
        /// </summary>
        TensorAliasingBitARM = 0x00800000,

        /// <summary>
        ///     <c>TileMemoryBitQCOM</c>
        /// </summary>
        TileMemoryBitQCOM = 0x08000000,

        /// <summary>
        ///     <c>VideoEncodeQuantizationDeltaMapBitKHR</c>
        /// </summary>
        VideoEncodeQuantizationDeltaMapBitKHR = 0x02000000,

        /// <summary>
        ///     <c>VideoEncodeEmphasisMapBitKHR</c>
        /// </summary>
        VideoEncodeEmphasisMapBitKHR = 0x04000000,

        /// <summary>
        ///     <c>ShadingRateImageBitNV</c>
        /// </summary>
        ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,

        /// <summary>
        ///     <c>HostTransferBitEXT</c>
        /// </summary>
        HostTransferBitEXT = HostTransferBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
