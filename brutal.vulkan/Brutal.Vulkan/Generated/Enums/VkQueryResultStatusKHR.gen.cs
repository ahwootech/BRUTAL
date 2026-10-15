namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryResultStatusKHR.html">VkQueryResultStatusKHR</see> - Specific status codes for operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[query-result-status-codes]]
    ///         Specific status codes that <i>can</i> be returned from a query are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkQueryResultStatusKHR {
    ///             VK_QUERY_RESULT_STATUS_ERROR_KHR = -1,
    ///             VK_QUERY_RESULT_STATUS_NOT_READY_KHR = 0,
    ///             VK_QUERY_RESULT_STATUS_COMPLETE_KHR = 1,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR = -1000299000,
    ///         } VkQueryResultStatusKHR;
    ///     </code>
    /// </remarks>
    public enum VkQueryResultStatusKHR : int
    {
        /// <summary>
        ///     <c>ErrorKHR</c> specifies that operations did not complete successfully.
        /// </summary>
        ErrorKHR = -1,

        /// <summary>
        ///     <c>NotReadyKHR</c> specifies that the query result is not yet available.
        /// </summary>
        NotReadyKHR = 0,

        /// <summary>
        ///     <c>CompleteKHR</c> specifies that operations completed successfully and the query result is available.
        /// </summary>
        CompleteKHR = 1,

        /// <summary>
        ///     <c>InsufficientBitstreamBufferRangeKHR</c>
        /// </summary>
        InsufficientBitstreamBufferRangeKHR = -1000299000,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
