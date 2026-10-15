namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExtent3D.html">VkExtent3D</see> - Structure specifying a three-dimensional extent
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A three-dimensional extent is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkExtent3D {
    ///             uint32_t    width;
    ///             uint32_t    height;
    ///             uint32_t    depth;
    ///         } VkExtent3D;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkExtent3D()
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

        /// <summary>
        ///     <c>Depth</c> is the depth of the extent.
        /// </summary>
        [FieldOffset(8)]
        public int Depth;
    }
}
