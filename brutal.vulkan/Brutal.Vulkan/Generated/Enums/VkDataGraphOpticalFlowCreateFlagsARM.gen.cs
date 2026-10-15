namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowCreateFlagBitsARM.html">VkDataGraphOpticalFlowCreateFlagBitsARM</see> - Bits specifying flags for newly created optical flow data graph node
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphPipelineOpticalFlowCreateInfoARM::flags</c>, controlling
    ///         optical flow pipeline operations, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphOpticalFlowCreateFlagBitsARM {
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_CREATE_ENABLE_HINT_BIT_ARM = 0x00000001,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_CREATE_ENABLE_COST_BIT_ARM = 0x00000002,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_CREATE_RESERVED_30_BIT_ARM = 0x40000000,
    ///         } VkDataGraphOpticalFlowCreateFlagBitsARM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDataGraphOpticalFlowCreateFlagsARM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>EnableHintBitARM</c> specifies that a <c>VkImageView</c> with external flow vector map will be used as hints in performing the motion search and <i>must</i> be connected to <c>VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_HINT_ARM</c>.
        /// </summary>
        EnableHintBitARM = 0x00000001,

        /// <summary>
        ///     <c>EnableCostBitARM</c> specifies that the cost for the forward flow is generated in a <c>VkImageView</c> which <i>must</i> be connected to <c>VK_DATA_GRAPH_PIPELINE_NODE_CONNECTION_TYPE_OPTICAL_FLOW_COST_ARM</c>. The cost is the confidence level of the flow vector for each grid in the image. The cost implies how (in)accurate the flow vector is. Higher cost value implies the flow vector to be less accurate and vice-versa.
        /// </summary>
        EnableCostBitARM = 0x00000002,

        /// <summary>
        ///     <c>Reserved30BitARM</c>
        /// </summary>
        Reserved30BitARM = 0x40000000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumARM</c>
        /// </summary>
        FlagBitsMaxEnumARM = 0x7FFFFFFF,
    }
}
