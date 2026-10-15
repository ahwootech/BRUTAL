namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265DpbSlotInfoKHR.html">VkVideoEncodeH265DpbSlotInfoKHR</see> - Structure specifies H.265 encode DPB picture information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265DpbSlotInfoKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             const StdVideoEncodeH265ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoEncodeH265DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH265DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoEncodeH265ReferenceInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-reference-info">H.265 reference information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoEncodeH265ReferenceInfo* StdReferenceInfo;
    }
}
