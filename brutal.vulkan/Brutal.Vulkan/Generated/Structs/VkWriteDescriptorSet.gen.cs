namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSet.html">VkWriteDescriptorSet</see> - Structure specifying the parameters of a descriptor set write operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWriteDescriptorSet</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkWriteDescriptorSet {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDescriptorSet                  dstSet;
    ///             uint32_t                         dstBinding;
    ///             uint32_t                         dstArrayElement;
    ///             uint32_t                         descriptorCount;
    ///             VkDescriptorType                 descriptorType;
    ///             const VkDescriptorImageInfo*     pImageInfo;
    ///             const VkDescriptorBufferInfo*    pBufferInfo;
    ///             const VkBufferView*              pTexelBufferView;
    ///         } VkWriteDescriptorSet;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkWriteDescriptorSet()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteDescriptorSet;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DstSet</c> is the destination descriptor set to update.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorSet DstSet;

        /// <summary>
        ///     <c>DstBinding</c> is the descriptor binding within that set.
        /// </summary>
        [FieldOffset(24)]
        public int DstBinding;

        /// <summary>
        ///     <c>DstArrayElement</c> is the starting element in that array.
        /// </summary>
        [FieldOffset(28)]
        public int DstArrayElement;

        /// <summary>
        ///     <c>DescriptorCount</c> is the number of descriptors to update. <c>descriptorCount</c> is one of
        /// </summary>
        [FieldOffset(32)]
        public int DescriptorCount;

        /// <summary>
        ///     <c>DescriptorType</c> is a <c>VkDescriptorType</c> specifying the type of each descriptor in <c>pImageInfo</c>, <c>pBufferInfo</c>, or <c>pTexelBufferView</c>, as described below. It <i>must</i> be the same type as the <c>descriptorType</c> specified in <c>VkDescriptorSetLayoutBinding</c> for <c>dstSet</c> at <c>dstBinding</c>. The type of the descriptor also controls which array the descriptors are taken from.
        /// </summary>
        [FieldOffset(36)]
        public VkDescriptorType DescriptorType;

        /// <summary>
        ///     <c>ImageInfo</c> is a pointer to an array of <c>VkDescriptorImageInfo</c> structures or is ignored, as described below.
        /// </summary>
        [FieldOffset(40)]
        public VkDescriptorImageInfo* ImageInfo;

        /// <summary>
        ///     <c>BufferInfo</c> is a pointer to an array of <c>VkDescriptorBufferInfo</c> structures or is ignored, as described below.
        /// </summary>
        [FieldOffset(48)]
        public VkDescriptorBufferInfo* BufferInfo;

        /// <summary>
        ///     <c>TexelBufferView</c> is a pointer to an array of <c>VkBufferView</c> handles as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-buffer-views">Buffer Views^</see> section or is ignored, as described below.
        /// </summary>
        [FieldOffset(56)]
        public VkBufferView* TexelBufferView;
    }
}
