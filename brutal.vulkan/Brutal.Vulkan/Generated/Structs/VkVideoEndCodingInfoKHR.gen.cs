namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEndCodingInfoKHR.html">VkVideoEndCodingInfoKHR</see> - Structure specifying video coding scope end information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEndCodingInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoEndCodingInfoKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkVideoEndCodingFlagsKHR    flags;
    ///         } VkVideoEndCodingInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEndCodingInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEndCodingInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEndCodingFlagsKHR Flags;
    }
}
