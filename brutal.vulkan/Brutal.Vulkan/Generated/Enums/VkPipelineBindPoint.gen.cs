namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineBindPoint.html">VkPipelineBindPoint</see> - Specify the bind point of a pipeline object to a command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>vkCmdBindPipeline::pipelineBindPoint</c>,
    ///         specifying the bind point of a pipeline object, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPipelineBindPoint {
    ///             VK_PIPELINE_BIND_POINT_GRAPHICS = 0,
    ///             VK_PIPELINE_BIND_POINT_COMPUTE = 1,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_PIPELINE_BIND_POINT_EXECUTION_GRAPH_AMDX = 1000134000,
    ///             #endif
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR = 1000165000,
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI = 1000369003,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_PIPELINE_BIND_POINT_DATA_GRAPH_ARM = 1000507000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_PIPELINE_BIND_POINT_RAY_TRACING_NV = VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR,
    ///         } VkPipelineBindPoint;
    ///     </code>
    /// </remarks>
    public enum VkPipelineBindPoint : int
    {
        /// <summary>
        ///     <c>Graphics</c> specifies binding as a graphics pipeline.
        /// </summary>
        Graphics = 0,

        /// <summary>
        ///     <c>Compute</c> specifies binding as a compute pipeline.
        /// </summary>
        Compute = 1,

        /// <summary>
        ///     <c>ExecutionGraphAMDX</c>
        /// </summary>
        ExecutionGraphAMDX = 1000134000,

        /// <summary>
        ///     <c>RayTracingKHR</c>
        /// </summary>
        RayTracingKHR = 1000165000,

        /// <summary>
        ///     <c>SubpassShadingHUAWEI</c>
        /// </summary>
        SubpassShadingHUAWEI = 1000369003,

        /// <summary>
        ///     <c>DataGraphARM</c>
        /// </summary>
        DataGraphARM = 1000507000,

        /// <summary>
        ///     <c>RayTracingNV</c>
        /// </summary>
        RayTracingNV = RayTracingKHR,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
