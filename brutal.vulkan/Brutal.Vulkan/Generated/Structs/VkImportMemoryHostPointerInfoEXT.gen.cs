namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMemoryHostPointerInfoEXT.html">VkImportMemoryHostPointerInfoEXT</see> - Import memory from a host pointer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory from a host pointer, add a
    ///         <c>VkImportMemoryHostPointerInfoEXT</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkMemoryAllocateInfo</c> structure.
    ///         The <c>VkImportMemoryHostPointerInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_host
    ///         typedef struct VkImportMemoryHostPointerInfoEXT {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///             void*                                 pHostPointer;
    ///         } VkImportMemoryHostPointerInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImportMemoryHostPointerInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMemoryHostPointerInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the handle type.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>HostPointer</c> is the host pointer to import from.
        /// </summary>
        [FieldOffset(24)]
        public void* HostPointer;
    }
}
