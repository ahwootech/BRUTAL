namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferOpaqueCaptureAddressCreateInfo.html">VkBufferOpaqueCaptureAddressCreateInfo</see> - Request a specific address for a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To request a specific device address for a buffer, add a
    ///         <c>VkBufferOpaqueCaptureAddressCreateInfo</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkBufferCreateInfo</c> structure.
    ///         The <c>VkBufferOpaqueCaptureAddressCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkBufferOpaqueCaptureAddressCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           opaqueCaptureAddress;
    ///         } VkBufferOpaqueCaptureAddressCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferOpaqueCaptureAddressCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OpaqueCaptureAddress</c> is the opaque capture address requested for the buffer.
        /// </summary>
        [FieldOffset(16)]
        public nint OpaqueCaptureAddress;
    }
}
