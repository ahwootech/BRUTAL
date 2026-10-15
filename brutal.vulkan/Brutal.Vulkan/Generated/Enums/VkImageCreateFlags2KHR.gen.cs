namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCreateFlagBits2KHR.html">VkImageCreateFlagBits2KHR</see> - Bitmask specifying additional parameters of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkImageCreateFlags2CreateInfoKHR::flags</c>, specifying additional
    ///         parameters of an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         // Flag bits for VkImageCreateFlagBits2KHR
    ///         typedef VkFlags64 VkImageCreateFlagBits2KHR;
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SPARSE_BINDING_BIT_KHR = 0x00000001ULL;
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SPARSE_RESIDENCY_BIT_KHR = 0x00000002ULL;
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SPARSE_ALIASED_BIT_KHR = 0x00000004ULL;
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_MUTABLE_FORMAT_BIT_KHR = 0x00000008ULL;
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_CUBE_COMPATIBLE_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_maintenance11
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_ALIAS_SINGLE_LAYER_DESCRIPTOR_BIT_KHR = 0x00400000ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_2D_ARRAY_COMPATIBLE_BIT_KHR = 0x00000020ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_EXTENDED_USAGE_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_DISJOINT_BIT_KHR = 0x00000200ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_ALIAS_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_VERSION_1_0 with VK_KHR_extended_flags
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_PROTECTED_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_sample_locations
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_NV_corner_sampled_image
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_CORNER_SAMPLED_BIT_NV = 0x00002000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_fragment_density_map
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_SUBSAMPLED_BIT_EXT = 0x00004000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_fragment_density_map_offset
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_FRAGMENT_DENSITY_MAP_OFFSET_BIT_EXT = 0x00008000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_descriptor_buffer
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00010000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_image_2d_view_of_3d
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_2D_VIEW_COMPATIBLE_BIT_EXT = 0x00020000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_multisampled_render_to_single_sampled
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT = 0x00040000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_maintenance1
    ///             static const VkImageCreateFlagBits2KHR VK_IMAGE_CREATE_2_VIDEO_PROFILE_INDEPENDENT_BIT_KHR = 0x00100000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkImageCreateFlags2KHR : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SparseBindingBitKHR</c> specifies that the image will be backed using sparse memory binding.
        /// </summary>
        SparseBindingBitKHR = 0x00000001,

        /// <summary>
        ///     <c>SparseResidencyBitKHR</c> specifies that the image <i>can</i> be partially backed using sparse memory binding. Images created with this flag <i>must</i> also be created with the <c>VK_IMAGE_CREATE_2_SPARSE_BINDING_BIT_KHR</c> flag.
        /// </summary>
        SparseResidencyBitKHR = 0x00000002,

        /// <summary>
        ///     <c>SparseAliasedBitKHR</c> specifies that the image will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another image (or another portion of the same image). Images created with this flag <i>must</i> also be created with the <c>VK_IMAGE_CREATE_2_SPARSE_BINDING_BIT_KHR</c> flag.
        /// </summary>
        SparseAliasedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>MutableFormatBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> with a different format from the image.
        /// </summary>
        MutableFormatBitKHR = 0x00000008,

        /// <summary>
        ///     <c>CubeCompatibleBitKHR</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> of type <c>VK_IMAGE_VIEW_TYPE_CUBE</c> or <c>VK_IMAGE_VIEW_TYPE_CUBE_ARRAY</c>.
        /// </summary>
        CubeCompatibleBitKHR = 0x00000010,

        /// <summary>
        ///     <c>AliasSingleLayerDescriptorBitKHR</c>
        /// </summary>
        AliasSingleLayerDescriptorBitKHR = 0x00400000,

        /// <summary>
        ///     <c>_2DArrayCompatibleBitKHR</c>
        /// </summary>
        _2DArrayCompatibleBitKHR = 0x00000020,

        /// <summary>
        ///     <c>SplitInstanceBindRegionsBitKHR</c>
        /// </summary>
        SplitInstanceBindRegionsBitKHR = 0x00000040,

        /// <summary>
        ///     <c>BlockTexelViewCompatibleBitKHR</c>
        /// </summary>
        BlockTexelViewCompatibleBitKHR = 0x00000080,

        /// <summary>
        ///     <c>ExtendedUsageBitKHR</c>
        /// </summary>
        ExtendedUsageBitKHR = 0x00000100,

        /// <summary>
        ///     <c>DisjointBitKHR</c>
        /// </summary>
        DisjointBitKHR = 0x00000200,

        /// <summary>
        ///     <c>AliasBitKHR</c>
        /// </summary>
        AliasBitKHR = 0x00000400,

        /// <summary>
        ///     <c>ProtectedBitKHR</c>
        /// </summary>
        ProtectedBitKHR = 0x00000800,

        /// <summary>
        ///     <c>SampleLocationsCompatibleDepthBitEXT</c>
        /// </summary>
        SampleLocationsCompatibleDepthBitEXT = 0x00001000,

        /// <summary>
        ///     <c>CornerSampledBitNV</c>
        /// </summary>
        CornerSampledBitNV = 0x00002000,

        /// <summary>
        ///     <c>SubsampledBitEXT</c>
        /// </summary>
        SubsampledBitEXT = 0x00004000,

        /// <summary>
        ///     <c>FragmentDensityMapOffsetBitEXT</c>
        /// </summary>
        FragmentDensityMapOffsetBitEXT = 0x00008000,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = 0x00010000,

        /// <summary>
        ///     <c>_2DViewCompatibleBitEXT</c>
        /// </summary>
        _2DViewCompatibleBitEXT = 0x00020000,

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampledBitEXT</c>
        /// </summary>
        MultisampledRenderToSingleSampledBitEXT = 0x00040000,

        /// <summary>
        ///     <c>VideoProfileIndependentBitKHR</c>
        /// </summary>
        VideoProfileIndependentBitKHR = 0x00100000,
    }
}
