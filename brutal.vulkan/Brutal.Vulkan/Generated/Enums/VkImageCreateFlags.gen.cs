namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCreateFlagBits.html">VkImageCreateFlagBits</see> - Bitmask specifying additional parameters of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkImageCreateInfo::flags</c>, specifying
    ///         additional parameters of an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageCreateFlagBits {
    ///             VK_IMAGE_CREATE_SPARSE_BINDING_BIT = 0x00000001,
    ///             VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
    ///             VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
    ///             VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x00000008,
    ///             VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x00000010,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_ALIAS_BIT = 0x00000400,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT = 0x00000040,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT = 0x00000020,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT = 0x00000080,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_EXTENDED_USAGE_BIT = 0x00000100,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_PROTECTED_BIT = 0x00000800,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_CREATE_DISJOINT_BIT = 0x00000200,
    ///             // Provided by VK_NV_corner_sampled_image
    ///             VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = 0x00002000,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_IMAGE_CREATE_DESCRIPTOR_HEAP_CAPTURE_REPLAY_BIT_EXT = 0x00010000,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = 0x00004000,
    ///             // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///             VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT = 0x00040000,
    ///             // Provided by VK_EXT_image_2d_view_of_3d
    ///             VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT = 0x00020000,
    ///             // Provided by VK_KHR_video_maintenance1
    ///             VK_IMAGE_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR = 0x00100000,
    ///             // Provided by VK_EXT_fragment_density_map_offset
    ///             VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_EXT = 0x00008000,
    ///             // Provided by VK_KHR_maintenance11
    ///             VK_IMAGE_CREATE_ALIAS_SINGLE_LAYER_DESCRIPTOR_BIT_KHR = 0x00400000,
    ///             // Provided by VK_KHR_bind_memory2 with VK_KHR_device_group
    ///             VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT,
    ///             // Provided by VK_KHR_maintenance1
    ///             VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR = VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_IMAGE_CREATE_EXTENDED_USAGE_BIT_KHR = VK_IMAGE_CREATE_EXTENDED_USAGE_BIT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_IMAGE_CREATE_DISJOINT_BIT_KHR = VK_IMAGE_CREATE_DISJOINT_BIT,
    ///             // Provided by VK_KHR_bind_memory2
    ///             VK_IMAGE_CREATE_ALIAS_BIT_KHR = VK_IMAGE_CREATE_ALIAS_BIT,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VK_IMAGE_CREATE_DESCRIPTOR_HEAP_CAPTURE_REPLAY_BIT_EXT,
    ///             // Provided by VK_QCOM_fragment_density_map_offset
    ///             VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM = VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_EXT,
    ///         } VkImageCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkImageCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SparseBindingBit</c> specifies that the image will be backed using sparse memory binding.
        /// </summary>
        SparseBindingBit = 0x00000001,

        /// <summary>
        ///     <c>SparseResidencyBit</c> specifies that the image <i>can</i> be partially backed using sparse memory binding. Images created with this flag <i>must</i> also be created with the <c>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</c> flag.
        /// </summary>
        SparseResidencyBit = 0x00000002,

        /// <summary>
        ///     <c>SparseAliasedBit</c> specifies that the image will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another image (or another portion of the same image). Images created with this flag <i>must</i> also be created with the <c>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</c> flag.
        /// </summary>
        SparseAliasedBit = 0x00000004,

        /// <summary>
        ///     <c>MutableFormatBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> with a different format from the image.
        /// </summary>
        MutableFormatBit = 0x00000008,

        /// <summary>
        ///     <c>CubeCompatibleBit</c> specifies that the image <i>can</i> be used to create a <c>VkImageView</c> of type <c>VK_IMAGE_VIEW_TYPE_CUBE</c> or <c>VK_IMAGE_VIEW_TYPE_CUBE_ARRAY</c>.
        /// </summary>
        CubeCompatibleBit = 0x00000010,

        /// <summary>
        ///     <c>AliasBit</c>
        /// </summary>
        AliasBit = 0x00000400,

        /// <summary>
        ///     <c>SplitInstanceBindRegionsBit</c>
        /// </summary>
        SplitInstanceBindRegionsBit = 0x00000040,

        /// <summary>
        ///     <c>_2DArrayCompatibleBit</c>
        /// </summary>
        _2DArrayCompatibleBit = 0x00000020,

        /// <summary>
        ///     <c>BlockTexelViewCompatibleBit</c>
        /// </summary>
        BlockTexelViewCompatibleBit = 0x00000080,

        /// <summary>
        ///     <c>ExtendedUsageBit</c>
        /// </summary>
        ExtendedUsageBit = 0x00000100,

        /// <summary>
        ///     <c>ProtectedBit</c>
        /// </summary>
        ProtectedBit = 0x00000800,

        /// <summary>
        ///     <c>DisjointBit</c>
        /// </summary>
        DisjointBit = 0x00000200,

        /// <summary>
        ///     <c>CornerSampledBitNV</c>
        /// </summary>
        CornerSampledBitNV = 0x00002000,

        /// <summary>
        ///     <c>DescriptorHeapCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorHeapCaptureReplayBitEXT = 0x00010000,

        /// <summary>
        ///     <c>SampleLocationsCompatibleDepthBitEXT</c>
        /// </summary>
        SampleLocationsCompatibleDepthBitEXT = 0x00001000,

        /// <summary>
        ///     <c>SubsampledBitEXT</c>
        /// </summary>
        SubsampledBitEXT = 0x00004000,

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampledBitEXT</c>
        /// </summary>
        MultisampledRenderToSingleSampledBitEXT = 0x00040000,

        /// <summary>
        ///     <c>_2DViewCompatibleBitEXT</c>
        /// </summary>
        _2DViewCompatibleBitEXT = 0x00020000,

        /// <summary>
        ///     <c>VideoProfileIndependentBitKHR</c>
        /// </summary>
        VideoProfileIndependentBitKHR = 0x00100000,

        /// <summary>
        ///     <c>FragmentDensityMapOffsetBitEXT</c>
        /// </summary>
        FragmentDensityMapOffsetBitEXT = 0x00008000,

        /// <summary>
        ///     <c>AliasSingleLayerDescriptorBitKHR</c>
        /// </summary>
        AliasSingleLayerDescriptorBitKHR = 0x00400000,

        /// <summary>
        ///     <c>SplitInstanceBindRegionsBitKHR</c>
        /// </summary>
        SplitInstanceBindRegionsBitKHR = SplitInstanceBindRegionsBit,

        /// <summary>
        ///     <c>_2DArrayCompatibleBitKHR</c>
        /// </summary>
        _2DArrayCompatibleBitKHR = _2DArrayCompatibleBit,

        /// <summary>
        ///     <c>BlockTexelViewCompatibleBitKHR</c>
        /// </summary>
        BlockTexelViewCompatibleBitKHR = BlockTexelViewCompatibleBit,

        /// <summary>
        ///     <c>ExtendedUsageBitKHR</c>
        /// </summary>
        ExtendedUsageBitKHR = ExtendedUsageBit,

        /// <summary>
        ///     <c>DisjointBitKHR</c>
        /// </summary>
        DisjointBitKHR = DisjointBit,

        /// <summary>
        ///     <c>AliasBitKHR</c>
        /// </summary>
        AliasBitKHR = AliasBit,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = DescriptorHeapCaptureReplayBitEXT,

        /// <summary>
        ///     <c>FragmentDensityMapOffsetBitQCOM</c>
        /// </summary>
        FragmentDensityMapOffsetBitQCOM = FragmentDensityMapOffsetBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
