namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencySubmissionPresentIdNV.html">VkLatencySubmissionPresentIdNV</see> - Structure used to associate a queueSubmit with a presentId
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencySubmissionPresentIdNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkLatencySubmissionPresentIdNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           presentID;
    ///         } VkLatencySubmissionPresentIdNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkLatencySubmissionPresentIdNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LatencySubmissionPresentIdNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentID</c> is used to associate the <c>vkQueueSubmit</c> with the presentId used for a given <c>vkQueuePresentKHR</c> via
        /// </summary>
        [FieldOffset(16)]
        public nint PresentID;
    }
}
