namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyDeviceMemoryImageInfoKHR.html">VkCopyDeviceMemoryImageInfoKHR</see> - Structure specifying copy operations between an image and memory ranges
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyDeviceMemoryImageInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyDeviceMemoryImageInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkCopyDeviceMemoryImageInfoKHR {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkImage                              image;
    ///             uint32_t                             regionCount;
    ///             const VkDeviceMemoryImageCopyKHR*    pRegions;
    ///         } VkCopyDeviceMemoryImageInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyDeviceMemoryImageInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyDeviceMemoryImageInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is the base image accessed by the copy command.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

        /// <summary>
        ///     <c>RegionCount</c> is the number of copies to be performed.
        /// </summary>
        [FieldOffset(24)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkDeviceMemoryImageCopyKHR</c> structures describing individual copy operations between two memory ranges.
        /// </summary>
        [FieldOffset(32)]
        public VkDeviceMemoryImageCopyKHR* Regions;
    }
}
