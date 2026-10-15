namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetAllocateInfo.html">VkDescriptorSetAllocateInfo</see> - Structure specifying the allocation parameters for descriptor sets
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorSetAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorSetAllocateInfo {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkDescriptorPool                descriptorPool;
    ///             uint32_t                        descriptorSetCount;
    ///             const VkDescriptorSetLayout*    pSetLayouts;
    ///         } VkDescriptorSetAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDescriptorSetAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorPool</c> is the pool which the sets will be allocated from.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorPool DescriptorPool;

        /// <summary>
        ///     <c>DescriptorSetCount</c> determines the number of descriptor sets to be allocated from the pool.
        /// </summary>
        [FieldOffset(24)]
        public int DescriptorSetCount;

        /// <summary>
        ///     <c>SetLayouts</c> is a pointer to an array of descriptor set layouts, with each member specifying how the corresponding descriptor set is allocated.
        /// </summary>
        [FieldOffset(32)]
        public VkDescriptorSetLayout* SetLayouts;
    }
}
