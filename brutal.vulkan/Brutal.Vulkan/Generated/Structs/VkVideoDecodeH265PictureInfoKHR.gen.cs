namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265PictureInfoKHR.html">VkVideoDecodeH265PictureInfoKHR</see> - Structure specifies H.265 picture information when decoding a frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH265PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265PictureInfoKHR {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             const StdVideoDecodeH265PictureInfo*    pStdPictureInfo;
    ///             uint32_t                                sliceSegmentCount;
    ///             const uint32_t*                         pSliceSegmentOffsets;
    ///         } VkVideoDecodeH265PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoDecodeH265PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoDecodeH265PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-picture-info">H.265 picture information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeH265PictureInfo* StdPictureInfo;

        /// <summary>
        ///     <c>SliceSegmentCount</c> is the number of elements in <c>pSliceSegmentOffsets</c>.
        /// </summary>
        [FieldOffset(24)]
        public int SliceSegmentCount;

        /// <summary>
        ///     <c>SliceSegmentOffsets</c> is a pointer to an array of <c>sliceSegmentCount</c> offsets specifying the start offset of the slice segments of the picture within the video bitstream buffer range specified in <c>VkVideoDecodeInfoKHR</c>.
        /// </summary>
        [FieldOffset(32)]
        public int* SliceSegmentOffsets;
    }
}
