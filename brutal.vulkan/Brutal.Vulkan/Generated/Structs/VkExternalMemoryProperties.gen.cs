namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryProperties.html">VkExternalMemoryProperties</see> - Structure specifying external memory handle type capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalMemoryProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalMemoryProperties {
    ///             VkExternalMemoryFeatureFlags       externalMemoryFeatures;
    ///             VkExternalMemoryHandleTypeFlags    exportFromImportedHandleTypes;
    ///             VkExternalMemoryHandleTypeFlags    compatibleHandleTypes;
    ///         } VkExternalMemoryProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkExternalMemoryProperties()
    {
        /// <summary>
        ///     <c>ExternalMemoryFeatures</c> is a bitmask of <c>VkExternalMemoryFeatureFlags</c> specifying the features of <c>handleType</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkExternalMemoryFeatureFlags ExternalMemoryFeatures;

        /// <summary>
        ///     <c>ExportFromImportedHandleTypes</c> is a bitmask of <c>VkExternalMemoryHandleTypeFlags</c> specifying which types of imported handle <c>handleType</c> <i>can</i> be exported from.
        /// </summary>
        [FieldOffset(4)]
        public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes;

        /// <summary>
        ///     <c>CompatibleHandleTypes</c> is a bitmask of <c>VkExternalMemoryHandleTypeFlags</c> specifying handle types which <i>can</i> be specified at the same time as <c>handleType</c> when creating an image compatible with external memory.
        /// </summary>
        [FieldOffset(8)]
        public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes;
    }
}
