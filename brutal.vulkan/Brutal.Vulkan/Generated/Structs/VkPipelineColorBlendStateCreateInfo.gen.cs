namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateInfo.html">VkPipelineColorBlendStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline color blend state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineColorBlendStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineColorBlendStateCreateInfo {
    ///             VkStructureType                               sType;
    ///             const void*                                   pNext;
    ///             VkPipelineColorBlendStateCreateFlags          flags;
    ///             VkBool32                                      logicOpEnable;
    ///             VkLogicOp                                     logicOp;
    ///             uint32_t                                      attachmentCount;
    ///             const VkPipelineColorBlendAttachmentState*    pAttachments;
    ///             float                                         blendConstants[4];
    ///         } VkPipelineColorBlendStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPipelineColorBlendStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineColorBlendStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineColorBlendStateCreateFlags Flags;

        /// <summary>
        ///     <c>LogicOpEnable</c> controls whether to apply <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-logicop">Logical Operations^</see>.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 LogicOpEnable;

        /// <summary>
        ///     <c>LogicOp</c> selects which logical operation to apply.
        /// </summary>
        [FieldOffset(24)]
        public VkLogicOp LogicOp;

        /// <summary>
        ///     <c>AttachmentCount</c> is the number of <c>VkPipelineColorBlendAttachmentState</c> elements in <c>pAttachments</c>.
        /// </summary>
        [FieldOffset(28)]
        public int AttachmentCount;

        /// <summary>
        ///     <c>Attachments</c> is a pointer to an array of <c>VkPipelineColorBlendAttachmentState</c> structures defining blend state for each color attachment.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineColorBlendAttachmentState* Attachments;

        /// <summary>
        ///     <c>BlendConstants</c> is a pointer to an array of four values used as the R, G, B, and A components of the blend constant that are used in blending, depending on the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-blendfactors">blend factor^</see>.
        /// </summary>
        [FieldOffset(40)]
        public float4 BlendConstants;
    }
}
