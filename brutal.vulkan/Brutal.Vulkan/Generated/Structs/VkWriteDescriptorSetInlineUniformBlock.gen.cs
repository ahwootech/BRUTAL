namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetInlineUniformBlock.html">VkWriteDescriptorSetInlineUniformBlock</see> - Structure specifying inline uniform block data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>descriptorType</c> member of <c>VkWriteDescriptorSet</c> is
    ///         <c>VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK</c> then the data to write to the
    ///         descriptor set is specified through a
    ///         <c>VkWriteDescriptorSetInlineUniformBlock</c> structure included in the
    ///         <c>pNext</c> chain of <c>VkWriteDescriptorSet</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkWriteDescriptorSetInlineUniformBlock</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkWriteDescriptorSetInlineUniformBlock {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           dataSize;
    ///             const void*        pData;
    ///         } VkWriteDescriptorSetInlineUniformBlock;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlock()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteDescriptorSetInlineUniformBlock;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataSize</c> is the number of bytes of inline uniform block data pointed to by <c>pData</c>.
        /// </summary>
        [FieldOffset(16)]
        public int DataSize;

        /// <summary>
        ///     <c>Data</c> is a pointer to <c>dataSize</c> number of bytes of data to write to the inline uniform block.
        /// </summary>
        [FieldOffset(24)]
        public void* Data;
    }
}
