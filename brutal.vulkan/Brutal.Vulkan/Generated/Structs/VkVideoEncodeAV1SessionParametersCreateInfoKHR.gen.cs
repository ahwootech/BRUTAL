namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionParametersCreateInfoKHR.html">VkVideoEncodeAV1SessionParametersCreateInfoKHR</see> - Structure specifies AV1 encoder parameter set information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-session-parameters">video session parameters^</see> object is
    ///         created with the codec operation
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR</c>, the
    ///         <c>VkVideoSessionParametersCreateInfoKHR::pNext</c> chain <i>must</i> include
    ///         a <c>VkVideoEncodeAV1SessionParametersCreateInfoKHR</c> structure specifying
    ///         the contents of the object.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1SessionParametersCreateInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1SessionParametersCreateInfoKHR {
    ///             VkStructureType                               sType;
    ///             const void*                                   pNext;
    ///             const StdVideoAV1SequenceHeader*              pStdSequenceHeader;
    ///             const StdVideoEncodeAV1DecoderModelInfo*      pStdDecoderModelInfo;
    ///             uint32_t                                      stdOperatingPointCount;
    ///             const StdVideoEncodeAV1OperatingPointInfo*    pStdOperatingPoints;
    ///         } VkVideoEncodeAV1SessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoEncodeAV1SessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1SessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdSequenceHeader</c> is a pointer to a <c>StdVideoAV1SequenceHeader</c> structure describing parameters of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-sequence-header">AV1 sequence header^</see> entry to store in the created object.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1SequenceHeader* StdSequenceHeader;

        /// <summary>
        ///     <c>StdDecoderModelInfo</c> is `NULL` or a pointer to a <c>StdVideoEncodeAV1DecoderModelInfo</c> structure specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-decoder-model-info">AV1 decoder model information^</see> to store in the created object.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeAV1DecoderModelInfo* StdDecoderModelInfo;

        /// <summary>
        ///     <c>StdOperatingPointCount</c> is the number of elements in the <c>pStdOperatingPoints</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int StdOperatingPointCount;

        /// <summary>
        ///     <c>StdOperatingPoints</c> is `NULL` or a pointer to an array of <c>stdOperatingPointCount</c> number of <c>StdVideoEncodeAV1OperatingPointInfo</c> structures specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-operating-points">AV1 operating point information^</see> to store in the created object. Each element <c>i</c> specifies the parameter values corresponding to element <c>i</c> of the syntax elements defined in section 6.4 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(40)]
        public StdVideoEncodeAV1OperatingPointInfo* StdOperatingPoints;
    }
}
