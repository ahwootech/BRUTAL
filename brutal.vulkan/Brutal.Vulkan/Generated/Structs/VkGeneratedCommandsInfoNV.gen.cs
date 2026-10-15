namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoNV.html">VkGeneratedCommandsInfoNV</see> - Structure specifying parameters for the generation of commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage:
    ///     </para>
    ///     <para>
    ///         The <c>VkGeneratedCommandsInfoNV</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkGeneratedCommandsInfoNV {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkPipelineBindPoint                  pipelineBindPoint;
    ///             VkPipeline                           pipeline;
    ///             VkIndirectCommandsLayoutNV           indirectCommandsLayout;
    ///             uint32_t                             streamCount;
    ///             const VkIndirectCommandsStreamNV*    pStreams;
    ///             uint32_t                             sequencesCount;
    ///             VkBuffer                             preprocessBuffer;
    ///             VkDeviceSize                         preprocessOffset;
    ///             VkDeviceSize                         preprocessSize;
    ///             VkBuffer                             sequencesCountBuffer;
    ///             VkDeviceSize                         sequencesCountOffset;
    ///             VkBuffer                             sequencesIndexBuffer;
    ///             VkDeviceSize                         sequencesIndexOffset;
    ///         } VkGeneratedCommandsInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public unsafe partial struct VkGeneratedCommandsInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeneratedCommandsInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is the <c>VkPipelineBindPoint</c> used for the <c>pipeline</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>Pipeline</c> is the <c>VkPipeline</c> used in the generation and execution process.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline Pipeline;

        /// <summary>
        ///     <c>IndirectCommandsLayout</c> is the <c>VkIndirectCommandsLayoutNV</c> that provides the command sequence to generate.
        /// </summary>
        [FieldOffset(32)]
        public VkIndirectCommandsLayoutNV IndirectCommandsLayout;

        /// <summary>
        ///     <c>StreamCount</c> defines the number of input streams
        /// </summary>
        [FieldOffset(40)]
        public int StreamCount;

        /// <summary>
        ///     <c>Streams</c> is a pointer to an array of <c>streamCount</c> <c>VkIndirectCommandsStreamNV</c> structures providing the input data for the tokens used in <c>indirectCommandsLayout</c>.
        /// </summary>
        [FieldOffset(48)]
        public VkIndirectCommandsStreamNV* Streams;

        /// <summary>
        ///     <c>SequencesCount</c> is the maximum number of sequences to reserve. If <c>sequencesCountBuffer</c> is <c>VK_NULL_HANDLE</c>, this is also the actual number of sequences generated.
        /// </summary>
        [FieldOffset(56)]
        public int SequencesCount;

        /// <summary>
        ///     <c>PreprocessBuffer</c> is the <c>VkBuffer</c> that is used for preprocessing the input data for execution. If this structure is used with <c>vkCmdExecuteGeneratedCommandsNV</c> with its <c>isPreprocessed</c> set to <c>VK_TRUE</c>, then the preprocessing step is skipped and data in this buffer will not be modified. The contents and the layout of this buffer are opaque to applications and <i>must</i> not be modified outside functions related to device-generated commands or copied to another buffer for reuse.
        /// </summary>
        [FieldOffset(64)]
        public VkBuffer PreprocessBuffer;

        /// <summary>
        ///     <c>PreprocessOffset</c> is the byte offset into <c>preprocessBuffer</c> where the preprocessed data is stored.
        /// </summary>
        [FieldOffset(72)]
        public ByteSize64 PreprocessOffset;

        /// <summary>
        ///     <c>PreprocessSize</c> is the maximum byte size within the <c>preprocessBuffer</c> after the <c>preprocessOffset</c> that is available for preprocessing.
        /// </summary>
        [FieldOffset(80)]
        public ByteSize64 PreprocessSize;

        /// <summary>
        ///     <c>SequencesCountBuffer</c> is a <c>VkBuffer</c> in which the actual number of sequences is provided as single <c>uint32_t</c> value.
        /// </summary>
        [FieldOffset(88)]
        public VkBuffer SequencesCountBuffer;

        /// <summary>
        ///     <c>SequencesCountOffset</c> is the byte offset into <c>sequencesCountBuffer</c> where the count value is stored.
        /// </summary>
        [FieldOffset(96)]
        public ByteSize64 SequencesCountOffset;

        /// <summary>
        ///     <c>SequencesIndexBuffer</c> is a <c>VkBuffer</c> that encodes the used sequence indices as <c>uint32_t</c> array.
        /// </summary>
        [FieldOffset(104)]
        public VkBuffer SequencesIndexBuffer;

        /// <summary>
        ///     <c>SequencesIndexOffset</c> is the byte offset into <c>sequencesIndexBuffer</c> where the index values start.
        /// </summary>
        [FieldOffset(112)]
        public ByteSize64 SequencesIndexOffset;
    }
}
