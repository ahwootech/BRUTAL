namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageStencilUsage2CreateInfoKHR.html">VkImageStencilUsage2CreateInfoKHR</see> - Specify separate 64-bit usage flags for the stencil aspect of a depth-stencil image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageStencilUsage2CreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags with VK_VERSION_1_2 or VK_EXT_separate_stencil_usage
    ///         typedef struct VkImageStencilUsage2CreateInfoKHR {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkImageUsageFlags2KHR    stencilUsage;
    ///         } VkImageStencilUsage2CreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageStencilUsage2CreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageStencilUsage2CreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StencilUsage</c> is a bitmask of <c>VkImageUsageFlags2KHR</c> describing the intended usage of the stencil aspect of the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags2KHR StencilUsage;
    }
}
