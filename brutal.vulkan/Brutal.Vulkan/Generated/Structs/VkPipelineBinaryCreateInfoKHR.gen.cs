namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryCreateInfoKHR.html">VkPipelineBinaryCreateInfoKHR</see> - Structure specifying where to retrieve data for pipeline binary creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineBinaryCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkPipelineBinaryCreateInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             const VkPipelineBinaryKeysAndDataKHR*    pKeysAndDataInfo;
    ///             VkPipeline                               pipeline;
    ///             const VkPipelineCreateInfoKHR*           pPipelineCreateInfo;
    ///         } VkPipelineBinaryCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPipelineBinaryCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineBinaryCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>KeysAndDataInfo</c> is `NULL` or a pointer to a <c>VkPipelineBinaryKeysAndDataKHR</c> structure that contains keys and data to create the pipeline binaries from.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBinaryKeysAndDataKHR* KeysAndDataInfo;

        /// <summary>
        ///     <c>Pipeline</c> is <c>VK_NULL_HANDLE</c> or a <c>VkPipeline</c> that contains data to create the pipeline binaries from.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline Pipeline;

        /// <summary>
        ///     <c>PipelineCreateInfo</c> is `NULL` or a pointer to a <c>VkPipelineCreateInfoKHR</c> structure with the pipeline creation info. This is used to probe the implementation&apos;s internal cache for pipeline binaries.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineCreateInfoKHR* PipelineCreateInfo;
    }
}
