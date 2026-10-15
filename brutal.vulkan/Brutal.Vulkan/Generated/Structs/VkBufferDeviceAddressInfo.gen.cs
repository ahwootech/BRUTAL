namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferDeviceAddressInfo.html">VkBufferDeviceAddressInfo</see> - Structure specifying the buffer to query an address for
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBufferDeviceAddressInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkBufferDeviceAddressInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           buffer;
    ///         } VkBufferDeviceAddressInfo;
    ///     </code>
    ///     <para>
    ///         // Jon: three-way conditional logic is broken
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferDeviceAddressInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferDeviceAddressInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> specifies the buffer whose address is being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;
    }
}
