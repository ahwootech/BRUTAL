namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalSemaphoreProperties.html">VkExternalSemaphoreProperties</see> - Structure describing supported external semaphore handle features
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalSemaphoreProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalSemaphoreProperties {
    ///             VkStructureType                       sType;
    ///             void*                                 pNext;
    ///             VkExternalSemaphoreHandleTypeFlags    exportFromImportedHandleTypes;
    ///             VkExternalSemaphoreHandleTypeFlags    compatibleHandleTypes;
    ///             VkExternalSemaphoreFeatureFlags       externalSemaphoreFeatures;
    ///         } VkExternalSemaphoreProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkExternalSemaphoreProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalSemaphoreProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExportFromImportedHandleTypes</c> is a bitmask of <c>VkExternalSemaphoreHandleTypeFlags</c> specifying which types of imported handle <c>handleType</c> <i>can</i> be exported from.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes;

        /// <summary>
        ///     <c>CompatibleHandleTypes</c> is a bitmask of <c>VkExternalSemaphoreHandleTypeFlags</c> specifying handle types which <i>can</i> be specified at the same time as <c>handleType</c> when creating a semaphore.
        /// </summary>
        [FieldOffset(20)]
        public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes;

        /// <summary>
        ///     <c>ExternalSemaphoreFeatures</c> is a bitmask of <c>VkExternalSemaphoreFeatureFlags</c> describing the features of <c>handleType</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures;
    }
}
