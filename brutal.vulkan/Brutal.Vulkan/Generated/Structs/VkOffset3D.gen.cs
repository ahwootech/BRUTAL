namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOffset3D.html">VkOffset3D</see> - Structure specifying a three-dimensional offset
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A three-dimensional offset is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkOffset3D {
    ///             int32_t    x;
    ///             int32_t    y;
    ///             int32_t    z;
    ///         } VkOffset3D;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkOffset3D()
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

        /// <summary>
        ///     <c>Z</c> is the z offset.
        /// </summary>
        [FieldOffset(8)]
        public int Z;
    }
}
