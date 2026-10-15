namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1PictureInfoKHR.html">VkVideoDecodeAV1PictureInfoKHR</see> - Structure specifies AV1 picture information when decoding a frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1
    ///         typedef struct VkVideoDecodeAV1PictureInfoKHR {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             const StdVideoDecodeAV1PictureInfo*    pStdPictureInfo;
    ///             int32_t                                referenceNameSlotIndices[VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR];
    ///             uint32_t                               frameHeaderOffset;
    ///             uint32_t                               tileCount;
    ///             const uint32_t*                        pTileOffsets;
    ///             const uint32_t*                        pTileSizes;
    ///         } VkVideoDecodeAV1PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkVideoDecodeAV1PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoDecodeAV1PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-av1-picture-info">AV1 picture information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeAV1PictureInfo* StdPictureInfo;

        ///
        [FieldOffset(24)]
        public fixed int ReferenceNameSlotIndices[7];

        /// <summary>
        ///     <c>FrameHeaderOffset</c> is the byte offset of the AV1 frame header OBU, as defined in section 5.9 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>, within the video bitstream buffer range specified in <c>VkVideoDecodeInfoKHR</c>.
        /// </summary>
        [FieldOffset(52)]
        public int FrameHeaderOffset;

        /// <summary>
        ///     <c>TileCount</c> is the number of elements in <c>pTileOffsets</c> and <c>pTileSizes</c>.
        /// </summary>
        [FieldOffset(56)]
        public int TileCount;

        /// <summary>
        ///     <c>TileOffsets</c> is a pointer to an array of <c>tileCount</c> integers specifying the byte offset of the tiles of the picture within the video bitstream buffer range specified in <c>VkVideoDecodeInfoKHR</c>.
        /// </summary>
        [FieldOffset(64)]
        public int* TileOffsets;

        /// <summary>
        ///     <c>TileSizes</c> is a pointer to an array of <c>tileCount</c> integers specifying the byte size of the tiles of the picture within the video bitstream buffer range specified in <c>VkVideoDecodeInfoKHR</c>.
        /// </summary>
        [FieldOffset(72)]
        public int* TileSizes;
    }
}
