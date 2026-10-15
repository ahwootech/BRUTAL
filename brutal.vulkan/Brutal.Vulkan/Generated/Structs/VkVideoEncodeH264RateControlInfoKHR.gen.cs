namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoKHR.html">VkVideoEncodeH264RateControlInfoKHR</see> - Structure describing H.264 stream rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264RateControlInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264RateControlInfoKHR {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkVideoEncodeH264RateControlFlagsKHR    flags;
    ///             uint32_t                                gopFrameCount;
    ///             uint32_t                                idrPeriod;
    ///             uint32_t                                consecutiveBFrameCount;
    ///             uint32_t                                temporalLayerCount;
    ///         } VkVideoEncodeH264RateControlInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeH264RateControlInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264RateControlInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeH264RateControlFlagsKHR</c> specifying H.264 rate control flags.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH264RateControlFlagsKHR Flags;

        /// <summary>
        ///     <c>GopFrameCount</c> is the number of frames within a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-gop">group of pictures (GOP)^</see> intended to be used by the application. If it is 0, the rate control algorithm may: assume an implementation-dependent GOP length. If it is <c>UINT32_MAX</c>, the GOP length is treated as infinite.
        /// </summary>
        [FieldOffset(20)]
        public int GopFrameCount;

        /// <summary>
        ///     <c>IdrPeriod</c> is the interval, in terms of number of frames, between two <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-idr-pic">IDR frames^</see> (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-idr-period">IDR period^</see>). If it is 0, the rate control algorithm may: assume an implementation-dependent IDR period. If it is <c>UINT32_MAX</c>, the IDR period is treated as infinite.
        /// </summary>
        [FieldOffset(24)]
        public int IdrPeriod;

        /// <summary>
        ///     <c>ConsecutiveBFrameCount</c> is the number of consecutive B frames between I and/or P frames within the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-gop">GOP^</see>.
        /// </summary>
        [FieldOffset(28)]
        public int ConsecutiveBFrameCount;

        /// <summary>
        ///     <c>TemporalLayerCount</c> specifies the number of H.264 temporal layers that the application intends to use.
        /// </summary>
        [FieldOffset(32)]
        public int TemporalLayerCount;
    }
}
