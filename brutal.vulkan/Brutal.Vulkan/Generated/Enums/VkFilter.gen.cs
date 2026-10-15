namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFilter.html">VkFilter</see> - Specify filters used for texture lookups
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>VkSamplerCreateInfo::magFilter</c> and
    ///         <c>minFilter</c> parameters, specifying filters used for texture lookups,
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFilter {
    ///             VK_FILTER_NEAREST = 0,
    ///             VK_FILTER_LINEAR = 1,
    ///             // Provided by VK_EXT_filter_cubic
    ///             VK_FILTER_CUBIC_EXT = 1000015000,
    ///             // Provided by VK_IMG_filter_cubic
    ///             VK_FILTER_CUBIC_IMG = VK_FILTER_CUBIC_EXT,
    ///         } VkFilter;
    ///     </code>
    /// </remarks>
    public enum VkFilter : int
    {
        /// <summary>
        ///     <c>Nearest</c> specifies nearest filtering.
        /// </summary>
        Nearest = 0,

        /// <summary>
        ///     <c>Linear</c> specifies linear filtering.  These filters are described in detail in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-texel-filtering">Texel Filtering^</see>.
        /// </summary>
        Linear = 1,

        /// <summary>
        ///     <c>CubicEXT</c>
        /// </summary>
        CubicEXT = 1000015000,

        /// <summary>
        ///     <c>CubicIMG</c>
        /// </summary>
        CubicIMG = CubicEXT,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
