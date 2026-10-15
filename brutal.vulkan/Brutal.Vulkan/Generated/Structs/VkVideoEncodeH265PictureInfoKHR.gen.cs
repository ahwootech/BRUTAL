namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265PictureInfoKHR.html">VkVideoEncodeH265PictureInfoKHR</see> - Structure specifies H.265 encode frame parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265PictureInfoKHR {
    ///             VkStructureType                                    sType;
    ///             const void*                                        pNext;
    ///             uint32_t                                           naluSliceSegmentEntryCount;
    ///             const VkVideoEncodeH265NaluSliceSegmentInfoKHR*    pNaluSliceSegmentEntries;
    ///             const StdVideoEncodeH265PictureInfo*               pStdPictureInfo;
    ///         } VkVideoEncodeH265PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeH265PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NaluSliceSegmentEntryCount</c> is the number of elements in <c>pNaluSliceSegmentEntries</c>.
        /// </summary>
        [FieldOffset(16)]
        public int NaluSliceSegmentEntryCount;

        /// <summary>
        ///     <c>NaluSliceSegmentEntries</c> is a pointer to an array of <c>naluSliceSegmentEntryCount</c> <c>VkVideoEncodeH265NaluSliceSegmentInfoKHR</c> structures specifying the parameters of the individual H.265 slice segments to encode for the input picture.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR* NaluSliceSegmentEntries;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoEncodeH265PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-picture-info">H.265 picture information^</see>.
        /// </summary>
        [FieldOffset(32)]
        public StdVideoEncodeH265PictureInfo* StdPictureInfo;
    }
}
