namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowImageUsageFlagBitsARM.html">VkDataGraphOpticalFlowImageUsageFlagBitsARM</see> - Bits specifying image usage for optical flow operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphOpticalFlowImageFormatInfoARM::usage</c>, controlling
    ///         optical flow usage, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphOpticalFlowImageUsageFlagBitsARM {
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_UNKNOWN_ARM = 0,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_INPUT_BIT_ARM = 0x00000001,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_OUTPUT_BIT_ARM = 0x00000002,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_HINT_BIT_ARM = 0x00000004,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_COST_BIT_ARM = 0x00000008,
    ///         } VkDataGraphOpticalFlowImageUsageFlagBitsARM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDataGraphOpticalFlowImageUsageFlagsARM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UnknownARM</c>
        /// </summary>
        UnknownARM = 0,

        /// <summary>
        ///     <c>InputBitARM</c> specifies that the image <i>can</i> be used as input or reference image for an optical flow operation.
        /// </summary>
        InputBitARM = 0x00000001,

        /// <summary>
        ///     <c>OutputBitARM</c> specifies that the image <i>can</i> be used as output flow vector map for an optical flow operation.
        /// </summary>
        OutputBitARM = 0x00000002,

        /// <summary>
        ///     <c>HintBitARM</c> specifies that the image <i>can</i> be used as hint flow vector map for an optical flow operation.
        /// </summary>
        HintBitARM = 0x00000004,

        /// <summary>
        ///     <c>CostBitARM</c> specifies that the image <i>can</i> be used as output cost map for an optical flow operation.
        /// </summary>
        CostBitARM = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumARM</c>
        /// </summary>
        FlagBitsMaxEnumARM = 0x7FFFFFFF,
    }
}
