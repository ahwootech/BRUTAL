namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryDeviceGroupInfo.html">VkBindBufferMemoryDeviceGroupInfo</see> - Structure specifying device within a group to bind to
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindBufferMemoryDeviceGroupInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBindBufferMemoryDeviceGroupInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           deviceIndexCount;
    ///             const uint32_t*    pDeviceIndices;
    ///         } VkBindBufferMemoryDeviceGroupInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindBufferMemoryDeviceGroupInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceIndexCount</c> is the number of elements in <c>pDeviceIndices</c>.
        /// </summary>
        [FieldOffset(16)]
        public int DeviceIndexCount;

        /// <summary>
        ///     <c>DeviceIndices</c> is a pointer to an array of device indices.
        /// </summary>
        [FieldOffset(24)]
        public int* DeviceIndices;
    }
}
