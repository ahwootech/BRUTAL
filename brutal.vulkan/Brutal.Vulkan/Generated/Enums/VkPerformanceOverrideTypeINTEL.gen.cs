namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideTypeINTEL.html">VkPerformanceOverrideTypeINTEL</see> - Performance override type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkPerformanceOverrideInfoINTEL::type</c>,
    ///         specifying performance override types, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef enum VkPerformanceOverrideTypeINTEL {
    ///             VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = 0,
    ///             VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = 1,
    ///         } VkPerformanceOverrideTypeINTEL;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceOverrideTypeINTEL : int
    {
        /// <summary>
        ///     <c>NullHardwareINTEL</c> turns all rendering operations into noop.
        /// </summary>
        NullHardwareINTEL = 0,

        /// <summary>
        ///     <c>FlushGpuCachesINTEL</c> stalls the stream of commands until all previously emitted commands have completed and all caches been flushed and invalidated.
        /// </summary>
        FlushGpuCachesINTEL = 1,

        /// <summary>
        ///     <c>MaxEnumINTEL</c>
        /// </summary>
        MaxEnumINTEL = 0x7FFFFFFF,
    }
}
