namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreCreateInfo.html">VkExportSemaphoreCreateInfo</see> - Structure specifying handle types that can be exported from a semaphore
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To create a semaphore whose payload <i>can</i> be exported to external handles,
    ///         add a <c>VkExportSemaphoreCreateInfo</c> structure to the <c>pNext</c> chain
    ///         of the <c>VkSemaphoreCreateInfo</c> structure.
    ///         The <c>VkExportSemaphoreCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExportSemaphoreCreateInfo {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalSemaphoreHandleTypeFlags    handleTypes;
    ///         } VkExportSemaphoreCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExportSemaphoreCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportSemaphoreCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c> is a bitmask of <c>VkExternalSemaphoreHandleTypeFlags</c> specifying one or more semaphore handle types the application <i>can</i> export from the resulting semaphore. The application <i>can</i> request multiple handle types for the same semaphore.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalSemaphoreHandleTypeFlags HandleTypes;
    }
}
