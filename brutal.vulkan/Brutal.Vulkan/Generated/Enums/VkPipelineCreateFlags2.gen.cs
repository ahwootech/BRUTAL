namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateFlagBits2.html">VkPipelineCreateFlagBits2</see> - Bitmask controlling how a pipeline is created
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPipelineCreateFlags2CreateInfo::flags</c>, specifying how a
    ///         pipeline is created, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         // Flag bits for VkPipelineCreateFlagBits2
    ///         typedef VkFlags64 VkPipelineCreateFlagBits2;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT = 0x00000001ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT = 0x00000002ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DERIVATIVE_BIT = 0x00000004ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x00000008ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT = 0x00000010ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT = 0x00000100ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT = 0x00000200ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT = 0x08000000ULL;
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT = 0x40000000ULL;
    ///             // Provided by VK_AMDX_shader_enqueue with VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_EXECUTION_GRAPH_BIT_AMDX = 0x100000000ULL;
    ///             #endif
    ///             // Provided by VK_EXT_descriptor_heap
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DESCRIPTOR_HEAP_BIT_EXT = 0x1000000000ULL;
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_BUILT_IN_PRIMITIVES_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_opacity_micromap, VK_EXT_opacity_micromap with VK_KHR_maintenance5 or VK_VERSION_1_4
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT = 0x01000000ULL;
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_SPHERES_AND_LINEAR_SWEPT_SPHERES_BIT_NV = 0x200000000ULL;
    ///             // Provided by VK_EXT_legacy_dithering with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and (VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5)
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x400000000ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR = 0x00000001ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR = 0x00000002ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR = 0x00000004ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = 0x00000008ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_NV_ray_tracing, VK_KHR_maintenance5 with VK_NV_ray_tracing
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV = 0x00000020ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_pipeline_executable_properties, VK_KHR_maintenance5 with VK_KHR_pipeline_executable_properties
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_pipeline_executable_properties, VK_KHR_maintenance5 with VK_KHR_pipeline_executable_properties
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_VERSION_1_3 or VK_EXT_pipeline_creation_cache_control, VK_KHR_maintenance5 with VK_VERSION_1_3 or VK_EXT_pipeline_creation_cache_control
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_VERSION_1_3 or VK_EXT_pipeline_creation_cache_control, VK_KHR_maintenance5 with VK_VERSION_1_3 or VK_EXT_pipeline_creation_cache_control
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR = 0x00000200ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_graphics_pipeline_library, VK_KHR_maintenance5 with VK_EXT_graphics_pipeline_library
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT = 0x00000400ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_graphics_pipeline_library, VK_KHR_maintenance5 with VK_EXT_graphics_pipeline_library
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = 0x00800000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_pipeline_library, VK_KHR_maintenance5 with VK_KHR_pipeline_library
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR = 0x00002000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = 0x00010000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = 0x00020000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_NV_device_generated_commands, VK_KHR_maintenance5 with VK_NV_device_generated_commands
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV = 0x00040000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_NV_ray_tracing_motion_blur, VK_KHR_maintenance5 with VK_NV_ray_tracing_motion_blur
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV = 0x00100000ULL;
    ///             // Provided by VK_KHR_extended_flags with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and VK_KHR_fragment_shading_rate, VK_KHR_maintenance5 with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and VK_KHR_fragment_shading_rate
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00200000ULL;
    ///             // Provided by VK_KHR_extended_flags with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and VK_EXT_fragment_density_map, VK_KHR_maintenance5 with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and VK_EXT_fragment_density_map
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x00400000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_attachment_feedback_loop_layout, VK_KHR_maintenance5 with VK_EXT_attachment_feedback_loop_layout
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x02000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_attachment_feedback_loop_layout, VK_KHR_maintenance5 with VK_EXT_attachment_feedback_loop_layout
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x04000000ULL;
    ///             // Provided by VK_KHR_maintenance5 with VK_VERSION_1_4 or VK_EXT_pipeline_protected_access
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT = 0x08000000ULL;
    ///             // Provided by VK_KHR_maintenance5 with VK_VERSION_1_4 or VK_EXT_pipeline_protected_access
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT = 0x40000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_NV_displacement_micromap, VK_KHR_maintenance5 with VK_NV_displacement_micromap
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV = 0x10000000ULL;
    ///             #endif
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_descriptor_buffer, VK_KHR_maintenance5 with VK_EXT_descriptor_buffer
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT = 0x20000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_ARM_pipeline_opacity_micromap, VK_KHR_maintenance5 with VK_ARM_pipeline_opacity_micromap, VK_ARM_pipeline_opacity_micromap
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_DISALLOW_OPACITY_MICROMAP_BIT_ARM = 0x2000000000ULL;
    ///             // Provided by VK_KHR_maintenance5 with VK_ARM_shader_instrumentation, VK_ARM_shader_instrumentation
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_INSTRUMENT_SHADERS_BIT_ARM = 0x8000000000ULL;
    ///             // Provided by VK_KHR_pipeline_binary
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_CAPTURE_DATA_BIT_KHR = 0x80000000ULL;
    ///             // Provided by VK_EXT_device_generated_commands
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_EXT = 0x4000000000ULL;
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE = 0x10000000000ULL;
    ///             // Provided by VK_KHR_opacity_micromap with VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_KHR = 0x01000000ULL;
    ///             // Provided by VK_KHR_opacity_micromap with VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_OPACITY_MICROMAP_DISALLOW_MIXED_SPECIAL_INDEX_BIT_KHR = 0x20000000000ULL;
    ///             // Provided by VK_EXT_shader_64bit_indexing
    ///             static const VkPipelineCreateFlagBits2 VK_PIPELINE_CREATE_2_64_BIT_INDEXING_BIT_EXT = 0x80000000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkPipelineCreateFlags2 : ulong
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
        ///     <c>DerivativeBit</c> specifies that the pipeline to be created will be a child of a previously created parent pipeline.   It is valid to set both <c>VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT</c> and <c>VK_PIPELINE_CREATE_2_DERIVATIVE_BIT</c>. This allows a pipeline to be both a parent and possibly a child in a pipeline hierarchy. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-pipeline-derivatives">Pipeline Derivatives^</see> for more information.
        /// </summary>
        DerivativeBit = 0x00000004,

        /// <summary>
        ///     <c>ViewIndexFromDeviceIndexBit</c>
        /// </summary>
        ViewIndexFromDeviceIndexBit = 0x00000008,

        /// <summary>
        ///     <c>DispatchBaseBit</c>
        /// </summary>
        DispatchBaseBit = 0x00000010,

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
        ///     <c>ExecutionGraphBitAMDX</c>
        /// </summary>
        ExecutionGraphBitAMDX = 0x100000000,

        /// <summary>
        ///     <c>DescriptorHeapBitEXT</c>
        /// </summary>
        DescriptorHeapBitEXT = 0x1000000000,

        /// <summary>
        ///     <c>RayTracingSkipBuiltInPrimitivesBitKHR</c>
        /// </summary>
        RayTracingSkipBuiltInPrimitivesBitKHR = 0x00001000,

        /// <summary>
        ///     <c>RayTracingOpacityMicromapBitEXT</c>
        /// </summary>
        RayTracingOpacityMicromapBitEXT = 0x01000000,

        /// <summary>
        ///     <c>RayTracingAllowSpheresAndLinearSweptSpheresBitNV</c>
        /// </summary>
        RayTracingAllowSpheresAndLinearSweptSpheresBitNV = 0x200000000,

        /// <summary>
        ///     <c>EnableLegacyDitheringBitEXT</c>
        /// </summary>
        EnableLegacyDitheringBitEXT = 0x400000000,

        /// <summary>
        ///     <c>DisableOptimizationBitKHR</c>
        /// </summary>
        DisableOptimizationBitKHR = 0x00000001,

        /// <summary>
        ///     <c>AllowDerivativesBitKHR</c>
        /// </summary>
        AllowDerivativesBitKHR = 0x00000002,

        /// <summary>
        ///     <c>DerivativeBitKHR</c>
        /// </summary>
        DerivativeBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ViewIndexFromDeviceIndexBitKHR</c>
        /// </summary>
        ViewIndexFromDeviceIndexBitKHR = 0x00000008,

        /// <summary>
        ///     <c>DispatchBaseBitKHR</c>
        /// </summary>
        DispatchBaseBitKHR = 0x00000010,

        /// <summary>
        ///     <c>DeferCompileBitNV</c>
        /// </summary>
        DeferCompileBitNV = 0x00000020,

        /// <summary>
        ///     <c>CaptureStatisticsBitKHR</c>
        /// </summary>
        CaptureStatisticsBitKHR = 0x00000040,

        /// <summary>
        ///     <c>CaptureInternalRepresentationsBitKHR</c>
        /// </summary>
        CaptureInternalRepresentationsBitKHR = 0x00000080,

        /// <summary>
        ///     <c>FailOnPipelineCompileRequiredBitKHR</c>
        /// </summary>
        FailOnPipelineCompileRequiredBitKHR = 0x00000100,

        /// <summary>
        ///     <c>EarlyReturnOnFailureBitKHR</c>
        /// </summary>
        EarlyReturnOnFailureBitKHR = 0x00000200,

        /// <summary>
        ///     <c>LinkTimeOptimizationBitEXT</c>
        /// </summary>
        LinkTimeOptimizationBitEXT = 0x00000400,

        /// <summary>
        ///     <c>RetainLinkTimeOptimizationInfoBitEXT</c>
        /// </summary>
        RetainLinkTimeOptimizationInfoBitEXT = 0x00800000,

        /// <summary>
        ///     <c>LibraryBitKHR</c>
        /// </summary>
        LibraryBitKHR = 0x00000800,

        /// <summary>
        ///     <c>RayTracingSkipTrianglesBitKHR</c>
        /// </summary>
        RayTracingSkipTrianglesBitKHR = 0x00001000,

        /// <summary>
        ///     <c>RayTracingSkipAabbsBitKHR</c>
        /// </summary>
        RayTracingSkipAabbsBitKHR = 0x00002000,

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
        ///     <c>RayTracingShaderGroupHandleCaptureReplayBitKHR</c>
        /// </summary>
        RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x00080000,

        /// <summary>
        ///     <c>IndirectBindableBitNV</c>
        /// </summary>
        IndirectBindableBitNV = 0x00040000,

        /// <summary>
        ///     <c>RayTracingAllowMotionBitNV</c>
        /// </summary>
        RayTracingAllowMotionBitNV = 0x00100000,

        /// <summary>
        ///     <c>RenderingFragmentShadingRateAttachmentBitKHR</c>
        /// </summary>
        RenderingFragmentShadingRateAttachmentBitKHR = 0x00200000,

        /// <summary>
        ///     <c>RenderingFragmentDensityMapAttachmentBitEXT</c>
        /// </summary>
        RenderingFragmentDensityMapAttachmentBitEXT = 0x00400000,

        /// <summary>
        ///     <c>ColorAttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        ColorAttachmentFeedbackLoopBitEXT = 0x02000000,

        /// <summary>
        ///     <c>DepthStencilAttachmentFeedbackLoopBitEXT</c>
        /// </summary>
        DepthStencilAttachmentFeedbackLoopBitEXT = 0x04000000,

        /// <summary>
        ///     <c>NoProtectedAccessBitEXT</c>
        /// </summary>
        NoProtectedAccessBitEXT = 0x08000000,

        /// <summary>
        ///     <c>ProtectedAccessOnlyBitEXT</c>
        /// </summary>
        ProtectedAccessOnlyBitEXT = 0x40000000,

        /// <summary>
        ///     <c>RayTracingDisplacementMicromapBitNV</c>
        /// </summary>
        RayTracingDisplacementMicromapBitNV = 0x10000000,

        /// <summary>
        ///     <c>DescriptorBufferBitEXT</c>
        /// </summary>
        DescriptorBufferBitEXT = 0x20000000,

        /// <summary>
        ///     <c>DisallowOpacityMicromapBitARM</c>
        /// </summary>
        DisallowOpacityMicromapBitARM = 0x2000000000,

        /// <summary>
        ///     <c>InstrumentShadersBitARM</c>
        /// </summary>
        InstrumentShadersBitARM = 0x8000000000,

        /// <summary>
        ///     <c>CaptureDataBitKHR</c>
        /// </summary>
        CaptureDataBitKHR = 0x80000000,

        /// <summary>
        ///     <c>IndirectBindableBitEXT</c>
        /// </summary>
        IndirectBindableBitEXT = 0x4000000000,

        /// <summary>
        ///     <c>PerLayerFragmentDensityBitVALVE</c>
        /// </summary>
        PerLayerFragmentDensityBitVALVE = 0x10000000000,

        /// <summary>
        ///     <c>RayTracingOpacityMicromapBitKHR</c>
        /// </summary>
        RayTracingOpacityMicromapBitKHR = 0x01000000,

        /// <summary>
        ///     <c>OpacityMicromapDisallowMixedSpecialIndexBitKHR</c>
        /// </summary>
        OpacityMicromapDisallowMixedSpecialIndexBitKHR = 0x20000000000,

        /// <summary>
        ///     <c>_64BitIndexingBitEXT</c>
        /// </summary>
        _64BitIndexingBitEXT = 0x80000000000,
    }
}
