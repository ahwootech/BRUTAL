namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalFenceProperties.html">VkExternalFenceProperties</see> - Structure describing supported external fence handle features
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalFenceProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalFenceProperties {
    ///             VkStructureType                   sType;
    ///             void*                             pNext;
    ///             VkExternalFenceHandleTypeFlags    exportFromImportedHandleTypes;
    ///             VkExternalFenceHandleTypeFlags    compatibleHandleTypes;
    ///             VkExternalFenceFeatureFlags       externalFenceFeatures;
    ///         } VkExternalFenceProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkExternalFenceProperties()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalFenceProperties;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExportFromImportedHandleTypes</c> is a bitmask of <c>VkExternalFenceHandleTypeFlags</c> indicating which types of imported handle <c>handleType</c> <i>can</i> be exported from.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes;

        /// <summary>
        ///     <c>CompatibleHandleTypes</c> is a bitmask of <c>VkExternalFenceHandleTypeFlags</c> specifying handle types which <i>can</i> be specified at the same time as <c>handleType</c> when creating a fence.
        /// </summary>
        [FieldOffset(20)]
        public VkExternalFenceHandleTypeFlags CompatibleHandleTypes;

        /// <summary>
        ///     <c>ExternalFenceFeatures</c> is a bitmask of <c>VkExternalFenceFeatureFlags</c> indicating the features of <c>handleType</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalFenceFeatureFlags ExternalFenceFeatures;
    }
}
