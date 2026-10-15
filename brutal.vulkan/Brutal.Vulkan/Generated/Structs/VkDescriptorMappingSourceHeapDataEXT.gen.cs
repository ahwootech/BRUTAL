namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceHeapDataEXT.html">VkDescriptorMappingSourceHeapDataEXT</see> - Structure specifying mapping a uniform buffer to heap data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceHeapDataEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceHeapDataEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorMappingSourceHeapDataEXT {
    ///             uint32_t    heapOffset;
    ///             uint32_t    pushOffset;
    ///         } VkDescriptorMappingSourceHeapDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkDescriptorMappingSourceHeapDataEXT()
    {
        /// <summary>
        ///     <c>HeapOffset</c> is a constant byte offset added to the heap address for the mapped buffer.
        /// </summary>
        [FieldOffset(0)]
        public int HeapOffset;

        /// <summary>
        ///     <c>PushOffset</c> is an index into push data where an additional offset into the heap for the mapped resource will be retrieved.
        /// </summary>
        [FieldOffset(4)]
        public int PushOffset;
    }
}
