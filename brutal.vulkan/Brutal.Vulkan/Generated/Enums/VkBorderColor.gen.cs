namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBorderColor.html">VkBorderColor</see> - Specify border color used for texture lookups
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkSamplerCreateInfo::borderColor</c>, specifying
    ///         the border color used for texture lookups, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkBorderColor {
    ///             VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0,
    ///             VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1,
    ///             VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2,
    ///             VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3,
    ///             VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4,
    ///             VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5,
    ///             // Provided by VK_EXT_custom_border_color
    ///             VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = 1000287003,
    ///             // Provided by VK_EXT_custom_border_color
    ///             VK_BORDER_COLOR_INT_CUSTOM_EXT = 1000287004,
    ///         } VkBorderColor;
    ///     </code>
    /// </remarks>
    public enum VkBorderColor : int
    {
        /// <summary>
        ///     <c>FloatTransparentBlack</c> specifies a transparent, floating-point format, black color.
        /// </summary>
        FloatTransparentBlack = 0,

        /// <summary>
        ///     <c>IntTransparentBlack</c> specifies a transparent, integer format, black color.
        /// </summary>
        IntTransparentBlack = 1,

        /// <summary>
        ///     <c>FloatOpaqueBlack</c> specifies an opaque, floating-point format, black color.
        /// </summary>
        FloatOpaqueBlack = 2,

        /// <summary>
        ///     <c>IntOpaqueBlack</c> specifies an opaque, integer format, black color.
        /// </summary>
        IntOpaqueBlack = 3,

        /// <summary>
        ///     <c>FloatOpaqueWhite</c> specifies an opaque, floating-point format, white color.
        /// </summary>
        FloatOpaqueWhite = 4,

        /// <summary>
        ///     <c>IntOpaqueWhite</c> specifies an opaque, integer format, white color.  These colors are described in detail in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-border-replacement">Border Replacement^</see>.
        /// </summary>
        IntOpaqueWhite = 5,

        /// <summary>
        ///     <c>FloatCustomEXT</c>
        /// </summary>
        FloatCustomEXT = 1000287003,

        /// <summary>
        ///     <c>IntCustomEXT</c>
        /// </summary>
        IntCustomEXT = 1000287004,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
