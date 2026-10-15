namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryResultFlagBits.html">VkQueryResultFlagBits</see> - Bitmask specifying how and when query results are returned
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkGetQueryPoolResults::flags</c> and
    ///         <c>vkCmdCopyQueryPoolResults::flags</c>, specifying how and when
    ///         results are returned, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkQueryResultFlagBits {
    ///             VK_QUERY_RESULT_64_BIT = 0x00000001,
    ///             VK_QUERY_RESULT_WAIT_BIT = 0x00000002,
    ///             VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 0x00000004,
    ///             VK_QUERY_RESULT_PARTIAL_BIT = 0x00000008,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_QUERY_RESULT_WITH_STATUS_BIT_KHR = 0x00000010,
    ///         } VkQueryResultFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkQueryResultFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_64Bit</c> specifies the results will be written as an array of 64-bit unsigned integer values. If this bit is not set, the results will be written as an array of 32-bit unsigned integer values.
        /// </summary>
        _64Bit = 0x00000001,

        /// <summary>
        ///     <c>WaitBit</c> specifies that Vulkan will wait for each query&apos;s status to become available before retrieving its results.
        /// </summary>
        WaitBit = 0x00000002,

        /// <summary>
        ///     <c>WithAvailabilityBit</c> specifies that the availability status accompanies the results.
        /// </summary>
        WithAvailabilityBit = 0x00000004,

        /// <summary>
        ///     <c>PartialBit</c> specifies that returning partial results is acceptable.
        /// </summary>
        PartialBit = 0x00000008,

        /// <summary>
        ///     <c>WithStatusBitKHR</c>
        /// </summary>
        WithStatusBitKHR = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
