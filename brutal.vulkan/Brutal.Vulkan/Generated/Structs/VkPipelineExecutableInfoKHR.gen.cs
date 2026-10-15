namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInfoKHR.html">VkPipelineExecutableInfoKHR</see> - Structure describing a pipeline executable to query for associated statistics or internal representations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutableInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPipelineExecutableInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkPipeline         pipeline;
    ///             uint32_t           executableIndex;
    ///         } VkPipelineExecutableInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineExecutableInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineExecutableInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Pipeline</c> is the pipeline to query.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline Pipeline;

        /// <summary>
        ///     <c>ExecutableIndex</c> is the index of the pipeline executable to query in the array of executable properties returned by <c>vkGetPipelineExecutablePropertiesKHR</c>.
        /// </summary>
        [FieldOffset(24)]
        public int ExecutableIndex;
    }
}
