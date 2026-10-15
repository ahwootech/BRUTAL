namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264DpbSlotInfoKHR.html">VkVideoEncodeH264DpbSlotInfoKHR</see> - Structure specifies H.264 encode DPB picture information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264DpbSlotInfoKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             const StdVideoEncodeH264ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoEncodeH264DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH264DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoEncodeH264ReferenceInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-reference-info">H.264 reference information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoEncodeH264ReferenceInfo* StdReferenceInfo;
    }
}
