namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConservativeRasterizationModeEXT.html">VkConservativeRasterizationModeEXT</see> - Specify the conservative rasterization mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineRasterizationConservativeStateCreateInfoEXT::conservativeRasterizationMode</c>,
    ///         specifying the conservative rasterization mode are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conservative_rasterization
    ///         typedef enum VkConservativeRasterizationModeEXT {
    ///             VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT = 0,
    ///             VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT = 1,
    ///             VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT = 2,
    ///         } VkConservativeRasterizationModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkConservativeRasterizationModeEXT : int
    {
        /// <summary>
        ///     <c>DisabledEXT</c> specifies that conservative rasterization is disabled and rasterization proceeds as normal.
        /// </summary>
        DisabledEXT = 0,

        /// <summary>
        ///     <c>OverestimateEXT</c> specifies that conservative rasterization is enabled in overestimation mode.
        /// </summary>
        OverestimateEXT = 1,

        /// <summary>
        ///     <c>UnderestimateEXT</c> specifies that conservative rasterization is enabled in underestimation mode.
        /// </summary>
        UnderestimateEXT = 2,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
