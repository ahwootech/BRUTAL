namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryOpaqueCaptureAddressAllocateInfo.html">VkMemoryOpaqueCaptureAddressAllocateInfo</see> - Request a specific address for a memory allocation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To request a specific device address for a memory allocation, add a
    ///         <c>VkMemoryOpaqueCaptureAddressAllocateInfo</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkMemoryAllocateInfo</c> structure.
    ///         The <c>VkMemoryOpaqueCaptureAddressAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkMemoryOpaqueCaptureAddressAllocateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           opaqueCaptureAddress;
    ///         } VkMemoryOpaqueCaptureAddressAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OpaqueCaptureAddress</c> is the opaque capture address requested for the memory allocation.
        /// </summary>
        [FieldOffset(16)]
        public nint OpaqueCaptureAddress;
    }
}
