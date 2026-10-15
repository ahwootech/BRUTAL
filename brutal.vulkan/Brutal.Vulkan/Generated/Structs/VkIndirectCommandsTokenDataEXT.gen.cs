namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenDataEXT.html">VkIndirectCommandsTokenDataEXT</see> - Union specifying the token-specific details of an indirect command layout token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsTokenDataEXT</c> structure provides token-specific
    ///         details used to generate the indirect execution layout.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef union VkIndirectCommandsTokenDataEXT {
    ///             const VkIndirectCommandsPushConstantTokenEXT*    pPushConstant;
    ///             const VkIndirectCommandsVertexBufferTokenEXT*    pVertexBuffer;
    ///             const VkIndirectCommandsIndexBufferTokenEXT*     pIndexBuffer;
    ///             const VkIndirectCommandsExecutionSetTokenEXT*    pExecutionSet;
    ///         } VkIndirectCommandsTokenDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkIndirectCommandsTokenDataEXT()
    {
        /// <summary>
        ///     <c>PushConstant</c> is a pointer to a <c>VkIndirectCommandsPushConstantTokenEXT</c> structure needed for <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT</c>, and <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT</c> tokens
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectCommandsPushConstantTokenEXT* PushConstant;

        /// <summary>
        ///     <c>VertexBuffer</c> is a pointer to a <c>VkIndirectCommandsVertexBufferTokenEXT</c> structure needed for <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT</c> tokens
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectCommandsVertexBufferTokenEXT* VertexBuffer;

        /// <summary>
        ///     <c>IndexBuffer</c> is a pointer to a <c>VkIndirectCommandsIndexBufferTokenEXT</c> structure needed for <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT</c> tokens
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectCommandsIndexBufferTokenEXT* IndexBuffer;

        /// <summary>
        ///     <c>ExecutionSet</c> is a pointer to a <c>VkIndirectCommandsExecutionSetTokenEXT</c> structure needed for <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT</c> tokens
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectCommandsExecutionSetTokenEXT* ExecutionSet;
    }
}
