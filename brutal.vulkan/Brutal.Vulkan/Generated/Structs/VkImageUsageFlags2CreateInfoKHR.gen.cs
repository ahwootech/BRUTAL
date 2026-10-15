namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageUsageFlags2CreateInfoKHR.html">VkImageUsageFlags2CreateInfoKHR</see> - Extended image usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageUsageFlags2CreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         typedef struct VkImageUsageFlags2CreateInfoKHR {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkImageUsageFlags2KHR    usage;
    ///         } VkImageUsageFlags2CreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageUsageFlags2CreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageUsageFlags2CreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags2KHR</c> specifying allowed usages of the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags2KHR Usage;
    }
}
