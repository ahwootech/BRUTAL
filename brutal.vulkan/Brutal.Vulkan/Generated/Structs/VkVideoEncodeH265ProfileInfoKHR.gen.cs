namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265ProfileInfoKHR.html">VkVideoEncodeH265ProfileInfoKHR</see> - Structure specifying H.265 encode-specific video profile parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting H.265 video encode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR</c> and adding a
    ///         <c>VkVideoEncodeH265ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH265ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265ProfileInfoKHR {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             StdVideoH265ProfileIdc    stdProfileIdc;
    ///         } VkVideoEncodeH265ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH265ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265ProfileInfoKHR;

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
