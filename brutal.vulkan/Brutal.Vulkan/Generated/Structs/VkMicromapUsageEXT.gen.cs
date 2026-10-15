namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapUsageEXT.html">VkMicromapUsageEXT</see> - Structure specifying the usage information used to build a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapUsageEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapUsageEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkMicromapUsageEXT {
    ///             uint32_t    count;
    ///             uint32_t    subdivisionLevel;
    ///             uint32_t    format;
    ///         } VkMicromapUsageEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkMicromapUsageEXT()
    {
        /// <summary>
        ///     <c>Count</c> is the number of triangles in the usage format defined by the <c>subdivisionLevel</c> and <c>format</c> below in the micromap
        /// </summary>
        [FieldOffset(0)]
        public int Count;

        /// <summary>
        ///     <c>SubdivisionLevel</c> is the subdivision level of this usage format
        /// </summary>
        [FieldOffset(4)]
        public int SubdivisionLevel;

        /// <summary>
        ///     <c>Format</c> is the format of this usage format
        /// </summary>
        [FieldOffset(8)]
        public int Format;
    }
}
