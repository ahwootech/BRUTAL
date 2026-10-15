namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTexelBufferDescriptorInfoEXT.html">VkTexelBufferDescriptorInfoEXT</see> - Structure describing an image descriptor created from a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkTexelBufferDescriptorInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkTexelBufferDescriptorInfoEXT {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkFormat                   format;
    ///             VkDeviceAddressRangeEXT    addressRange;
    ///         } VkTexelBufferDescriptorInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkTexelBufferDescriptorInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TexelBufferDescriptorInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is the <c>VkFormat</c> of the descriptor.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>AddressRange</c> is a <c>VkDeviceAddressRangeKHR</c> defining the range of data backing the descriptor.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddressRangeEXT AddressRange;
    }
}
