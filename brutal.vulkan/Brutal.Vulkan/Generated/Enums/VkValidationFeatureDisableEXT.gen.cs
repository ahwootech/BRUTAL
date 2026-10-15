namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureDisableEXT.html">VkValidationFeatureDisableEXT</see> - Specify validation features to disable
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of elements of the
    ///         <c>VkValidationFeaturesEXT::pDisabledValidationFeatures</c> array,
    ///         specifying validation features to be disabled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_features
    ///         typedef enum VkValidationFeatureDisableEXT {
    ///             VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = 0,
    ///             VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = 1,
    ///             VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = 2,
    ///             VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = 3,
    ///             VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = 4,
    ///             VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = 5,
    ///             VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = 6,
    ///             VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT = 7,
    ///         } VkValidationFeatureDisableEXT;
    ///     </code>
    /// </remarks>
    public enum VkValidationFeatureDisableEXT : int
    {
        /// <summary>
        ///     <c>AllEXT</c> specifies that all validation checks are disabled.
        /// </summary>
        AllEXT = 0,

        /// <summary>
        ///     <c>ShadersEXT</c> specifies that shader validation, both runtime and standalone, is disabled. This validation occurs inside <c>VkShaderModuleCreateInfo</c>. This feature is enabled by default.
        /// </summary>
        ShadersEXT = 1,

        /// <summary>
        ///     <c>ThreadSafetyEXT</c> specifies that thread safety validation is disabled. This feature is enabled by default.
        /// </summary>
        ThreadSafetyEXT = 2,

        /// <summary>
        ///     <c>ApiParametersEXT</c> specifies that stateless parameter validation is disabled. This feature is enabled by default.
        /// </summary>
        ApiParametersEXT = 3,

        /// <summary>
        ///     <c>ObjectLifetimesEXT</c> specifies that object lifetime validation is disabled. This feature is enabled by default.
        /// </summary>
        ObjectLifetimesEXT = 4,

        /// <summary>
        ///     <c>CoreChecksEXT</c> specifies that core validation checks are disabled. This feature is enabled by default. If this feature is disabled, <c>VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT</c> is implied.
        /// </summary>
        CoreChecksEXT = 5,

        /// <summary>
        ///     <c>UniqueHandlesEXT</c> specifies that protection against duplicate non-dispatchable object handles is disabled. This feature is enabled by default.
        /// </summary>
        UniqueHandlesEXT = 6,

        /// <summary>
        ///     <c>ShaderValidationCacheEXT</c>  specifies that there will be no caching of shader validation results and every shader will be validated on every application execution. Shader validation caching is enabled by default.
        /// </summary>
        ShaderValidationCacheEXT = 7,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
