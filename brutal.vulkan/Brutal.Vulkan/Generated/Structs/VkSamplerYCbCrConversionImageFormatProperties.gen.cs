namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversionImageFormatProperties.html">VkSamplerYcbcrConversionImageFormatProperties</see> - Structure specifying combined image sampler descriptor count for multi-planar images
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine the number of combined image samplers required to support a
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-multiplanar">multi-planar format^</see>, add
    ///         <c>VkSamplerYcbcrConversionImageFormatProperties</c> to the <c>pNext</c> chain
    ///         of the <c>VkImageFormatProperties2</c> structure in a call to
    ///         <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSamplerYcbcrConversionImageFormatProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkSamplerYcbcrConversionImageFormatProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           combinedImageSamplerDescriptorCount;
    ///         } VkSamplerYcbcrConversionImageFormatProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerYCbCrConversionImageFormatProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerYCbCrConversionImageFormatProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CombinedImageSamplerDescriptorCount</c> is the number of combined image sampler descriptors that the implementation uses to access the format.
        /// </summary>
        [FieldOffset(16)]
        public int CombinedImageSamplerDescriptorCount;
    }
}
