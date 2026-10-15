namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorAddressInfoEXT.html">VkDescriptorAddressInfoEXT</see> - Structure specifying descriptor buffer address info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Data describing a <c>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</c>,
    ///         <c>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</c>,
    ///         <c>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</c>, or
    ///         <c>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</c> descriptor is passed in a
    ///         <c>VkDescriptorAddressInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkDescriptorAddressInfoEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceAddress    address;
    ///             VkDeviceSize       range;
    ///             VkFormat           format;
    ///         } VkDescriptorAddressInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDescriptorAddressInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorAddressInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Address</c> is either `0` or a device address at an offset in a buffer, where the base address can be queried from <c>vkGetBufferDeviceAddress</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress Address;

        /// <summary>
        ///     <c>Range</c> is the size in bytes of the buffer or buffer view used by the descriptor.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Range;

        /// <summary>
        ///     <c>Format</c> is the format of the data elements in the buffer view and is ignored for buffers.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat Format;
    }
}
