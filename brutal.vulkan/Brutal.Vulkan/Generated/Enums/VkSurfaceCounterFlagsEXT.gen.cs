namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCounterFlagBitsEXT.html">VkSurfaceCounterFlagBitsEXT</see> - Surface-relative counter types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkSurfaceCapabilities2EXT::supportedSurfaceCounters</c>, indicating
    ///         supported surface counter types, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_surface_counter
    ///         typedef enum VkSurfaceCounterFlagBitsEXT {
    ///             VK_SURFACE_COUNTER_VBLANK_BIT_EXT = 0x00000001,
    ///             // VK_SURFACE_COUNTER_VBLANK_EXT is a legacy alias
    ///             VK_SURFACE_COUNTER_VBLANK_EXT = VK_SURFACE_COUNTER_VBLANK_BIT_EXT,
    ///         } VkSurfaceCounterFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSurfaceCounterFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>VblankBitEXT</c> specifies a counter incrementing once every time a vertical blanking period occurs on the display associated with the surface.
        /// </summary>
        VblankBitEXT = 0x00000001,

        /// <summary>
        ///     <c>VblankEXT</c>
        /// </summary>
        VblankEXT = VblankBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
