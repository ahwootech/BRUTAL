namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDynamicState.html">VkDynamicState</see> - Indicate which dynamic state is taken from dynamic state commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The source of different pieces of dynamic state is specified by the
    ///         <c>VkPipelineDynamicStateCreateInfo::pDynamicStates</c> property of the
    ///         currently active pipeline, each of whose elements <i>must</i> be one of the
    ///         values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkDynamicState {
    ///             VK_DYNAMIC_STATE_VIEWPORT = 0,
    ///             VK_DYNAMIC_STATE_SCISSOR = 1,
    ///             VK_DYNAMIC_STATE_LINE_WIDTH = 2,
    ///             VK_DYNAMIC_STATE_DEPTH_BIAS = 3,
    ///             VK_DYNAMIC_STATE_BLEND_CONSTANTS = 4,
    ///             VK_DYNAMIC_STATE_DEPTH_BOUNDS = 5,
    ///             VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = 6,
    ///             VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = 7,
    ///             VK_DYNAMIC_STATE_STENCIL_REFERENCE = 8,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_CULL_MODE = 1000267000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_FRONT_FACE = 1000267001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = 1000267002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = 1000267003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = 1000267004,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = 1000267005,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = 1000267006,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = 1000267007,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = 1000267008,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = 1000267009,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = 1000267010,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_STENCIL_OP = 1000267011,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = 1000377001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = 1000377002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = 1000377004,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_DYNAMIC_STATE_LINE_STIPPLE = 1000259000,
    ///             // Provided by VK_NV_clip_space_w_scaling
    ///             VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = 1000087000,
    ///             // Provided by VK_EXT_discard_rectangles
    ///             VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = 1000099000,
    ///             // Provided by VK_EXT_discard_rectangles
    ///             VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT = 1000099001,
    ///             // Provided by VK_EXT_discard_rectangles
    ///             VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT = 1000099002,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = 1000143000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = 1000164004,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = 1000164006,
    ///             // Provided by VK_NV_scissor_exclusive
    ///             VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV = 1000205000,
    ///             // Provided by VK_NV_scissor_exclusive
    ///             VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = 1000205001,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = 1000226000,
    ///             // Provided by VK_EXT_vertex_input_dynamic_state
    ///             VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = 1000352000,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = 1000377000,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_DYNAMIC_STATE_LOGIC_OP_EXT = 1000377003,
    ///             // Provided by VK_EXT_color_write_enable
    ///             VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = 1000381000,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT = 1000455003,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_POLYGON_MODE_EXT = 1000455004,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT = 1000455005,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_SAMPLE_MASK_EXT = 1000455006,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT = 1000455007,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT = 1000455008,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT = 1000455009,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT = 1000455010,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT = 1000455011,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT = 1000455012,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_KHR_maintenance2 or VK_VERSION_1_1
    ///             VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT = 1000455002,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_EXT_transform_feedback
    ///             VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT = 1000455013,
    ///             // Provided by VK_EXT_conservative_rasterization with VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT = 1000455014,
    ///             // Provided by VK_EXT_conservative_rasterization with VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT = 1000455015,
    ///             // Provided by VK_EXT_depth_clip_enable with VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT = 1000455016,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_EXT_sample_locations
    ///             VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT = 1000455017,
    ///             // Provided by VK_EXT_blend_operation_advanced with VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT = 1000455018,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_EXT_provoking_vertex
    ///             VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT = 1000455019,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_VERSION_1_4 or VK_KHR_line_rasterization or VK_EXT_line_rasterization
    ///             VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT = 1000455020,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_VERSION_1_4 or VK_KHR_line_rasterization or VK_EXT_line_rasterization
    ///             VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT = 1000455021,
    ///             // Provided by VK_EXT_depth_clip_control with VK_EXT_extended_dynamic_state3
    ///             VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT = 1000455022,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_clip_space_w_scaling
    ///             VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV = 1000455023,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_viewport_swizzle
    ///             VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV = 1000455024,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_fragment_coverage_to_color
    ///             VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV = 1000455025,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_fragment_coverage_to_color
    ///             VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV = 1000455026,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_framebuffer_mixed_samples
    ///             VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV = 1000455027,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_framebuffer_mixed_samples
    ///             VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV = 1000455028,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_framebuffer_mixed_samples
    ///             VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV = 1000455029,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_shading_rate_image
    ///             VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV = 1000455030,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_representative_fragment_test
    ///             VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV = 1000455031,
    ///             // Provided by VK_EXT_extended_dynamic_state3 with VK_NV_coverage_reduction_mode
    ///             VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV = 1000455032,
    ///             // Provided by VK_EXT_attachment_feedback_loop_dynamic_state
    ///             VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT = 1000524000,
    ///             // Provided by VK_EXT_depth_clamp_control
    ///             VK_DYNAMIC_STATE_DEPTH_CLAMP_RANGE_EXT = 1000582000,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = VK_DYNAMIC_STATE_LINE_STIPPLE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_CULL_MODE_EXT = VK_DYNAMIC_STATE_CULL_MODE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_FRONT_FACE_EXT = VK_DYNAMIC_STATE_FRONT_FACE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY_EXT = VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT_EXT = VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT_EXT = VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE_EXT = VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_DEPTH_COMPARE_OP_EXT = VK_DYNAMIC_STATE_DEPTH_COMPARE_OP,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE_EXT = VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_DYNAMIC_STATE_STENCIL_OP_EXT = VK_DYNAMIC_STATE_STENCIL_OP,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE_EXT = VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE_EXT = VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE_EXT = VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_DYNAMIC_STATE_LINE_STIPPLE_KHR = VK_DYNAMIC_STATE_LINE_STIPPLE,
    ///         } VkDynamicState;
    ///     </code>
    /// </remarks>
    public enum VkDynamicState : int
    {
        /// <summary>
        ///     <c>Viewport</c> specifies that the <c>pViewports</c> state in <c>VkPipelineViewportStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetViewport</c> before any drawing commands. The number of viewports used by a pipeline is still specified by the <c>viewportCount</c> member of <c>VkPipelineViewportStateCreateInfo</c>.
        /// </summary>
        Viewport = 0,

        /// <summary>
        ///     <c>Scissor</c> specifies that the <c>pScissors</c> state in <c>VkPipelineViewportStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetScissor</c> before any drawing commands. The number of scissor rectangles used by a pipeline is still specified by the <c>scissorCount</c> member of <c>VkPipelineViewportStateCreateInfo</c>.
        /// </summary>
        Scissor = 1,

        /// <summary>
        ///     <c>LineWidth</c> specifies that the <c>lineWidth</c> state in <c>VkPipelineRasterizationStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetLineWidth</c> before any drawing commands that generate line primitives for the rasterizer.
        /// </summary>
        LineWidth = 2,

        /// <summary>
        ///     <c>DepthBias</c> specifies that the <c>depthBiasConstantFactor</c>, <c>depthBiasClamp</c> and <c>depthBiasSlopeFactor</c> states in <c>VkPipelineRasterizationStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetDepthBias</c> before any draws are performed with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-depthbias-enable">depth bias enabled^</see>.
        /// </summary>
        DepthBias = 3,

        /// <summary>
        ///     <c>BlendConstants</c> specifies that the <c>blendConstants</c> state in <c>VkPipelineColorBlendStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetBlendConstants</c> before any draws are performed with a pipeline state with <c>VkPipelineColorBlendAttachmentState</c> member <c>blendEnable</c> set to <c>VK_TRUE</c> and any of the blend functions using a constant blend color.
        /// </summary>
        BlendConstants = 4,

        /// <summary>
        ///     <c>DepthBounds</c> specifies that the <c>minDepthBounds</c> and <c>maxDepthBounds</c> states of <c>VkPipelineDepthStencilStateCreateInfo</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetDepthBounds</c> before any draws are performed with a pipeline state with <c>VkPipelineDepthStencilStateCreateInfo</c> member <c>depthBoundsTestEnable</c> set to <c>VK_TRUE</c>.
        /// </summary>
        DepthBounds = 5,

        /// <summary>
        ///     <c>StencilCompareMask</c> specifies that the <c>compareMask</c> state in <c>VkPipelineDepthStencilStateCreateInfo</c> for both <c>front</c> and <c>back</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetStencilCompareMask</c> before any draws are performed with a pipeline state with <c>VkPipelineDepthStencilStateCreateInfo</c> member <c>stencilTestEnable</c> set to <c>VK_TRUE</c>
        /// </summary>
        StencilCompareMask = 6,

        /// <summary>
        ///     <c>StencilWriteMask</c> specifies that the <c>writeMask</c> state in <c>VkPipelineDepthStencilStateCreateInfo</c> for both <c>front</c> and <c>back</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetStencilWriteMask</c> before any draws are performed with a pipeline state with <c>VkPipelineDepthStencilStateCreateInfo</c> member <c>stencilTestEnable</c> set to <c>VK_TRUE</c>
        /// </summary>
        StencilWriteMask = 7,

        /// <summary>
        ///     <c>StencilReference</c> specifies that the <c>reference</c> state in <c>VkPipelineDepthStencilStateCreateInfo</c> for both <c>front</c> and <c>back</c> will be ignored and <i>must</i> be set dynamically with <c>vkCmdSetStencilReference</c> before any draws are performed with a pipeline state with <c>VkPipelineDepthStencilStateCreateInfo</c> member <c>stencilTestEnable</c> set to <c>VK_TRUE</c>
        /// </summary>
        StencilReference = 8,

        /// <summary>
        ///     <c>CullMode</c>
        /// </summary>
        CullMode = 1000267000,

        /// <summary>
        ///     <c>FrontFace</c>
        /// </summary>
        FrontFace = 1000267001,

        /// <summary>
        ///     <c>PrimitiveTopology</c>
        /// </summary>
        PrimitiveTopology = 1000267002,

        /// <summary>
        ///     <c>ViewportWithCount</c>
        /// </summary>
        ViewportWithCount = 1000267003,

        /// <summary>
        ///     <c>ScissorWithCount</c>
        /// </summary>
        ScissorWithCount = 1000267004,

        /// <summary>
        ///     <c>VertexInputBindingStride</c>
        /// </summary>
        VertexInputBindingStride = 1000267005,

        /// <summary>
        ///     <c>DepthTestEnable</c>
        /// </summary>
        DepthTestEnable = 1000267006,

        /// <summary>
        ///     <c>DepthWriteEnable</c>
        /// </summary>
        DepthWriteEnable = 1000267007,

        /// <summary>
        ///     <c>DepthCompareOp</c>
        /// </summary>
        DepthCompareOp = 1000267008,

        /// <summary>
        ///     <c>DepthBoundsTestEnable</c>
        /// </summary>
        DepthBoundsTestEnable = 1000267009,

        /// <summary>
        ///     <c>StencilTestEnable</c>
        /// </summary>
        StencilTestEnable = 1000267010,

        /// <summary>
        ///     <c>StencilOp</c>
        /// </summary>
        StencilOp = 1000267011,

        /// <summary>
        ///     <c>RasterizerDiscardEnable</c>
        /// </summary>
        RasterizerDiscardEnable = 1000377001,

        /// <summary>
        ///     <c>DepthBiasEnable</c>
        /// </summary>
        DepthBiasEnable = 1000377002,

        /// <summary>
        ///     <c>PrimitiveRestartEnable</c>
        /// </summary>
        PrimitiveRestartEnable = 1000377004,

        /// <summary>
        ///     <c>LineStipple</c>
        /// </summary>
        LineStipple = 1000259000,

        /// <summary>
        ///     <c>ViewportWScalingNV</c>
        /// </summary>
        ViewportWScalingNV = 1000087000,

        /// <summary>
        ///     <c>DiscardRectangleEXT</c>
        /// </summary>
        DiscardRectangleEXT = 1000099000,

        /// <summary>
        ///     <c>DiscardRectangleEnableEXT</c>
        /// </summary>
        DiscardRectangleEnableEXT = 1000099001,

        /// <summary>
        ///     <c>DiscardRectangleModeEXT</c>
        /// </summary>
        DiscardRectangleModeEXT = 1000099002,

        /// <summary>
        ///     <c>SampleLocationsEXT</c>
        /// </summary>
        SampleLocationsEXT = 1000143000,

        /// <summary>
        ///     <c>RayTracingPipelineStackSizeKHR</c>
        /// </summary>
        RayTracingPipelineStackSizeKHR = 1000347000,

        /// <summary>
        ///     <c>ViewportShadingRatePaletteNV</c>
        /// </summary>
        ViewportShadingRatePaletteNV = 1000164004,

        /// <summary>
        ///     <c>ViewportCoarseSampleOrderNV</c>
        /// </summary>
        ViewportCoarseSampleOrderNV = 1000164006,

        /// <summary>
        ///     <c>ExclusiveScissorEnableNV</c>
        /// </summary>
        ExclusiveScissorEnableNV = 1000205000,

        /// <summary>
        ///     <c>ExclusiveScissorNV</c>
        /// </summary>
        ExclusiveScissorNV = 1000205001,

        /// <summary>
        ///     <c>FragmentShadingRateKHR</c>
        /// </summary>
        FragmentShadingRateKHR = 1000226000,

        /// <summary>
        ///     <c>VertexInputEXT</c>
        /// </summary>
        VertexInputEXT = 1000352000,

        /// <summary>
        ///     <c>PatchControlPointsEXT</c>
        /// </summary>
        PatchControlPointsEXT = 1000377000,

        /// <summary>
        ///     <c>LogicOpEXT</c>
        /// </summary>
        LogicOpEXT = 1000377003,

        /// <summary>
        ///     <c>ColorWriteEnableEXT</c>
        /// </summary>
        ColorWriteEnableEXT = 1000381000,

        /// <summary>
        ///     <c>DepthClampEnableEXT</c>
        /// </summary>
        DepthClampEnableEXT = 1000455003,

        /// <summary>
        ///     <c>PolygonModeEXT</c>
        /// </summary>
        PolygonModeEXT = 1000455004,

        /// <summary>
        ///     <c>RasterizationSamplesEXT</c>
        /// </summary>
        RasterizationSamplesEXT = 1000455005,

        /// <summary>
        ///     <c>SampleMaskEXT</c>
        /// </summary>
        SampleMaskEXT = 1000455006,

        /// <summary>
        ///     <c>AlphaToCoverageEnableEXT</c>
        /// </summary>
        AlphaToCoverageEnableEXT = 1000455007,

        /// <summary>
        ///     <c>AlphaToOneEnableEXT</c>
        /// </summary>
        AlphaToOneEnableEXT = 1000455008,

        /// <summary>
        ///     <c>LogicOpEnableEXT</c>
        /// </summary>
        LogicOpEnableEXT = 1000455009,

        /// <summary>
        ///     <c>ColorBlendEnableEXT</c>
        /// </summary>
        ColorBlendEnableEXT = 1000455010,

        /// <summary>
        ///     <c>ColorBlendEquationEXT</c>
        /// </summary>
        ColorBlendEquationEXT = 1000455011,

        /// <summary>
        ///     <c>ColorWriteMaskEXT</c>
        /// </summary>
        ColorWriteMaskEXT = 1000455012,

        /// <summary>
        ///     <c>TessellationDomainOriginEXT</c>
        /// </summary>
        TessellationDomainOriginEXT = 1000455002,

        /// <summary>
        ///     <c>RasterizationStreamEXT</c>
        /// </summary>
        RasterizationStreamEXT = 1000455013,

        /// <summary>
        ///     <c>ConservativeRasterizationModeEXT</c>
        /// </summary>
        ConservativeRasterizationModeEXT = 1000455014,

        /// <summary>
        ///     <c>ExtraPrimitiveOverestimationSizeEXT</c>
        /// </summary>
        ExtraPrimitiveOverestimationSizeEXT = 1000455015,

        /// <summary>
        ///     <c>DepthClipEnableEXT</c>
        /// </summary>
        DepthClipEnableEXT = 1000455016,

        /// <summary>
        ///     <c>SampleLocationsEnableEXT</c>
        /// </summary>
        SampleLocationsEnableEXT = 1000455017,

        /// <summary>
        ///     <c>ColorBlendAdvancedEXT</c>
        /// </summary>
        ColorBlendAdvancedEXT = 1000455018,

        /// <summary>
        ///     <c>ProvokingVertexModeEXT</c>
        /// </summary>
        ProvokingVertexModeEXT = 1000455019,

        /// <summary>
        ///     <c>LineRasterizationModeEXT</c>
        /// </summary>
        LineRasterizationModeEXT = 1000455020,

        /// <summary>
        ///     <c>LineStippleEnableEXT</c>
        /// </summary>
        LineStippleEnableEXT = 1000455021,

        /// <summary>
        ///     <c>DepthClipNegativeOneToOneEXT</c>
        /// </summary>
        DepthClipNegativeOneToOneEXT = 1000455022,

        /// <summary>
        ///     <c>ViewportWScalingEnableNV</c>
        /// </summary>
        ViewportWScalingEnableNV = 1000455023,

        /// <summary>
        ///     <c>ViewportSwizzleNV</c>
        /// </summary>
        ViewportSwizzleNV = 1000455024,

        /// <summary>
        ///     <c>CoverageToColorEnableNV</c>
        /// </summary>
        CoverageToColorEnableNV = 1000455025,

        /// <summary>
        ///     <c>CoverageToColorLocationNV</c>
        /// </summary>
        CoverageToColorLocationNV = 1000455026,

        /// <summary>
        ///     <c>CoverageModulationModeNV</c>
        /// </summary>
        CoverageModulationModeNV = 1000455027,

        /// <summary>
        ///     <c>CoverageModulationTableEnableNV</c>
        /// </summary>
        CoverageModulationTableEnableNV = 1000455028,

        /// <summary>
        ///     <c>CoverageModulationTableNV</c>
        /// </summary>
        CoverageModulationTableNV = 1000455029,

        /// <summary>
        ///     <c>ShadingRateImageEnableNV</c>
        /// </summary>
        ShadingRateImageEnableNV = 1000455030,

        /// <summary>
        ///     <c>RepresentativeFragmentTestEnableNV</c>
        /// </summary>
        RepresentativeFragmentTestEnableNV = 1000455031,

        /// <summary>
        ///     <c>CoverageReductionModeNV</c>
        /// </summary>
        CoverageReductionModeNV = 1000455032,

        /// <summary>
        ///     <c>AttachmentFeedbackLoopEnableEXT</c>
        /// </summary>
        AttachmentFeedbackLoopEnableEXT = 1000524000,

        /// <summary>
        ///     <c>DepthClampRangeEXT</c>
        /// </summary>
        DepthClampRangeEXT = 1000582000,

        /// <summary>
        ///     <c>LineStippleEXT</c>
        /// </summary>
        LineStippleEXT = LineStipple,

        /// <summary>
        ///     <c>CullModeEXT</c>
        /// </summary>
        CullModeEXT = CullMode,

        /// <summary>
        ///     <c>FrontFaceEXT</c>
        /// </summary>
        FrontFaceEXT = FrontFace,

        /// <summary>
        ///     <c>PrimitiveTopologyEXT</c>
        /// </summary>
        PrimitiveTopologyEXT = PrimitiveTopology,

        /// <summary>
        ///     <c>ViewportWithCountEXT</c>
        /// </summary>
        ViewportWithCountEXT = ViewportWithCount,

        /// <summary>
        ///     <c>ScissorWithCountEXT</c>
        /// </summary>
        ScissorWithCountEXT = ScissorWithCount,

        /// <summary>
        ///     <c>VertexInputBindingStrideEXT</c>
        /// </summary>
        VertexInputBindingStrideEXT = VertexInputBindingStride,

        /// <summary>
        ///     <c>DepthTestEnableEXT</c>
        /// </summary>
        DepthTestEnableEXT = DepthTestEnable,

        /// <summary>
        ///     <c>DepthWriteEnableEXT</c>
        /// </summary>
        DepthWriteEnableEXT = DepthWriteEnable,

        /// <summary>
        ///     <c>DepthCompareOpEXT</c>
        /// </summary>
        DepthCompareOpEXT = DepthCompareOp,

        /// <summary>
        ///     <c>DepthBoundsTestEnableEXT</c>
        /// </summary>
        DepthBoundsTestEnableEXT = DepthBoundsTestEnable,

        /// <summary>
        ///     <c>StencilTestEnableEXT</c>
        /// </summary>
        StencilTestEnableEXT = StencilTestEnable,

        /// <summary>
        ///     <c>StencilOpEXT</c>
        /// </summary>
        StencilOpEXT = StencilOp,

        /// <summary>
        ///     <c>RasterizerDiscardEnableEXT</c>
        /// </summary>
        RasterizerDiscardEnableEXT = RasterizerDiscardEnable,

        /// <summary>
        ///     <c>DepthBiasEnableEXT</c>
        /// </summary>
        DepthBiasEnableEXT = DepthBiasEnable,

        /// <summary>
        ///     <c>PrimitiveRestartEnableEXT</c>
        /// </summary>
        PrimitiveRestartEnableEXT = PrimitiveRestartEnable,

        /// <summary>
        ///     <c>LineStippleKHR</c>
        /// </summary>
        LineStippleKHR = LineStipple,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
