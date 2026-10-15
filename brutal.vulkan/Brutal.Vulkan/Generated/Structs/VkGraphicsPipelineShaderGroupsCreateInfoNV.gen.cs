namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineShaderGroupsCreateInfoNV.html">VkGraphicsPipelineShaderGroupsCreateInfoNV</see> - Structure specifying parameters of a newly created multi shader group pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGraphicsPipelineShaderGroupsCreateInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkGraphicsPipelineShaderGroupsCreateInfoNV {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             uint32_t                                    groupCount;
    ///             const VkGraphicsShaderGroupCreateInfoNV*    pGroups;
    ///             uint32_t                                    pipelineCount;
    ///             const VkPipeline*                           pPipelines;
    ///         } VkGraphicsPipelineShaderGroupsCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GraphicsPipelineShaderGroupsCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GroupCount</c> is the number of elements in the <c>pGroups</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int GroupCount;

        /// <summary>
        ///     <c>Groups</c> is a pointer to an array of <c>VkGraphicsShaderGroupCreateInfoNV</c> structures specifying which state of the original <c>VkGraphicsPipelineCreateInfo</c> each shader group overrides.
        /// </summary>
        [FieldOffset(24)]
        public VkGraphicsShaderGroupCreateInfoNV* Groups;

        /// <summary>
        ///     <c>PipelineCount</c> is the number of elements in the <c>pPipelines</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int PipelineCount;

        /// <summary>
        ///     <c>Pipelines</c> is a pointer to an array of graphics <c>VkPipeline</c> structures which are referenced within the created pipeline, including all their shader groups.
        /// </summary>
        [FieldOffset(40)]
        public VkPipeline* Pipelines;
    }
}
