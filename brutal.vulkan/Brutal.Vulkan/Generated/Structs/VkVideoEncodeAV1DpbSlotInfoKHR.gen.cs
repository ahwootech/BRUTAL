namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1DpbSlotInfoKHR.html">VkVideoEncodeAV1DpbSlotInfoKHR</see> - Structure specifies AV1 encode DPB picture information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1DpbSlotInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1DpbSlotInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             const StdVideoEncodeAV1ReferenceInfo*    pStdReferenceInfo;
    ///         } VkVideoEncodeAV1DpbSlotInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeAV1DpbSlotInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1DpbSlotInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdReferenceInfo</c> is a pointer to a <c>StdVideoEncodeAV1ReferenceInfo</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-info">AV1 reference information^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoEncodeAV1ReferenceInfo* StdReferenceInfo;
    }
}
