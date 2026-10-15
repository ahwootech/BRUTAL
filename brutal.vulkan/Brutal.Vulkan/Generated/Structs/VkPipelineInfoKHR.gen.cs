namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineInfoKHR.html">VkPipelineInfoKHR</see> - Structure describing a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPipelineInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkPipeline         pipeline;
    ///         } VkPipelineInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Pipeline</c> is a <c>VkPipeline</c> handle.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline Pipeline;
    }
}
