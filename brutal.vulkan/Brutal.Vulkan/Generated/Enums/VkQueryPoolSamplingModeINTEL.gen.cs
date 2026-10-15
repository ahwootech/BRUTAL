namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolSamplingModeINTEL.html">VkQueryPoolSamplingModeINTEL</see> - Enum specifying how performance queries should be captured
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkQueryPoolPerformanceQueryCreateInfoINTEL::performanceCountersSampling</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef enum VkQueryPoolSamplingModeINTEL {
    ///             VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0,
    ///         } VkQueryPoolSamplingModeINTEL;
    ///     </code>
    /// </remarks>
    public enum VkQueryPoolSamplingModeINTEL : int
    {
        /// <summary>
        ///     <c>ManualINTEL</c> is the default mode in which the application calls <c>vkCmdBeginQuery</c> and <c>vkCmdEndQuery</c> to record performance data.
        /// </summary>
        ManualINTEL = 0,

        /// <summary>
        ///     <c>MaxEnumINTEL</c>
        /// </summary>
        MaxEnumINTEL = 0x7FFFFFFF,
    }
}
