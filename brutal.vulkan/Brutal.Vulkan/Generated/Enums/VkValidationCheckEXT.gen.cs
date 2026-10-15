namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationCheckEXT.html">VkValidationCheckEXT</see> - Specify validation checks to disable
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of elements of the
    ///         <c>VkValidationFlagsEXT::pDisabledValidationChecks</c> array,
    ///         specifying validation checks to be disabled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_flags
    ///         typedef enum VkValidationCheckEXT {
    ///             VK_VALIDATION_CHECK_ALL_EXT = 0,
    ///             VK_VALIDATION_CHECK_SHADERS_EXT = 1,
    ///         } VkValidationCheckEXT;
    ///     </code>
    /// </remarks>
    public enum VkValidationCheckEXT : int
    {
        /// <summary>
        ///     <c>AllEXT</c> specifies that all validation checks are disabled.
        /// </summary>
        AllEXT = 0,

        /// <summary>
        ///     <c>ShadersEXT</c> specifies that shader validation is disabled.
        /// </summary>
        ShadersEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
