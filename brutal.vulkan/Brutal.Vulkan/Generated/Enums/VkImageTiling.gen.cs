namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageTiling.html">VkImageTiling</see> - Specifies the tiling arrangement of data in an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkImageCreateInfo::tiling</c>, specifying the
    ///         tiling arrangement of texel blocks in an image, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageTiling {
    ///             VK_IMAGE_TILING_OPTIMAL = 0,
    ///             VK_IMAGE_TILING_LINEAR = 1,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000,
    ///         } VkImageTiling;
    ///     </code>
    /// </remarks>
    public enum VkImageTiling : int
    {
        /// <summary>
        ///     <c>Optimal</c> specifies optimal tiling (texels are laid out in an implementation-dependent arrangement, for more efficient memory access).
        /// </summary>
        Optimal = 0,

        /// <summary>
        ///     <c>Linear</c> specifies linear tiling (texels are laid out in memory in row-major order, possibly with some padding on each row).
        /// </summary>
        Linear = 1,

        /// <summary>
        ///     <c>DrmFormatModifierEXT</c>
        /// </summary>
        DrmFormatModifierEXT = 1000158000,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
