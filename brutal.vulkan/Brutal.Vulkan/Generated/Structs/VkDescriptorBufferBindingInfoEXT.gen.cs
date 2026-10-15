namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorBufferBindingInfoEXT.html">VkDescriptorBufferBindingInfoEXT</see> - Structure specifying descriptor buffer binding information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorBufferBindingInfoEXT
    ///     </para>
    ///     <para>
    ///         Data describing a descriptor buffer binding is passed in a
    ///         <c>VkDescriptorBufferBindingInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkDescriptorBufferBindingInfoEXT {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkDeviceAddress       address;
    ///             VkBufferUsageFlags    usage;
    ///         } VkDescriptorBufferBindingInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorBufferBindingInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorBufferBindingInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Address</c> is a basetype:VkDeviceAddress specifying the device address defining the descriptor buffer to be bound.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress Address;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkBufferUsageFlags</c> specifying the <c>VkBufferCreateInfo::usage</c> for the buffer from which <c>address</c> was queried. Usage flags other than <c>VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT</c>, <c>VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT</c>, and <c>VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT</c> are ignored.
        /// </summary>
        [FieldOffset(24)]
        public VkBufferUsageFlags Usage;
    }
}
