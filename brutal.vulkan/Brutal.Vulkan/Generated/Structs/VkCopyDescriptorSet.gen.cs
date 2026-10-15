namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyDescriptorSet.html">VkCopyDescriptorSet</see> - Structure specifying a copy descriptor set operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCopyDescriptorSet</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkCopyDescriptorSet {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDescriptorSet    srcSet;
    ///             uint32_t           srcBinding;
    ///             uint32_t           srcArrayElement;
    ///             VkDescriptorSet    dstSet;
    ///             uint32_t           dstBinding;
    ///             uint32_t           dstArrayElement;
    ///             uint32_t           descriptorCount;
    ///         } VkCopyDescriptorSet;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCopyDescriptorSet()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyDescriptorSet;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcSet</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorSet SrcSet;

        /// <summary>
        ///     <c>SrcBinding</c>
        /// </summary>
        [FieldOffset(24)]
        public int SrcBinding;

        /// <summary>
        ///     <c>SrcArrayElement</c>
        /// </summary>
        [FieldOffset(28)]
        public int SrcArrayElement;

        /// <summary>
        ///     <c>DstSet</c>
        /// </summary>
        [FieldOffset(32)]
        public VkDescriptorSet DstSet;

        /// <summary>
        ///     <c>DstBinding</c>
        /// </summary>
        [FieldOffset(40)]
        public int DstBinding;

        /// <summary>
        ///     <c>DstArrayElement</c>
        /// </summary>
        [FieldOffset(44)]
        public int DstArrayElement;

        /// <summary>
        ///     <c>DescriptorCount</c> is the number of descriptors to copy from the source to destination. If <c>descriptorCount</c> is greater than the number of remaining array elements in the source or destination binding, those affect consecutive bindings in a manner similar to <c>VkWriteDescriptorSet</c> above.
        /// </summary>
        [FieldOffset(48)]
        public int DescriptorCount;
    }
}
