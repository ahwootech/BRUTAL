namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265InlineSessionParametersInfoKHR.html">VkVideoDecodeH265InlineSessionParametersInfoKHR</see> - Structure specifies inline H.265 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH265InlineSessionParametersInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265 with VK_KHR_video_maintenance2
    ///         typedef struct VkVideoDecodeH265InlineSessionParametersInfoKHR {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             const StdVideoH265VideoParameterSet*       pStdVPS;
    ///             const StdVideoH265SequenceParameterSet*    pStdSPS;
    ///             const StdVideoH265PictureParameterSet*     pStdPPS;
    ///         } VkVideoDecodeH265InlineSessionParametersInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoDecodeH265InlineSessionParametersInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265InlineSessionParametersInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdVPS</c> is `NULL` or a pointer to an instance of the <c>StdVideoH265VideoParameterSet</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-active-vps">active H.265 VPS^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH265VideoParameterSet* StdVPS;

        /// <summary>
        ///     <c>StdSPS</c> is `NULL` or a pointer to an instance of the <c>StdVideoH265SequenceParameterSet</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-active-sps">active H.265 SPS^</see>.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoH265SequenceParameterSet* StdSPS;

        /// <summary>
        ///     <c>StdPPS</c> is `NULL` or a pointer to an instance of the <c>StdVideoH265PictureParameterSet</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-active-pps">active H.265 PPS^</see>.
        /// </summary>
        [FieldOffset(32)]
        public StdVideoH265PictureParameterSet* StdPPS;
    }
}
