namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1DpbSlotInfoKHR.html">VkVideoDecodeAV1DpbSlotInfoKHR</see> - Structure specifies AV1 DPB information when decoding a frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1
    ///         typedef struct VkVideoDecodeAV1DpbSlotInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             const StdVideoDecodeAV1ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoDecodeAV1DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeAV1DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoDecodeAV1ReferenceInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-av1-reference-info">AV1 reference information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoDecodeAV1ReferenceInfo* StdReferenceInfo;
    }
}
