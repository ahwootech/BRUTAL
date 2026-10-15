namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR.html">VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR</see> - Structure specifying enabled per picture partition video encode feedback values
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_feedback2
    ///         typedef struct VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR {
    ///             VkStructureType                              sType;
    ///             const void*                                  pNext;
    ///             uint32_t                                     maxPerPartitionFeedbackEntries;
    ///             VkVideoEncodePerPartitionFeedbackFlagsKHR    perPartitionEncodeFeedbackFlags;
    ///         } VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPerPartitionFeedbackEntries</c> specifies the maximum number of picture partitions for which per picture partition video encode feedback values <i>can</i> be captured by queries of the new pool.
        /// </summary>
        [FieldOffset(16)]
        public int MaxPerPartitionFeedbackEntries;

        /// <summary>
        ///     <c>PerPartitionEncodeFeedbackFlags</c> is a bitmask of <c>VkVideoEncodePerPartitionFeedbackFlagsKHR</c> values specifying the set of enabled per picture partition video encode feedback values captured by queries of the new pool.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodePerPartitionFeedbackFlagsKHR PerPartitionEncodeFeedbackFlags;
    }
}
