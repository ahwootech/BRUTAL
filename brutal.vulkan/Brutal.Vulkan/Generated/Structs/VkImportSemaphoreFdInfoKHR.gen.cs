namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreFdInfoKHR.html">VkImportSemaphoreFdInfoKHR</see> - Structure specifying POSIX file descriptor to import to a semaphore
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImportSemaphoreFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_fd
    ///         typedef struct VkImportSemaphoreFdInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkSemaphore                              semaphore;
    ///             VkSemaphoreImportFlags                   flags;
    ///             VkExternalSemaphoreHandleTypeFlagBits    handleType;
    ///             int                                      fd;
    ///         } VkImportSemaphoreFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkImportSemaphoreFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportSemaphoreFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is the semaphore into which the payload will be imported.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSemaphoreImportFlags</c> specifying additional parameters for the semaphore payload import operation.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphoreImportFlags Flags;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> value specifying the type of <c>fd</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExternalSemaphoreHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>Fd</c> is the external handle to import.
        /// </summary>
        [FieldOffset(32)]
        public int Fd;
    }
}
