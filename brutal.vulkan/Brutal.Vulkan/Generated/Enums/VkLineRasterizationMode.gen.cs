namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLineRasterizationMode.html">VkLineRasterizationMode</see> - Line rasterization modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineRasterizationLineStateCreateInfo::lineRasterizationMode</c>,
    ///         specifying the line rasterization mode, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkLineRasterizationMode {
    ///             VK_LINE_RASTERIZATION_MODE_DEFAULT = 0,
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR = 1,
    ///             VK_LINE_RASTERIZATION_MODE_BRESENHAM = 2,
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH = 3,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = VK_LINE_RASTERIZATION_MODE_DEFAULT,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = VK_LINE_RASTERIZATION_MODE_RECTANGULAR,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = VK_LINE_RASTERIZATION_MODE_BRESENHAM,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR = VK_LINE_RASTERIZATION_MODE_DEFAULT,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR = VK_LINE_RASTERIZATION_MODE_RECTANGULAR,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR = VK_LINE_RASTERIZATION_MODE_BRESENHAM,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR = VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH,
    ///         } VkLineRasterizationMode;
    ///     </code>
    /// </remarks>
    public enum VkLineRasterizationMode : int
    {
        /// <summary>
        ///     <c>Default</c> is equivalent to <c>VK_LINE_RASTERIZATION_MODE_RECTANGULAR</c> if <c>VkPhysicalDeviceLimits::strictLines</c> is <c>VK_TRUE</c>, otherwise lines are drawn as non-<c>strictLines</c> parallelograms. Both of these modes are defined in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-lines-basic">Basic Line Segment Rasterization^</see>.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     <c>Rectangular</c> specifies lines drawn as if they were rectangles extruded from the line
        /// </summary>
        Rectangular = 1,

        /// <summary>
        ///     <c>Bresenham</c> specifies lines drawn by determining which pixel diamonds the line intersects and exits, as defined in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-lines-bresenham">Bresenham Line Segment Rasterization^</see>.
        /// </summary>
        Bresenham = 2,

        /// <summary>
        ///     <c>RectangularSmooth</c> specifies lines drawn if they were rectangles extruded from the line, with alpha falloff, as defined in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-lines-smooth">Smooth Lines^</see>.
        /// </summary>
        RectangularSmooth = 3,

        /// <summary>
        ///     <c>DefaultEXT</c>
        /// </summary>
        DefaultEXT = Default,

        /// <summary>
        ///     <c>RectangularEXT</c>
        /// </summary>
        RectangularEXT = Rectangular,

        /// <summary>
        ///     <c>BresenhamEXT</c>
        /// </summary>
        BresenhamEXT = Bresenham,

        /// <summary>
        ///     <c>RectangularSmoothEXT</c>
        /// </summary>
        RectangularSmoothEXT = RectangularSmooth,

        /// <summary>
        ///     <c>DefaultKHR</c>
        /// </summary>
        DefaultKHR = Default,

        /// <summary>
        ///     <c>RectangularKHR</c>
        /// </summary>
        RectangularKHR = Rectangular,

        /// <summary>
        ///     <c>BresenhamKHR</c>
        /// </summary>
        BresenhamKHR = Bresenham,

        /// <summary>
        ///     <c>RectangularSmoothKHR</c>
        /// </summary>
        RectangularSmoothKHR = RectangularSmooth,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
