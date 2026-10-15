namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceDescriptorHeapInfoEXT.html">VkCommandBufferInheritanceDescriptorHeapInfoEXT</see> - Structure specifying command buffer inheritance information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkCommandBufferInheritanceInfo</c> includes a
    ///         <c>VkCommandBufferInheritanceDescriptorHeapInfoEXT</c> structure, then that
    ///         structure indicates that the secondary will use the same descriptor heaps as
    ///         the primary command buffer.
    ///     </para>
    ///     <para>
    ///         The <c>VkCommandBufferInheritanceDescriptorHeapInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkCommandBufferInheritanceDescriptorHeapInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             const VkBindHeapInfoEXT*    pSamplerHeapBindInfo;
    ///             const VkBindHeapInfoEXT*    pResourceHeapBindInfo;
    ///         } VkCommandBufferInheritanceDescriptorHeapInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCommandBufferInheritanceDescriptorHeapInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceDescriptorHeapInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SamplerHeapBindInfo</c> specifies the <c>VkBindHeapInfoEXT</c> of the sampler heap bound using <c>vkCmdBindSamplerHeapEXT</c> in the primary. If this is `NULL`, it indicates that no sampler heap is bound.
        /// </summary>
        [FieldOffset(16)]
        public VkBindHeapInfoEXT* SamplerHeapBindInfo;

        /// <summary>
        ///     <c>ResourceHeapBindInfo</c> specifies the <c>VkBindHeapInfoEXT</c> of the resource heap bound using <c>vkCmdBindResourceHeapEXT</c> in the primary. If this is `NULL`, it indicates that no resource heap is bound.
        /// </summary>
        [FieldOffset(24)]
        public VkBindHeapInfoEXT* ResourceHeapBindInfo;
    }
}
