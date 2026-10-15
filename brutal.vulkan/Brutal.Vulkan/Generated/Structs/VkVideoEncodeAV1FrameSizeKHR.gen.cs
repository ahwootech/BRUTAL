namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1FrameSizeKHR.html">VkVideoEncodeAV1FrameSizeKHR</see> - Structure describing frame size values per AV1 prediction mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1FrameSizeKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1FrameSizeKHR {
    ///             uint32_t    intraFrameSize;
    ///             uint32_t    predictiveFrameSize;
    ///             uint32_t    bipredictiveFrameSize;
    ///         } VkVideoEncodeAV1FrameSizeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeAV1FrameSizeKHR()
    {
        /// <summary>
        ///     <c>IntraFrameSize</c> is the size in bytes to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public int IntraFrameSize;

        /// <summary>
        ///     <c>PredictiveFrameSize</c> is the size in bytes to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR</c>.
        /// </summary>
        [FieldOffset(4)]
        public int PredictiveFrameSize;

        /// <summary>
        ///     <c>BipredictiveFrameSize</c> is the size in bytes to be used for frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR</c>.
        /// </summary>
        [FieldOffset(8)]
        public int BipredictiveFrameSize;
    }
}
