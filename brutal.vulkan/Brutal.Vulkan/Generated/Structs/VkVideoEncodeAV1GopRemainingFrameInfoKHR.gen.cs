namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1GopRemainingFrameInfoKHR.html">VkVideoEncodeAV1GopRemainingFrameInfoKHR</see> - Structure specifying AV1 encode rate control GOP remaining frame counts
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1GopRemainingFrameInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1GopRemainingFrameInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           useGopRemainingFrames;
    ///             uint32_t           gopRemainingIntra;
    ///             uint32_t           gopRemainingPredictive;
    ///             uint32_t           gopRemainingBipredictive;
    ///         } VkVideoEncodeAV1GopRemainingFrameInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeAV1GopRemainingFrameInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1GopRemainingFrameInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseGopRemainingFrames</c> indicates whether the implementation&apos;s rate control algorithm <i>should</i> use the values specified in <c>gopRemainingIntra</c>, <c>gopRemainingPredictive</c>, and <c>gopRemainingBipredictive</c>. If <c>useGopRemainingFrames</c> is <c>VK_FALSE</c>, then the values of <c>gopRemainingIntra</c>, <c>gopRemainingPredictive</c>, and <c>gopRemainingBipredictive</c> are ignored.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseGopRemainingFrames;

        /// <summary>
        ///     <c>GopRemainingIntra</c> specifies the number of frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR</c> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">GOP^</see> prior to executing the next video encode operation.
        /// </summary>
        [FieldOffset(20)]
        public int GopRemainingIntra;

        /// <summary>
        ///     <c>GopRemainingPredictive</c> specifies the number of frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR</c> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">GOP^</see> prior to executing the next video encode operation.
        /// </summary>
        [FieldOffset(24)]
        public int GopRemainingPredictive;

        /// <summary>
        ///     <c>GopRemainingBipredictive</c> specifies the number of frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR</c> the implementation&apos;s rate control algorithm <i>should</i> assume to be remaining in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">GOP^</see> prior to executing the next video encode operation.
        /// </summary>
        [FieldOffset(28)]
        public int GopRemainingBipredictive;
    }
}
