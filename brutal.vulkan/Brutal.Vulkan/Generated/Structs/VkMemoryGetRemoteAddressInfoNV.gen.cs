namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryGetRemoteAddressInfoNV.html">VkMemoryGetRemoteAddressInfoNV</see> - Structure describing a remote accessible address export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryGetRemoteAddressInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_rdma
    ///         typedef struct VkMemoryGetRemoteAddressInfoNV {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkDeviceMemory                        memory;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkMemoryGetRemoteAddressInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryGetRemoteAddressInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryGetRemoteAddressInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the memory object from which the remote accessible address will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>HandleType</c> is the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
