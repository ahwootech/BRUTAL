namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWriteIndirectExecutionSetPipelineEXT.html">VkWriteIndirectExecutionSetPipelineEXT</see> - Struct specifying pipeline update information for an indirect execution set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWriteIndirectExecutionSetPipelineEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkWriteIndirectExecutionSetPipelineEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           index;
    ///             VkPipeline         pipeline;
    ///         } VkWriteIndirectExecutionSetPipelineEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkWriteIndirectExecutionSetPipelineEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WriteIndirectExecutionSetPipelineEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Index</c> is the element of the set to update
        /// </summary>
        [FieldOffset(16)]
        public int Index;

        /// <summary>
        ///     <c>Pipeline</c> is the pipeline to store in the indirect execution set
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline Pipeline;
    }
}
