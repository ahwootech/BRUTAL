namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineNodeTypeARM.html">VkDataGraphPipelineNodeTypeARM</see> - Enumeration describing the type of a data graph pipeline node
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineNodeTypeARM
    ///     </para>
    ///     <para>
    ///         Possible values of <c>VkDataGraphPipelineNodeTypeARM</c>, specifying the type
    ///         of a data graph pipeline node, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphPipelineNodeTypeARM {
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_TYPE_OPTICAL_FLOW_ARM = 1000631000,
    ///         } VkDataGraphPipelineNodeTypeARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphPipelineNodeTypeARM : int
    {
        /// <summary>
        ///     <c>OpticalFlowARM</c> corresponds to an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#graphs-operations-opticalflow">optical flow node^</see>.
        /// </summary>
        OpticalFlowARM = 1000631000,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
