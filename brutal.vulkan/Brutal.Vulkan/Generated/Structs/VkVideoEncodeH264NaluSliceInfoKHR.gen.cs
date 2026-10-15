namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264NaluSliceInfoKHR.html">VkVideoEncodeH264NaluSliceInfoKHR</see> - Structure specifies H.264 encode slice NALU parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264NaluSliceInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264NaluSliceInfoKHR {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             int32_t                                 constantQp;
    ///             const StdVideoEncodeH264SliceHeader*    pStdSliceHeader;
    ///         } VkVideoEncodeH264NaluSliceInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeH264NaluSliceInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264NaluSliceInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ConstantQp</c> is the QP to use for the slice if the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-rate-control-modes">rate control mode^</see> configured for the video session is <c>VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ConstantQp;

        /// <summary>
        ///     <c>StdSliceHeader</c> is a pointer to a <c>StdVideoEncodeH264SliceHeader</c> structure specifying <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-slice-header-params">H.264 slice header parameters^</see> for the slice.
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH264SliceHeader* StdSliceHeader;
    }
}
