namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMemoryFdInfoKHR.html">VkImportMemoryFdInfoKHR</see> - Import memory created on the same physical device from a file descriptor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory from a POSIX file descriptor handle, add a
    ///         <c>VkImportMemoryFdInfoKHR</c> structure to the <c>pNext</c> chain of the
    ///         <c>VkMemoryAllocateInfo</c> structure.
    ///         The <c>VkImportMemoryFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_fd
    ///         typedef struct VkImportMemoryFdInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///             int                                   fd;
    ///         } VkImportMemoryFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImportMemoryFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMemoryFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the handle type of <c>fd</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>Fd</c> is the external handle to import.
        /// </summary>
        [FieldOffset(20)]
        public int Fd;
    }
}
