namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowPerformanceLevelARM.html">VkDataGraphOpticalFlowPerformanceLevelARM</see> - Optical flow performance level types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Optical flow exposes performance levels which the user can choose based on
    ///         the desired performance and quality requirement.
    ///         The optical flow performance level types are defined with the following:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphOpticalFlowPerformanceLevelARM {
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_ARM = 0,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_ARM = 1,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_ARM = 2,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_ARM = 3,
    ///         } VkDataGraphOpticalFlowPerformanceLevelARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphOpticalFlowPerformanceLevelARM : int
    {
        /// <summary>
        ///     <c>UnknownARM</c>
        /// </summary>
        UnknownARM = 0,

        /// <summary>
        ///     <c>SlowARM</c> is a level with slower performance but higher quality.
        /// </summary>
        SlowARM = 1,

        /// <summary>
        ///     <c>MediumARM</c> is a level with medium performance and medium quality.
        /// </summary>
        MediumARM = 2,

        /// <summary>
        ///     <c>FastARM</c> is a preset with higher performance but lower quality.
        /// </summary>
        FastARM = 3,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
