namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateFlagBits.html">VkPipelineCreateFlagBits</see> - Bitmask controlling how a pipeline is created
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///     </para>
    ///     <para>
    ///         * <c>VkGraphicsPipelineCreateInfo::flags</c>
    ///         * <c>VkComputePipelineCreateInfo::flags</c>
    ///     </para>
    ///     <para>
    ///         specify how a pipeline is created, and are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPipelineCreateFlagBits {
    ///             VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x00000001,
    ///             VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x00000002,
    ///             VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x00000004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_PIPELINE_CREATE_DISPATCH_BASE_BIT = 0x00000010,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x00000008,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT = 0x00000100,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT = 0x00000200,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT = 0x08000000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT = 0x40000000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = 0x00004000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = 0x00008000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = 0x00010000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = 0x00020000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = 0x00001000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = 0x00002000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = 0x00000020,
    ///             // Provided by VK_EXT_fragment_density_map with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x00400000,
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00200000,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = 0x00000040,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = 0x00000080,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = 0x00040000,
    ///             // Provided by VK_KHR_pipeline_library
    ///             VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = 0x00000800,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = 0x20000000,
    ///             // Provided by VK_EXT_graphics_pipeline_library
    ///             VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = 0x00800000,
    ///             // Provided by VK_EXT_graphics_pipeline_library
    ///             VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT = 0x00000400,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV = 0x00100000,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x02000000,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x04000000,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_PIPELINE_CREATE_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV = 0x10000000,
    ///             #endif
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_KHR = 0x01000000,
    ///             // Provided by VK_VERSION_1_1
    ///             // VK_PIPELINE_CREATE_DISPATCH_BASE is a legacy alias
    ///             VK_PIPELINE_CREATE_DISPATCH_BASE = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_PIPELINE_CREATE_DISPATCH_BASE_BIT_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             // VK_PIPELINE_CREATE_DISPATCH_BASE_KHR is a legacy alias
    ///             VK_PIPELINE_CREATE_DISPATCH_BASE_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,
    ///             // Provided by VK_EXT_fragment_density_map with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             // VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT is a legacy alias
    ///             VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT,
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             // VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR is a legacy alias
    ///             VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT = VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT = VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT = VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_KHR,
    ///             // Provided by VK_EXT_pipeline_protected_access
    ///             VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT = VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT,
    ///             // Provided by VK_EXT_pipeline_protected_access
    ///             VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT = VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT,
    ///         } VkPipelineCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DisableOptimizationBit</c> specifies that the created pipeline will not be optimized. Using this flag may: reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimizationBit = 0x00000001,

        /// <summary>
        ///     <c>AllowDerivativesBit</c> specifies that the pipeline to be created is allowed to be the parent of a pipeline that will be created in a subsequent pipeline creation call.
        /// </summary>
        AllowDerivativesBit = 0x00000002,

        /// <summary>
        ///     <c>DerivativeBit</c> specifies that the pipeline to be created will be a child of a previously created parent pipeline.  It is valid to set both <c>VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT</c> and <c>VK_PIPELINE_CREATE_DERIVATIVE_BIT</c>. This allows a pipeline to be both a parent and possibly a child in a pipeline hierarchy. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-pipeline-derivatives">Pipeline Derivatives^</see> for more information.
        /// </summary>
        DerivativeBit = 0x00000004,

        /// <summary>
        ///     <c>DispatchBaseBit</c>
        /// </summary>
        DispatchBaseBit = 0x00000010,

        /// <summary>
        ///     <c>ViewIndexFromDeviceIndexBit</c>
        /// </summary>
        ViewIndexFromDeviceIndexBit = 0x00000008,

        /// <summary>
        ///     <c>FailOnPipelineCompileRequiredBit</c>
        /// </summary>
        FailOnPipelineCompileRequiredBit = 0x00000100,

        /// <summary>
        ///     <c>EarlyReturnOnFailureBit</c>
        /// </summary>
        EarlyReturnOnFailureBit = 0x00000200,

        /// <summary>
        ///     <c>NoProtectedAccessBit</c>
        /// </summary>
        NoProtectedAccessBit = 0x08000000,

        /// <summary>
        ///     <c>ProtectedAccessOnlyBit</c>
        /// </summary>
        ProtectedAccessOnlyBit = 0x40000000,

        /// <summary>
        ///     <c>RayTracingNoNullAnyHitShadersBitKHR</c>
        /// </summary>
        RayTracingNoNullAnyHitShadersBitKHR = 0x00004000,

        /// <summary>
        ///     <c>RayTracingNoNullClosestHitShadersBitKHR</c>
        /// </summary>
        RayTracingNoNullClosestHitShadersBitKHR = 0x00008000,

        /// <summary>
        ///     <c>RayTracingNoNullMissShadersBitKHR</c>
        /// </summary>
        RayTracingNoNullMissShadersBitKHR = 0x00010000,

        /// <summary>
        ///     <c>RayTracingNoNullIntersectionShadersBitKHR</c>
        /// </summary>
        RayTracingNoNullIntersectionShadersBitKHR = 0x00020000,

        /// <summary>
        ///     <c>RayTracingSkipTrianglesBitKHR</c>
        /// </summary>
        RayTracingSkipTrianglesBitKHR = 0x00001000,

        /// <summary>
        ///     <c>RayTracingSkipAabbsBitKHR</c>
        /// </summary>
        RayTracingSkipAabbsBitKHR = 0x00002000,

        /// <summary>
        ///     <c>RayTracingShaderGroupHandleCaptureReplayBitKHR</c>
        /// </summary>
        RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x00080000,

        /// <summary>
        ///     <c>DeferCompileBitNV</c>
        /// </summary>
        DeferCompileBitNV = 0x00000020,

        /// <summary>
        ///     <c>RenderingFragmentDensityMapAttachmentBitEXT</c>
        /// </summary>
        RenderingFragmentDensityMapAttachmentBitEXT = 0x00400000,

        /// <summary>
        ///     <c>RenderingFragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        RenderingFragmentShadingRateAttachmentBitKHR = 0x00200000,

        /// <summary>
        ///     <c>CaptureStatisticsBitKHR</c>
        /// </summary>
        CaptureStatisticsBitKHR = 0x00000040,

        /// <summary>
        ///     <c>CaptureInternalRepresentationsBitKHR</c>
        /// </summary>
        CaptureInternalRepresentationsBitKHR = 0x00000080,

        /// <summary>
        ///     <c>IndirectBindableBitNV</c>
        /// </summary>
        IndirectBindableBitNV = 0x00040000,

        /// <summary>
        ///     <c>LibraryBitKHR</c>
        /// </summary>
        LibraryBitKHR = 0x00000800,

        /// <summary>
        ///     <c>DescriptorBufferBitEXT</c>
        /// </summary>
        DescriptorBufferBitEXT = 0x20000000,

        /// <summary>
        ///     <c>RetainLinkTimeOptimizationInfoBitEXT</c>
        /// </summary>
        RetainLinkTimeOptimizationInfoBitEXT = 0x00800000,

        /// <summary>
        ///     <c>LinkTimeOptimizationBitEXT</c>
        /// </summary>
        LinkTimeOptimizationBitEXT = 0x00000400,

        /// <summary>
        ///     <c>RayTracingAllowMotionBitNV</c>
        /// </summary>
        RayTracingAllowMotionBitNV = 0x00100000,

        /// <summary>
        ///     <c>ColorAttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        ColorAttachmentFeedbackLoopBitEXT = 0x02000000,

        /// <summary>
        ///     <c>DepthStencilAttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        DepthStencilAttachmentFeedbackLoopBitEXT = 0x04000000,

        /// <summary>
        ///     <c>RayTracingDisplacementMicromapBitNV</c>
        /// </summary>
        RayTracingDisplacementMicromapBitNV = 0x10000000,

        /// <summary>
        ///     <c>RayTracingOpacityMicromapBitKHR</c>
        /// </summary>
        RayTracingOpacityMicromapBitKHR = 0x01000000,

        /// <summary>
        ///     <c>DispatchBase</c>
        /// </summary>
        DispatchBase = DispatchBaseBit,

        /// <summary>
        ///     <c>ViewIndexFromDeviceIndexBitKHR</c>
        /// </summary>
        ViewIndexFromDeviceIndexBitKHR = ViewIndexFromDeviceIndexBit,

        /// <summary>
        ///     <c>DispatchBaseBitKHR</c>
        /// </summary>
        DispatchBaseBitKHR = DispatchBaseBit,

        /// <summary>
        ///     <c>DispatchBaseKHR</c>
        /// </summary>
        DispatchBaseKHR = DispatchBaseBit,

        /// <summary>
        ///     <c>FailOnPipelineCompileRequiredBitEXT</c>
        /// </summary>
        FailOnPipelineCompileRequiredBitEXT = FailOnPipelineCompileRequiredBit,

        /// <summary>
        ///     <c>EarlyReturnOnFailureBitEXT</c>
        /// </summary>
        EarlyReturnOnFailureBitEXT = EarlyReturnOnFailureBit,

        /// <summary>
        ///     <c>RayTracingOpacityMicromapBitEXT</c>
        /// </summary>
        RayTracingOpacityMicromapBitEXT = RayTracingOpacityMicromapBitKHR,

        /// <summary>
        ///     <c>NoProtectedAccessBitEXT</c>
        /// </summary>
        NoProtectedAccessBitEXT = NoProtectedAccessBit,

        /// <summary>
        ///     <c>ProtectedAccessOnlyBitEXT</c>
        /// </summary>
        ProtectedAccessOnlyBitEXT = ProtectedAccessOnlyBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
