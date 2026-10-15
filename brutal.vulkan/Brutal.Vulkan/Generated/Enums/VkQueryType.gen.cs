namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryType.html">VkQueryType</see> - Specify the type of queries managed by a query pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkQueryPoolCreateInfo::queryType</c>, specifying
    ///         the type of queries managed by the pool, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkQueryType {
    ///             VK_QUERY_TYPE_OCCLUSION = 0,
    ///             VK_QUERY_TYPE_PIPELINE_STATISTICS = 1,
    ///             VK_QUERY_TYPE_TIMESTAMP = 2,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR = 1000023000,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = 1000028004,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = 1000116000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = 1000150000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = 1000150001,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = 1000165000,
    ///             // Provided by VK_QCOM_elapsed_timer_query
    ///             VK_QUERY_TYPE_TIME_ELAPSED_QCOM = 1000173000,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = 1000210000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_QUERY_TYPE_VIDEO_ENCODE_FEEDBACK_KHR = 1000299000,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT = 1000328000,
    ///             // Provided by VK_EXT_primitives_generated_query
    ///             VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT = 1000382000,
    ///             // Provided by VK_KHR_ray_tracing_maintenance1
    ///             VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR = 1000386000,
    ///             // Provided by VK_KHR_ray_tracing_maintenance1
    ///             VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR = 1000386001,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_QUERY_TYPE_MICROMAP_SERIALIZATION_SIZE_EXT = 1000396000,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_QUERY_TYPE_MICROMAP_COMPACTED_SIZE_EXT = 1000396001,
    ///         } VkQueryType;
    ///     </code>
    /// </remarks>
    public enum VkQueryType : int
    {
        /// <summary>
        ///     <c>Occlusion</c> specifies an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-occlusion">occlusion query^</see>.
        /// </summary>
        Occlusion = 0,

        /// <summary>
        ///     <c>PipelineStatistics</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-pipestats">pipeline statistics query^</see>.
        /// </summary>
        PipelineStatistics = 1,

        /// <summary>
        ///     <c>Timestamp</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-timestamps">timestamp query^</see>.
        /// </summary>
        Timestamp = 2,

        /// <summary>
        ///     <c>ResultStatusOnlyKHR</c>
        /// </summary>
        ResultStatusOnlyKHR = 1000023000,

        /// <summary>
        ///     <c>TransformFeedbackStreamEXT</c>
        /// </summary>
        TransformFeedbackStreamEXT = 1000028004,

        /// <summary>
        ///     <c>PerformanceQueryKHR</c>
        /// </summary>
        PerformanceQueryKHR = 1000116000,

        /// <summary>
        ///     <c>AccelerationStructureCompactedSizeKHR</c>
        /// </summary>
        AccelerationStructureCompactedSizeKHR = 1000150000,

        /// <summary>
        ///     <c>AccelerationStructureSerializationSizeKHR</c>
        /// </summary>
        AccelerationStructureSerializationSizeKHR = 1000150001,

        /// <summary>
        ///     <c>AccelerationStructureCompactedSizeNV</c>
        /// </summary>
        AccelerationStructureCompactedSizeNV = 1000165000,

        /// <summary>
        ///     <c>TimeElapsedQCOM</c>
        /// </summary>
        TimeElapsedQCOM = 1000173000,

        /// <summary>
        ///     <c>PerformanceQueryINTEL</c>
        /// </summary>
        PerformanceQueryINTEL = 1000210000,

        /// <summary>
        ///     <c>VideoEncodeFeedbackKHR</c>
        /// </summary>
        VideoEncodeFeedbackKHR = 1000299000,

        /// <summary>
        ///     <c>MeshPrimitivesGeneratedEXT</c>
        /// </summary>
        MeshPrimitivesGeneratedEXT = 1000328000,

        /// <summary>
        ///     <c>PrimitivesGeneratedEXT</c>
        /// </summary>
        PrimitivesGeneratedEXT = 1000382000,

        /// <summary>
        ///     <c>AccelerationStructureSerializationBottomLevelPointersKHR</c>
        /// </summary>
        AccelerationStructureSerializationBottomLevelPointersKHR = 1000386000,

        /// <summary>
        ///     <c>AccelerationStructureSizeKHR</c>
        /// </summary>
        AccelerationStructureSizeKHR = 1000386001,

        /// <summary>
        ///     <c>MicromapSerializationSizeEXT</c>
        /// </summary>
        MicromapSerializationSizeEXT = 1000396000,

        /// <summary>
        ///     <c>MicromapCompactedSizeEXT</c>
        /// </summary>
        MicromapCompactedSizeEXT = 1000396001,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
