namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoFormatInfoKHR.html">VkPhysicalDeviceVideoFormatInfoKHR</see> - Structure specifying the codec video format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoFormatInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkPhysicalDeviceVideoFormatInfoKHR {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkImageUsageFlags    imageUsage;
    ///         } VkPhysicalDeviceVideoFormatInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoFormatInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoFormatInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageUsage</c> is a bitmask of <c>VkImageUsageFlags</c> specifying the intended usage of the video images.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags ImageUsage;
    }
}
