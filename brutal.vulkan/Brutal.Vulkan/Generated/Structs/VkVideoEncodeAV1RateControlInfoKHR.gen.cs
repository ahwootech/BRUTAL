namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlInfoKHR.html">VkVideoEncodeAV1RateControlInfoKHR</see> - Structure describing AV1 stream rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1RateControlInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1RateControlInfoKHR {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkVideoEncodeAV1RateControlFlagsKHR    flags;
    ///             uint32_t                               gopFrameCount;
    ///             uint32_t                               keyFramePeriod;
    ///             uint32_t                               consecutiveBipredictiveFrameCount;
    ///             uint32_t                               temporalLayerCount;
    ///         } VkVideoEncodeAV1RateControlInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeAV1RateControlInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1RateControlInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeAV1RateControlFlagsKHR</c> specifying AV1 rate control flags.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeAV1RateControlFlagsKHR Flags;

        /// <summary>
        ///     <c>GopFrameCount</c> is the number of frames within a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">group of pictures (GOP)^</see> intended to be used by the application. If it is set to 0, the rate control algorithm may: assume an implementation-dependent GOP length. If it is set to <c>UINT32_MAX</c>, the GOP length is treated as infinite.
        /// </summary>
        [FieldOffset(20)]
        public int GopFrameCount;

        /// <summary>
        ///     <c>KeyFramePeriod</c> is the interval, in terms of number of frames, between two frames with the AV1 frame type <c>STD_VIDEO_AV1_FRAME_TYPE_KEY</c> (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-key-frame-period">key frame period^</see>). If it is set to 0, the rate control algorithm may: assume an implementation-dependent key frame period. If it is set to <c>UINT32_MAX</c>, the key frame period is treated as infinite.
        /// </summary>
        [FieldOffset(24)]
        public int KeyFramePeriod;

        /// <summary>
        ///     <c>ConsecutiveBipredictiveFrameCount</c> is the number of consecutive frames encoded with <c>VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR</c> between frames encoded with other <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">rate control groups^</see> within the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">GOP^</see>.
        /// </summary>
        [FieldOffset(28)]
        public int ConsecutiveBipredictiveFrameCount;

        /// <summary>
        ///     <c>TemporalLayerCount</c> specifies the number of AV1 temporal layers that the application intends to use.
        /// </summary>
        [FieldOffset(32)]
        public int TemporalLayerCount;
    }
}
