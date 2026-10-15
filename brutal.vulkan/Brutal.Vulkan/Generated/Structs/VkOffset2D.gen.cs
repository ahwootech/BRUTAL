namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOffset2D.html">VkOffset2D</see> - Structure specifying a two-dimensional offset
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A two-dimensional offset is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkOffset2D {
    ///             int32_t    x;
    ///             int32_t    y;
    ///         } VkOffset2D;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkOffset2D()
    {
        /// <summary>
        ///     <c>X</c> is the x offset.
        /// </summary>
        [FieldOffset(0)]
        public int X;

        /// <summary>
        ///     <c>Y</c> is the y offset.
        /// </summary>
        [FieldOffset(4)]
        public int Y;
    }
}
