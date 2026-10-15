namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkXYColorEXT.html">VkXYColorEXT</see> - Specify X,Y chromaticity coordinates
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkXYColorEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_hdr_metadata
    ///         typedef struct VkXYColorEXT {
    ///             float    x;
    ///             float    y;
    ///         } VkXYColorEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkXYColorEXT()
    {
        /// <summary>
        ///     <c>X</c> is the <c>x</c> chromaticity coordinate.
        /// </summary>
        [FieldOffset(0)]
        public float X;

        /// <summary>
        ///     <c>Y</c> is the <c>y</c> chromaticity coordinate.
        /// </summary>
        [FieldOffset(4)]
        public float Y;
    }
}
