namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatPropertiesNV.html">VkExternalImageFormatPropertiesNV</see> - Structure specifying external image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalImageFormatPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_capabilities
    ///         typedef struct VkExternalImageFormatPropertiesNV {
    ///             VkImageFormatProperties              imageFormatProperties;
    ///             VkExternalMemoryFeatureFlagsNV       externalMemoryFeatures;
    ///             VkExternalMemoryHandleTypeFlagsNV    exportFromImportedHandleTypes;
    ///             VkExternalMemoryHandleTypeFlagsNV    compatibleHandleTypes;
    ///         } VkExternalImageFormatPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct VkExternalImageFormatPropertiesNV()
    {
        /// <summary>
        ///     <c>ImageFormatProperties</c> will be filled in as when calling <c>vkGetPhysicalDeviceImageFormatProperties</c>, but the values returned may: vary depending on the external handle type requested.
        /// </summary>
        [FieldOffset(0)]
        public VkImageFormatProperties ImageFormatProperties;

        /// <summary>
        ///     <c>ExternalMemoryFeatures</c> is a bitmask of <c>VkExternalMemoryFeatureFlagsNV</c>, indicating properties of the external memory handle type (<c>vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType</c>) being queried, or 0 if the external memory handle type is 0.
        /// </summary>
        [FieldOffset(32)]
        public VkExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;

        /// <summary>
        ///     <c>ExportFromImportedHandleTypes</c> is a bitmask of <c>VkExternalMemoryHandleTypeFlagsNV</c> containing a bit set for every external handle type that may: be used to create memory from which the handles of the type specified in <c>vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType</c> <i>can</i> be exported, or 0 if the external memory handle type is 0.
        /// </summary>
        [FieldOffset(36)]
        public VkExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;

        /// <summary>
        ///     <c>CompatibleHandleTypes</c> is a bitmask of <c>VkExternalMemoryHandleTypeFlagsNV</c> containing a bit set for every external handle type that may: be specified simultaneously with the handle type specified by <c>vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType</c> when calling <c>vkAllocateMemory</c>, or 0 if the external memory handle type is 0. <c>compatibleHandleTypes</c> will always contain <c>vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType</c>
        /// </summary>
        [FieldOffset(40)]
        public VkExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
    }
}
