namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneAlphaFlagBitsKHR.html">VkDisplayPlaneAlphaFlagBitsKHR</see> - Alpha blending type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDisplaySurfaceCreateInfoKHR::alphaMode</c>, specifying the type of
    ///         alpha blending to use on a display, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef enum VkDisplayPlaneAlphaFlagBitsKHR {
    ///             VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,
    ///             VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = 0x00000002,
    ///             VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = 0x00000004,
    ///             VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = 0x00000008,
    ///         } VkDisplayPlaneAlphaFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDisplayPlaneAlphaFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OpaqueBitKHR</c> specifies that the source image will be treated as opaque.
        /// </summary>
        OpaqueBitKHR = 0x00000001,

        /// <summary>
        ///     <c>GlobalBitKHR</c> specifies that a global alpha value <i>must</i> be specified that will be applied to all pixels in the source image.
        /// </summary>
        GlobalBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PerPixelBitKHR</c> specifies that the alpha value will be determined by the alpha component of the source image&apos;s pixels. If the source format contains no alpha values, no blending will be applied. The source alpha values are not premultiplied into the source image&apos;s other color components.
        /// </summary>
        PerPixelBitKHR = 0x00000004,

        /// <summary>
        ///     <c>PerPixelPremultipliedBitKHR</c> is equivalent to <c>VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR</c>, except the source alpha values are assumed to be premultiplied into the source image&apos;s other color components.
        /// </summary>
        PerPixelPremultipliedBitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
