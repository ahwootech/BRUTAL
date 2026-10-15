namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineNodeConnectionTypeARM.html">VkDataGraphPipelineNodeConnectionTypeARM</see> - Connection points for a fixed-function data graph node
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDataGraphPipelineNodeConnectionTypeARM</c>,
    ///         specifying the connection points of a data graph pipeline node, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphPipelineNodeConnectionTypeARM {
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_INPUT_ARM = 1000631000,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_REFERENCE_ARM = 1000631001,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_HINT_ARM = 1000631002,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_FLOW_VECTOR_ARM = 1000631003,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_COST_ARM = 1000631004,
    ///         } VkDataGraphPipelineNodeConnectionTypeARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphPipelineNodeConnectionTypeARM : int
    {
        /// <summary>
        ///     <c>OpticalFlowInputARM</c>  specifies the connection point for the input image of an optical flow node.
        /// </summary>
        OpticalFlowInputARM = 1000631000,

        /// <summary>
        ///     <c>OpticalFlowReferenceARM</c>  specifies the connection point for the input reference image of an optical flow node.
        /// </summary>
        OpticalFlowReferenceARM = 1000631001,

        /// <summary>
        ///     <c>OpticalFlowHintARM</c>  specifies the connection point for the optional external hint flow vector map of an optical flow node.
        /// </summary>
        OpticalFlowHintARM = 1000631002,

        /// <summary>
        ///     <c>OpticalFlowFlowVectorARM</c>  specifies the connection point for the output flow vector map of an optical flow node.
        /// </summary>
        OpticalFlowFlowVectorARM = 1000631003,

        /// <summary>
        ///     <c>OpticalFlowCostARM</c>  specifies the connection point for the optional output cost map of an optical flow node.
        /// </summary>
        OpticalFlowCostARM = 1000631004,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
