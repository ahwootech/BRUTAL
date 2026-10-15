namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportFenceCreateInfo.html">VkExportFenceCreateInfo</see> - Structure specifying handle types that can be exported from a fence
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To create a fence whose payload <i>can</i> be exported to external handles, add a
    ///         <c>VkExportFenceCreateInfo</c> structure to the <c>pNext</c> chain of the
    ///         <c>VkFenceCreateInfo</c> structure.
    ///         The <c>VkExportFenceCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExportFenceCreateInfo {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkExternalFenceHandleTypeFlags    handleTypes;
    ///         } VkExportFenceCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExportFenceCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportFenceCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c> is a bitmask of <c>VkExternalFenceHandleTypeFlags</c> specifying one or more fence handle types the application <i>can</i> export from the resulting fence. The application <i>can</i> request multiple handle types for the same fence.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalFenceHandleTypeFlags HandleTypes;
    }
}
