namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatFeatureFlagBits.html">VkFormatFeatureFlagBits</see> - Bitmask specifying features supported by a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the <c>VkFormatProperties</c> features
    ///         <c>linearTilingFeatures</c>, <c>optimalTilingFeatures</c>,
    ///         and <c>bufferFeatures</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFormatFeatureFlagBits {
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 0x00000001,
    ///             VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 0x00000002,
    ///             VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 0x00000004,
    ///             VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 0x00000008,
    ///             VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 0x00000010,
    ///             VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x00000020,
    ///             VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 0x00000040,
    ///             VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 0x00000080,
    ///             VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 0x00000100,
    ///             VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x00000200,
    ///             VK_FORMAT_FEATURE_BLIT_SRC_BIT = 0x00000400,
    ///             VK_FORMAT_FEATURE_BLIT_DST_BIT = 0x00000800,
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = 0x00001000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_TRANSFER_SRC_BIT = 0x00004000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_TRANSFER_DST_BIT = 0x00008000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT = 0x00020000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = 0x00040000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = 0x00080000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = 0x00100000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x00200000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_DISJOINT_BIT = 0x00400000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT = 0x00800000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT = 0x00010000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR = 0x02000000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR = 0x04000000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 0x20000000,
    ///             // Provided by VK_EXT_filter_cubic
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = 0x00002000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x01000000,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x40000000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR = 0x08000000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR = 0x10000000,
    ///             // Provided by VK_IMG_filter_cubic
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG = VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT,
    ///             // Provided by VK_KHR_maintenance1
    ///             VK_FORMAT_FEATURE_TRANSFER_SRC_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_SRC_BIT,
    ///             // Provided by VK_KHR_maintenance1
    ///             VK_FORMAT_FEATURE_TRANSFER_DST_BIT_KHR = VK_FORMAT_FEATURE_TRANSFER_DST_BIT,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT = VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR = VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_DISJOINT_BIT_KHR = VK_FORMAT_FEATURE_DISJOINT_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT_KHR = VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT,
    ///         } VkFormatFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkFormatFeatureFlags : int
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
        ///     <c>BlitSrcBit</c> specifies that an image <i>can</i> be used as <c>srcImage</c> for the <c>vkCmdBlitImage</c> command.
        /// </summary>
        BlitSrcBit = 0x00000400,

        /// <summary>
        ///     <c>BlitDstBit</c> specifies that an image <i>can</i> be used as <c>dstImage</c> for the <c>vkCmdBlitImage</c> command.
        /// </summary>
        BlitDstBit = 0x00000800,

        /// <summary>
        ///     <c>SampledImageFilterLinearBit</c> specifies that if <c>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</c> is also set, an image view <i>can</i> be used with a sampler that has either of <c>magFilter</c> or <c>minFilter</c> set to <c>VK_FILTER_LINEAR</c>, or <c>mipmapMode</c> set to <c>VK_SAMPLER_MIPMAP_MODE_LINEAR</c>. If <c>VK_FORMAT_FEATURE_BLIT_SRC_BIT</c> is also set, an image can be used as the <c>srcImage</c> to <c>vkCmdBlitImage</c> with a <c>filter</c> of <c>VK_FILTER_LINEAR</c>. This bit <i>must</i> only be exposed for formats that also support the <c>VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT</c> or <c>VK_FORMAT_FEATURE_BLIT_SRC_BIT</c>. + If the format being queried is a depth/stencil format, this bit only specifies that the depth aspect (not the stencil aspect) of an image of this format supports linear filtering, and that linear filtering of the depth aspect is supported whether depth compare is enabled in the sampler or not. Where depth comparison is supported it may: be linear filtered whether this bit is present or not, but where this bit is not present the filtered value may: be computed in an implementation-dependent manner which differs from the normal rules of linear filtering. The resulting value <i>must</i> be in the range <c>[0,1]</c> and <i>should</i> be proportional to, or a weighted average of, the number of comparison passes or failures.
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
        ///     <c>SampledImageFilterMinmaxBit</c>
        /// </summary>
        SampledImageFilterMinmaxBit = 0x00010000,

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
        ///     <c>SampledImageFilterCubicBitEXT</c>
        /// </summary>
        SampledImageFilterCubicBitEXT = 0x00002000,

        /// <summary>
        ///     <c>FragmentDensityMapBitEXT</c>
        /// </summary>
        FragmentDensityMapBitEXT = 0x01000000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x40000000,

        /// <summary>
        ///     <c>VideoEncodeInputBitKHR</c>
        /// </summary>
        VideoEncodeInputBitKHR = 0x08000000,

        /// <summary>
        ///     <c>VideoEncodeDpbBitKHR</c>
        /// </summary>
        VideoEncodeDpbBitKHR = 0x10000000,

        /// <summary>
        ///     <c>SampledImageFilterCubicBitIMG</c>
        /// </summary>
        SampledImageFilterCubicBitIMG = SampledImageFilterCubicBitEXT,

        /// <summary>
        ///     <c>TransferSrcBitKHR</c>
        /// </summary>
        TransferSrcBitKHR = TransferSrcBit,

        /// <summary>
        ///     <c>TransferDstBitKHR</c>
        /// </summary>
        TransferDstBitKHR = TransferDstBit,

        /// <summary>
        ///     <c>SampledImageFilterMinmaxBitEXT</c>
        /// </summary>
        SampledImageFilterMinmaxBitEXT = SampledImageFilterMinmaxBit,

        /// <summary>
        ///     <c>MidpointChromaSamplesBitKHR</c>
        /// </summary>
        MidpointChromaSamplesBitKHR = MidpointChromaSamplesBit,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionLinearFilterBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionLinearFilterBitKHR = SampledImageYCbCrConversionLinearFilterBit,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionSeparateReconstructionFilterBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionSeparateReconstructionFilterBitKHR =
            SampledImageYCbCrConversionSeparateReconstructionFilterBit,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitBitKHR =
            SampledImageYCbCrConversionChromaReconstructionExplicitBit,

        /// <summary>
        ///     <c>SampledImageYCbCrConversionChromaReconstructionExplicitForceableBitKHR</c>
        /// </summary>
        SampledImageYCbCrConversionChromaReconstructionExplicitForceableBitKHR =
            SampledImageYCbCrConversionChromaReconstructionExplicitForceableBit,

        /// <summary>
        ///     <c>DisjointBitKHR</c>
        /// </summary>
        DisjointBitKHR = DisjointBit,

        /// <summary>
        ///     <c>CositedChromaSamplesBitKHR</c>
        /// </summary>
        CositedChromaSamplesBitKHR = CositedChromaSamplesBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
