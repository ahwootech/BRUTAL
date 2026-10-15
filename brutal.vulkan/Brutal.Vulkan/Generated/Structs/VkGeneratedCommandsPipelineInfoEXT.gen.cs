namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsPipelineInfoEXT.html">VkGeneratedCommandsPipelineInfoEXT</see> - Structure specifying a pipeline for use with indirect command preprocessing
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkGeneratedCommandsPipelineInfoEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkPipeline         pipeline;
    ///         } VkGeneratedCommandsPipelineInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkGeneratedCommandsPipelineInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsPipelineInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Pipeline</c> is a valid pipeline object.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline Pipeline;
    }
}
