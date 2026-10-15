namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGraphicsShaderGroupCreateInfoNV.html">VkGraphicsShaderGroupCreateInfoNV</see> - Structure specifying override parameters for each shader group
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGraphicsShaderGroupCreateInfoNV</c> structure provides the state
    ///         overrides for each shader group.
    ///         Each shader group behaves like a pipeline that was created from its state as
    ///         well as the remaining parent&apos;s state.
    ///         It is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkGraphicsShaderGroupCreateInfoNV {
    ///             VkStructureType                                 sType;
    ///             const void*                                     pNext;
    ///             uint32_t                                        stageCount;
    ///             const VkPipelineShaderStageCreateInfo*          pStages;
    ///             const VkPipelineVertexInputStateCreateInfo*     pVertexInputState;
    ///             const VkPipelineTessellationStateCreateInfo*    pTessellationState;
    ///         } VkGraphicsShaderGroupCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GraphicsShaderGroupCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StageCount</c> is the number of entries in the <c>pStages</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int StageCount;

        /// <summary>
        ///     <c>Stages</c> is a pointer to an array <c>VkPipelineShaderStageCreateInfo</c> structures specifying the set of the shader stages to be included in this shader group.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineShaderStageCreateInfo* Stages;

        /// <summary>
        ///     <c>VertexInputState</c> is a pointer to a <c>VkPipelineVertexInputStateCreateInfo</c> structure.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineVertexInputStateCreateInfo* VertexInputState;

        /// <summary>
        ///     <c>TessellationState</c> is a pointer to a <c>VkPipelineTessellationStateCreateInfo</c> structure, and is ignored if the shader group does not include a tessellation control shader stage and tessellation evaluation shader stage.
        /// </summary>
        [FieldOffset(40)]
        public VkPipelineTessellationStateCreateInfo* TessellationState;
    }
}
