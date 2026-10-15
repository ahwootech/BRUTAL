namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkViewportSwizzleNV.html">VkViewportSwizzleNV</see> - Structure specifying a viewport swizzle
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkViewportSwizzleNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_viewport_swizzle
    ///         typedef struct VkViewportSwizzleNV {
    ///             VkViewportCoordinateSwizzleNV    x;
    ///             VkViewportCoordinateSwizzleNV    y;
    ///             VkViewportCoordinateSwizzleNV    z;
    ///             VkViewportCoordinateSwizzleNV    w;
    ///         } VkViewportSwizzleNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkViewportSwizzleNV()
    {
        /// <summary>
        ///     <c>X</c> is a <c>VkViewportCoordinateSwizzleNV</c> value specifying the swizzle operation to apply to the x component of the primitive
        /// </summary>
        [FieldOffset(0)]
        public VkViewportCoordinateSwizzleNV X;

        /// <summary>
        ///     <c>Y</c> is a <c>VkViewportCoordinateSwizzleNV</c> value specifying the swizzle operation to apply to the y component of the primitive
        /// </summary>
        [FieldOffset(4)]
        public VkViewportCoordinateSwizzleNV Y;

        /// <summary>
        ///     <c>Z</c> is a <c>VkViewportCoordinateSwizzleNV</c> value specifying the swizzle operation to apply to the z component of the primitive
        /// </summary>
        [FieldOffset(8)]
        public VkViewportCoordinateSwizzleNV Z;

        /// <summary>
        ///     <c>W</c> is a <c>VkViewportCoordinateSwizzleNV</c> value specifying the swizzle operation to apply to the w component of the primitive
        /// </summary>
        [FieldOffset(12)]
        public VkViewportCoordinateSwizzleNV W;
    }
}
