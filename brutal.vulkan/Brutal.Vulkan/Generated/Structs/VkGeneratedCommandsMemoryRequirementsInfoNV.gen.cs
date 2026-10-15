namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoNV.html">VkGeneratedCommandsMemoryRequirementsInfoNV</see> - Structure specifying parameters for the reservation of preprocess buffer space
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkGeneratedCommandsMemoryRequirementsInfoNV {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkPipelineBindPoint           pipelineBindPoint;
    ///             VkPipeline                    pipeline;
    ///             VkIndirectCommandsLayoutNV    indirectCommandsLayout;
    ///             uint32_t                      maxSequencesCount;
    ///         } VkGeneratedCommandsMemoryRequirementsInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsMemoryRequirementsInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is the <c>VkPipelineBindPoint</c> of the <c>pipeline</c> that this buffer memory is intended to be used with during the execution.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>Pipeline</c> is the <c>VkPipeline</c> that this buffer memory is intended to be used with during the execution.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline Pipeline;

        /// <summary>
        ///     <c>IndirectCommandsLayout</c> is the <c>VkIndirectCommandsLayoutNV</c> that this buffer memory is intended to be used with.
        /// </summary>
        [FieldOffset(32)]
        public VkIndirectCommandsLayoutNV IndirectCommandsLayout;

        /// <summary>
        ///     <c>MaxSequencesCount</c> is the maximum number of sequences that this buffer memory in combination with the other state provided <i>can</i> be used with.
        /// </summary>
        [FieldOffset(40)]
        public int MaxSequencesCount;
    }
}
