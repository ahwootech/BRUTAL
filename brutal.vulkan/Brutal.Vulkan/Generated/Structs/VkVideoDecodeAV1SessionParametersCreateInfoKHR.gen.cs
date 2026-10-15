namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1SessionParametersCreateInfoKHR.html">VkVideoDecodeAV1SessionParametersCreateInfoKHR</see> - Structure specifies AV1 decoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-session-parameters">video session parameters^</see> object is
    ///         created with the codec operation
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR</c>, the
    ///         <c>VkVideoSessionParametersCreateInfoKHR::pNext</c> chain <i>must</i> include
    ///         a <c>VkVideoDecodeAV1SessionParametersCreateInfoKHR</c> structure specifying
    ///         the contents of the object.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1SessionParametersCreateInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1
    ///         typedef struct VkVideoDecodeAV1SessionParametersCreateInfoKHR {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             const StdVideoAV1SequenceHeader*    pStdSequenceHeader;
    ///         } VkVideoDecodeAV1SessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeAV1SessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1SessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdSequenceHeader</c> is a pointer to a <c>StdVideoAV1SequenceHeader</c> structure describing the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-av1-sequence-header">AV1 sequence header^</see> entry to store in the created object.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1SequenceHeader* StdSequenceHeader;
    }
}
