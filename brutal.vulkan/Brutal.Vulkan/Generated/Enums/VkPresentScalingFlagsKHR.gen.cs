namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentScalingFlagBitsKHR.html">VkPresentScalingFlagBitsKHR</see> - Bitmask specifying presentation scaling methods
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkSurfacePresentScalingCapabilitiesKHR::supportedPresentScaling</c>,
    ///         specifying scaling modes supported by the surface, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_maintenance1
    ///         typedef enum VkPresentScalingFlagBitsKHR {
    ///             VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR = 0x00000001,
    ///             VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR = 0x00000002,
    ///             VK_PRESENT_SCALING_STRETCH_BIT_KHR = 0x00000004,
    ///             VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR,
    ///             VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR,
    ///             VK_PRESENT_SCALING_STRETCH_BIT_EXT = VK_PRESENT_SCALING_STRETCH_BIT_KHR,
    ///         } VkPresentScalingFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPresentScalingFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OneToOneBitKHR</c> specifies that no scaling occurs, and pixels in the swapchain image are mapped to one and only one pixel in the surface. The mapping between pixels is defined by the chosen presentation gravity.
        /// </summary>
        OneToOneBitKHR = 0x00000001,

        /// <summary>
        ///     <c>AspectRatioStretchBitKHR</c> specifies that the swapchain image will be minified or magnified such that at least one of the resulting width or height is equal to the corresponding surface dimension, and the other resulting dimension is less than or equal to the corresponding surface dimension, with the aspect ratio of the resulting image being identical to that of the original swapchain image.
        /// </summary>
        AspectRatioStretchBitKHR = 0x00000002,

        /// <summary>
        ///     <c>StretchBitKHR</c> specifies that the swapchain image will be minified or magnified such that the resulting image dimensions are equal to those of the surface.
        /// </summary>
        StretchBitKHR = 0x00000004,

        /// <summary>
        ///     <c>OneToOneBitEXT</c>
        /// </summary>
        OneToOneBitEXT = OneToOneBitKHR,

        /// <summary>
        ///     <c>AspectRatioStretchBitEXT</c>
        /// </summary>
        AspectRatioStretchBitEXT = AspectRatioStretchBitKHR,

        /// <summary>
        ///     <c>StretchBitEXT</c>
        /// </summary>
        StretchBitEXT = StretchBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
