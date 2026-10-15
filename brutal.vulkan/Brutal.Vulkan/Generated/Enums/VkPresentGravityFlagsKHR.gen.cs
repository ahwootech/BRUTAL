namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentGravityFlagBitsKHR.html">VkPresentGravityFlagBitsKHR</see> - Bitmask specifying presentation pixel gravity on either the x or y axis
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in the
    ///         <c>VkSurfacePresentScalingCapabilitiesKHR::supportedPresentGravityX</c>
    ///         or <c>supportedPresentGravityY</c> fields, specifying the gravity of
    ///         presented pixels supported by the surface, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_maintenance1
    ///         typedef enum VkPresentGravityFlagBitsKHR {
    ///             VK_PRESENT_GRAVITY_MIN_BIT_KHR = 0x00000001,
    ///             VK_PRESENT_GRAVITY_MAX_BIT_KHR = 0x00000002,
    ///             VK_PRESENT_GRAVITY_CENTERED_BIT_KHR = 0x00000004,
    ///             VK_PRESENT_GRAVITY_MIN_BIT_EXT = VK_PRESENT_GRAVITY_MIN_BIT_KHR,
    ///             VK_PRESENT_GRAVITY_MAX_BIT_EXT = VK_PRESENT_GRAVITY_MAX_BIT_KHR,
    ///             VK_PRESENT_GRAVITY_CENTERED_BIT_EXT = VK_PRESENT_GRAVITY_CENTERED_BIT_KHR,
    ///         } VkPresentGravityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPresentGravityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MinBitKHR</c> means that the pixels will gravitate towards the top or left side of the surface.
        /// </summary>
        MinBitKHR = 0x00000001,

        /// <summary>
        ///     <c>MaxBitKHR</c> means that the pixels will gravitate towards the bottom or right side of the surface.
        /// </summary>
        MaxBitKHR = 0x00000002,

        /// <summary>
        ///     <c>CenteredBitKHR</c> means that the pixels will be centered in the surface.  If the value in <c>VkSurfaceCapabilitiesKHR::currentTransform</c> is not <c>VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR</c>, it is implementation-defined whether the gravity configuration applies to the presented image before or after transformation.
        /// </summary>
        CenteredBitKHR = 0x00000004,

        /// <summary>
        ///     <c>MinBitEXT</c>
        /// </summary>
        MinBitEXT = MinBitKHR,

        /// <summary>
        ///     <c>MaxBitEXT</c>
        /// </summary>
        MaxBitEXT = MaxBitKHR,

        /// <summary>
        ///     <c>CenteredBitEXT</c>
        /// </summary>
        CenteredBitEXT = CenteredBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
