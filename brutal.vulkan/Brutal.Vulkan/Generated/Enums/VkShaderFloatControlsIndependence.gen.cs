namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderFloatControlsIndependence.html">VkShaderFloatControlsIndependence</see> - Bitmask specifying whether, and how, shader float controls can be set separately
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which may: be returned in the <c>denormBehaviorIndependence</c> and
    ///         <c>roundingModeIndependence</c> fields of
    ///         <c>VkPhysicalDeviceFloatControlsProperties</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkShaderFloatControlsIndependence {
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = 0,
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = 1,
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = 2,
    ///             // Provided by VK_KHR_shader_float_controls
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY,
    ///             // Provided by VK_KHR_shader_float_controls
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL,
    ///             // Provided by VK_KHR_shader_float_controls
    ///             VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE_KHR = VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE,
    ///         } VkShaderFloatControlsIndependence;
    ///     </code>
    /// </remarks>
    public enum VkShaderFloatControlsIndependence : int
    {
        /// <summary>
        ///     <c>_32BitOnly</c> specifies that shader float controls for 32-bit floating-point <i>can</i> be set independently; other bit widths <i>must</i> be set identically to each other.
        /// </summary>
        _32BitOnly = 0,

        /// <summary>
        ///     <c>All</c> specifies that shader float controls for all bit widths <i>can</i> be set independently.
        /// </summary>
        All = 1,

        /// <summary>
        ///     <c>None</c> specifies that shader float controls for all bit widths <i>must</i> be set identically.
        /// </summary>
        None = 2,

        /// <summary>
        ///     <c>_32BitOnlyKHR</c>
        /// </summary>
        _32BitOnlyKHR = _32BitOnly,

        /// <summary>
        ///     <c>AllKHR</c>
        /// </summary>
        AllKHR = All,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
