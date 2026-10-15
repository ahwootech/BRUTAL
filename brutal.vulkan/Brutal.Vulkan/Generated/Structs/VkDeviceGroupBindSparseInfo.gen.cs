namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupBindSparseInfo.html">VkDeviceGroupBindSparseInfo</see> - Structure indicating which instances are bound
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkBindSparseInfo</c> includes a
    ///         <c>VkDeviceGroupBindSparseInfo</c> structure, then that structure includes
    ///         device indices specifying which instance of the resources and memory are
    ///         bound.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupBindSparseInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceGroupBindSparseInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           resourceDeviceIndex;
    ///             uint32_t           memoryDeviceIndex;
    ///         } VkDeviceGroupBindSparseInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceGroupBindSparseInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupBindSparseInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ResourceDeviceIndex</c> is a device index indicating which instance of the resource is bound.
        /// </summary>
        [FieldOffset(16)]
        public int ResourceDeviceIndex;

        /// <summary>
        ///     <c>MemoryDeviceIndex</c> is a device index indicating which instance of the memory the resource instance is bound to.
        /// </summary>
        [FieldOffset(20)]
        public int MemoryDeviceIndex;
    }
}
