namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceTransformFlagBitsKHR.html">VkSurfaceTransformFlagBitsKHR</see> - Presentation transforms supported on a device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkSurfaceCapabilitiesKHR::supportedTransforms</c> indicating the
    ///         presentation transforms supported for the surface on the specified device,
    ///         and possible values of
    ///         <c>VkSurfaceCapabilitiesKHR::currentTransform</c> indicating the
    ///         surface&apos;s current transform relative to the presentation engine&apos;s natural
    ///         orientation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef enum VkSurfaceTransformFlagBitsKHR {
    ///             VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = 0x00000001,
    ///             VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = 0x00000002,
    ///             VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = 0x00000004,
    ///             VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = 0x00000008,
    ///             VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = 0x00000010,
    ///             VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = 0x00000020,
    ///             VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 0x00000040,
    ///             VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 0x00000080,
    ///             VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = 0x00000100,
    ///         } VkSurfaceTransformFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSurfaceTransformFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>IdentityBitKHR</c> specifies that image content is presented without being transformed.
        /// </summary>
        IdentityBitKHR = 0x00000001,

        /// <summary>
        ///     <c>Rotate90BitKHR</c> specifies that image content is rotated 90 degrees clockwise.
        /// </summary>
        Rotate90BitKHR = 0x00000002,

        /// <summary>
        ///     <c>Rotate180BitKHR</c> specifies that image content is rotated 180 degrees clockwise.
        /// </summary>
        Rotate180BitKHR = 0x00000004,

        /// <summary>
        ///     <c>Rotate270BitKHR</c> specifies that image content is rotated 270 degrees clockwise.
        /// </summary>
        Rotate270BitKHR = 0x00000008,

        /// <summary>
        ///     <c>HorizontalMirrorBitKHR</c> specifies that image content is mirrored horizontally.
        /// </summary>
        HorizontalMirrorBitKHR = 0x00000010,

        /// <summary>
        ///     <c>HorizontalMirrorRotate90BitKHR</c> specifies that image content is mirrored horizontally, then rotated 90 degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate90BitKHR = 0x00000020,

        /// <summary>
        ///     <c>HorizontalMirrorRotate180BitKHR</c>  specifies that image content is mirrored horizontally, then rotated 180 degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate180BitKHR = 0x00000040,

        /// <summary>
        ///     <c>HorizontalMirrorRotate270BitKHR</c>  specifies that image content is mirrored horizontally, then rotated 270 degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate270BitKHR = 0x00000080,

        /// <summary>
        ///     <c>InheritBitKHR</c> specifies that the presentation transform is not specified, and is instead determined by platform-specific considerations and mechanisms outside Vulkan.
        /// </summary>
        InheritBitKHR = 0x00000100,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
