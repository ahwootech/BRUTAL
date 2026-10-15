namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyDeviceMemoryInfoKHR.html">VkCopyDeviceMemoryInfoKHR</see> - Structure specifying a buffer copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyDeviceMemoryInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyDeviceMemoryInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkCopyDeviceMemoryInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             uint32_t                        regionCount;
    ///             const VkDeviceMemoryCopyKHR*    pRegions;
    ///         } VkCopyDeviceMemoryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCopyDeviceMemoryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyDeviceMemoryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RegionCount</c> is the number of copies to be performed.
        /// </summary>
        [FieldOffset(16)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkDeviceMemoryCopyKHR</c> structures describing individual copy operations between two memory ranges.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemoryCopyKHR* Regions;
    }
}
