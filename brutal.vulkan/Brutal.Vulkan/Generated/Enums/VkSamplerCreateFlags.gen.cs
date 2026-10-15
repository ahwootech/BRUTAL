namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateFlagBits.html">VkSamplerCreateFlagBits</see> - Bitmask specifying additional parameters of sampler
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSamplerCreateInfo::flags</c>, specifying
    ///         additional parameters of a sampler, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSamplerCreateFlagBits {
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = 0x00000001,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x00000002,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00000008,
    ///             // Provided by VK_EXT_non_seamless_cube_map
    ///             VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT = 0x00000004,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM = 0x00000010,
    ///         } VkSamplerCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSamplerCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SubsampledBitEXT</c>
        /// </summary>
        SubsampledBitEXT = 0x00000001,

        /// <summary>
        ///     <c>SubsampledCoarseReconstructionBitEXT</c>
        /// </summary>
        SubsampledCoarseReconstructionBitEXT = 0x00000002,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = 0x00000008,

        /// <summary>
        ///     <c>NonSeamlessCubeMapBitEXT</c>
        /// </summary>
        NonSeamlessCubeMapBitEXT = 0x00000004,

        /// <summary>
        ///     <c>ImageProcessingBitQCOM</c>
        /// </summary>
        ImageProcessingBitQCOM = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
