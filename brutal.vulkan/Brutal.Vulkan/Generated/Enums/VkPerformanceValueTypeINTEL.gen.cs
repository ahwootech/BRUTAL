namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueTypeINTEL.html">VkPerformanceValueTypeINTEL</see> - Type of the parameters that can be queried
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkPerformanceValueINTEL::type</c>, specifying the
    ///         type of the data returned in <c>VkPerformanceValueINTEL::data</c>, are:
    ///     </para>
    ///     <para>
    ///         * <c>VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL</c> specifies that unsigned
    ///         32-bit integer data is returned in <c>data</c>.value32.
    ///         * <c>VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL</c> specifies that unsigned
    ///         64-bit integer data is returned in <c>data</c>.value64.
    ///         * <c>VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL</c> specifies that
    ///         floating-point data is returned in <c>data</c>.valueFloat.
    ///         * <c>VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL</c> specifies that
    ///         basetype:VkBool32 data is returned in <c>data</c>.valueBool.
    ///         * <c>VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL</c> specifies that a pointer to
    ///         a null-terminated UTF-8 string is returned in <c>data</c>.valueString.
    ///         The pointer is valid for the lifetime of the <c>device</c> parameter
    ///         passed to <c>vkGetPerformanceParameterINTEL</c>.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef enum VkPerformanceValueTypeINTEL {
    ///             VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,
    ///             VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,
    ///             VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,
    ///             VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,
    ///             VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4,
    ///         } VkPerformanceValueTypeINTEL;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceValueTypeINTEL : int
    {
        /// <summary>
        ///     <c>UInt32INTEL</c>
        /// </summary>
        UInt32INTEL = 0,

        /// <summary>
        ///     <c>UInt64INTEL</c>
        /// </summary>
        UInt64INTEL = 1,

        /// <summary>
        ///     <c>FloatINTEL</c>
        /// </summary>
        FloatINTEL = 2,

        /// <summary>
        ///     <c>BoolINTEL</c>
        /// </summary>
        BoolINTEL = 3,

        /// <summary>
        ///     <c>StringINTEL</c>
        /// </summary>
        StringINTEL = 4,

        /// <summary>
        ///     <c>MaxEnumINTEL</c>
        /// </summary>
        MaxEnumINTEL = 0x7FFFFFFF,
    }
}
