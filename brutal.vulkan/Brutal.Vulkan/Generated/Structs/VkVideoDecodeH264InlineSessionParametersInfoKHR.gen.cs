namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264InlineSessionParametersInfoKHR.html">VkVideoDecodeH264InlineSessionParametersInfoKHR</see> - Structure specifies inline H.264 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH264InlineSessionParametersInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264 with VK_KHR_video_maintenance2
    ///         typedef struct VkVideoDecodeH264InlineSessionParametersInfoKHR {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             const StdVideoH264SequenceParameterSet*    pStdSPS;
    ///             const StdVideoH264PictureParameterSet*     pStdPPS;
    ///         } VkVideoDecodeH264InlineSessionParametersInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoDecodeH264InlineSessionParametersInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH264InlineSessionParametersInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdSPS</c> is `NULL` or a pointer to an instance of the <c>StdVideoH264SequenceParameterSet</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-active-sps">active H.264 SPS^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH264SequenceParameterSet* StdSPS;

        /// <summary>
        ///     <c>StdPPS</c> is `NULL` or a pointer to an instance of the <c>StdVideoH264PictureParameterSet</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-active-pps">active H.264 PPS^</see>.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoH264PictureParameterSet* StdPPS;
    }
}
