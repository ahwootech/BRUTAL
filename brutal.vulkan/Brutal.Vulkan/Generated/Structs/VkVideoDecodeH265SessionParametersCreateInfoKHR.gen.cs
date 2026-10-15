namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersCreateInfoKHR.html">VkVideoDecodeH265SessionParametersCreateInfoKHR</see> - Structure specifies H.265 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-session-parameters">video session parameters^</see> object is
    ///         created with the codec operation
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR</c>, the
    ///         <c>VkVideoSessionParametersCreateInfoKHR::pNext</c> chain <i>must</i> include
    ///         a <c>VkVideoDecodeH265SessionParametersCreateInfoKHR</c> structure specifying
    ///         the capacity and initial contents of the object.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeH265SessionParametersCreateInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265SessionParametersCreateInfoKHR {
    ///             VkStructureType                                        sType;
    ///             const void*                                            pNext;
    ///             uint32_t                                               maxStdVPSCount;
    ///             uint32_t                                               maxStdSPSCount;
    ///             uint32_t                                               maxStdPPSCount;
    ///             const VkVideoDecodeH265SessionParametersAddInfoKHR*    pParametersAddInfo;
    ///         } VkVideoDecodeH265SessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoDecodeH265SessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265SessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxStdVPSCount</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-vps">H.265 VPS^</see> entries the created <c>VkVideoSessionParametersKHR</c> <i>can</i> contain.
        /// </summary>
        [FieldOffset(16)]
        public int MaxStdVPSCount;

        /// <summary>
        ///     <c>MaxStdSPSCount</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-sps">H.265 SPS^</see> entries the created <c>VkVideoSessionParametersKHR</c> <i>can</i> contain.
        /// </summary>
        [FieldOffset(20)]
        public int MaxStdSPSCount;

        /// <summary>
        ///     <c>MaxStdPPSCount</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-pps">H.265 PPS^</see> entries the created <c>VkVideoSessionParametersKHR</c> <i>can</i> contain.
        /// </summary>
        [FieldOffset(24)]
        public int MaxStdPPSCount;

        /// <summary>
        ///     <c>ParametersAddInfo</c> is `NULL` or a pointer to a <c>VkVideoDecodeH265SessionParametersAddInfoKHR</c> structure specifying H.265 parameters to add upon object creation.
        /// </summary>
        [FieldOffset(32)]
        public VkVideoDecodeH265SessionParametersAddInfoKHR* ParametersAddInfo;
    }
}
