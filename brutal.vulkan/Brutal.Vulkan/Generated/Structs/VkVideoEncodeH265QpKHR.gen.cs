namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QpKHR.html">VkVideoEncodeH265QpKHR</see> - Structure describing H.265 QP values per picture type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265QpKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265QpKHR {
    ///             int32_t    qpI;
    ///             int32_t    qpP;
    ///             int32_t    qpB;
    ///         } VkVideoEncodeH265QpKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkVideoEncodeH265QpKHR()
    {
        /// <summary>
        ///     <c>QpI</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-i-pic">I pictures^</see>.
        /// </summary>
        [FieldOffset(0)]
        public int QpI;

        /// <summary>
        ///     <c>QpP</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-p-pic">P pictures^</see>.
        /// </summary>
        [FieldOffset(4)]
        public int QpP;

        /// <summary>
        ///     <c>QpB</c> is the QP to be used for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-b-pic">B pictures^</see>.
        /// </summary>
        [FieldOffset(8)]
        public int QpB;
    }
}
