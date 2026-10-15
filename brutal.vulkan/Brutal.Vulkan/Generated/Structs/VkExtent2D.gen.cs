namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExtent2D.html">VkExtent2D</see> - Structure specifying a two-dimensional extent
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A two-dimensional extent is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkExtent2D {
    ///             uint32_t    width;
    ///             uint32_t    height;
    ///         } VkExtent2D;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkExtent2D()
    {
        /// <summary>
        ///     <c>Width</c> is the width of the extent.
        /// </summary>
        [FieldOffset(0)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is the height of the extent.
        /// </summary>
        [FieldOffset(4)]
        public int Height;
    }
}
