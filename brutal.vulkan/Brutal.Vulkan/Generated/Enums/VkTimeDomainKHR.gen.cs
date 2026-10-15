namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTimeDomainKHR.html">VkTimeDomainKHR</see> - Supported time domains
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The set of supported time domains consists of:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_calibrated_timestamps
    ///         typedef enum VkTimeDomainKHR {
    ///             VK_TIME_DOMAIN_DEVICE_KHR = 0,
    ///             VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR = 1,
    ///             VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR = 2,
    ///             VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR = 3,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_TIME_DOMAIN_PRESENT_STAGE_LOCAL_EXT = 1000208000,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_TIME_DOMAIN_SWAPCHAIN_LOCAL_EXT = 1000208001,
    ///             // Provided by VK_EXT_calibrated_timestamps
    ///             VK_TIME_DOMAIN_DEVICE_EXT = VK_TIME_DOMAIN_DEVICE_KHR,
    ///             // Provided by VK_EXT_calibrated_timestamps
    ///             VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR,
    ///             // Provided by VK_EXT_calibrated_timestamps
    ///             VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR,
    ///             // Provided by VK_EXT_calibrated_timestamps
    ///             VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR,
    ///         } VkTimeDomainKHR;
    ///     </code>
    /// </remarks>
    public enum VkTimeDomainKHR : int
    {
        /// <summary>
        ///     <c>DeviceKHR</c> specifies the device time domain. Timestamp values in this time domain use the same units and are comparable with device timestamp values captured using <c>vkCmdWriteTimestamp</c> and are defined to be incrementing according to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits-timestampPeriod"><c>timestampPeriod</c>^</see> of the device.
        /// </summary>
        DeviceKHR = 0,

        /// <summary>
        ///     <c>ClockMonotonicKHR</c> specifies the CLOCK_MONOTONIC time domain available on POSIX platforms. Timestamp values in this time domain are in units of nanoseconds and are comparable with platform timestamp values captured using the POSIX clock_gettime API as computed by this example:  [NOTE]
        /// </summary>
        ClockMonotonicKHR = 1,

        /// <summary>
        ///     <c>ClockMonotonicRawKHR</c>
        /// </summary>
        ClockMonotonicRawKHR = 2,

        /// <summary>
        ///     <c>QueryPerformanceCounterKHR</c>
        /// </summary>
        QueryPerformanceCounterKHR = 3,

        /// <summary>
        ///     <c>PresentStageLocalEXT</c>
        /// </summary>
        PresentStageLocalEXT = 1000208000,

        /// <summary>
        ///     <c>SwapchainLocalEXT</c>
        /// </summary>
        SwapchainLocalEXT = 1000208001,

        /// <summary>
        ///     <c>DeviceEXT</c>
        /// </summary>
        DeviceEXT = DeviceKHR,

        /// <summary>
        ///     <c>ClockMonotonicEXT</c>
        /// </summary>
        ClockMonotonicEXT = ClockMonotonicKHR,

        /// <summary>
        ///     <c>ClockMonotonicRawEXT</c>
        /// </summary>
        ClockMonotonicRawEXT = ClockMonotonicRawKHR,

        /// <summary>
        ///     <c>QueryPerformanceCounterEXT</c>
        /// </summary>
        QueryPerformanceCounterEXT = QueryPerformanceCounterKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
