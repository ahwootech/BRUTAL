namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMemoryAllocateInfo.html">VkExportMemoryAllocateInfo</see> - Specify exportable handle types for a device memory object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When allocating memory whose payload may: be exported to another process or
    ///         Vulkan instance, add a <c>VkExportMemoryAllocateInfo</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkMemoryAllocateInfo</c> structure, specifying
    ///         the handle types that may: be exported.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMemoryAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExportMemoryAllocateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkExternalMemoryHandleTypeFlags    handleTypes;
    ///         } VkExportMemoryAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExportMemoryAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMemoryAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c> is zero or a bitmask of <c>VkExternalMemoryHandleTypeFlags</c> specifying one or more memory handle types the application <i>can</i> export from the resulting allocation. The application <i>can</i> request multiple handle types for the same allocation.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleTypes;
    }
}
