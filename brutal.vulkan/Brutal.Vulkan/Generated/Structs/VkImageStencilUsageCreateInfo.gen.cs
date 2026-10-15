namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageStencilUsageCreateInfo.html">VkImageStencilUsageCreateInfo</see> - Specify separate usage flags for the stencil aspect of a depth-stencil image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageStencilUsageCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkImageStencilUsageCreateInfo {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkImageUsageFlags    stencilUsage;
    ///         } VkImageStencilUsageCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageStencilUsageCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageStencilUsageCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StencilUsage</c> is a bitmask of <c>VkImageUsageFlags</c> describing the intended usage of the stencil aspect of the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags StencilUsage;
    }
}
