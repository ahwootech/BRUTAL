namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265NaluSliceSegmentInfoKHR.html">VkVideoEncodeH265NaluSliceSegmentInfoKHR</see> - Structure specifies H.265 encode slice segment NALU parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265NaluSliceSegmentInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265NaluSliceSegmentInfoKHR {
    ///             VkStructureType                                sType;
    ///             const void*                                    pNext;
    ///             int32_t                                        constantQp;
    ///             const StdVideoEncodeH265SliceSegmentHeader*    pStdSliceSegmentHeader;
    ///         } VkVideoEncodeH265NaluSliceSegmentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeH265NaluSliceSegmentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265NaluSliceSegmentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ConstantQp</c> is the QP to use for the slice segment if the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> configured for the video session is <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ConstantQp;

        /// <summary>
        ///     <c>StdSliceSegmentHeader</c> is a pointer to a <c>StdVideoEncodeH265SliceSegmentHeader</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-slice-segment-header-params">H.265 slice segment header parameters^</see> for the slice segment.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH265SliceSegmentHeader* StdSliceSegmentHeader;
    }
}
