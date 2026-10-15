namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265DpbSlotInfoKHR.html">VkVideoDecodeH265DpbSlotInfoKHR</see> - Structure specifies H.265 DPB information when decoding a frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH265DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265DpbSlotInfoKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             const StdVideoDecodeH265ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoDecodeH265DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeH265DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoDecodeH265ReferenceInfo</c> structure specifying reference picture information described in section 8.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeH265ReferenceInfo* StdReferenceInfo;
    }
}
