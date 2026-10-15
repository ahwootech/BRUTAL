namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT.html">VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT</see> - Structure describing descriptor buffer density map properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_EXT_fragment_density_map
    ///         typedef struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             size_t             combinedImageSamplerDensityMapDescriptorSize;
    ///         } VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CombinedImageSamplerDensityMapDescriptorSize</c>
        /// </summary>
        [FieldOffset(16)]
        public nuint CombinedImageSamplerDensityMapDescriptorSize;
    }
}
