namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackCreateInfo.html">VkPipelineCreationFeedbackCreateInfo</see> - Request for feedback about the creation of a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Feedback about the creation of a particular pipeline object <i>can</i> be obtained
    ///         by adding a <c>VkPipelineCreationFeedbackCreateInfo</c> structure to the
    ///         <c>pNext</c> chain of <c>VkGraphicsPipelineCreateInfo</c>,
    ///         or <c>VkComputePipelineCreateInfo</c>.
    ///         The <c>VkPipelineCreationFeedbackCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPipelineCreationFeedbackCreateInfo {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkPipelineCreationFeedback*    pPipelineCreationFeedback;
    ///             uint32_t                       pipelineStageCreationFeedbackCount;
    ///             VkPipelineCreationFeedback*    pPipelineStageCreationFeedbacks;
    ///         } VkPipelineCreationFeedbackCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPipelineCreationFeedbackCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineCreationFeedbackCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineCreationFeedback</c> is a pointer to a <c>VkPipelineCreationFeedback</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCreationFeedback* PipelineCreationFeedback;

        /// <summary>
        ///     <c>PipelineStageCreationFeedbackCount</c> is the number of elements in <c>pPipelineStageCreationFeedbacks</c>.
        /// </summary>
        [FieldOffset(24)]
        public int PipelineStageCreationFeedbackCount;

        /// <summary>
        ///     <c>PipelineStageCreationFeedbacks</c> is a pointer to an array of <c>pipelineStageCreationFeedbackCount</c> <c>VkPipelineCreationFeedback</c> structures.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineCreationFeedback* PipelineStageCreationFeedbacks;
    }
}
