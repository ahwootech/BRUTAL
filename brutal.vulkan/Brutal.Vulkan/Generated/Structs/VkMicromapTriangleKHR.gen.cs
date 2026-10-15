namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapTriangleKHR.html">VkMicromapTriangleKHR</see> - Structure specifying the micromap format and data for a triangle
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapTriangleKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapTriangleKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef struct VkMicromapTriangleKHR {
    ///             uint32_t    dataOffset;
    ///             uint16_t    subdivisionLevel;
    ///             uint16_t    format;
    ///         } VkMicromapTriangleKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkMicromapTriangleKHR()
    {
        /// <summary>
        ///     <c>DataOffset</c> is the offset in bytes of the start of the data for this triangle. This is a byte aligned value.
        /// </summary>
        [FieldOffset(0)]
        public int DataOffset;

        /// <summary>
        ///     <c>SubdivisionLevel</c> is the subdivision level of this triangle
        /// </summary>
        [FieldOffset(4)]
        public ushort SubdivisionLevel;

        /// <summary>
        ///     <c>Format</c> is the format of this triangle
        /// </summary>
        [FieldOffset(6)]
        public ushort Format;
    }
}
