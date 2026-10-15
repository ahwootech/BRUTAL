namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoKHR.html">VkVideoEncodeH264PictureInfoKHR</see> - Structure specifies H.264 encode frame parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264PictureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264PictureInfoKHR {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             uint32_t                                    naluSliceEntryCount;
    ///             const VkVideoEncodeH264NaluSliceInfoKHR*    pNaluSliceEntries;
    ///             const StdVideoEncodeH264PictureInfo*        pStdPictureInfo;
    ///             VkBool32                                    generatePrefixNalu;
    ///         } VkVideoEncodeH264PictureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoEncodeH264PictureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264PictureInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NaluSliceEntryCount</c> is the number of elements in <c>pNaluSliceEntries</c>.
        /// </summary>
        [FieldOffset(16)]
        public int NaluSliceEntryCount;

        /// <summary>
        ///     <c>NaluSliceEntries</c> is a pointer to an array of <c>naluSliceEntryCount</c> <c>VkVideoEncodeH264NaluSliceInfoKHR</c> structures specifying the parameters of the individual H.264 slices to encode for the input picture.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoEncodeH264NaluSliceInfoKHR* NaluSliceEntries;

        /// <summary>
        ///     <c>StdPictureInfo</c> is a pointer to a <c>StdVideoEncodeH264PictureInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-picture-info">H.264 picture information^</see>.
        /// </summary>
        [FieldOffset(32)]
        public StdVideoEncodeH264PictureInfo* StdPictureInfo;

        /// <summary>
        ///     <c>GeneratePrefixNalu</c> controls whether prefix NALUs are generated before slice NALUs into the target bitstream, as defined in sections 7.3.2.12 and 7.4.2.12 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 GeneratePrefixNalu;
    }
}
