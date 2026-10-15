namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineCreateInfo.html">VkGraphicsPipelineCreateInfo</see> - Structure specifying parameters of a newly created graphics pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGraphicsPipelineCreateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkGraphicsPipelineCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkGraphicsPipelineCreateInfo {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             VkPipelineCreateFlags                            flags;
    ///             uint32_t                                         stageCount;
    ///             const VkPipelineShaderStageCreateInfo*           pStages;
    ///             const VkPipelineVertexInputStateCreateInfo*      pVertexInputState;
    ///             const VkPipelineInputAssemblyStateCreateInfo*    pInputAssemblyState;
    ///             const VkPipelineTessellationStateCreateInfo*     pTessellationState;
    ///             const VkPipelineViewportStateCreateInfo*         pViewportState;
    ///             const VkPipelineRasterizationStateCreateInfo*    pRasterizationState;
    ///             const VkPipelineMultisampleStateCreateInfo*      pMultisampleState;
    ///             const VkPipelineDepthStencilStateCreateInfo*     pDepthStencilState;
    ///             const VkPipelineColorBlendStateCreateInfo*       pColorBlendState;
    ///             const VkPipelineDynamicStateCreateInfo*          pDynamicState;
    ///             VkPipelineLayout                                 layout;
    ///             VkRenderPass                                     renderPass;
    ///             uint32_t                                         subpass;
    ///             VkPipeline                                       basePipelineHandle;
    ///             int32_t                                          basePipelineIndex;
    ///         } VkGraphicsPipelineCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public unsafe partial struct VkGraphicsPipelineCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GraphicsPipelineCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineCreateFlags</c> specifying how the pipeline will be generated.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCreateFlags Flags;

        /// <summary>
        ///     <c>StageCount</c> is the number of entries in the <c>pStages</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int StageCount;

        /// <summary>
        ///     <c>Stages</c> is a pointer to an array of <c>stageCount</c> <c>VkPipelineShaderStageCreateInfo</c> structures describing the set of the shader stages to be included in the graphics pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineShaderStageCreateInfo* Stages;

        /// <summary>
        ///     <c>VertexInputState</c> is a pointer to a <c>VkPipelineVertexInputStateCreateInfo</c> structure.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineVertexInputStateCreateInfo* VertexInputState;

        /// <summary>
        ///     <c>InputAssemblyState</c> is a pointer to a <c>VkPipelineInputAssemblyStateCreateInfo</c> structure which determines input assembly behavior for vertex shading, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing">Drawing Commands^</see>.
        /// </summary>
        [FieldOffset(40)]
        public VkPipelineInputAssemblyStateCreateInfo* InputAssemblyState;

        /// <summary>
        ///     <c>TessellationState</c> is a pointer to a <c>VkPipelineTessellationStateCreateInfo</c> structure defining tessellation state used by tessellation shaders.
        /// </summary>
        [FieldOffset(48)]
        public VkPipelineTessellationStateCreateInfo* TessellationState;

        /// <summary>
        ///     <c>ViewportState</c> is a pointer to a <c>VkPipelineViewportStateCreateInfo</c> structure defining viewport state used when rasterization is enabled.
        /// </summary>
        [FieldOffset(56)]
        public VkPipelineViewportStateCreateInfo* ViewportState;

        /// <summary>
        ///     <c>RasterizationState</c> is a pointer to a <c>VkPipelineRasterizationStateCreateInfo</c> structure defining rasterization state.
        /// </summary>
        [FieldOffset(64)]
        public VkPipelineRasterizationStateCreateInfo* RasterizationState;

        /// <summary>
        ///     <c>MultisampleState</c> is a pointer to a <c>VkPipelineMultisampleStateCreateInfo</c> structure defining multisample state used when rasterization is enabled.
        /// </summary>
        [FieldOffset(72)]
        public VkPipelineMultisampleStateCreateInfo* MultisampleState;

        /// <summary>
        ///     <c>DepthStencilState</c> is a pointer to a <c>VkPipelineDepthStencilStateCreateInfo</c> structure defining depth/stencil state used when rasterization is enabled for depth or stencil attachments accessed during rendering.
        /// </summary>
        [FieldOffset(80)]
        public VkPipelineDepthStencilStateCreateInfo* DepthStencilState;

        /// <summary>
        ///     <c>ColorBlendState</c> is a pointer to a <c>VkPipelineColorBlendStateCreateInfo</c> structure defining color blend state used when rasterization is enabled for any color attachments accessed during rendering.
        /// </summary>
        [FieldOffset(88)]
        public VkPipelineColorBlendStateCreateInfo* ColorBlendState;

        /// <summary>
        ///     <c>DynamicState</c> is a pointer to a <c>VkPipelineDynamicStateCreateInfo</c> structure defining which properties of the pipeline state object are dynamic and <i>can</i> be changed independently of the pipeline state. This <i>can</i> be `NULL`, which means no state in the pipeline is considered dynamic.
        /// </summary>
        [FieldOffset(96)]
        public VkPipelineDynamicStateCreateInfo* DynamicState;

        /// <summary>
        ///     <c>Layout</c> is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        [FieldOffset(104)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>RenderPass</c> is a handle to a render pass object describing the environment in which the pipeline will be used. The pipeline <i>must</i> only be used with a render pass instance compatible with the one provided. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-compatibility">Render Pass Compatibility^</see> for more information. The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(112)]
        public VkRenderPass RenderPass;

        /// <summary>
        ///     <c>Subpass</c> is the index of the subpass in the render pass where this pipeline will be used.
        /// </summary>
        [FieldOffset(120)]
        public int Subpass;

        /// <summary>
        ///     <c>BasePipelineHandle</c> is a pipeline to derive from.
        /// </summary>
        [FieldOffset(128)]
        public VkPipeline BasePipelineHandle;

        /// <summary>
        ///     <c>BasePipelineIndex</c> is an index into the <c>pCreateInfos</c> parameter to use as a pipeline to derive from.
        /// </summary>
        [FieldOffset(136)]
        public int BasePipelineIndex;
    }
}
