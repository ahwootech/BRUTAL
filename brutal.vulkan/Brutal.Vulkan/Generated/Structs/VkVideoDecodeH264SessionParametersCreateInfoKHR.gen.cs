namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionParametersCreateInfoKHR.html">VkVideoDecodeH264SessionParametersCreateInfoKHR</see> - Structure specifies H.264 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-session-parameters">video session parameters^</see> object is
    ///         created with the codec operation
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR</c>, the
    ///         <c>VkVideoSessionParametersCreateInfoKHR::pNext</c> chain <i>must</i> include
    ///         a <c>VkVideoDecodeH264SessionParametersCreateInfoKHR</c> structure specifying
    ///         the capacity and initial contents of the object.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeH264SessionParametersCreateInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264
    ///         typedef struct VkVideoDecodeH264SessionParametersCreateInfoKHR {
    ///             VkStructureType                                        sType;
    ///             const void*                                            pNext;
    ///             uint32_t                                               maxStdSPSCount;
    ///             uint32_t                                               maxStdPPSCount;
    ///             const VkVideoDecodeH264SessionParametersAddInfoKHR*    pParametersAddInfo;
    ///         } VkVideoDecodeH264SessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoDecodeH264SessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH264SessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxStdSPSCount</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-sps">H.264 SPS^</see> entries the created <c>VkVideoSessionParametersKHR</c> <i>can</i> contain.
        /// </summary>
        [FieldOffset(16)]
        public int MaxStdSPSCount;

        /// <summary>
        ///     <c>MaxStdPPSCount</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-pps">H.264 PPS^</see> entries the created <c>VkVideoSessionParametersKHR</c> <i>can</i> contain.
        /// </summary>
        [FieldOffset(20)]
        public int MaxStdPPSCount;

        /// <summary>
        ///     <c>ParametersAddInfo</c> is `NULL` or a pointer to a <c>VkVideoDecodeH264SessionParametersAddInfoKHR</c> structure specifying H.264 parameters to add upon object creation.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoDecodeH264SessionParametersAddInfoKHR* ParametersAddInfo;
    }
}
