namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeEXT.html">VkIndirectCommandsTokenTypeEXT</see> - Enum specifying token commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of those elements of the
    ///         <c>VkIndirectCommandsLayoutCreateInfoEXT::pTokens</c> array specifying
    ///         command tokens (other elements of the array specify command parameters) are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef enum VkIndirectCommandsTokenTypeEXT {
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT = 0,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT = 1,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT = 2,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT = 3,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT = 4,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT = 5,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT = 6,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT = 7,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT = 8,
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT = 9,
    ///             // Provided by VK_EXT_descriptor_heap with VK_EXT_device_generated_commands
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_DATA_EXT = 1000135000,
    ///             // Provided by VK_EXT_descriptor_heap with VK_EXT_device_generated_commands
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_DATA_SEQUENCE_INDEX_EXT = 1000135001,
    ///             // Provided by VK_EXT_device_generated_commands with VK_NV_mesh_shader
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT = 1000202002,
    ///             // Provided by VK_EXT_device_generated_commands with VK_NV_mesh_shader
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT = 1000202003,
    ///             // Provided by VK_EXT_device_generated_commands with VK_EXT_mesh_shader
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT = 1000328000,
    ///             // Provided by VK_EXT_device_generated_commands with VK_EXT_mesh_shader
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT = 1000328001,
    ///             // Provided by VK_KHR_ray_tracing_maintenance1 with VK_EXT_device_generated_commands
    ///             VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT = 1000386004,
    ///         } VkIndirectCommandsTokenTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkIndirectCommandsTokenTypeEXT : int
    {
        /// <summary>
        ///     <c>ExecutionSetEXT</c>
        /// </summary>
        ExecutionSetEXT = 0,

        /// <summary>
        ///     <c>PushConstantEXT</c>
        /// </summary>
        PushConstantEXT = 1,

        /// <summary>
        ///     <c>SequenceIndexEXT</c>
        /// </summary>
        SequenceIndexEXT = 2,

        /// <summary>
        ///     <c>IndexBufferEXT</c>
        /// </summary>
        IndexBufferEXT = 3,

        /// <summary>
        ///     <c>VertexBufferEXT</c>
        /// </summary>
        VertexBufferEXT = 4,

        /// <summary>
        ///     <c>DrawIndexedEXT</c>
        /// </summary>
        DrawIndexedEXT = 5,

        /// <summary>
        ///     <c>DrawEXT</c>
        /// </summary>
        DrawEXT = 6,

        /// <summary>
        ///     <c>DrawIndexedCountEXT</c>
        /// </summary>
        DrawIndexedCountEXT = 7,

        /// <summary>
        ///     <c>DrawCountEXT</c>
        /// </summary>
        DrawCountEXT = 8,

        /// <summary>
        ///     <c>DispatchEXT</c>
        /// </summary>
        DispatchEXT = 9,

        /// <summary>
        ///     <c>PushDataEXT</c>
        /// </summary>
        PushDataEXT = 1000135000,

        /// <summary>
        ///     <c>PushDataSequenceIndexEXT</c>
        /// </summary>
        PushDataSequenceIndexEXT = 1000135001,

        /// <summary>
        ///     <c>DrawMeshTasksNVEXT</c>
        /// </summary>
        DrawMeshTasksNVEXT = 1000202002,

        /// <summary>
        ///     <c>DrawMeshTasksCountNVEXT</c>
        /// </summary>
        DrawMeshTasksCountNVEXT = 1000202003,

        /// <summary>
        ///     <c>DrawMeshTasksEXT</c>
        /// </summary>
        DrawMeshTasksEXT = 1000328000,

        /// <summary>
        ///     <c>DrawMeshTasksCountEXT</c>
        /// </summary>
        DrawMeshTasksCountEXT = 1000328001,

        /// <summary>
        ///     <c>TraceRays2EXT</c>
        /// </summary>
        TraceRays2EXT = 1000386004,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
