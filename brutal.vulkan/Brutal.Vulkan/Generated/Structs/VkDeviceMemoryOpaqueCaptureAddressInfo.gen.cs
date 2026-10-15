namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryOpaqueCaptureAddressInfo.html">VkDeviceMemoryOpaqueCaptureAddressInfo</see> - Structure specifying the memory object to query an address for
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceMemoryOpaqueCaptureAddressInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkDeviceMemoryOpaqueCaptureAddressInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceMemory     memory;
    ///         } VkDeviceMemoryOpaqueCaptureAddressInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> specifies the memory whose address is being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;
    }
}
