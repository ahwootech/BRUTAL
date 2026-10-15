namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMemoryAllocateInfoNV.html">VkExportMemoryAllocateInfoNV</see> - Specify memory handle types that may be exported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExportMemoryAllocateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory
    ///         typedef struct VkExportMemoryAllocateInfoNV {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkExternalMemoryHandleTypeFlagsNV    handleTypes;
    ///         } VkExportMemoryAllocateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExportMemoryAllocateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMemoryAllocateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c> is a bitmask of <c>VkExternalMemoryHandleTypeFlagsNV</c> specifying one or more memory handle types that may: be exported. Multiple handle types may: be requested for the same allocation as long as they are compatible, as reported by <c>vkGetPhysicalDeviceExternalImageFormatPropertiesNV</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
    }
}
