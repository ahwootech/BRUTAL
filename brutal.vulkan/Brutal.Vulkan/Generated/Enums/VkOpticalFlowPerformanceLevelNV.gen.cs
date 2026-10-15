namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowPerformanceLevelNV.html">VkOpticalFlowPerformanceLevelNV</see> - Optical flow performance level types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Optical flow exposes performance levels which the application <i>can</i> choose
    ///         based on the desired performance and quality requirement.
    ///     </para>
    ///     <para>
    ///         The optical flow performance level types are defined with the following:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowPerformanceLevelNV {
    ///             VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV = 0,
    ///             VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV = 1,
    ///             VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV = 2,
    ///             VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV = 3,
    ///         } VkOpticalFlowPerformanceLevelNV;
    ///     </code>
    /// </remarks>
    public enum VkOpticalFlowPerformanceLevelNV : int
    {
        /// <summary>
        ///     <c>UnknownNV</c>
        /// </summary>
        UnknownNV = 0,

        /// <summary>
        ///     <c>SlowNV</c> is a level with slower performance but higher quality.
        /// </summary>
        SlowNV = 1,

        /// <summary>
        ///     <c>MediumNV</c> is a level with medium performance and medium quality.
        /// </summary>
        MediumNV = 2,

        /// <summary>
        ///     <c>FastNV</c> is a preset with higher performance but lower quality.
        /// </summary>
        FastNV = 3,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
