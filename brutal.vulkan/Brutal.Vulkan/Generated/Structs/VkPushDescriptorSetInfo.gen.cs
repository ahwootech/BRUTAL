namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetInfo.html">VkPushDescriptorSetInfo</see> - Structure specifying a descriptor set push operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPushDescriptorSetInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkPushDescriptorSetInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPushDescriptorSetInfo {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkShaderStageFlags             stageFlags;
    ///             VkPipelineLayout               layout;
    ///             uint32_t                       set;
    ///             uint32_t                       descriptorWriteCount;
    ///             const VkWriteDescriptorSet*    pDescriptorWrites;
    ///         } VkPushDescriptorSetInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPushDescriptorSetInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PushDescriptorSetInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StageFlags</c> is a bitmask of <c>VkShaderStageFlags</c> specifying the shader stages that will use the descriptors.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkPipelineLayout</c> object used to program the bindings.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>Set</c> is the set number of the descriptor set in the pipeline layout that will be updated.
        /// </summary>
        [FieldOffset(32)]
        public int Set;

        /// <summary>
        ///     <c>DescriptorWriteCount</c> is the number of elements in the <c>pDescriptorWrites</c> array.
        /// </summary>
        [FieldOffset(36)]
        public int DescriptorWriteCount;

        /// <summary>
        ///     <c>DescriptorWrites</c> is a pointer to an array of <c>VkWriteDescriptorSet</c> structures describing the descriptors to be updated.
        /// </summary>
        [FieldOffset(40)]
        public VkWriteDescriptorSet* DescriptorWrites;
    }
}
