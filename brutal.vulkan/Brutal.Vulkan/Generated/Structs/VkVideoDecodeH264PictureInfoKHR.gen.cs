namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureInfoKHR.html">VkVideoDecodeH264PictureInfoKHR</see> - Structure specifies H.264 decode picture parameters when decoding a picture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH264PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264
    ///         typedef struct VkVideoDecodeH264PictureInfoKHR {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             const StdVideoDecodeH264PictureInfo*    pStdPictureInfo;
    ///             uint32_t                                sliceCount;
    ///             const uint32_t*                         pSliceOffsets;
    ///         } VkVideoDecodeH264PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoDecodeH264PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH264PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoDecodeH264PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-picture-info">H.264 picture information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeH264PictureInfo* StdPictureInfo;

        /// <summary>
        ///     <c>SliceCount</c> is the number of elements in <c>pSliceOffsets</c>.
        /// </summary>
        [FieldOffset(24)]
        public int SliceCount;

        /// <summary>
        ///     <c>SliceOffsets</c> is a pointer to an array of <c>sliceCount</c> offsets specifying the start offset of the slices of the picture within the video bitstream buffer range specified in <c>VkVideoDecodeInfoKHR</c>.
        /// </summary>
        [FieldOffset(32)]
        public int* SliceOffsets;
    }
}
