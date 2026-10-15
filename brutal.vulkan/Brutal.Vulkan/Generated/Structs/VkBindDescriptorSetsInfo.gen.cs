namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorSetsInfo.html">VkBindDescriptorSetsInfo</see> - Structure specifying a descriptor set binding operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindDescriptorSetsInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkBindDescriptorSetsInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkBindDescriptorSetsInfo {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkShaderStageFlags        stageFlags;
    ///             VkPipelineLayout          layout;
    ///             uint32_t                  firstSet;
    ///             uint32_t                  descriptorSetCount;
    ///             const VkDescriptorSet*    pDescriptorSets;
    ///             uint32_t                  dynamicOffsetCount;
    ///             const uint32_t*           pDynamicOffsets;
    ///         } VkBindDescriptorSetsInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkBindDescriptorSetsInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindDescriptorSetsInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StageFlags</c> is a bitmask of <c>VkShaderStageFlags</c> specifying the shader stages the descriptor sets will be bound to.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkPipelineLayout</c> object used to program the bindings.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>FirstSet</c> is the set number of the first descriptor set to be bound.
        /// </summary>
        [FieldOffset(32)]
        public int FirstSet;

        /// <summary>
        ///     <c>DescriptorSetCount</c> is the number of elements in the <c>pDescriptorSets</c> array.
        /// </summary>
        [FieldOffset(36)]
        public int DescriptorSetCount;

        /// <summary>
        ///     <c>DescriptorSets</c> is a pointer to an array of handles to <c>VkDescriptorSet</c> objects describing the descriptor sets to bind to.
        /// </summary>
        [FieldOffset(40)]
        public VkDescriptorSet* DescriptorSets;

        /// <summary>
        ///     <c>DynamicOffsetCount</c> is the number of dynamic offsets in the <c>pDynamicOffsets</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int DynamicOffsetCount;

        /// <summary>
        ///     <c>DynamicOffsets</c> is a pointer to an array of <c>uint32_t</c> values specifying dynamic offsets.
        /// </summary>
        [FieldOffset(56)]
        public int* DynamicOffsets;
    }
}
