namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetPipelineInfoEXT.html">VkIndirectExecutionSetPipelineInfoEXT</see> - Struct specifying parameters of a newly created indirect execution set containing only pipelines
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectExecutionSetPipelineInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectExecutionSetPipelineInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkPipeline         initialPipeline;
    ///             uint32_t           maxPipelineCount;
    ///         } VkIndirectExecutionSetPipelineInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkIndirectExecutionSetPipelineInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectExecutionSetPipelineInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>InitialPipeline</c> is the initial pipeline for the set. This pipeline will be automatically added to the set at index `0`.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline InitialPipeline;

        /// <summary>
        ///     <c>MaxPipelineCount</c> is the maximum number of pipelines stored in the set.
        /// </summary>
        [FieldOffset(24)]
        public int MaxPipelineCount;
    }
}
