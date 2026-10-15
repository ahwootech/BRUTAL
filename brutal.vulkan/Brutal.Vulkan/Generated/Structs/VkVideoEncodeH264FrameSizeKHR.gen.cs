namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264FrameSizeKHR.html">VkVideoEncodeH264FrameSizeKHR</see> - Structure describing frame size values per H.264 picture type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264FrameSizeKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264FrameSizeKHR {
    ///             uint32_t    frameISize;
    ///             uint32_t    framePSize;
    ///             uint32_t    frameBSize;
    ///         } VkVideoEncodeH264FrameSizeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeH264FrameSizeKHR()
    {
        /// <summary>
        ///     <c>FrameISize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-i-pic">I pictures^</see>.
        /// </summary>
        [FieldOffset(0)]
        public int FrameISize;

        /// <summary>
        ///     <c>FramePSize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-p-pic">P pictures^</see>.
        /// </summary>
        [FieldOffset(4)]
        public int FramePSize;

        /// <summary>
        ///     <c>FrameBSize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-b-pic">B pictures^</see>.
        /// </summary>
        [FieldOffset(8)]
        public int FrameBSize;
    }
}
