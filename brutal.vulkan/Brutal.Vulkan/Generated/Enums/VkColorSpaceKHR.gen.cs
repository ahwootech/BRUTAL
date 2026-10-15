namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkColorSpaceKHR.html">VkColorSpaceKHR</see> - Supported color space of the presentation engine
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkSurfaceFormatKHR::colorSpace</c>, specifying
    ///         the color spaces that a presentation engine can accept, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef enum VkColorSpaceKHR {
    ///             VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = 0,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = 1000104001,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = 1000104002,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT = 1000104003,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = 1000104004,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_BT709_LINEAR_EXT = 1000104005,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_BT709_NONLINEAR_EXT = 1000104006,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_BT2020_LINEAR_EXT = 1000104007,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_HDR10_ST2084_EXT = 1000104008,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             // VK_COLOR_SPACE_DOLBYVISION_EXT is legacy, but no reason was given in the API XML
    ///             VK_COLOR_SPACE_DOLBYVISION_EXT = 1000104009,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_HDR10_HLG_EXT = 1000104010,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = 1000104011,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = 1000104012,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_PASS_THROUGH_EXT = 1000104013,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,
    ///             // Provided by VK_AMD_display_native_hdr
    ///             VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = 1000213000,
    ///             // VK_COLORSPACE_SRGB_NONLINEAR_KHR is a legacy alias
    ///             VK_COLORSPACE_SRGB_NONLINEAR_KHR = VK_COLOR_SPACE_SRGB_NONLINEAR_KHR,
    ///             // Provided by VK_EXT_swapchain_colorspace
    ///             // VK_COLOR_SPACE_DCI_P3_LINEAR_EXT is a legacy alias
    ///             VK_COLOR_SPACE_DCI_P3_LINEAR_EXT = VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT,
    ///         } VkColorSpaceKHR;
    ///     </code>
    /// </remarks>
    public enum VkColorSpaceKHR : int
    {
        /// <summary>
        ///     <c>SRGBNonlinearKHR</c> specifies support for the images in sRGB color space, encoded according to the sRGB specification.
        /// </summary>
        SRGBNonlinearKHR = 0,

        /// <summary>
        ///     <c>DisplayP3NonlinearEXT</c>
        /// </summary>
        DisplayP3NonlinearEXT = 1000104001,

        /// <summary>
        ///     <c>ExtendedSRGBLinearEXT</c>
        /// </summary>
        ExtendedSRGBLinearEXT = 1000104002,

        /// <summary>
        ///     <c>DisplayP3LinearEXT</c>
        /// </summary>
        DisplayP3LinearEXT = 1000104003,

        /// <summary>
        ///     <c>DciP3NonlinearEXT</c>
        /// </summary>
        DciP3NonlinearEXT = 1000104004,

        /// <summary>
        ///     <c>Bt709LinearEXT</c>
        /// </summary>
        Bt709LinearEXT = 1000104005,

        /// <summary>
        ///     <c>Bt709NonlinearEXT</c>
        /// </summary>
        Bt709NonlinearEXT = 1000104006,

        /// <summary>
        ///     <c>Bt2020LinearEXT</c>
        /// </summary>
        Bt2020LinearEXT = 1000104007,

        /// <summary>
        ///     <c>Hdr10St2084EXT</c>
        /// </summary>
        Hdr10St2084EXT = 1000104008,

        /// <summary>
        ///     <c>DolbyvisionEXT</c>
        /// </summary>
        DolbyvisionEXT = 1000104009,

        /// <summary>
        ///     <c>Hdr10HlgEXT</c>
        /// </summary>
        Hdr10HlgEXT = 1000104010,

        /// <summary>
        ///     <c>AdobergbLinearEXT</c>
        /// </summary>
        AdobergbLinearEXT = 1000104011,

        /// <summary>
        ///     <c>AdobergbNonlinearEXT</c>
        /// </summary>
        AdobergbNonlinearEXT = 1000104012,

        /// <summary>
        ///     <c>PassThroughEXT</c>
        /// </summary>
        PassThroughEXT = 1000104013,

        /// <summary>
        ///     <c>ExtendedSRGBNonlinearEXT</c>
        /// </summary>
        ExtendedSRGBNonlinearEXT = 1000104014,

        /// <summary>
        ///     <c>DisplayNativeAMD</c>
        /// </summary>
        DisplayNativeAMD = 1000213000,

        /// <summary>
        ///     <c>DciP3LinearEXT</c>
        /// </summary>
        DciP3LinearEXT = DisplayP3LinearEXT,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
