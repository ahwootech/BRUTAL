namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265RateControlLayerInfoKHR.html">VkVideoEncodeH265RateControlLayerInfoKHR</see> - Structure describing H.265 per-layer rate control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265RateControlLayerInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265RateControlLayerInfoKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkBool32                         useMinQp;
    ///             VkVideoEncodeH265QpKHR           minQp;
    ///             VkBool32                         useMaxQp;
    ///             VkVideoEncodeH265QpKHR           maxQp;
    ///             VkBool32                         useMaxFrameSize;
    ///             VkVideoEncodeH265FrameSizeKHR    maxFrameSize;
    ///         } VkVideoEncodeH265RateControlLayerInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265RateControlLayerInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseMinQp</c> indicates whether the QP values determined by rate control will be clamped to the lower bounds on the QP values specified in <c>minQp</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseMinQp;

        /// <summary>
        ///     <c>MinQp</c> specifies the lower bounds on the QP values, for each picture type, that the implementation&apos;s rate control algorithm will use when <c>useMinQp</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoEncodeH265QpKHR MinQp;

        /// <summary>
        ///     <c>UseMaxQp</c> indicates whether the QP values determined by rate control will be clamped to the upper bounds on the QP values specified in <c>maxQp</c>.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 UseMaxQp;

        /// <summary>
        ///     <c>MaxQp</c> specifies the upper bounds on the QP values, for each picture type, that the implementation&apos;s rate control algorithm will use when <c>useMaxQp</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeH265QpKHR MaxQp;

        /// <summary>
        ///     <c>UseMaxFrameSize</c> indicates whether the implementation&apos;s rate control algorithm <i>should</i> use the values specified in <c>maxFrameSize</c> as the upper bounds on the encoded frame size for each picture type.
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 UseMaxFrameSize;

        /// <summary>
        ///     <c>MaxFrameSize</c> specifies the upper bounds on the encoded frame size, for each picture type, when <c>useMaxFrameSize</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(52)]
        public VkVideoEncodeH265FrameSizeKHR MaxFrameSize;
    }
}
