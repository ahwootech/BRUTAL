namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowGridSizeFlagBitsARM.html">VkDataGraphOpticalFlowGridSizeFlagBitsARM</see> - Bits specifying grid sizes for optical flow operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Optical flow vectors are generated block-wise, one vector for each block of
    ///         NxN pixels (referred to as grid).
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphPipelineOpticalFlowCreateInfoARM::outputGridSize</c> and
    ///         <c>VkDataGraphPipelineOpticalFlowCreateInfoARM::hintGridSize</c>, or
    ///         which are returned in
    ///         <c>VkQueueFamilyDataGraphOpticalFlowPropertiesARM::supportedOutputGridSizes</c>
    ///         and
    ///         <c>VkQueueFamilyDataGraphOpticalFlowPropertiesARM::supportedHintGridSizes</c>
    ///         controlling optical flow grid sizes, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphOpticalFlowGridSizeFlagBitsARM {
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_ARM = 0,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_ARM = 0x00000001,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_ARM = 0x00000002,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_ARM = 0x00000004,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_ARM = 0x00000008,
    ///         } VkDataGraphOpticalFlowGridSizeFlagBitsARM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDataGraphOpticalFlowGridSizeFlagsARM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UnknownARM</c>
        /// </summary>
        UnknownARM = 0,

        /// <summary>
        ///     <c>_1X1BitARM</c> specifies that grid is 1x1 pixel.
        /// </summary>
        _1X1BitARM = 0x00000001,

        /// <summary>
        ///     <c>_2X2BitARM</c> specifies that grid is 2x2 pixel.
        /// </summary>
        _2X2BitARM = 0x00000002,

        /// <summary>
        ///     <c>_4X4BitARM</c> specifies that grid is 4x4 pixel.
        /// </summary>
        _4X4BitARM = 0x00000004,

        /// <summary>
        ///     <c>_8X8BitARM</c> specifies that grid is 8x8 pixel.
        /// </summary>
        _8X8BitARM = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumARM</c>
        /// </summary>
        FlagBitsMaxEnumARM = 0x7FFFFFFF,
    }
}
