namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryGetFdInfoKHR.html">VkMemoryGetFdInfoKHR</see> - Structure describing a POSIX FD memory export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryGetFdInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_fd
    ///         typedef struct VkMemoryGetFdInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkDeviceMemory                        memory;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkMemoryGetFdInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryGetFdInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryGetFdInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the memory object from which the handle will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
