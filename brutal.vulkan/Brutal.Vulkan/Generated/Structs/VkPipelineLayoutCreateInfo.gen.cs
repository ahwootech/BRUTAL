namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateInfo.html">VkPipelineLayoutCreateInfo</see> - Structure specifying the parameters of a newly created pipeline layout object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineLayoutCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineLayoutCreateInfo {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkPipelineLayoutCreateFlags     flags;
    ///             uint32_t                        setLayoutCount;
    ///             const VkDescriptorSetLayout*    pSetLayouts;
    ///             uint32_t                        pushConstantRangeCount;
    ///             const VkPushConstantRange*      pPushConstantRanges;
    ///         } VkPipelineLayoutCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPipelineLayoutCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineLayoutCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineLayoutCreateFlags</c> specifying options for pipeline layout creation.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineLayoutCreateFlags Flags;

        /// <summary>
        ///     <c>SetLayoutCount</c> is the number of descriptor sets included in the pipeline layout.
        /// </summary>
        [FieldOffset(20)]
        public int SetLayoutCount;

        /// <summary>
        ///     <c>SetLayouts</c> is a pointer to an array of <c>VkDescriptorSetLayout</c> objects. The implementation <i>must</i> not access these objects outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorSetLayout* SetLayouts;

        /// <summary>
        ///     <c>PushConstantRangeCount</c> is the number of push constant ranges included in the pipeline layout.
        /// </summary>
        [FieldOffset(32)]
        public int PushConstantRangeCount;

        /// <summary>
        ///     <c>PushConstantRanges</c> is a pointer to an array of <c>VkPushConstantRange</c> structures defining a set of push constant ranges for use in a single pipeline layout. In addition to descriptor set layouts, a pipeline layout also describes how many push constants <i>can</i> be accessed by each stage of the pipeline. + [NOTE]
        /// </summary>
        [FieldOffset(40)]
        public VkPushConstantRange* PushConstantRanges;
    }
}
