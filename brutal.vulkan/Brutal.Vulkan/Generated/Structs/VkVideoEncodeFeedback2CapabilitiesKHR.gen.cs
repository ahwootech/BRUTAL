namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFeedback2CapabilitiesKHR.html">VkVideoEncodeFeedback2CapabilitiesKHR</see> - Structure describing additional video encode feedback capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeFeedback2CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_feedback2
    ///         typedef struct VkVideoEncodeFeedback2CapabilitiesKHR {
    ///             VkStructureType                              sType;
    ///             void*                                        pNext;
    ///             uint32_t                                     maxPerPartitionFeedbackEntries;
    ///             VkVideoEncodePerPartitionFeedbackFlagsKHR    supportedPerPartitionEncodeFeedbackFlags;
    ///         } VkVideoEncodeFeedback2CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeFeedback2CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeFeedback2CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPerPartitionFeedbackEntries</c> specifies the maximum number of picture partitions for which the implementation supports capturing per picture partition video encode feedback values.
        /// </summary>
        [FieldOffset(16)]
        public int MaxPerPartitionFeedbackEntries;

        /// <summary>
        ///     <c>SupportedPerPartitionEncodeFeedbackFlags</c> is a bitmask of <c>VkVideoEncodePerPartitionFeedbackFlagsKHR</c> values specifying the set of per picture partition video encode feedback values supported by <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-video-encode-feedback">video encode feedback queries^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodePerPartitionFeedbackFlagsKHR SupportedPerPartitionEncodeFeedbackFlags;
    }
}
