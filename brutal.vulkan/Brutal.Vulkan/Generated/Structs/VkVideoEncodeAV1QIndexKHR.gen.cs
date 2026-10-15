namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QIndexKHR.html">VkVideoEncodeAV1QIndexKHR</see> - Structure describing AV1 quantizer index values per prediction mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1QIndexKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1QIndexKHR {
    ///             uint32_t    intraQIndex;
    ///             uint32_t    predictiveQIndex;
    ///             uint32_t    bipredictiveQIndex;
    ///         } VkVideoEncodeAV1QIndexKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeAV1QIndexKHR()
    {
        /// <summary>
        ///     <c>IntraQIndex</c> is the quantizer index to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public int IntraQIndex;

        /// <summary>
        ///     <c>PredictiveQIndex</c> is the quantizer index to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR</c>.
        /// </summary>
        [FieldOffset(4)]
        public int PredictiveQIndex;

        /// <summary>
        ///     <c>BipredictiveQIndex</c> is the quantizer index to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR</c>.
        /// </summary>
        [FieldOffset(8)]
        public int BipredictiveQIndex;
    }
}
