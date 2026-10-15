namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferDeviceAddressCreateInfoEXT.html">VkBufferDeviceAddressCreateInfoEXT</see> - Request a specific address for a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To request a specific device address for a buffer, add a
    ///         <c>VkBufferDeviceAddressCreateInfoEXT</c> structure to the <c>pNext</c> chain
    ///         of the <c>VkBufferCreateInfo</c> structure.
    ///         The <c>VkBufferDeviceAddressCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_buffer_device_address
    ///         typedef struct VkBufferDeviceAddressCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceAddress    deviceAddress;
    ///         } VkBufferDeviceAddressCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferDeviceAddressCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceAddress</c> is the device address requested for the buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress DeviceAddress;
    }
}
