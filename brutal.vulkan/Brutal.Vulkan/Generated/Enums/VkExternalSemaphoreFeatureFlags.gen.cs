namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreFeatureFlagBits.html">VkExternalSemaphoreFeatureFlagBits</see> - Bitfield describing features of an external semaphore handle type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkExternalSemaphoreProperties::externalSemaphoreFeatures</c>,
    ///         specifying the features of an external semaphore handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalSemaphoreFeatureFlagBits {
    ///             VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = 0x00000001,
    ///             VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = 0x00000002,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT,
    ///         } VkExternalSemaphoreFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalSemaphoreFeatureFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ExportableBit</c> specifies that handles of this type <i>can</i> be exported from Vulkan semaphore objects.
        /// </summary>
        ExportableBit = 0x00000001,

        /// <summary>
        ///     <c>ImportableBit</c> specifies that handles of this type <i>can</i> be imported as Vulkan semaphore objects.
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
