namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionBindPointARM.html">VkDataGraphPipelineSessionBindPointARM</see> - Enumeration describing the bind points of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionBindPointARM
    ///     </para>
    ///     <para>
    ///         Possible values of <c>VkDataGraphPipelineSessionBindPointARM</c>, specifying
    ///         the bind point of a data graph pipeline session, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef enum VkDataGraphPipelineSessionBindPointARM {
    ///             VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM = 0,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_OPTICAL_FLOW_CACHE_ARM = 1000631001,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_NEURAL_ACCELERATOR_STATISTICS_ARM = 1000676000,
    ///         } VkDataGraphPipelineSessionBindPointARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphPipelineSessionBindPointARM : int
    {
        /// <summary>
        ///     <c>TransientARM</c>  corresponds to the transient data produced and consumed during one dispatch of a data graph pipeline in a data graph pipeline session. This transient data is never reused by subsequent dispatches and can safely be clobbered once a <c>vkCmdDispatchDataGraphARM</c> command completes execution.
        /// </summary>
        TransientARM = 0,

        /// <summary>
        ///     <c>OpticalFlowCacheARM</c>
        /// </summary>
        OpticalFlowCacheARM = 1000631001,

        /// <summary>
        ///     <c>NeuralAcceleratorStatisticsARM</c>
        /// </summary>
        NeuralAcceleratorStatisticsARM = 1000676000,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
