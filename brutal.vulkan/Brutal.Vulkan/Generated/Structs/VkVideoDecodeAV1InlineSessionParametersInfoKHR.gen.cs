namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1InlineSessionParametersInfoKHR.html">VkVideoDecodeAV1InlineSessionParametersInfoKHR</see> - Structure specifies inline AV1 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1InlineSessionParametersInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1 with VK_KHR_video_maintenance2
    ///         typedef struct VkVideoDecodeAV1InlineSessionParametersInfoKHR {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             const StdVideoAV1SequenceHeader*    pStdSequenceHeader;
    ///         } VkVideoDecodeAV1InlineSessionParametersInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeAV1InlineSessionParametersInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1InlineSessionParametersInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdSequenceHeader</c> is `NULL` or a pointer to an instance of the <c>StdVideoAV1SequenceHeader</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-av1-active-sequence-header">active AV1 sequence header^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1SequenceHeader* StdSequenceHeader;
    }
}
