namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateCreateInfo.html">VkDescriptorUpdateTemplateCreateInfo</see> - Structure specifying parameters of a newly created descriptor update template
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorUpdateTemplateCreateInfo</c> structure is defined as:
    ///         <code>
    ///             // Provided by VK_VERSION_1_1
    ///             typedef struct VkDescriptorUpdateTemplateCreateInfo {
    ///                 VkStructureType                           sType;
    ///                 const void*                               pNext;
    ///                 VkDescriptorUpdateTemplateCreateFlags     flags;
    ///                 uint32_t                                  descriptorUpdateEntryCount;
    ///                 const VkDescriptorUpdateTemplateEntry*    pDescriptorUpdateEntries;
    ///                 VkDescriptorUpdateTemplateType            templateType;
    ///                 VkDescriptorSetLayout                     descriptorSetLayout;
    ///                 VkPipelineBindPoint                       pipelineBindPoint;
    ///                 VkPipelineLayout                          pipelineLayout;
    ///                 uint32_t                                  set;
    ///             } VkDescriptorUpdateTemplateCreateInfo;
    ///         </code>
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorUpdateTemplateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorUpdateTemplateCreateFlags Flags;

        /// <summary>
        ///     <c>DescriptorUpdateEntryCount</c> is the number of elements in the <c>pDescriptorUpdateEntries</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int DescriptorUpdateEntryCount;

        /// <summary>
        ///     <c>DescriptorUpdateEntries</c> is a pointer to an array of <c>VkDescriptorUpdateTemplateEntry</c> structures describing the descriptors to be updated by the descriptor update template.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorUpdateTemplateEntry* DescriptorUpdateEntries;

        /// <summary>
        ///     <c>TemplateType</c> Specifies the type of the descriptor update template. If set to <c>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET</c> it <i>can</i> only be used to update descriptor sets with a fixed <c>descriptorSetLayout</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkDescriptorUpdateTemplateType TemplateType;

        /// <summary>
        ///     <c>DescriptorSetLayout</c> is the descriptor set layout used to build the descriptor update template. All descriptor sets which are going to be updated through the newly created descriptor update template <i>must</i> be created with a layout that matches (is the same as, or defined identically to) this layout. This parameter is ignored if <c>templateType</c> is not <c>VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET</c>. The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(40)]
        public VkDescriptorSetLayout DescriptorSetLayout;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is reserved for future use and is ignored
        /// </summary>
        [FieldOffset(48)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>PipelineLayout</c> is reserved for future use and is ignored
        /// </summary>
        [FieldOffset(56)]
        public VkPipelineLayout PipelineLayout;

        /// <summary>
        ///     <c>Set</c> is reserved for future use and is ignored
        /// </summary>
        [FieldOffset(64)]
        public int Set;
    }
}
