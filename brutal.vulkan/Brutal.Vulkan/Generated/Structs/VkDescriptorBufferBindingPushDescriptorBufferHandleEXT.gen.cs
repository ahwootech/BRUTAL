namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorBufferBindingPushDescriptorBufferHandleEXT.html">VkDescriptorBufferBindingPushDescriptorBufferHandleEXT</see> - Structure specifying push descriptor buffer binding information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits-bufferlessPushDescriptors"><c>VkPhysicalDeviceDescriptorBufferPropertiesEXT::bufferlessPushDescriptors</c>^</see>
    ///         property is <c>VK_FALSE</c>, the <c>VkBuffer</c> handle of the buffer for push
    ///         descriptors is passed in a
    ///         <c>VkDescriptorBufferBindingPushDescriptorBufferHandleEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           buffer;
    ///         } VkDescriptorBufferBindingPushDescriptorBufferHandleEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorBufferBindingPushDescriptorBufferHandleEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is the <c>VkBuffer</c> handle of the buffer for push descriptors.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;
    }
}
