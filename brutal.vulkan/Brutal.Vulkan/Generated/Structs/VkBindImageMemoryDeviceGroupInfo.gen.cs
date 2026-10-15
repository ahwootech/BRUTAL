namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryDeviceGroupInfo.html">VkBindImageMemoryDeviceGroupInfo</see> - Structure specifying device within a group to bind to
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindImageMemoryDeviceGroupInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBindImageMemoryDeviceGroupInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           deviceIndexCount;
    ///             const uint32_t*    pDeviceIndices;
    ///             uint32_t           splitInstanceBindRegionCount;
    ///             const VkRect2D*    pSplitInstanceBindRegions;
    ///         } VkBindImageMemoryDeviceGroupInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindImageMemoryDeviceGroupInfo;

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

        /// <summary>
        ///     <c>SplitInstanceBindRegionCount</c> is the number of elements in <c>pSplitInstanceBindRegions</c>.
        /// </summary>
        [FieldOffset(32)]
        public int SplitInstanceBindRegionCount;

        /// <summary>
        ///     <c>SplitInstanceBindRegions</c> is a pointer to an array of <c>VkRect2D</c> structures describing which regions of the image are attached to each instance of memory.
        /// </summary>
        [FieldOffset(40)]
        public VkRect2D* SplitInstanceBindRegions;
    }
}
