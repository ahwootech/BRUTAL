namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewUsage2CreateInfoKHR.html">VkImageViewUsage2CreateInfoKHR</see> - Specify the intended usage of an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The set of usages for the created image view <i>can</i> be restricted compared to
    ///         the parent image&apos;s <c>usage</c> flags by adding a
    ///         <c>VkImageViewUsage2CreateInfoKHR</c> structure to the <c>pNext</c> chain of
    ///         <c>VkImageViewCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageViewUsage2CreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         typedef struct VkImageViewUsage2CreateInfoKHR {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkImageUsageFlags2KHR    usage;
    ///         } VkImageViewUsage2CreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewUsage2CreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewUsage2CreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags2KHR</c> specifying allowed usages of the image view.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags2KHR Usage;
    }
}
