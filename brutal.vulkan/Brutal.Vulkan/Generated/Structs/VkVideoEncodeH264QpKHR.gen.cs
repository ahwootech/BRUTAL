namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QpKHR.html">VkVideoEncodeH264QpKHR</see> - Structure describing H.264 QP values per picture type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264QpKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264QpKHR {
    ///             int32_t    qpI;
    ///             int32_t    qpP;
    ///             int32_t    qpB;
    ///         } VkVideoEncodeH264QpKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeH264QpKHR()
    {
        /// <summary>
        ///     <c>QpI</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-i-pic">I pictures^</see>.
        /// </summary>
        [FieldOffset(0)]
        public int QpI;

        /// <summary>
        ///     <c>QpP</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-p-pic">P pictures^</see>.
        /// </summary>
        [FieldOffset(4)]
        public int QpP;

        /// <summary>
        ///     <c>QpB</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-b-pic">B pictures^</see>.
        /// </summary>
        [FieldOffset(8)]
        public int QpB;
    }
}
