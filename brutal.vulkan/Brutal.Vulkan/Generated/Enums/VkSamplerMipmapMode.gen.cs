namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerMipmapMode.html">VkSamplerMipmapMode</see> - Specify mipmap mode used for texture lookups
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>VkSamplerCreateInfo::mipmapMode</c>,
    ///         specifying the mipmap mode used for texture lookups, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSamplerMipmapMode {
    ///             VK_SAMPLER_MIPMAP_MODE_NEAREST = 0,
    ///             VK_SAMPLER_MIPMAP_MODE_LINEAR = 1,
    ///         } VkSamplerMipmapMode;
    ///     </code>
    /// </remarks>
    public enum VkSamplerMipmapMode : int
    {
        /// <summary>
        ///     <c>Nearest</c> specifies nearest filtering.
        /// </summary>
        Nearest = 0,

        /// <summary>
        ///     <c>Linear</c> specifies linear filtering.  These modes are described in detail in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-texel-filtering">Texel Filtering^</see>.
        /// </summary>
        Linear = 1,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
