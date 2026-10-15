namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolVideoEncodeFeedbackCreateInfoKHR.html">VkQueryPoolVideoEncodeFeedbackCreateInfoKHR</see> - Structure specifying enabled video encode feedback values
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryPoolVideoEncodeFeedbackCreateInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkVideoEncodeFeedbackFlagsKHR    encodeFeedbackFlags;
    ///         } VkQueryPoolVideoEncodeFeedbackCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryPoolVideoEncodeFeedbackCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>EncodeFeedbackFlags</c> is a bitmask of <c>VkVideoEncodeFeedbackFlagsKHR</c> values specifying the set of enabled video encode feedback values captured by queries of the new pool.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeFeedbackFlagsKHR EncodeFeedbackFlags;
    }
}
