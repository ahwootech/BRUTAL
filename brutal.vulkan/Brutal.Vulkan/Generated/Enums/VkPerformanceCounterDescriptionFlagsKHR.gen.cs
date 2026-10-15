namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionFlagBitsKHR.html">VkPerformanceCounterDescriptionFlagBitsKHR</see> - Bitmask specifying usage behavior for a counter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPerformanceCounterDescriptionKHR::flags</c>, specifying usage
    ///         behavior of a performance counter, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef enum VkPerformanceCounterDescriptionFlagBitsKHR {
    ///             VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR = 0x00000001,
    ///             VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR = 0x00000002,
    ///             // VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR is a legacy alias
    ///             VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR = VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR,
    ///             // VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR is a legacy alias
    ///             VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR = VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR,
    ///         } VkPerformanceCounterDescriptionFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPerformanceCounterDescriptionFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PerformanceImpactingBitKHR</c>  specifies that recording the counter may: have a noticeable performance impact.
        /// </summary>
        PerformanceImpactingBitKHR = 0x00000001,

        /// <summary>
        ///     <c>ConcurrentlyImpactedBitKHR</c>  specifies that concurrently recording the counter while other submitted command buffers are running may: impact the accuracy of the recording.
        /// </summary>
        ConcurrentlyImpactedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PerformanceImpactingKHR</c>
        /// </summary>
        PerformanceImpactingKHR = PerformanceImpactingBitKHR,

        /// <summary>
        ///     <c>ConcurrentlyImpactedKHR</c>
        /// </summary>
        ConcurrentlyImpactedKHR = ConcurrentlyImpactedBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
