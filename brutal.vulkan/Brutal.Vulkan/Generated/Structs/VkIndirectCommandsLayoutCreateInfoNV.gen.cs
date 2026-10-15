namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoNV.html">VkIndirectCommandsLayoutCreateInfoNV</see> - Structure specifying the parameters of a newly created indirect commands layout object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsLayoutCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkIndirectCommandsLayoutCreateInfoNV {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkIndirectCommandsLayoutUsageFlagsNV      flags;
    ///             VkPipelineBindPoint                       pipelineBindPoint;
    ///             uint32_t                                  tokenCount;
    ///             const VkIndirectCommandsLayoutTokenNV*    pTokens;
    ///             uint32_t                                  streamCount;
    ///             const uint32_t*                           pStreamStrides;
    ///         } VkIndirectCommandsLayoutCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectCommandsLayoutCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkIndirectCommandsLayoutUsageFlagsNV</c> specifying usage hints of this layout.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectCommandsLayoutUsageFlagsNV Flags;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is the <c>VkPipelineBindPoint</c> that this layout targets.
        /// </summary>
        [FieldOffset(20)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>TokenCount</c> is the length of the individual command sequence.
        /// </summary>
        [FieldOffset(24)]
        public int TokenCount;

        /// <summary>
        ///     <c>Tokens</c> is an array describing each command token in detail. See <c>VkIndirectCommandsTokenTypeNV</c> and <c>VkIndirectCommandsLayoutTokenNV</c> below for details.
        /// </summary>
        [FieldOffset(32)]
        public VkIndirectCommandsLayoutTokenNV* Tokens;

        /// <summary>
        ///     <c>StreamCount</c> is the number of streams used to provide the token inputs.
        /// </summary>
        [FieldOffset(40)]
        public int StreamCount;

        /// <summary>
        ///     <c>StreamStrides</c> is an array defining the byte stride for each input stream.
        /// </summary>
        [FieldOffset(48)]
        public int* StreamStrides;
    }
}
