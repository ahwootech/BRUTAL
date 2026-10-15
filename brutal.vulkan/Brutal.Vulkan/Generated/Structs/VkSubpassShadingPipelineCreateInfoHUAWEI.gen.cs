namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassShadingPipelineCreateInfoHUAWEI.html">VkSubpassShadingPipelineCreateInfoHUAWEI</see> - Structure specifying parameters of a newly created subpass shading pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A subpass shading pipeline is a compute pipeline which <i>must</i> be called only
    ///         in a subpass of a render pass with work dimensions specified by render area
    ///         size.
    ///         The subpass shading pipeline shader is a compute shader allowed to access
    ///         input attachments specified in the calling subpass.
    ///         To create a subpass shading pipeline, call <c>vkCreateComputePipelines</c>
    ///         with <c>VkSubpassShadingPipelineCreateInfoHUAWEI</c> in the <c>pNext</c> chain
    ///         of <c>VkComputePipelineCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSubpassShadingPipelineCreateInfoHUAWEI</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_subpass_shading
    ///         typedef struct VkSubpassShadingPipelineCreateInfoHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkRenderPass       renderPass;
    ///             uint32_t           subpass;
    ///         } VkSubpassShadingPipelineCreateInfoHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSubpassShadingPipelineCreateInfoHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassShadingPipelineCreateInfoHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPass</c> is a handle to a render pass object describing the environment in which the pipeline will be used. The pipeline <i>must</i> only be used with a render pass instance compatible with the one provided. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-compatibility">Render Pass Compatibility^</see> for more information. The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPass RenderPass;

        /// <summary>
        ///     <c>Subpass</c> is the index of the subpass in the render pass where this pipeline will be used.
        /// </summary>
        [FieldOffset(24)]
        public int Subpass;
    }
}
