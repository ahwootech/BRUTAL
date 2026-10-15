namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265FrameSizeKHR.html">VkVideoEncodeH265FrameSizeKHR</see> - Structure describing frame size values per H.265 picture type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265FrameSizeKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265FrameSizeKHR {
    ///             uint32_t    frameISize;
    ///             uint32_t    framePSize;
    ///             uint32_t    frameBSize;
    ///         } VkVideoEncodeH265FrameSizeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeH265FrameSizeKHR()
    {
        /// <summary>
        ///     <c>FrameISize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-i-pic">I frames^</see>.
        /// </summary>
        [FieldOffset(0)]
        public int FrameISize;

        /// <summary>
        ///     <c>FramePSize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-p-pic">P frames^</see>.
        /// </summary>
        [FieldOffset(4)]
        public int FramePSize;

        /// <summary>
        ///     <c>FrameBSize</c> is the size in bytes to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B frames^</see>.
        /// </summary>
        [FieldOffset(8)]
        public int FrameBSize;
    }
}
