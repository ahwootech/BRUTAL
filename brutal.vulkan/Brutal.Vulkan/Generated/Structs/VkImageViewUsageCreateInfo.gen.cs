namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewUsageCreateInfo.html">VkImageViewUsageCreateInfo</see> - Specify the intended usage of an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The set of usages for the created image view <i>can</i> be restricted compared to
    ///         the parent image&apos;s <c>usage</c> flags by adding a
    ///         <c>VkImageViewUsageCreateInfo</c> structure to the <c>pNext</c> chain of
    ///         <c>VkImageViewCreateInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageViewUsageCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkImageViewUsageCreateInfo {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkImageUsageFlags    usage;
    ///         } VkImageViewUsageCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewUsageCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewUsageCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags</c> specifying allowed usages of the image view.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags Usage;
    }
}
