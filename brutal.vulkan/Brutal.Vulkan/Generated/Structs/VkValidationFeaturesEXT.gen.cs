namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationFeaturesEXT.html">VkValidationFeaturesEXT</see> - Specify validation features to enable or disable for a Vulkan instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When creating a Vulkan instance for which you wish to enable or disable
    ///         specific validation features, add a <c>VkValidationFeaturesEXT</c> structure
    ///         to the <c>pNext</c> chain of the <c>VkInstanceCreateInfo</c> structure,
    ///         specifying the features to be enabled or disabled.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_features
    ///         typedef struct VkValidationFeaturesEXT {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             uint32_t                                enabledValidationFeatureCount;
    ///             const VkValidationFeatureEnableEXT*     pEnabledValidationFeatures;
    ///             uint32_t                                disabledValidationFeatureCount;
    ///             const VkValidationFeatureDisableEXT*    pDisabledValidationFeatures;
    ///         } VkValidationFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkValidationFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ValidationFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>EnabledValidationFeatureCount</c> is the number of features to enable.
        /// </summary>
        [FieldOffset(16)]
        public int EnabledValidationFeatureCount;

        /// <summary>
        ///     <c>EnabledValidationFeatures</c> is a pointer to an array of <c>VkValidationFeatureEnableEXT</c> values specifying the validation features to be enabled.
        /// </summary>
        [FieldOffset(24)]
        public VkValidationFeatureEnableEXT* EnabledValidationFeatures;

        /// <summary>
        ///     <c>DisabledValidationFeatureCount</c> is the number of features to disable.
        /// </summary>
        [FieldOffset(32)]
        public int DisabledValidationFeatureCount;

        /// <summary>
        ///     <c>DisabledValidationFeatures</c> is a pointer to an array of <c>VkValidationFeatureDisableEXT</c> values specifying the validation features to be disabled.
        /// </summary>
        [FieldOffset(40)]
        public VkValidationFeatureDisableEXT* DisabledValidationFeatures;
    }
}
