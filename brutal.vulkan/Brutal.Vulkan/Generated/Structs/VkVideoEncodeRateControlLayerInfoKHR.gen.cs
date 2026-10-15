namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlLayerInfoKHR.html">VkVideoEncodeRateControlLayerInfoKHR</see> - Structure to set encode per-layer rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeRateControlLayerInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeRateControlLayerInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           averageBitrate;
    ///             uint64_t           maxBitrate;
    ///             uint32_t           frameRateNumerator;
    ///             uint32_t           frameRateDenominator;
    ///         } VkVideoEncodeRateControlLayerInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeRateControlLayerInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeRateControlLayerInfoKHR;

        /// <summary>
        ///     <c>Next</c> is a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AverageBitrate</c> is the average <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-bitrate">bitrate^</see> to be targeted by the implementation&apos;s rate control algorithm.
        /// </summary>
        [FieldOffset(16)]
        public nint AverageBitrate;

        /// <summary>
        ///     <c>MaxBitrate</c> is the peak <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-bitrate">bitrate^</see> to be targeted by the implementation&apos;s rate control algorithm.
        /// </summary>
        [FieldOffset(24)]
        public nint MaxBitrate;

        /// <summary>
        ///     <c>FrameRateNumerator</c> is the numerator of the frame rate assumed by the implementation&apos;s rate control algorithm.
        /// </summary>
        [FieldOffset(32)]
        public int FrameRateNumerator;

        /// <summary>
        ///     <c>FrameRateDenominator</c> is the denominator of the frame rate assumed by the implementation&apos;s rate control algorithm.
        /// </summary>
        [FieldOffset(36)]
        public int FrameRateDenominator;
    }
}
