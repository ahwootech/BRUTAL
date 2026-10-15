namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoEXT.html">VkIndirectExecutionSetInfoEXT</see> - Union specifying parameters of a newly created indirect execution set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectExecutionSetInfoEXT</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef union VkIndirectExecutionSetInfoEXT {
    ///             const VkIndirectExecutionSetPipelineInfoEXT*    pPipelineInfo;
    ///             const VkIndirectExecutionSetShaderInfoEXT*      pShaderInfo;
    ///         } VkIndirectExecutionSetInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkIndirectExecutionSetInfoEXT()
    {
        /// <summary>
        ///     <c>PipelineInfo</c> is a pointer to a <c>VkIndirectExecutionSetPipelineInfoEXT</c> structure containing pipeline layout information for the set.
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectExecutionSetPipelineInfoEXT* PipelineInfo;

        /// <summary>
        ///     <c>ShaderInfo</c> is a pointer to a <c>VkIndirectExecutionSetShaderInfoEXT</c> structure containing shader object layout information for the set.
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectExecutionSetShaderInfoEXT* ShaderInfo;
    }
}
