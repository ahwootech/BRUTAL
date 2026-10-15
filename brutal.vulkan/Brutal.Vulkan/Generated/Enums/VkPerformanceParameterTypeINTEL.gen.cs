namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceParameterTypeINTEL.html">VkPerformanceParameterTypeINTEL</see> - Parameters that can be queried
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>vkGetPerformanceParameterINTEL::parameter</c>,
    ///         specifying a performance query feature, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef enum VkPerformanceParameterTypeINTEL {
    ///             VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL = 0,
    ///             VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL = 1,
    ///         } VkPerformanceParameterTypeINTEL;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceParameterTypeINTEL : int
    {
        /// <summary>
        ///     <c>HwCountersSupportedINTEL</c> has a boolean result which tells whether hardware counters can be captured.
        /// </summary>
        HwCountersSupportedINTEL = 0,

        /// <summary>
        ///     <c>StreamMarkerValidBitsINTEL</c> has a 32 bits integer result which tells how many bits can be written into the <c>VkPerformanceValueINTEL</c> value.
        /// </summary>
        StreamMarkerValidBitsINTEL = 1,

        /// <summary>
        ///     <c>MaxEnumINTEL</c>
        /// </summary>
        MaxEnumINTEL = 0x7FFFFFFF,
    }
}
