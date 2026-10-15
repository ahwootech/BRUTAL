namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264DpbSlotInfoKHR.html">VkVideoDecodeH264DpbSlotInfoKHR</see> - Structure specifies H.264 decode DPB picture information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH264DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264
    ///         typedef struct VkVideoDecodeH264DpbSlotInfoKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             const StdVideoDecodeH264ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoDecodeH264DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeH264DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH264DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoDecodeH264ReferenceInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-reference-info">H.264 reference information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeH264ReferenceInfo* StdReferenceInfo;
    }
}
