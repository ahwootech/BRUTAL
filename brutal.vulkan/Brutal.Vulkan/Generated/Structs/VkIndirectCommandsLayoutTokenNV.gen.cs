namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenNV.html">VkIndirectCommandsLayoutTokenNV</see> - Struct specifying the details of an indirect command layout token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsLayoutTokenNV</c> structure specifies details to the
    ///         function arguments that need to be known at layout creation time:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkIndirectCommandsLayoutTokenNV {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkIndirectCommandsTokenTypeNV    tokenType;
    ///             uint32_t                         stream;
    ///             uint32_t                         offset;
    ///             uint32_t                         vertexBindingUnit;
    ///             VkBool32                         vertexDynamicStride;
    ///             VkPipelineLayout                 pushconstantPipelineLayout;
    ///             VkShaderStageFlags               pushconstantShaderStageFlags;
    ///             uint32_t                         pushconstantOffset;
    ///             uint32_t                         pushconstantSize;
    ///             VkIndirectStateFlagsNV           indirectStateFlags;
    ///             uint32_t                         indexTypeCount;
    ///             const VkIndexType*               pIndexTypes;
    ///             const uint32_t*                  pIndexTypeValues;
    ///         } VkIndirectCommandsLayoutTokenNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkIndirectCommandsLayoutTokenNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.IndirectCommandsLayoutTokenNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TokenType</c> is a <c>VkIndirectCommandsTokenTypeNV</c> specifying the token command type.
        /// </summary>
        [FieldOffset(16)]
        public VkIndirectCommandsTokenTypeNV TokenType;

        /// <summary>
        ///     <c>Stream</c> is the index of the input stream containing the token argument data.
        /// </summary>
        [FieldOffset(20)]
        public int Stream;

        /// <summary>
        ///     <c>Offset</c> is a relative starting offset within the input stream memory for the token argument data.
        /// </summary>
        [FieldOffset(24)]
        public int Offset;

        /// <summary>
        ///     <c>VertexBindingUnit</c> is used for the vertex buffer binding command.
        /// </summary>
        [FieldOffset(28)]
        public int VertexBindingUnit;

        /// <summary>
        ///     <c>VertexDynamicStride</c> sets if the vertex buffer stride is provided by the binding command rather than the current bound graphics pipeline state.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 VertexDynamicStride;

        /// <summary>
        ///     <c>PushconstantPipelineLayout</c> is the <c>VkPipelineLayout</c> used for the push constant command.
        /// </summary>
        [FieldOffset(40)]
        public VkPipelineLayout PushconstantPipelineLayout;

        /// <summary>
        ///     <c>PushconstantShaderStageFlags</c> are the shader stage flags used for the push constant command.
        /// </summary>
        [FieldOffset(48)]
        public VkShaderStageFlags PushconstantShaderStageFlags;

        /// <summary>
        ///     <c>PushconstantOffset</c> is the offset used for the push constant command.
        /// </summary>
        [FieldOffset(52)]
        public int PushconstantOffset;

        /// <summary>
        ///     <c>PushconstantSize</c> is the size used for the push constant command.
        /// </summary>
        [FieldOffset(56)]
        public int PushconstantSize;

        /// <summary>
        ///     <c>IndirectStateFlags</c> is a <c>VkIndirectStateFlagsNV</c> bitfield indicating the active states for the state flag command.
        /// </summary>
        [FieldOffset(60)]
        public VkIndirectStateFlagsNV IndirectStateFlags;

        /// <summary>
        ///     <c>IndexTypeCount</c> is the optional size of the <c>pIndexTypes</c> and <c>pIndexTypeValues</c> array pairings. If not zero, it allows to register a custom `uint32_t` value to be treated as specific <c>VkIndexType</c>.
        /// </summary>
        [FieldOffset(64)]
        public int IndexTypeCount;

        /// <summary>
        ///     <c>IndexTypes</c> is the used <c>VkIndexType</c> for the corresponding `uint32_t` value entry in <c>pIndexTypeValues</c>.
        /// </summary>
        [FieldOffset(72)]
        public VkIndexType* IndexTypes;

        /// <summary>
        ///     <c>IndexTypeValues</c>
        /// </summary>
        [FieldOffset(80)]
        public int* IndexTypeValues;
    }
}
