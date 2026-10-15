namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreGetFdInfoKHR.html">VkSemaphoreGetFdInfoKHR</see> - Structure describing a POSIX FD semaphore export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSemaphoreGetFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_fd
    ///         typedef struct VkSemaphoreGetFdInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkSemaphore                              semaphore;
    ///             VkExternalSemaphoreHandleTypeFlagBits    handleType;
    ///         } VkSemaphoreGetFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSemaphoreGetFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreGetFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is the semaphore from which state will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalSemaphoreHandleTypeFlags HandleType;
    }
}
