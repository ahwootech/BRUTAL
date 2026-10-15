namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterStorageKHR.html">VkPerformanceCounterStorageKHR</see> - Supported counter storage types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Performance counters have an associated storage.
    ///         This storage describes the payload of a counter result.
    ///     </para>
    ///     <para>
    ///         The performance counter storage types which may: be returned in
    ///         <c>VkPerformanceCounterKHR::storage</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef enum VkPerformanceCounterStorageKHR {
    ///             VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = 0,
    ///             VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = 1,
    ///             VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = 2,
    ///             VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = 3,
    ///             VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = 4,
    ///             VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = 5,
    ///         } VkPerformanceCounterStorageKHR;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceCounterStorageKHR : int
    {
        /// <summary>
        ///     <c>Int32KHR</c> - the performance counter storage is a 32-bit signed integer.
        /// </summary>
        Int32KHR = 0,

        /// <summary>
        ///     <c>Int64KHR</c> - the performance counter storage is a 64-bit signed integer.
        /// </summary>
        Int64KHR = 1,

        /// <summary>
        ///     <c>UInt32KHR</c> - the performance counter storage is a 32-bit unsigned integer.
        /// </summary>
        UInt32KHR = 2,

        /// <summary>
        ///     <c>UInt64KHR</c> - the performance counter storage is a 64-bit unsigned integer.
        /// </summary>
        UInt64KHR = 3,

        /// <summary>
        ///     <c>Float32KHR</c> - the performance counter storage is a 32-bit floating-point.
        /// </summary>
        Float32KHR = 4,

        /// <summary>
        ///     <c>Float64KHR</c> - the performance counter storage is a 64-bit floating-point.
        /// </summary>
        Float64KHR = 5,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
