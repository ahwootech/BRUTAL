namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersAddInfoKHR.html">VkVideoEncodeH264SessionParametersAddInfoKHR</see> - Structure specifies H.264 encoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264SessionParametersAddInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264SessionParametersAddInfoKHR {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             uint32_t                                   stdSPSCount;
    ///             const StdVideoH264SequenceParameterSet*    pStdSPSs;
    ///             uint32_t                                   stdPPSCount;
    ///             const StdVideoH264PictureParameterSet*     pStdPPSs;
    ///         } VkVideoEncodeH264SessionParametersAddInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoEncodeH264SessionParametersAddInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264SessionParametersAddInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdSPSCount</c> is the number of elements in the <c>pStdSPSs</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int StdSPSCount;

        /// <summary>
        ///     <c>StdSPSs</c> is a pointer to an array of <c>StdVideoH264SequenceParameterSet</c> structures describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">H.264 SPS^</see> entries to add.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoH264SequenceParameterSet* StdSPSs;

        /// <summary>
        ///     <c>StdPPSCount</c> is the number of elements in the <c>pStdPPSs</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int StdPPSCount;

        /// <summary>
        ///     <c>StdPPSs</c> is a pointer to an array of <c>StdVideoH264PictureParameterSet</c> structures describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">H.264 PPS^</see> entries to add.
        /// </summary>
        [FieldOffset(40)]
        public StdVideoH264PictureParameterSet* StdPPSs;
    }
}
