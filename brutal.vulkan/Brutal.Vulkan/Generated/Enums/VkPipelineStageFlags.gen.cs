namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits.html">VkPipelineStageFlagBits</see> - Bitmask specifying pipeline stages
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in a <c>VkPipelineStageFlags</c> mask, specifying
    ///         stages of execution, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPipelineStageFlagBits {
    ///             VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 0x00000001,
    ///             VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 0x00000002,
    ///             VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 0x00000004,
    ///             VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 0x00000008,
    ///             VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = 0x00000010,
    ///             VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = 0x00000020,
    ///             VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 0x00000040,
    ///             VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 0x00000080,
    ///             VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 0x00000100,
    ///             VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 0x00000200,
    ///             VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 0x00000400,
    ///             VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 0x00000800,
    ///             VK_PIPELINE_STAGE_TRANSFER_BIT = 0x00001000,
    ///             VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = 0x00002000,
    ///             VK_PIPELINE_STAGE_HOST_BIT = 0x00004000,
    ///             VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = 0x00008000,
    ///             VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = 0x00010000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_STAGE_NONE = 0,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = 0x01000000,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 0x02000000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR = 0x00200000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT = 0x00080000,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT = 0x00100000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_EXT = 0x00020000,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV = VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV = VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV = VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV = VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV = VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV = VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_EXT,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_PIPELINE_STAGE_NONE_KHR = VK_PIPELINE_STAGE_NONE,
    ///         } VkPipelineStageFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineStageFlags : int
    {
        /// <summary>
        ///     <c>TopOfPipeBit</c> is equivalent to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c> with <c>VkAccessFlags</c> set to `0` when specified in the second synchronization scope, but specifies no stage of execution when specified in the first scope.
        /// </summary>
        TopOfPipeBit = 0x00000001,

        /// <summary>
        ///     <c>DrawIndirectBit</c> specifies the stage of the pipeline where stext:VkDrawIndirect* / stext:VkDispatchIndirect* / stext:VkTraceRaysIndirect* data structures are consumed.
        /// </summary>
        DrawIndirectBit = 0x00000002,

        /// <summary>
        ///     <c>VertexInputBit</c> specifies the stage of the pipeline where vertex and index buffers are consumed.
        /// </summary>
        VertexInputBit = 0x00000004,

        /// <summary>
        ///     <c>VertexShaderBit</c> specifies the vertex shader stage.
        /// </summary>
        VertexShaderBit = 0x00000008,

        /// <summary>
        ///     <c>TessellationControlShaderBit</c> specifies the tessellation control shader stage.
        /// </summary>
        TessellationControlShaderBit = 0x00000010,

        /// <summary>
        ///     <c>TessellationEvaluationShaderBit</c> specifies the tessellation evaluation shader stage.
        /// </summary>
        TessellationEvaluationShaderBit = 0x00000020,

        /// <summary>
        ///     <c>GeometryShaderBit</c> specifies the geometry shader stage.
        /// </summary>
        GeometryShaderBit = 0x00000040,

        /// <summary>
        ///     <c>FragmentShaderBit</c> specifies the fragment shader stage.
        /// </summary>
        FragmentShaderBit = 0x00000080,

        /// <summary>
        ///     <c>EarlyFragmentTestsBit</c> specifies the stage of the pipeline where early fragment tests (depth and stencil tests before fragment shading) are performed. This stage also includes <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">render pass load operations^</see> for framebuffer attachments with a depth/stencil format.
        /// </summary>
        EarlyFragmentTestsBit = 0x00000100,

        /// <summary>
        ///     <c>LateFragmentTestsBit</c> specifies the stage of the pipeline where late fragment tests (depth and stencil tests after fragment shading) are performed. This stage also includes <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">render pass store operations^</see> for framebuffer attachments with a depth/stencil format.
        /// </summary>
        LateFragmentTestsBit = 0x00000200,

        /// <summary>
        ///     <c>ColorAttachmentOutputBit</c> specifies the stage of the pipeline after blending where the final color values are output from the pipeline. This stage includes <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-blending">blending^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-logicop">logic operations^</see>, render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see> operations for color attachments, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-resolve-operations">render pass multisample resolve operations^</see>, and <c>vkCmdClearAttachments</c>.
        /// </summary>
        ColorAttachmentOutputBit = 0x00000400,

        /// <summary>
        ///     <c>ComputeShaderBit</c> specifies the execution of a compute shader.
        /// </summary>
        ComputeShaderBit = 0x00000800,

        /// <summary>
        ///     <c>TransferBit</c>
        /// </summary>
        TransferBit = 0x00001000,

        /// <summary>
        ///     <c>BottomOfPipeBit</c> is equivalent to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c> with <c>VkAccessFlags</c> set to `0` when specified in the first synchronization scope, but specifies no stage of execution when specified in the second scope.
        /// </summary>
        BottomOfPipeBit = 0x00002000,

        /// <summary>
        ///     <c>HostBit</c> specifies a pseudo-stage indicating execution on the host of reads/writes of device memory. This stage is not invoked by any commands recorded in a command buffer.
        /// </summary>
        HostBit = 0x00004000,

        /// <summary>
        ///     <c>AllGraphicsBit</c> specifies the execution of all graphics pipeline stages, and is equivalent to the logical OR of:
        /// </summary>
        AllGraphicsBit = 0x00008000,

        /// <summary>
        ///     <c>AllCommandsBit</c> specifies all operations performed by all commands supported on the queue it is used with.
        /// </summary>
        AllCommandsBit = 0x00010000,

        /// <summary>
        ///     <c>None</c>
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>TransformFeedbackBitEXT</c>
        /// </summary>
        TransformFeedbackBitEXT = 0x01000000,

        /// <summary>
        ///     <c>ConditionalRenderingBitEXT</c>
        /// </summary>
        ConditionalRenderingBitEXT = 0x00040000,

        /// <summary>
        ///     <c>AccelerationStructureBuildBitKHR</c>
        /// </summary>
        AccelerationStructureBuildBitKHR = 0x02000000,

        /// <summary>
        ///     <c>RayTracingShaderBitKHR</c>
        /// </summary>
        RayTracingShaderBitKHR = 0x00200000,

        /// <summary>
        ///     <c>FragmentDensityProcessBitEXT</c>
        /// </summary>
        FragmentDensityProcessBitEXT = 0x00800000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x00400000,

        /// <summary>
        ///     <c>TaskShaderBitEXT</c>
        /// </summary>
        TaskShaderBitEXT = 0x00080000,

        /// <summary>
        ///     <c>MeshShaderBitEXT</c>
        /// </summary>
        MeshShaderBitEXT = 0x00100000,

        /// <summary>
        ///     <c>CommandPreprocessBitEXT</c>
        /// </summary>
        CommandPreprocessBitEXT = 0x00020000,

        /// <summary>
        ///     <c>ShadingRateImageBitNV</c>
        /// </summary>
        ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,

        /// <summary>
        ///     <c>RayTracingShaderBitNV</c>
        /// </summary>
        RayTracingShaderBitNV = RayTracingShaderBitKHR,

        /// <summary>
        ///     <c>AccelerationStructureBuildBitNV</c>
        /// </summary>
        AccelerationStructureBuildBitNV = AccelerationStructureBuildBitKHR,

        /// <summary>
        ///     <c>TaskShaderBitNV</c>
        /// </summary>
        TaskShaderBitNV = TaskShaderBitEXT,

        /// <summary>
        ///     <c>MeshShaderBitNV</c>
        /// </summary>
        MeshShaderBitNV = MeshShaderBitEXT,

        /// <summary>
        ///     <c>CommandPreprocessBitNV</c>
        /// </summary>
        CommandPreprocessBitNV = CommandPreprocessBitEXT,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
