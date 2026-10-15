namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRect2D.html">VkRect2D</see> - Structure specifying a two-dimensional subregion
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Rectangles are used to describe a specified rectangular region of pixels
    ///         within an image or framebuffer.
    ///         Rectangles include both an offset and an extent of the same dimensionality,
    ///         as described above.
    ///         Two-dimensional rectangles are defined by the structure
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkRect2D {
    ///             VkOffset2D    offset;
    ///             VkExtent2D    extent;
    ///         } VkRect2D;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkRect2D()
    {
        /// <summary>
        ///     <c>Offset</c> is a <c>VkOffset2D</c> specifying the rectangle offset.
        /// </summary>
        [FieldOffset(0)]
        public VkOffset2D Offset;

        /// <summary>
        ///     <c>Extent</c> is a <c>VkExtent2D</c> specifying the rectangle extent.
        /// </summary>
        [FieldOffset(8)]
        public VkExtent2D Extent;
    }
}
