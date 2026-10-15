namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeVP9PictureInfoKHR.html">VkVideoDecodeVP9PictureInfoKHR</see> - Structure specifies VP9 picture information when decoding a frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeVP9PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_vp9
    ///         typedef struct VkVideoDecodeVP9PictureInfoKHR {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             const StdVideoDecodeVP9PictureInfo*    pStdPictureInfo;
    ///             int32_t                                referenceNameSlotIndices[VK_MAX_VIDEO_VP9_REFERENCES_PER_FRAME_KHR];
    ///             uint32_t                               uncompressedHeaderOffset;
    ///             uint32_t                               compressedHeaderOffset;
    ///             uint32_t                               tilesOffset;
    ///         } VkVideoDecodeVP9PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoDecodeVP9PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeVP9PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoDecodeVP9PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-vp9-picture-info">VP9 picture information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeVP9PictureInfo* StdPictureInfo;

        /// <summary>
        ///     <c>ReferenceNameSlotIndices</c> is an array of three (<c>VK_MAX_VIDEO_VP9_REFERENCES_PER_FRAME_KHR</c>, which is equal to the Video Std definition <c>STD_VIDEO_VP9_REFS_PER_FRAME</c>) signed integer values specifying the index of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#dpb-slot">DPB slot^</see> or a negative integer value for each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-vp9-reference-names">VP9 reference name^</see> used for inter coding. In particular, the DPB slot index for the VP9 reference name <c>frame</c> is specified in <c>referenceNameSlotIndices</c>[<c>frame</c> - <c>STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME</c>].
        /// </summary>
        [FieldOffset(24)]
        public int3 ReferenceNameSlotIndices;

        /// <summary>
        ///     <c>UncompressedHeaderOffset</c> is the byte offset of the uncompressed frame header, as defined in section 6.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#google-vp9">VP9 Specification^</see>.
        /// </summary>
        [FieldOffset(36)]
        public int UncompressedHeaderOffset;

        /// <summary>
        ///     <c>CompressedHeaderOffset</c> is the byte offset of the compressed frame header, as defined in section 6.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#google-vp9">VP9 Specification^</see>.
        /// </summary>
        [FieldOffset(40)]
        public int CompressedHeaderOffset;

        /// <summary>
        ///     <c>TilesOffset</c> is the byte offset of the frame tile data, as defined in section 6.4 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#google-vp9">VP9 Specification^</see>.
        /// </summary>
        [FieldOffset(44)]
        public int TilesOffset;
    }
}
