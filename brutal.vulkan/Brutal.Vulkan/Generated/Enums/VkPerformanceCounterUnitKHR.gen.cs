namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterUnitKHR.html">VkPerformanceCounterUnitKHR</see> - Supported counter unit types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Performance counters have an associated unit.
    ///         This unit describes how to interpret the performance counter result.
    ///     </para>
    ///     <para>
    ///         The performance counter unit types which may: be returned in
    ///         <c>VkPerformanceCounterKHR::unit</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef enum VkPerformanceCounterUnitKHR {
    ///             VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR = 0,
    ///             VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR = 1,
    ///             VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR = 2,
    ///             VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR = 3,
    ///             VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR = 4,
    ///             VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR = 5,
    ///             VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR = 6,
    ///             VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR = 7,
    ///             VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR = 8,
    ///             VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR = 9,
    ///             VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR = 10,
    ///         } VkPerformanceCounterUnitKHR;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceCounterUnitKHR : int
    {
        /// <summary>
        ///     <c>GenericKHR</c> - the performance counter unit is a generic data point.
        /// </summary>
        GenericKHR = 0,

        /// <summary>
        ///     <c>PercentageKHR</c> - the performance counter unit is a percentage (%).
        /// </summary>
        PercentageKHR = 1,

        /// <summary>
        ///     <c>NanosecondsKHR</c> - the performance counter unit is a value of nanoseconds (ns).
        /// </summary>
        NanosecondsKHR = 2,

        /// <summary>
        ///     <c>BytesKHR</c> - the performance counter unit is a value of bytes.
        /// </summary>
        BytesKHR = 3,

        /// <summary>
        ///     <c>BytesPerSecondKHR</c> - the performance counter unit is a value of bytes/s.
        /// </summary>
        BytesPerSecondKHR = 4,

        /// <summary>
        ///     <c>KelvinKHR</c> - the performance counter unit is a temperature reported in Kelvin.
        /// </summary>
        KelvinKHR = 5,

        /// <summary>
        ///     <c>WattsKHR</c> - the performance counter unit is a value of watts (W).
        /// </summary>
        WattsKHR = 6,

        /// <summary>
        ///     <c>VoltsKHR</c> - the performance counter unit is a value of volts (V).
        /// </summary>
        VoltsKHR = 7,

        /// <summary>
        ///     <c>AmpsKHR</c> - the performance counter unit is a value of amps (A).
        /// </summary>
        AmpsKHR = 8,

        /// <summary>
        ///     <c>HertzKHR</c> - the performance counter unit is a value of hertz (Hz).
        /// </summary>
        HertzKHR = 9,

        /// <summary>
        ///     <c>CyclesKHR</c> - the performance counter unit is a value of cycles.
        /// </summary>
        CyclesKHR = 10,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
