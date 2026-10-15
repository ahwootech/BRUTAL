namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeUsageInfoKHR.html">VkVideoDecodeUsageInfoKHR</see> - Structure specifying video decode usage information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Additional information about the video decode use case <i>can</i> be provided by
    ///         adding a <c>VkVideoDecodeUsageInfoKHR</c> structure to the <c>pNext</c> chain
    ///         of <c>VkVideoProfileInfoKHR</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeUsageInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_queue
    ///         typedef struct VkVideoDecodeUsageInfoKHR {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkVideoDecodeUsageFlagsKHR    videoUsageHints;
    ///         } VkVideoDecodeUsageInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeUsageInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeUsageInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoUsageHints</c> is a bitmask of <c>VkVideoDecodeUsageFlagsKHR</c> specifying hints about the intended use of the video decode profile.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoDecodeUsageFlagsKHR VideoUsageHints;
    }
}
