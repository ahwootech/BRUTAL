namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlLayerInfoKHR.html">VkVideoEncodeAV1RateControlLayerInfoKHR</see> - Structure describing AV1 per-layer rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1RateControlLayerInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1RateControlLayerInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkBool32                        useMinQIndex;
    ///             VkVideoEncodeAV1QIndexKHR       minQIndex;
    ///             VkBool32                        useMaxQIndex;
    ///             VkVideoEncodeAV1QIndexKHR       maxQIndex;
    ///             VkBool32                        useMaxFrameSize;
    ///             VkVideoEncodeAV1FrameSizeKHR    maxFrameSize;
    ///         } VkVideoEncodeAV1RateControlLayerInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkVideoEncodeAV1RateControlLayerInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1RateControlLayerInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseMinQIndex</c> indicates whether the quantizer index values determined by rate control will be clamped to the lower bounds on the quantizer index values specified in <c>minQIndex</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseMinQIndex;

        /// <summary>
        ///     <c>MinQIndex</c> specifies the lower bounds on the quantizer index values, for each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">rate control group^</see>, that the implementation&apos;s rate control algorithm will use when <c>useMinQIndex</c> is set to <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeAV1QIndexKHR MinQIndex;

        /// <summary>
        ///     <c>UseMaxQIndex</c> indicates whether the quantizer index values determined by rate control will be clamped to the upper bounds on the quantizer index values specified in <c>maxQIndex</c>.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 UseMaxQIndex;

        /// <summary>
        ///     <c>MaxQIndex</c> specifies the upper bounds on the quantizer index values, for each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">rate control group^</see>, that the implementation&apos;s rate control algorithm will use when <c>useMaxQIndex</c> is set to <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeAV1QIndexKHR MaxQIndex;

        /// <summary>
        ///     <c>UseMaxFrameSize</c> indicates whether the implementation&apos;s rate control algorithm <i>should</i> use the values specified in <c>maxFrameSize</c> as the upper bounds on the encoded frame size for each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">rate control group^</see>.
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 UseMaxFrameSize;

        /// <summary>
        ///     <c>MaxFrameSize</c> specifies the upper bounds on the encoded frame size, for each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">rate control group^</see>, when <c>useMaxFrameSize</c> is set to <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(52)]
        public VkVideoEncodeAV1FrameSizeKHR MaxFrameSize;
    }
}
