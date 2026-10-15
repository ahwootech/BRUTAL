namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageInfoKHR.html">VkVideoEncodeUsageInfoKHR</see> - Structure specifying video encode usage information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Additional information about the video encode use case <i>can</i> be provided by
    ///         adding a <c>VkVideoEncodeUsageInfoKHR</c> structure to the <c>pNext</c> chain
    ///         of <c>VkVideoProfileInfoKHR</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeUsageInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeUsageInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkVideoEncodeUsageFlagsKHR      videoUsageHints;
    ///             VkVideoEncodeContentFlagsKHR    videoContentHints;
    ///             VkVideoEncodeTuningModeKHR      tuningMode;
    ///         } VkVideoEncodeUsageInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeUsageInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeUsageInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoUsageHints</c> is a bitmask of <c>VkVideoEncodeUsageFlagsKHR</c> specifying hints about the intended use of the video encode profile.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeUsageFlagsKHR VideoUsageHints;

        /// <summary>
        ///     <c>VideoContentHints</c> is a bitmask of <c>VkVideoEncodeContentFlagsKHR</c> specifying hints about the content to be encoded using the video encode profile.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeContentFlagsKHR VideoContentHints;

        /// <summary>
        ///     <c>TuningMode</c> is a <c>VkVideoEncodeTuningModeKHR</c> value specifying the tuning mode to use when encoding with the video profile.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoEncodeTuningModeKHR TuningMode;
    }
}
