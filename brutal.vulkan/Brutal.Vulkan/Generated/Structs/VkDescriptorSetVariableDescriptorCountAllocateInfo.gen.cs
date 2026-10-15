namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountAllocateInfo.html">VkDescriptorSetVariableDescriptorCountAllocateInfo</see> - Structure specifying additional allocation parameters for descriptor sets
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of a <c>VkDescriptorSetAllocateInfo</c> structure
    ///         includes a <c>VkDescriptorSetVariableDescriptorCountAllocateInfo</c>
    ///         structure, then that structure includes an array of descriptor counts for
    ///         variable-sized descriptor bindings, one for each descriptor set being
    ///         allocated.
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorSetVariableDescriptorCountAllocateInfo</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkDescriptorSetVariableDescriptorCountAllocateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           descriptorSetCount;
    ///             const uint32_t*    pDescriptorCounts;
    ///         } VkDescriptorSetVariableDescriptorCountAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorSetCount</c> is zero or the number of elements in <c>pDescriptorCounts</c>.
        /// </summary>
        [FieldOffset(16)]
        public int DescriptorSetCount;

        /// <summary>
        ///     <c>DescriptorCounts</c> is a pointer to an array of descriptor counts, with each member specifying the number of descriptors in a variable-sized descriptor binding in the corresponding descriptor set being allocated.
        /// </summary>
        [FieldOffset(24)]
        public int* DescriptorCounts;
    }
}
