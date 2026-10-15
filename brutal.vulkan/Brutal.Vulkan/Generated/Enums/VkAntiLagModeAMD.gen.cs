namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAntiLagModeAMD.html">VkAntiLagModeAMD</see> - Set the status of the anti-lag feature
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkAntiLagDataAMD::mode</c>, specifying the
    ///         anti-lag status, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_anti_lag
    ///         typedef enum VkAntiLagModeAMD {
    ///             VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD = 0,
    ///             VK_ANTI_LAG_MODE_ON_AMD = 1,
    ///             VK_ANTI_LAG_MODE_OFF_AMD = 2,
    ///         } VkAntiLagModeAMD;
    ///     </code>
    /// </remarks>
    public enum VkAntiLagModeAMD : int
    {
        /// <summary>
        ///     <c>DriverControlAMD</c> specifies that anti-lag will be enabled or disabled depending on driver settings.
        /// </summary>
        DriverControlAMD = 0,

        /// <summary>
        ///     <c>OnAMD</c> specifies that anti-lag will be enabled.
        /// </summary>
        OnAMD = 1,

        /// <summary>
        ///     <c>OffAMD</c> specifies that anti-lag will be disabled.
        /// </summary>
        OffAMD = 2,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
