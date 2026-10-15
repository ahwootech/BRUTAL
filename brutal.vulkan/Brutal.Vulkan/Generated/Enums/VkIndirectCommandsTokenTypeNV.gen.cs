namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeNV.html">VkIndirectCommandsTokenTypeNV</see> - Enum specifying token commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of those elements of the
    ///         <c>VkIndirectCommandsLayoutCreateInfoNV::pTokens</c> array specifying
    ///         command tokens (other elements of the array specify command parameters) are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef enum VkIndirectCommandsTokenTypeNV {
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = 0,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = 1,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = 2,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = 3,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = 4,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = 5,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = 6,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = 7,
    ///             // Provided by VK_EXT_descriptor_heap with VK_NV_device_generated_commands
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_DATA_NV = 1000135000,
    ///             // Provided by VK_EXT_mesh_shader with VK_NV_device_generated_commands
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV = 1000328000,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV = 1000428003,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV = 1000428004,
    ///         } VkIndirectCommandsTokenTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkIndirectCommandsTokenTypeNV : int
    {
        /// <summary>
        ///     <c>ShaderGroupNV</c>
        /// </summary>
        ShaderGroupNV = 0,

        /// <summary>
        ///     <c>StateFlagsNV</c>
        /// </summary>
        StateFlagsNV = 1,

        /// <summary>
        ///     <c>IndexBufferNV</c>
        /// </summary>
        IndexBufferNV = 2,

        /// <summary>
        ///     <c>VertexBufferNV</c>
        /// </summary>
        VertexBufferNV = 3,

        /// <summary>
        ///     <c>PushConstantNV</c>
        /// </summary>
        PushConstantNV = 4,

        /// <summary>
        ///     <c>DrawIndexedNV</c>
        /// </summary>
        DrawIndexedNV = 5,

        /// <summary>
        ///     <c>DrawNV</c>
        /// </summary>
        DrawNV = 6,

        /// <summary>
        ///     <c>DrawTasksNV</c>
        /// </summary>
        DrawTasksNV = 7,

        /// <summary>
        ///     <c>PushDataNV</c>
        /// </summary>
        PushDataNV = 1000135000,

        /// <summary>
        ///     <c>DrawMeshTasksNV</c>
        /// </summary>
        DrawMeshTasksNV = 1000328000,

        /// <summary>
        ///     <c>PipelineNV</c>
        /// </summary>
        PipelineNV = 1000428003,

        /// <summary>
        ///     <c>DispatchNV</c>
        /// </summary>
        DispatchNV = 1000428004,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
