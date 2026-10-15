namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">VkOpaqueCaptureDescriptorDataCreateInfoEXT</see> - Structure specifying opaque capture descriptor data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpaqueCaptureDescriptorDataCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkOpaqueCaptureDescriptorDataCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const void*        opaqueCaptureDescriptorData;
    ///         } VkOpaqueCaptureDescriptorDataCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkOpaqueCaptureDescriptorDataCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpaqueCaptureDescriptorDataCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OpaqueCaptureDescriptorData</c> is a pointer to an application-allocated buffer containing opaque capture data retrieved using <c>vkGetBufferOpaqueCaptureDescriptorDataEXT</c>, <c>vkGetImageOpaqueCaptureDescriptorDataEXT</c>, <c>vkGetImageViewOpaqueCaptureDescriptorDataEXT</c>, <c>vkGetSamplerOpaqueCaptureDescriptorDataEXT</c>, or <c>vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT</c>.
        /// </summary>
        [FieldOffset(16)]
        public void* OpaqueCaptureDescriptorData;
    }
}
