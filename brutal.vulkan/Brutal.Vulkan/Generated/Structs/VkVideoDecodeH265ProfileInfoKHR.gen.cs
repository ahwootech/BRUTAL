namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265ProfileInfoKHR.html">VkVideoDecodeH265ProfileInfoKHR</see> - Structure specifying H.265 decode profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting H.265 video decode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR</c> and adding a
    ///         <c>VkVideoDecodeH265ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeH265ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265ProfileInfoKHR {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             StdVideoH265ProfileIdc    stdProfileIdc;
    ///         } VkVideoDecodeH265ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeH265ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265ProfileInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdProfileIdc</c> is a <c>StdVideoH265ProfileIdc</c> value specifying the H.265 codec profile IDC, as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH265ProfileIdc StdProfileIdc;
    }
}
