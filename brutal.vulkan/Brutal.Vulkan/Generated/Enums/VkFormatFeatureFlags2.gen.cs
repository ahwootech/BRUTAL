namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits2.html">VkFormatFeatureFlagBits2</see> - Bitmask specifying features supported by a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the <c>VkFormatProperties3</c> features
    ///         <c>linearTilingFeatures</c>, <c>optimalTilingFeatures</c>, and
    ///         <c>bufferFeatures</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         // Flag bits for VkFormatFeatureFlagBits2
    ///         typedef VkFlags64 VkFormatFeatureFlagBits2;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT = 0x00000001ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT = 0x00000002ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT = 0x00000004ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT = 0x00000008ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT = 0x00000010ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x00000020ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT = 0x00000040ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT = 0x00000080ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT = 0x00000100ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT = 0x00000200ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLIT_SRC_BIT = 0x00000400ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLIT_DST_BIT = 0x00000800ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 0x00001000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT = 0x00004000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT = 0x00008000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 0x00010000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT = 0x00020000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 0x00040000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 0x00080000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 0x00100000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x00200000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DISJOINT_BIT = 0x00400000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT = 0x00800000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT = 0x80000000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT = 0x100000000ULL;
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT = 0x200000000ULL;
    ///             // Provided by VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT = 0x00002000ULL;
    ///             // Provided by VK_VERSION_1_4
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT = 0x400000000000ULL;
    ///             // Provided by VK_KHR_video_decode_queue with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR = 0x02000000ULL;
    ///             // Provided by VK_KHR_video_decode_queue with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR = 0x04000000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 0x20000000ULL;
    ///             // Provided by VK_EXT_fragment_density_map with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x01000000ULL;
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x40000000ULL;
    ///             // Provided by VK_EXT_host_image_copy
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT = 0x400000000000ULL;
    ///             // Provided by VK_KHR_video_encode_queue with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR = 0x08000000ULL;
    ///             // Provided by VK_KHR_video_encode_queue with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR = 0x10000000ULL;
    ///             // Provided by VK_QCOM_image_processing with VK_QCOM_image_processing3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLOCK_MATCHING_SXD_BIT_QCOM = 0x100000000000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR = 0x00000001ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR = 0x00000002ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR = 0x00000004ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = 0x00000008ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT_KHR = 0x00000020ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR = 0x00000200ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = 0x00020000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = 0x00040000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = 0x00080000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = 0x00100000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR = 0x00200000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR = 0x00400000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR = 0x00800000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR = 0x80000000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR = 0x100000000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR = 0x200000000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2 with VK_VERSION_1_2 or VK_EXT_sampler_filter_minmax
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR = 0x00010000ULL;
    ///             // Provided by VK_KHR_format_feature_flags2 with VK_EXT_filter_cubic or VK_IMG_filter_cubic
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = 0x00002000ULL;
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_RADIUS_BUFFER_BIT_NV = 0x8000000000000ULL;
    ///             // Provided by VK_NV_linear_color_attachment with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV = 0x4000000000ULL;
    ///             // Provided by VK_QCOM_image_processing with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM = 0x400000000ULL;
    ///             // Provided by VK_QCOM_image_processing with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM = 0x800000000ULL;
    ///             // Provided by VK_QCOM_image_processing with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM = 0x1000000000ULL;
    ///             // Provided by VK_QCOM_image_processing with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM = 0x2000000000ULL;
    ///             // Provided by VK_ARM_tensors
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TENSOR_SHADER_BIT_ARM = 0x8000000000ULL;
    ///             // Provided by VK_ARM_tensors
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TENSOR_IMAGE_ALIASING_BIT_ARM = 0x80000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV = 0x10000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV = 0x20000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV = 0x40000000000ULL;
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_TENSOR_DATA_GRAPH_BIT_ARM = 0x1000000000000ULL;
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_COPY_IMAGE_INDIRECT_DST_BIT_KHR = 0x800000000000000ULL;
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x2000000000000ULL;
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR = 0x4000000000000ULL;
    ///             // Provided by VK_IMG_filter_linear_2d
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_2D_BIT_IMG = 0x200000000000ULL;
    ///             // Provided by VK_KHR_maintenance10 with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_COMPUTE_QUEUE_BIT_KHR = 0x10000000000000ULL;
    ///             // Provided by VK_KHR_maintenance10 with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DEPTH_COPY_ON_TRANSFER_QUEUE_BIT_KHR = 0x20000000000000ULL;
    ///             // Provided by VK_KHR_maintenance10 with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_COMPUTE_QUEUE_BIT_KHR = 0x40000000000000ULL;
    ///             // Provided by VK_KHR_maintenance10 with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_STENCIL_COPY_ON_TRANSFER_QUEUE_BIT_KHR = 0x80000000000000ULL;
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DATA_GRAPH_OPTICAL_FLOW_IMAGE_BIT_ARM = 0x100000000000000ULL;
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DATA_GRAPH_OPTICAL_FLOW_VECTOR_BIT_ARM = 0x200000000000000ULL;
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             static const VkFormatFeatureFlagBits2 VK_FORMAT_FEATURE_2_DATA_GRAPH_OPTICAL_FLOW_COST_BIT_ARM = 0x400000000000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkFormatFeatureFlags2 : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SampledImageBit</c> specifies that an image view <i>can</i> be <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sampledimage">sampled from^</see>.
        /// </summary>
        SampledImageBit = 0x00000001,

        /// <summary>
        ///     <c>StorageImageBit</c> specifies that an image view <i>can</i> be used as a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image^</see>.
        /// </summary>
        StorageImageBit = 0x00000002,

        /// <summary>
        ///     <c>StorageImageAtomicBit</c> specifies that an image view <i>can</i> be used as storage image that supports atomic operations.
        /// </summary>
        StorageImageAtomicBit = 0x00000004,

        /// <summary>
        ///     <c>UniformTexelBufferBit</c>
        /// </summary>
        UniformTexelBufferBit = 0x00000008,

        /// <summary>
        ///     <c>StorageTexelBufferBit</c>
        /// </summary>
        StorageTexelBufferBit = 0x00000010,

        /// <summary>
        ///     <c>StorageTexelBufferAtomicBit</c>
        /// </summary>
        StorageTexelBufferAtomicBit = 0x00000020,

        /// <summary>
        ///     <c>VertexBufferBit</c>
        /// </summary>
        VertexBufferBit = 0x00000040,

        /// <summary>
        ///     <c>ColorAttachmentBit</c> specifies that an image view <i>can</i> be used as a framebuffer color attachment and as an input attachment.
        /// </summary>
        ColorAttachmentBit = 0x00000080,

        /// <summary>
        ///     <c>ColorAttachmentBlendBit</c> specifies that an image view <i>can</i> be used as a framebuffer color attachment that supports blending.
        /// </summary>
        ColorAttachmentBlendBit = 0x00000100,

        /// <summary>
        ///     <c>DepthStencilAttachmentBit</c> specifies that an image view <i>can</i> be used as a framebuffer depth/stencil attachment and as an input attachment.
        /// </summary>
        DepthStencilAttachmentBit = 0x00000200,

        /// <summary>
        ///     <c>BlitSrcBit</c> specifies that an image <i>can</i> be used as the <c>srcImage</c> for <c>vkCmdBlitImage</c>.
        /// </summary>
        BlitSrcBit = 0x00000400,

        /// <summary>
        ///     <c>BlitDstBit</c> specifies that an image <i>can</i> be used as the <c>dstImage</c> for <c>vkCmdBlitImage</c>.
        /// </summary>
        BlitDstBit = 0x00000800,

        /// <summary>
        ///     <c>SampledImageFilterLinearBit</c> specifies that if <c>VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT</c> is also set, an image view <i>can</i> be used with a sampler that has either of <c>magFilter</c> or <c>minFilter</c> set to <c>VK_FILTER_LINEAR</c>, or <c>mipmapMode</c> set to <c>VK_SAMPLER_MIPMAP_MODE_LINEAR</c>. If <c>VK_FORMAT_FEATURE_2_BLIT_SRC_BIT</c> is also set, an image can be used as the <c>srcImage</c> for <c>vkCmdBlitImage</c> with a <c>filter</c> of <c>VK_FILTER_LINEAR</c>. This bit <i>must</i> only be exposed for formats that also support the <c>VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT</c> or <c>VK_FORMAT_FEATURE_2_BLIT_SRC_BIT</c>. + If the format being queried is a depth/stencil format, this bit only specifies that the depth aspect (not the stencil aspect) of an image of this format supports linear filtering. Where depth comparison is supported it may: be linear filtered whether this bit is present or not, but where this bit is not present the filtered value may: be computed in an implementation-dependent manner which differs from the normal rules of linear filtering. The resulting value <i>must</i> be in the range <c>[0,1]</c> and <i>should</i> be proportional to, or a weighted average of, the number of comparison passes or failures.
        /// </summary>
        SampledImageFilterLinearBit = 0x00001000,

        /// <summary>
        ///     <c>TransferSrcBit</c>
        /// </summary>
        TransferSrcBit = 0x00004000,

        /// <summary>
        ///     <c>TransferDstBit</c>
        /// </summary>
        TransferDstBit = 0x00008000,

        /// <summary>
        ///     <c>SampledImageFilterMinmaxBit</c>
        /// </summary>
        SampledImageFilterMinmaxBit = 0x00010000,

        /// <summary>
        ///     <c>MidpointChromaSamplesBit</c>
        /// </summary>
        MidpointChromaSamplesBit = 0x00020000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionLinearFilterBit</c>
        /// </summary>
        SampledImageYCbCrConversionLinearFilterBit = 0x00040000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionSeparateReconstructionFilterBit</c>
        /// </summary>
        SampledImageYCbCrConversionSeparateReconstructionFilterBit = 0x00080000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitBit</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitBit = 0x00100000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitForceableBit</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitForceableBit = 0x00200000,

        /// <summary>
        ///     <c>DisjointBit</c>
        /// </summary>
        DisjointBit = 0x00400000,

        /// <summary>
        ///     <c>CositedChromaSamplesBit</c>
        /// </summary>
        CositedChromaSamplesBit = 0x00800000,

        /// <summary>
        ///     <c>StorageReadWithoutFormatBit</c>
        /// </summary>
        StorageReadWithoutFormatBit = 0x80000000,

        /// <summary>
        ///     <c>StorageWriteWithoutFormatBit</c>
        /// </summary>
        StorageWriteWithoutFormatBit = 0x100000000,

        /// <summary>
        ///     <c>SampledImageDepthComparisonBit</c>
        /// </summary>
        SampledImageDepthComparisonBit = 0x200000000,

        /// <summary>
        ///     <c>SampledImageFilterCubicBit</c>
        /// </summary>
        SampledImageFilterCubicBit = 0x00002000,

        /// <summary>
        ///     <c>HostImageTransferBit</c>
        /// </summary>
        HostImageTransferBit = 0x400000000000,

        /// <summary>
        ///     <c>VideoDecodeOutputBitKHR</c>
        /// </summary>
        VideoDecodeOutputBitKHR = 0x02000000,

        /// <summary>
        ///     <c>VideoDecodeDpbBitKHR</c>
        /// </summary>
        VideoDecodeDpbBitKHR = 0x04000000,

        /// <summary>
        ///     <c>AccelerationStructureVertexBufferBitKHR</c>
        /// </summary>
        AccelerationStructureVertexBufferBitKHR = 0x20000000,

        /// <summary>
        ///     <c>FragmentDensityMapBitEXT</c>
        /// </summary>
        FragmentDensityMapBitEXT = 0x01000000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x40000000,

        /// <summary>
        ///     <c>HostImageTransferBitEXT</c>
        /// </summary>
        HostImageTransferBitEXT = 0x400000000000,

        /// <summary>
        ///     <c>VideoEncodeInputBitKHR</c>
        /// </summary>
        VideoEncodeInputBitKHR = 0x08000000,

        /// <summary>
        ///     <c>VideoEncodeDpbBitKHR</c>
        /// </summary>
        VideoEncodeDpbBitKHR = 0x10000000,

        /// <summary>
        ///     <c>BlockMatchingSxdBitQCOM</c>
        /// </summary>
        BlockMatchingSxdBitQCOM = 0x100000000000,

        /// <summary>
        ///     <c>SampledImageBitKHR</c>
        /// </summary>
        SampledImageBitKHR = 0x00000001,

        /// <summary>
        ///     <c>StorageImageBitKHR</c>
        /// </summary>
        StorageImageBitKHR = 0x00000002,

        /// <summary>
        ///     <c>StorageImageAtomicBitKHR</c>
        /// </summary>
        StorageImageAtomicBitKHR = 0x00000004,

        /// <summary>
        ///     <c>UniformTexelBufferBitKHR</c>
        /// </summary>
        UniformTexelBufferBitKHR = 0x00000008,

        /// <summary>
        ///     <c>StorageTexelBufferBitKHR</c>
        /// </summary>
        StorageTexelBufferBitKHR = 0x00000010,

        /// <summary>
        ///     <c>StorageTexelBufferAtomicBitKHR</c>
        /// </summary>
        StorageTexelBufferAtomicBitKHR = 0x00000020,

        /// <summary>
        ///     <c>VertexBufferBitKHR</c>
        /// </summary>
        VertexBufferBitKHR = 0x00000040,

        /// <summary>
        ///     <c>ColorAttachmentBitKHR</c>
        /// </summary>
        ColorAttachmentBitKHR = 0x00000080,

        /// <summary>
        ///     <c>ColorAttachmentBlendBitKHR</c>
        /// </summary>
        ColorAttachmentBlendBitKHR = 0x00000100,

        /// <summary>
        ///     <c>DepthStencilAttachmentBitKHR</c>
        /// </summary>
        DepthStencilAttachmentBitKHR = 0x00000200,

        /// <summary>
        ///     <c>BlitSrcBitKHR</c>
        /// </summary>
        BlitSrcBitKHR = 0x00000400,

        /// <summary>
        ///     <c>BlitDstBitKHR</c>
        /// </summary>
        BlitDstBitKHR = 0x00000800,

        /// <summary>
        ///     <c>SampledImageFilterLinearBitKHR</c>
        /// </summary>
        SampledImageFilterLinearBitKHR = 0x00001000,

        /// <summary>
        ///     <c>TransferSrcBitKHR</c>
        /// </summary>
        TransferSrcBitKHR = 0x00004000,

        /// <summary>
        ///     <c>TransferDstBitKHR</c>
        /// </summary>
        TransferDstBitKHR = 0x00008000,

        /// <summary>
        ///     <c>MidpointChromaSamplesBitKHR</c>
        /// </summary>
        MidpointChromaSamplesBitKHR = 0x00020000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionLinearFilterBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionLinearFilterBitKHR = 0x00040000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionSeparateReconstructionFilterBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionSeparateReconstructionFilterBitKHR = 0x00080000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitBitKHR = 0x00100000,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitForceableBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitForceableBitKHR = 0x00200000,

        /// <summary>
        ///     <c>DisjointBitKHR</c>
        /// </summary>
        DisjointBitKHR = 0x00400000,

        /// <summary>
        ///     <c>CositedChromaSamplesBitKHR</c>
        /// </summary>
        CositedChromaSamplesBitKHR = 0x00800000,

        /// <summary>
        ///     <c>StorageReadWithoutFormatBitKHR</c>
        /// </summary>
        StorageReadWithoutFormatBitKHR = 0x80000000,

        /// <summary>
        ///     <c>StorageWriteWithoutFormatBitKHR</c>
        /// </summary>
        StorageWriteWithoutFormatBitKHR = 0x100000000,

        /// <summary>
        ///     <c>SampledImageDepthComparisonBitKHR</c>
        /// </summary>
        SampledImageDepthComparisonBitKHR = 0x200000000,

        /// <summary>
        ///     <c>SampledImageFilterMinmaxBitKHR</c>
        /// </summary>
        SampledImageFilterMinmaxBitKHR = 0x00010000,

        /// <summary>
        ///     <c>SampledImageFilterCubicBitEXT</c>
        /// </summary>
        SampledImageFilterCubicBitEXT = 0x00002000,

        /// <summary>
        ///     <c>AccelerationStructureRadiusBufferBitNV</c>
        /// </summary>
        AccelerationStructureRadiusBufferBitNV = 0x8000000000000,

        /// <summary>
        ///     <c>LinearColorAttachmentBitNV</c>
        /// </summary>
        LinearColorAttachmentBitNV = 0x4000000000,

        /// <summary>
        ///     <c>WeightImageBitQCOM</c>
        /// </summary>
        WeightImageBitQCOM = 0x400000000,

        /// <summary>
        ///     <c>WeightSampledImageBitQCOM</c>
        /// </summary>
        WeightSampledImageBitQCOM = 0x800000000,

        /// <summary>
        ///     <c>BlockMatchingBitQCOM</c>
        /// </summary>
        BlockMatchingBitQCOM = 0x1000000000,

        /// <summary>
        ///     <c>BoxFilterSampledBitQCOM</c>
        /// </summary>
        BoxFilterSampledBitQCOM = 0x2000000000,

        /// <summary>
        ///     <c>TensorShaderBitARM</c>
        /// </summary>
        TensorShaderBitARM = 0x8000000000,

        /// <summary>
        ///     <c>TensorImageAliasingBitARM</c>
        /// </summary>
        TensorImageAliasingBitARM = 0x80000000000,

        /// <summary>
        ///     <c>OpticalFlowImageBitNV</c>
        /// </summary>
        OpticalFlowImageBitNV = 0x10000000000,

        /// <summary>
        ///     <c>OpticalFlowVectorBitNV</c>
        /// </summary>
        OpticalFlowVectorBitNV = 0x20000000000,

        /// <summary>
        ///     <c>OpticalFlowCostBitNV</c>
        /// </summary>
        OpticalFlowCostBitNV = 0x40000000000,

        /// <summary>
        ///     <c>TensorDataGraphBitARM</c>
        /// </summary>
        TensorDataGraphBitARM = 0x1000000000000,

        /// <summary>
        ///     <c>CopyImageIndirectDstBitKHR</c>
        /// </summary>
        CopyImageIndirectDstBitKHR = 0x800000000000000,

        /// <summary>
        ///     <c>VideoEncodeQuantizationDeltaMapBitKHR</c>
        /// </summary>
        VideoEncodeQuantizationDeltaMapBitKHR = 0x2000000000000,

        /// <summary>
        ///     <c>VideoEncodeEmphasisMapBitKHR</c>
        /// </summary>
        VideoEncodeEmphasisMapBitKHR = 0x4000000000000,

        /// <summary>
        ///     <c>SampledImageFilterLinear2DBitIMG</c>
        /// </summary>
        SampledImageFilterLinear2DBitIMG = 0x200000000000,

        /// <summary>
        ///     <c>DepthCopyOnComputeQueueBitKHR</c>
        /// </summary>
        DepthCopyOnComputeQueueBitKHR = 0x10000000000000,

        /// <summary>
        ///     <c>DepthCopyOnTransferQueueBitKHR</c>
        /// </summary>
        DepthCopyOnTransferQueueBitKHR = 0x20000000000000,

        /// <summary>
        ///     <c>StencilCopyOnComputeQueueBitKHR</c>
        /// </summary>
        StencilCopyOnComputeQueueBitKHR = 0x40000000000000,

        /// <summary>
        ///     <c>StencilCopyOnTransferQueueBitKHR</c>
        /// </summary>
        StencilCopyOnTransferQueueBitKHR = 0x80000000000000,

        /// <summary>
        ///     <c>DataGraphOpticalFlowImageBitARM</c>
        /// </summary>
        DataGraphOpticalFlowImageBitARM = 0x100000000000000,

        /// <summary>
        ///     <c>DataGraphOpticalFlowVectorBitARM</c>
        /// </summary>
        DataGraphOpticalFlowVectorBitARM = 0x200000000000000,

        /// <summary>
        ///     <c>DataGraphOpticalFlowCostBitARM</c>
        /// </summary>
        DataGraphOpticalFlowCostBitARM = 0x400000000000000,
    }
}
