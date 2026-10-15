namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceConfigurationTypeINTEL.html">VkPerformanceConfigurationTypeINTEL</see> - Type of performance configuration
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPerformanceConfigurationAcquireInfoINTEL::type</c>, specifying
    ///         performance configuration types, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef enum VkPerformanceConfigurationTypeINTEL {
    ///             VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,
    ///         } VkPerformanceConfigurationTypeINTEL;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceConfigurationTypeINTEL : int
    {
        /// <summary>
        ///     <c>CommandQueueMetricsDiscoveryActivatedINTEL</c>
        /// </summary>
        CommandQueueMetricsDiscoveryActivatedINTEL = 0,

        /// <summary>
        ///     <c>MaxEnumINTEL</c>
        /// </summary>
        MaxEnumINTEL = 0x7FFFFFFF,
    }
}
