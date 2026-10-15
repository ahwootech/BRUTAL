namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPolygonMode.html">VkPolygonMode</see> - Control polygon rasterization mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the
    ///         <c>VkPipelineRasterizationStateCreateInfo::polygonMode</c> property of
    ///         the currently active pipeline, specifying the method of rasterization for
    ///         polygons, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPolygonMode {
    ///             VK_POLYGON_MODE_FILL = 0,
    ///             VK_POLYGON_MODE_LINE = 1,
    ///             VK_POLYGON_MODE_POINT = 2,
    ///             // Provided by VK_NV_fill_rectangle
    ///             VK_POLYGON_MODE_FILL_RECTANGLE_NV = 1000153000,
    ///         } VkPolygonMode;
    ///     </code>
    /// </remarks>
    public enum VkPolygonMode : int
    {
        /// <summary>
        ///     <c>Fill</c> specifies that polygons are rendered using the polygon rasterization rules in this section.  These modes affect only the final rasterization of polygons: in particular, a polygon&apos;s vertices are shaded and the polygon is clipped and possibly culled before these modes are applied.  The point size of the final rasterization of polygons when <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-polygonmode">polygon mode^</see> is <c>VK_POLYGON_MODE_POINT</c> is implementation-dependent, and the point size may: either be <c>PointSize</c> or 1.0.
        /// </summary>
        Fill = 0,

        /// <summary>
        ///     <c>Line</c> specifies that polygon edges are drawn as line segments.
        /// </summary>
        Line = 1,

        /// <summary>
        ///     <c>Point</c> specifies that polygon vertices are drawn as points.
        /// </summary>
        Point = 2,

        /// <summary>
        ///     <c>FillRectangleNV</c>
        /// </summary>
        FillRectangleNV = 1000153000,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
