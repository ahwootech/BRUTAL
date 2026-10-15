namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationFeatureEnableEXT.html">VkValidationFeatureEnableEXT</see> - Specify validation features to enable
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of elements of the
    ///         <c>VkValidationFeaturesEXT::pEnabledValidationFeatures</c> array,
    ///         specifying validation features to be enabled, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_features
    ///         typedef enum VkValidationFeatureEnableEXT {
    ///             VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,
    ///             VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
    ///             VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = 2,
    ///             VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = 3,
    ///             VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = 4,
    ///         } VkValidationFeatureEnableEXT;
    ///     </code>
    /// </remarks>
    public enum VkValidationFeatureEnableEXT : int
    {
        /// <summary>
        ///     <c>GpuAssistedEXT</c> specifies that GPU-assisted validation is enabled. Activating this feature instruments shader programs to generate additional diagnostic data. This feature is disabled by default.
        /// </summary>
        GpuAssistedEXT = 0,

        /// <summary>
        ///     <c>GpuAssistedReserveBindingSlotEXT</c>  specifies that the validation layers reserve a descriptor set binding slot for their own use. The layer reports a value for <c>VkPhysicalDeviceLimits::maxBoundDescriptorSets</c> that is one less than the value reported by the device. If the device supports the binding of only one descriptor set, the validation layer does not perform GPU-assisted validation. This feature is disabled by default.
        /// </summary>
        GpuAssistedReserveBindingSlotEXT = 1,

        /// <summary>
        ///     <c>BestPracticesEXT</c> specifies that Vulkan best-practices validation is enabled. Activating this feature enables the output of warnings related to common misuse of the API, but which are not explicitly prohibited by the specification. This feature is disabled by default.
        /// </summary>
        BestPracticesEXT = 2,

        /// <summary>
        ///     <c>DebugPrintfEXT</c> specifies that the layers will process <c>debugPrintfEXT</c> operations in shaders and send the resulting output to the debug callback. This feature is disabled by default.
        /// </summary>
        DebugPrintfEXT = 3,

        /// <summary>
        ///     <c>SynchronizationValidationEXT</c>  specifies that Vulkan synchronization validation is enabled. This feature reports resource access conflicts due to missing or incorrect synchronization operations between actions (Draw, Copy, Dispatch, Blit) reading or writing the same regions of memory. This feature is disabled by default.
        /// </summary>
        SynchronizationValidationEXT = 4,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
