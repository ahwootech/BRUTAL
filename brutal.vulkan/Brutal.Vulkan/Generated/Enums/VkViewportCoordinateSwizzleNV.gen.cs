namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkViewportCoordinateSwizzleNV.html">VkViewportCoordinateSwizzleNV</see> - Specify how a viewport coordinate is swizzled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>VkViewportSwizzleNV::x</c>, <c>y</c>, <c>z</c>,
    ///         and <c>w</c> members, specifying swizzling of the corresponding components of
    ///         primitives, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_viewport_swizzle
    ///         typedef enum VkViewportCoordinateSwizzleNV {
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,
    ///             VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7,
    ///         } VkViewportCoordinateSwizzleNV;
    ///     </code>
    /// </remarks>
    public enum VkViewportCoordinateSwizzleNV : int
    {
        /// <summary>
        ///     <c>PositiveXNV</c>
        /// </summary>
        PositiveXNV = 0,

        /// <summary>
        ///     <c>NegativeXNV</c>
        /// </summary>
        NegativeXNV = 1,

        /// <summary>
        ///     <c>PositiveYNV</c>
        /// </summary>
        PositiveYNV = 2,

        /// <summary>
        ///     <c>NegativeYNV</c>
        /// </summary>
        NegativeYNV = 3,

        /// <summary>
        ///     <c>PositiveZNV</c>
        /// </summary>
        PositiveZNV = 4,

        /// <summary>
        ///     <c>NegativeZNV</c>
        /// </summary>
        NegativeZNV = 5,

        /// <summary>
        ///     <c>PositiveWNV</c>
        /// </summary>
        PositiveWNV = 6,

        /// <summary>
        ///     <c>NegativeWNV</c>
        /// </summary>
        NegativeWNV = 7,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
