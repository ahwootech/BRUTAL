namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSparseProperties.html">VkPhysicalDeviceSparseProperties</see> - Structure specifying physical device sparse memory properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSparseProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPhysicalDeviceSparseProperties {
    ///             VkBool32    residencyStandard2DBlockShape;
    ///             VkBool32    residencyStandard2DMultisampleBlockShape;
    ///             VkBool32    residencyStandard3DBlockShape;
    ///             VkBool32    residencyAlignedMipSize;
    ///             VkBool32    residencyNonResidentStrict;
    ///         } VkPhysicalDeviceSparseProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkPhysicalDeviceSparseProperties()
    {
        /// <summary>
        ///     <c>ResidencyStandard2DBlockShape</c>  is <c>VK_TRUE</c> if the physical device will access all single-sample 2D sparse resources using the standard sparse image block shapes (based on image format), as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory-sparseblockshapessingle">Standard Sparse Image Block Shapes (Single Sample)^</see> table. If this property is not supported the value returned in the <c>imageGranularity</c> member of the <c>VkSparseImageFormatProperties</c> structure for single-sample 2D images is not required: to match the standard sparse image block dimensions listed in the table.
        /// </summary>
        [FieldOffset(0)]
        public Brutal.Bool32 ResidencyStandard2DBlockShape;

        /// <summary>
        ///     <c>ResidencyStandard2DMultisampleBlockShape</c>  is <c>VK_TRUE</c> if the physical device will access all multisample 2D sparse resources using the standard sparse image block shapes (based on image format), as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory-sparseblockshapesmsaa">Standard Sparse Image Block Shapes (MSAA)^</see> table. If this property is not supported, the value returned in the <c>imageGranularity</c> member of the <c>VkSparseImageFormatProperties</c> structure for multisample 2D images is not required: to match the standard sparse image block dimensions listed in the table.
        /// </summary>
        [FieldOffset(4)]
        public Brutal.Bool32 ResidencyStandard2DMultisampleBlockShape;

        /// <summary>
        ///     <c>ResidencyStandard3DBlockShape</c>  is <c>VK_TRUE</c> if the physical device will access all 3D sparse resources using the standard sparse image block shapes (based on image format), as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory-sparseblockshapessingle">Standard Sparse Image Block Shapes (Single Sample)^</see> table. If this property is not supported, the value returned in the <c>imageGranularity</c> member of the <c>VkSparseImageFormatProperties</c> structure for 3D images is not required: to match the standard sparse image block dimensions listed in the table.
        /// </summary>
        [FieldOffset(8)]
        public Brutal.Bool32 ResidencyStandard3DBlockShape;

        /// <summary>
        ///     <c>ResidencyAlignedMipSize</c>  is <c>VK_TRUE</c> if images with mip level dimensions that are not integer multiples of the corresponding dimensions of the sparse image block may: be placed in the mip tail. If this property is not reported, only mip levels with dimensions smaller than the <c>imageGranularity</c> member of the <c>VkSparseImageFormatProperties</c> structure will be placed in the mip tail. If this property is reported the implementation is allowed to return <c>VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT</c> in the <c>flags</c> member of <c>VkSparseImageFormatProperties</c>, indicating that mip level dimensions that are not integer multiples of the corresponding dimensions of the sparse image block will be placed in the mip tail.
        /// </summary>
        [FieldOffset(12)]
        public Brutal.Bool32 ResidencyAlignedMipSize;

        /// <summary>
        ///     <c>ResidencyNonResidentStrict</c>  specifies whether the physical device <i>can</i> consistently access non-resident regions of a resource. If this property is <c>VK_TRUE</c>, access to non-resident regions of resources will be guaranteed to return values as if the resource was populated with 0; writes to non-resident regions will be discarded.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ResidencyNonResidentStrict;
    }
}
