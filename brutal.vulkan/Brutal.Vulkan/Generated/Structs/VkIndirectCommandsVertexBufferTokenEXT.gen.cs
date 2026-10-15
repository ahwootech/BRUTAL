namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsVertexBufferTokenEXT.html">VkIndirectCommandsVertexBufferTokenEXT</see> - Structure specifying layout token info for a single index buffer command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsVertexBufferTokenEXT</c> structure specifies the
    ///         layout token info for the
    ///         <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsVertexBufferTokenEXT {
    ///             uint32_t    vertexBindingUnit;
    ///         } VkIndirectCommandsVertexBufferTokenEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkIndirectCommandsVertexBufferTokenEXT()
    {
        /// <summary>
        ///     <c>VertexBindingUnit</c> is the vertex input binding number to be bound.
        /// </summary>
        [FieldOffset(0)]
        public int VertexBindingUnit;
    }
}
