namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSetPresentConfigNV.html">VkSetPresentConfigNV</see> - Structure specifying present metering configuration
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Present Metering evenly paces out the next <c>numFramesPerBatch</c>
    ///         <c>vkQueuePresentKHR</c> presents.
    ///         This gives smoother pacing between presents in applications with frame
    ///         generation integrations.
    ///     </para>
    ///     <para>
    ///         The <c>VkSetPresentConfigNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_present_metering
    ///         typedef struct VkSetPresentConfigNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           numFramesPerBatch;
    ///             uint32_t           presentConfigFeedback;
    ///         } VkSetPresentConfigNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSetPresentConfigNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SetPresentConfigNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NumFramesPerBatch</c> is the number of frames to batch
        /// </summary>
        [FieldOffset(16)]
        public int NumFramesPerBatch;

        /// <summary>
        ///     <c>PresentConfigFeedback</c> will return the success or error status
        /// </summary>
        [FieldOffset(20)]
        public int PresentConfigFeedback;
    }
}
