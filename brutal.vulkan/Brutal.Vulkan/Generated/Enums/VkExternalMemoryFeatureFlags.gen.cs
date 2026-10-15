namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBits.html">VkExternalMemoryFeatureFlagBits</see> - Bitmask specifying features of an external memory handle type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkExternalMemoryProperties::externalMemoryFeatures</c>, specifying
    ///         features of an external memory handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkExternalMemoryFeatureFlagBits {
    ///             VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = 0x00000001,
    ///             VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = 0x00000002,
    ///             VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = 0x00000004,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_KHR = VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT,
    ///         } VkExternalMemoryFeatureFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalMemoryFeatureFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DedicatedOnlyBit</c> specifies that images or buffers created with the specified parameters and handle type <i>must</i> use the mechanisms defined by <c>VkMemoryDedicatedRequirements</c> and <c>VkMemoryDedicatedAllocateInfo</c> to create (or import) a dedicated allocation for the image or buffer.
        /// </summary>
        DedicatedOnlyBit = 0x00000001,

        /// <summary>
        ///     <c>ExportableBit</c> specifies that handles of this type <i>can</i> be exported from Vulkan memory objects.
        /// </summary>
        ExportableBit = 0x00000002,

        /// <summary>
        ///     <c>ImportableBit</c> specifies that handles of this type <i>can</i> be imported as Vulkan memory objects.  Because their semantics in external APIs roughly align with that of an image or buffer with a dedicated allocation in Vulkan, implementations are required: to report <c>VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT</c> for the following external handle types:
        /// </summary>
        ImportableBit = 0x00000004,

        /// <summary>
        ///     <c>DedicatedOnlyBitKHR</c>
        /// </summary>
        DedicatedOnlyBitKHR = DedicatedOnlyBit,

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
