namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapTypeEXT.html">VkMicromapTypeEXT</see> - Type of micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapTypeEXT
    ///     </para>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkMicromapCreateInfoEXT::type</c>
    ///         specifying the type of micromap, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef enum VkMicromapTypeEXT {
    ///             VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT = 0,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV = 1000397000,
    ///             #endif
    ///         } VkMicromapTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkMicromapTypeEXT : int
    {
        /// <summary>
        ///     <c>OpacityMicromapEXT</c> is a micromap containing data to control the opacity of a triangle.
        /// </summary>
        OpacityMicromapEXT = 0,

        /// <summary>
        ///     <c>DisplacementMicromapNV</c>
        /// </summary>
        DisplacementMicromapNV = 1000397000,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
