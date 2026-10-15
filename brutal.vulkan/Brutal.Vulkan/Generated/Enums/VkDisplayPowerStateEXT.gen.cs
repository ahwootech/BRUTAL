namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPowerStateEXT.html">VkDisplayPowerStateEXT</see> - Possible power states for a display
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDisplayPowerInfoEXT::powerState</c>, specifying
    ///         the new power state of a display, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef enum VkDisplayPowerStateEXT {
    ///             VK_DISPLAY_POWER_STATE_OFF_EXT = 0,
    ///             VK_DISPLAY_POWER_STATE_SUSPEND_EXT = 1,
    ///             VK_DISPLAY_POWER_STATE_ON_EXT = 2,
    ///         } VkDisplayPowerStateEXT;
    ///     </code>
    /// </remarks>
    public enum VkDisplayPowerStateEXT : int
    {
        /// <summary>
        ///     <c>OffEXT</c> specifies that the display is powered down.
        /// </summary>
        OffEXT = 0,

        /// <summary>
        ///     <c>SuspendEXT</c> specifies that the display is put into a low power mode, from which it may: be able to transition back to <c>VK_DISPLAY_POWER_STATE_ON_EXT</c> more quickly than if it were in <c>VK_DISPLAY_POWER_STATE_OFF_EXT</c>. This state may: be the same as <c>VK_DISPLAY_POWER_STATE_OFF_EXT</c>.
        /// </summary>
        SuspendEXT = 1,

        /// <summary>
        ///     <c>OnEXT</c> specifies that the display is powered on.
        /// </summary>
        OnEXT = 2,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
