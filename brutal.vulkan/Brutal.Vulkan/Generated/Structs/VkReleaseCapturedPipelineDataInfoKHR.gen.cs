namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkReleaseCapturedPipelineDataInfoKHR.html">VkReleaseCapturedPipelineDataInfoKHR</see> - Structure specifying a pipeline whose captured data is to be released
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkReleaseCapturedPipelineDataInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkReleaseCapturedPipelineDataInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkPipeline         pipeline;
    ///         } VkReleaseCapturedPipelineDataInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkReleaseCapturedPipelineDataInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ReleaseCapturedPipelineDataInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Pipeline</c> the handle of the pipeline object to release the data from.
        /// </summary>
        [FieldOffset(16)]
        public VkPipeline Pipeline;
    }
}
