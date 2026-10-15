namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalFenceFeatureFlagBits.html">VkExternalFenceFeatureFlagBits</see> - Bitfield describing features of an external fence handle type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkExternalFenceProperties::externalFenceFeatures</c>, indicating
    ///         features of a fence external handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalFenceFeatureFlagBits {
    ///             VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = 0x00000001,
    ///             VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = 0x00000002,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT,
    ///         } VkExternalFenceFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalFenceFeatureFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ExportableBit</c> specifies handles of this type <i>can</i> be exported from Vulkan fence objects.
        /// </summary>
        ExportableBit = 0x00000001,

        /// <summary>
        ///     <c>ImportableBit</c> specifies handles of this type <i>can</i> be imported to Vulkan fence objects.
        /// </summary>
        ImportableBit = 0x00000002,

        /// <summary>
        ///     <c>ExportableBitKHR</c>
        /// </summary>
        ExportableBitKHR = ExportableBit,

        /// <summary>
        ///     <c>ImportableBitKHR</c>
        /// </summary>
        ImportableBitKHR = ImportableBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
