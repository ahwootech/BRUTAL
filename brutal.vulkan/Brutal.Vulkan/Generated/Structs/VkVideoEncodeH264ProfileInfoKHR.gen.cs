namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264ProfileInfoKHR.html">VkVideoEncodeH264ProfileInfoKHR</see> - Structure specifying H.264 encode-specific video profile parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting H.264 video encode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR</c> and adding a
    ///         <c>VkVideoEncodeH264ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH264ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264ProfileInfoKHR {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             StdVideoH264ProfileIdc    stdProfileIdc;
    ///         } VkVideoEncodeH264ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH264ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264ProfileInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdProfileIdc</c> is a <c>StdVideoH264ProfileIdc</c> value specifying the H.264 codec profile IDC, where enum constant `STD_VIDEO_H264_PROFILE_IDC_BASELINE` identifies the Constrained Baseline profile as defined in A.2.1.1 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>, and all other values correspond to profiles defined in section A.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH264ProfileIdc StdProfileIdc;
    }
}
