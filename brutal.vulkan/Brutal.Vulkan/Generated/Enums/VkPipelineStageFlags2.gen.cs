namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineStageFlagBits2.html">VkPipelineStageFlagBits2</see> - Pipeline stage flags for VkPipelineStageFlags2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in a <c>VkPipelineStageFlags2</c> mask, specifying
    ///         stages of execution, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         // Flag bits for VkPipelineStageFlagBits2
    ///         typedef VkFlags64 VkPipelineStageFlagBits2;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_NONE = 0ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT = 0x00000001ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT = 0x00000002ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT = 0x00000004ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT = 0x00000008ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT = 0x00000010ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT = 0x00000020ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT = 0x00000040ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT = 0x00000080ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT = 0x00000100ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT = 0x00000200ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT = 0x00000400ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT = 0x00000800ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT = 0x00001000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TRANSFER_BIT = 0x00001000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT = 0x00002000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_HOST_BIT = 0x00004000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT = 0x00008000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT = 0x00010000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COPY_BIT = 0x100000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_RESOLVE_BIT = 0x200000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_BLIT_BIT = 0x400000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_CLEAR_BIT = 0x800000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT = 0x1000000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT = 0x2000000000ULL;
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT = 0x4000000000ULL;
    ///             // Provided by VK_KHR_video_decode_queue
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR = 0x04000000ULL;
    ///             // Provided by VK_KHR_video_encode_queue
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR = 0x08000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_NONE_KHR = 0ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR = 0x00000001ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR = 0x00000002ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR = 0x00000004ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR = 0x00000008ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR = 0x00000020ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR = 0x00000200ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR = 0x00002000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_HOST_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR = 0x00010000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COPY_BIT_KHR = 0x100000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR = 0x200000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_BLIT_BIT_KHR = 0x400000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR = 0x800000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR = 0x1000000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR = 0x2000000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR = 0x4000000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_transform_feedback
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = 0x01000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_conditional_rendering
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_device_generated_commands
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 0x00020000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_device_generated_commands
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT = 0x00020000ULL;
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_shading_rate_image
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV = 0x00400000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 0x02000000ULL;
    ///             // Provided by VK_KHR_ray_tracing_pipeline with VK_KHR_synchronization2
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = 0x00200000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_ray_tracing
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV = 0x00200000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_ray_tracing
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV = 0x02000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_fragment_density_map
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_mesh_shader
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV = 0x00080000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_mesh_shader
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 0x00100000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_mesh_shader
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT = 0x00080000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_mesh_shader
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT = 0x00100000ULL;
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI = 0x8000000000ULL;
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             // VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI is a legacy alias
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 0x8000000000ULL;
    ///             // Provided by VK_HUAWEI_invocation_mask
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 0x10000000000ULL;
    ///             // Provided by VK_KHR_ray_tracing_maintenance1 with VK_KHR_synchronization2 or VK_VERSION_1_3
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR = 0x10000000ULL;
    ///             // Provided by VK_EXT_opacity_micromap
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT = 0x40000000ULL;
    ///             // Provided by VK_HUAWEI_cluster_culling_shader
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI = 0x20000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV = 0x20000000ULL;
    ///             // Provided by VK_NV_cooperative_vector
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_CONVERT_COOPERATIVE_VECTOR_MATRIX_BIT_NV = 0x100000000000ULL;
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_DATA_GRAPH_BIT_ARM = 0x40000000000ULL;
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_COPY_INDIRECT_BIT_KHR = 0x400000000000ULL;
    ///             // Provided by VK_EXT_memory_decompression
    ///             static const VkPipelineStageFlagBits2 VK_PIPELINE_STAGE_2_MEMORY_DECOMPRESSION_BIT_EXT = 0x200000000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkPipelineStageFlags2 : ulong
    {
        /// <summary>
        ///     <c>None</c> specifies no stages of execution.
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>TopOfPipeBit</c> is equivalent to <c>VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT</c> with <c>VkAccessFlags2</c> set to `0` when specified in the second synchronization scope, but equivalent to <c>VK_PIPELINE_STAGE_2_NONE</c> in the first scope.
        /// </summary>
        TopOfPipeBit = 0x00000001,

        /// <summary>
        ///     <c>DrawIndirectBit</c> specifies the stage of the pipeline where indirect command parameters are consumed.
        /// </summary>
        DrawIndirectBit = 0x00000002,

        /// <summary>
        ///     <c>VertexInputBit</c> is equivalent to the logical OR of: include::{generated}/sync/flagDefinitions/VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT.adoc[]
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
        ///     <c>ColorAttachmentOutputBit</c> specifies the stage of the pipeline where final color values are output from the pipeline. This stage includes <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-blending">blending^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-logicop">logic operations^</see>, render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see> operations for color attachments, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-resolve-operations">render pass multisample resolve operations^</see>, and <c>vkCmdClearAttachments</c>.
        /// </summary>
        ColorAttachmentOutputBit = 0x00000400,

        /// <summary>
        ///     <c>ComputeShaderBit</c> specifies the compute shader stage.
        /// </summary>
        ComputeShaderBit = 0x00000800,

        /// <summary>
        ///     <c>AllTransferBit</c> is equivalent to specifying all of: include::{generated}/sync/flagDefinitions/VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT.adoc[]
        /// </summary>
        AllTransferBit = 0x00001000,

        /// <summary>
        ///     <c>TransferBit</c>
        /// </summary>
        TransferBit = 0x00001000,

        /// <summary>
        ///     <c>BottomOfPipeBit</c> is equivalent to <c>VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT</c> with <c>VkAccessFlags2</c> set to `0` when specified in the first synchronization scope, but equivalent to <c>VK_PIPELINE_STAGE_2_NONE</c> in the second scope.  [NOTE]
        /// </summary>
        BottomOfPipeBit = 0x00002000,

        /// <summary>
        ///     <c>HostBit</c> specifies a pseudo-stage indicating execution on the host of reads/writes of device memory. This stage is not invoked by any commands recorded in a command buffer.
        /// </summary>
        HostBit = 0x00004000,

        /// <summary>
        ///     <c>AllGraphicsBit</c> specifies the execution of all graphics pipeline stages, and is equivalent to the logical OR of: include::{generated}/sync/flagDefinitions/VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT.adoc[]
        /// </summary>
        AllGraphicsBit = 0x00008000,

        /// <summary>
        ///     <c>AllCommandsBit</c> specifies all operations performed by all commands supported on the queue it is used with.
        /// </summary>
        AllCommandsBit = 0x00010000,

        /// <summary>
        ///     <c>CopyBit</c> specifies the execution of all <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">copy commands^</see>, including <c>vkCmdCopyQueryPoolResults</c>.
        /// </summary>
        CopyBit = 0x100000000,

        /// <summary>
        ///     <c>ResolveBit</c> specifies the execution of <c>vkCmdResolveImage</c>.
        /// </summary>
        ResolveBit = 0x200000000,

        /// <summary>
        ///     <c>BlitBit</c> specifies the execution of <c>vkCmdBlitImage</c>.
        /// </summary>
        BlitBit = 0x400000000,

        /// <summary>
        ///     <c>ClearBit</c> specifies the execution of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#clears">clear commands^</see>, with the exception of <c>vkCmdClearAttachments</c>.
        /// </summary>
        ClearBit = 0x800000000,

        /// <summary>
        ///     <c>IndexInputBit</c> specifies the stage of the pipeline where index buffers are consumed.
        /// </summary>
        IndexInputBit = 0x1000000000,

        /// <summary>
        ///     <c>VertexAttributeInputBit</c> specifies the stage of the pipeline where vertex buffers are consumed.
        /// </summary>
        VertexAttributeInputBit = 0x2000000000,

        /// <summary>
        ///     <c>PreRasterizationShadersBit</c> is equivalent to specifying all supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-graphics-subsets-pre-rasterization">pre-rasterization shader stages^</see>: include::{generated}/sync/flagDefinitions/VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT.adoc[]
        /// </summary>
        PreRasterizationShadersBit = 0x4000000000,

        /// <summary>
        ///     <c>VideoDecodeBitKHR</c>
        /// </summary>
        VideoDecodeBitKHR = 0x04000000,

        /// <summary>
        ///     <c>VideoEncodeBitKHR</c>
        /// </summary>
        VideoEncodeBitKHR = 0x08000000,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = 0,

        /// <summary>
        ///     <c>TopOfPipeBitKHR</c>
        /// </summary>
        TopOfPipeBitKHR = 0x00000001,

        /// <summary>
        ///     <c>DrawIndirectBitKHR</c>
        /// </summary>
        DrawIndirectBitKHR = 0x00000002,

        /// <summary>
        ///     <c>VertexInputBitKHR</c>
        /// </summary>
        VertexInputBitKHR = 0x00000004,

        /// <summary>
        ///     <c>VertexShaderBitKHR</c>
        /// </summary>
        VertexShaderBitKHR = 0x00000008,

        /// <summary>
        ///     <c>TessellationControlShaderBitKHR</c>
        /// </summary>
        TessellationControlShaderBitKHR = 0x00000010,

        /// <summary>
        ///     <c>TessellationEvaluationShaderBitKHR</c>
        /// </summary>
        TessellationEvaluationShaderBitKHR = 0x00000020,

        /// <summary>
        ///     <c>GeometryShaderBitKHR</c>
        /// </summary>
        GeometryShaderBitKHR = 0x00000040,

        /// <summary>
        ///     <c>FragmentShaderBitKHR</c>
        /// </summary>
        FragmentShaderBitKHR = 0x00000080,

        /// <summary>
        ///     <c>EarlyFragmentTestsBitKHR</c>
        /// </summary>
        EarlyFragmentTestsBitKHR = 0x00000100,

        /// <summary>
        ///     <c>LateFragmentTestsBitKHR</c>
        /// </summary>
        LateFragmentTestsBitKHR = 0x00000200,

        /// <summary>
        ///     <c>ColorAttachmentOutputBitKHR</c>
        /// </summary>
        ColorAttachmentOutputBitKHR = 0x00000400,

        /// <summary>
        ///     <c>ComputeShaderBitKHR</c>
        /// </summary>
        ComputeShaderBitKHR = 0x00000800,

        /// <summary>
        ///     <c>AllTransferBitKHR</c>
        /// </summary>
        AllTransferBitKHR = 0x00001000,

        /// <summary>
        ///     <c>TransferBitKHR</c>
        /// </summary>
        TransferBitKHR = 0x00001000,

        /// <summary>
        ///     <c>BottomOfPipeBitKHR</c>
        /// </summary>
        BottomOfPipeBitKHR = 0x00002000,

        /// <summary>
        ///     <c>HostBitKHR</c>
        /// </summary>
        HostBitKHR = 0x00004000,

        /// <summary>
        ///     <c>AllGraphicsBitKHR</c>
        /// </summary>
        AllGraphicsBitKHR = 0x00008000,

        /// <summary>
        ///     <c>AllCommandsBitKHR</c>
        /// </summary>
        AllCommandsBitKHR = 0x00010000,

        /// <summary>
        ///     <c>CopyBitKHR</c>
        /// </summary>
        CopyBitKHR = 0x100000000,

        /// <summary>
        ///     <c>ResolveBitKHR</c>
        /// </summary>
        ResolveBitKHR = 0x200000000,

        /// <summary>
        ///     <c>BlitBitKHR</c>
        /// </summary>
        BlitBitKHR = 0x400000000,

        /// <summary>
        ///     <c>ClearBitKHR</c>
        /// </summary>
        ClearBitKHR = 0x800000000,

        /// <summary>
        ///     <c>IndexInputBitKHR</c>
        /// </summary>
        IndexInputBitKHR = 0x1000000000,

        /// <summary>
        ///     <c>VertexAttributeInputBitKHR</c>
        /// </summary>
        VertexAttributeInputBitKHR = 0x2000000000,

        /// <summary>
        ///     <c>PreRasterizationShadersBitKHR</c>
        /// </summary>
        PreRasterizationShadersBitKHR = 0x4000000000,

        /// <summary>
        ///     <c>TransformFeedbackBitEXT</c>
        /// </summary>
        TransformFeedbackBitEXT = 0x01000000,

        /// <summary>
        ///     <c>ConditionalRenderingBitEXT</c>
        /// </summary>
        ConditionalRenderingBitEXT = 0x00040000,

        /// <summary>
        ///     <c>CommandPreprocessBitNV</c>
        /// </summary>
        CommandPreprocessBitNV = 0x00020000,

        /// <summary>
        ///     <c>CommandPreprocessBitEXT</c>
        /// </summary>
        CommandPreprocessBitEXT = 0x00020000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentBitKHR = 0x00400000,

        /// <summary>
        ///     <c>ShadingRateImageBitNV</c>
        /// </summary>
        ShadingRateImageBitNV = 0x00400000,

        /// <summary>
        ///     <c>AccelerationStructureBuildBitKHR</c>
        /// </summary>
        AccelerationStructureBuildBitKHR = 0x02000000,

        /// <summary>
        ///     <c>RayTracingShaderBitKHR</c>
        /// </summary>
        RayTracingShaderBitKHR = 0x00200000,

        /// <summary>
        ///     <c>RayTracingShaderBitNV</c>
        /// </summary>
        RayTracingShaderBitNV = 0x00200000,

        /// <summary>
        ///     <c>AccelerationStructureBuildBitNV</c>
        /// </summary>
        AccelerationStructureBuildBitNV = 0x02000000,

        /// <summary>
        ///     <c>FragmentDensityProcessBitEXT</c>
        /// </summary>
        FragmentDensityProcessBitEXT = 0x00800000,

        /// <summary>
        ///     <c>TaskShaderBitNV</c>
        /// </summary>
        TaskShaderBitNV = 0x00080000,

        /// <summary>
        ///     <c>MeshShaderBitNV</c>
        /// </summary>
        MeshShaderBitNV = 0x00100000,

        /// <summary>
        ///     <c>TaskShaderBitEXT</c>
        /// </summary>
        TaskShaderBitEXT = 0x00080000,

        /// <summary>
        ///     <c>MeshShaderBitEXT</c>
        /// </summary>
        MeshShaderBitEXT = 0x00100000,

        /// <summary>
        ///     <c>SubpassShaderBitHUAWEI</c>
        /// </summary>
        SubpassShaderBitHUAWEI = 0x8000000000,

        /// <summary>
        ///     <c>SubpassShadingBitHUAWEI</c>
        /// </summary>
        SubpassShadingBitHUAWEI = 0x8000000000,

        /// <summary>
        ///     <c>InvocationMaskBitHUAWEI</c>
        /// </summary>
        InvocationMaskBitHUAWEI = 0x10000000000,

        /// <summary>
        ///     <c>AccelerationStructureCopyBitKHR</c>
        /// </summary>
        AccelerationStructureCopyBitKHR = 0x10000000,

        /// <summary>
        ///     <c>MicromapBuildBitEXT</c>
        /// </summary>
        MicromapBuildBitEXT = 0x40000000,

        /// <summary>
        ///     <c>ClusterCullingShaderBitHUAWEI</c>
        /// </summary>
        ClusterCullingShaderBitHUAWEI = 0x20000000000,

        /// <summary>
        ///     <c>OpticalFlowBitNV</c>
        /// </summary>
        OpticalFlowBitNV = 0x20000000,

        /// <summary>
        ///     <c>ConvertCooperativeVectorMatrixBitNV</c>
        /// </summary>
        ConvertCooperativeVectorMatrixBitNV = 0x100000000000,

        /// <summary>
        ///     <c>DataGraphBitARM</c>
        /// </summary>
        DataGraphBitARM = 0x40000000000,

        /// <summary>
        ///     <c>CopyIndirectBitKHR</c>
        /// </summary>
        CopyIndirectBitKHR = 0x400000000000,

        /// <summary>
        ///     <c>MemoryDecompressionBitEXT</c>
        /// </summary>
        MemoryDecompressionBitEXT = 0x200000000000,
    }
}
