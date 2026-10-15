namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetWithTemplateInfo.html">VkPushDescriptorSetWithTemplateInfo</see> - Structure specifying a descriptor set push operation using a descriptor update template
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPushDescriptorSetWithTemplateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkPushDescriptorSetWithTemplateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPushDescriptorSetWithTemplateInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkDescriptorUpdateTemplate    descriptorUpdateTemplate;
    ///             VkPipelineLayout              layout;
    ///             uint32_t                      set;
    ///             const void*                   pData;
    ///         } VkPushDescriptorSetWithTemplateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPushDescriptorSetWithTemplateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PushDescriptorSetWithTemplateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorUpdateTemplate</c> is a descriptor update template defining how to interpret the descriptor information in <c>pData</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorUpdateTemplate DescriptorUpdateTemplate;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkPipelineLayout</c> object used to program the bindings. It <i>must</i> be compatible with the layout used to create the <c>descriptorUpdateTemplate</c> handle.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>Set</c> is the set number of the descriptor set in the pipeline layout that will be updated. This <i>must</i> be the same number used to create the <c>descriptorUpdateTemplate</c> handle.
        /// </summary>
        [FieldOffset(32)]
        public int Set;

        /// <summary>
        ///     <c>Data</c> is a pointer to memory containing descriptors for the templated update.
        /// </summary>
        [FieldOffset(40)]
        public void* Data;
    }
}
