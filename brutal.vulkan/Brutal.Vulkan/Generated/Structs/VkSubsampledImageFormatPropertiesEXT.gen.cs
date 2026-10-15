namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubsampledImageFormatPropertiesEXT.html">VkSubsampledImageFormatPropertiesEXT</see> - Structure specifying image descriptor count for subsampled images
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine the number of image descriptors required to support a
    ///         subsampled image created with <c>VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT</c>, add
    ///         <c>VkSubsampledImageFormatPropertiesEXT</c> to the <c>pNext</c> chain of the
    ///         <c>VkImageFormatProperties2</c> structure in a call to
    ///         <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSubsampledImageFormatPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap with VK_EXT_fragment_density_map
    ///         typedef struct VkSubsampledImageFormatPropertiesEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           subsampledImageDescriptorCount;
    ///         } VkSubsampledImageFormatPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSubsampledImageFormatPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubsampledImageFormatPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubsampledImageDescriptorCount</c> is the number of image descriptors that the implementation uses to access the image.
        /// </summary>
        [FieldOffset(16)]
        public int SubsampledImageDescriptorCount;
    }
}
