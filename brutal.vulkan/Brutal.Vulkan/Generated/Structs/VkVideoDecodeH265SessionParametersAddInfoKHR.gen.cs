namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersAddInfoKHR.html">VkVideoDecodeH265SessionParametersAddInfoKHR</see> - Structure specifies H.265 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoDecodeH265SessionParametersAddInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265SessionParametersAddInfoKHR {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             uint32_t                                   stdVPSCount;
    ///             const StdVideoH265VideoParameterSet*       pStdVPSs;
    ///             uint32_t                                   stdSPSCount;
    ///             const StdVideoH265SequenceParameterSet*    pStdSPSs;
    ///             uint32_t                                   stdPPSCount;
    ///             const StdVideoH265PictureParameterSet*     pStdPPSs;
    ///         } VkVideoDecodeH265SessionParametersAddInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkVideoDecodeH265SessionParametersAddInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265SessionParametersAddInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdVPSCount</c> is the number of elements in the <c>pStdVPSs</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int StdVPSCount;

        /// <summary>
        ///     <c>StdVPSs</c> is a pointer to an array of <c>StdVideoH265VideoParameterSet</c> structures describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-vps">H.265 VPS^</see> entries to add.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoH265VideoParameterSet* StdVPSs;

        /// <summary>
        ///     <c>StdSPSCount</c> is the number of elements in the <c>pStdSPSs</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int StdSPSCount;

        /// <summary>
        ///     <c>StdSPSs</c> is a pointer to an array of <c>StdVideoH265SequenceParameterSet</c> structures describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-sps">H.265 SPS^</see> entries to add.
        /// </summary>
        [FieldOffset(40)]
        public StdVideoH265SequenceParameterSet* StdSPSs;

        /// <summary>
        ///     <c>StdPPSCount</c> is the number of elements in the <c>pStdPPSs</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int StdPPSCount;

        /// <summary>
        ///     <c>StdPPSs</c> is a pointer to an array of <c>StdVideoH265PictureParameterSet</c> structures describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-pps">H.265 PPS^</see> entries to add.
        /// </summary>
        [FieldOffset(56)]
        public StdVideoH265PictureParameterSet* StdPPSs;
    }
}
