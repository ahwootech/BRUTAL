namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryFeatureFlagBitsNV.html">VkExternalMemoryFeatureFlagBitsNV</see> - Bitmask specifying external memory features
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkExternalImageFormatPropertiesNV::externalMemoryFeatures</c>,
    ///         indicating properties of the external memory handle type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_capabilities
    ///         typedef enum VkExternalMemoryFeatureFlagBitsNV {
    ///             VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = 0x00000001,
    ///             VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = 0x00000002,
    ///             VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = 0x00000004,
    ///         } VkExternalMemoryFeatureFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DedicatedOnlyBitNV</c> specifies that external memory of the specified type <i>must</i> be created as a dedicated allocation when used in the manner specified.
        /// </summary>
        DedicatedOnlyBitNV = 0x00000001,

        /// <summary>
        ///     <c>ExportableBitNV</c> specifies that the implementation supports exporting handles of the specified type.
        /// </summary>
        ExportableBitNV = 0x00000002,

        /// <summary>
        ///     <c>ImportableBitNV</c> specifies that the implementation supports importing handles of the specified type.
        /// </summary>
        ImportableBitNV = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
