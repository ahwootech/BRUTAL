namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSharedPresentSurfaceCapabilities2KHR.html">VkSharedPresentSurfaceCapabilities2KHR</see> - Structure describing capabilities of a surface for shared presentation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSharedPresentSurfaceCapabilities2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags with VK_KHR_shared_presentable_image
    ///         typedef struct VkSharedPresentSurfaceCapabilities2KHR {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkImageUsageFlags2KHR    sharedPresentSupportedUsageFlags;
    ///         } VkSharedPresentSurfaceCapabilities2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSharedPresentSurfaceCapabilities2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SharedPresentSurfaceCapabilities2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SharedPresentSupportedUsageFlags</c> is a bitmask of <c>VkImageUsageFlags2KHR</c> representing the ways the application <i>can</i> use the shared presentable image from a swapchain created with <c>VkPresentModeKHR</c> set to <c>VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR</c> or <c>VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR</c> for the surface on the specified device. <c>VK_IMAGE_USAGE_2_COLOR_ATTACHMENT_BIT_KHR</c> <i>must</i> be included in the set but implementations may: support additional usages.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags2KHR SharedPresentSupportedUsageFlags;
    }
}
