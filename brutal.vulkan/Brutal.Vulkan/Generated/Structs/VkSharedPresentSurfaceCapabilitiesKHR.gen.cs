namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSharedPresentSurfaceCapabilitiesKHR.html">VkSharedPresentSurfaceCapabilitiesKHR</see> - Structure describing capabilities of a surface for shared presentation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSharedPresentSurfaceCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shared_presentable_image
    ///         typedef struct VkSharedPresentSurfaceCapabilitiesKHR {
    ///             VkStructureType      sType;
    ///             void*                pNext;
    ///             VkImageUsageFlags    sharedPresentSupportedUsageFlags;
    ///         } VkSharedPresentSurfaceCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SharedPresentSupportedUsageFlags</c> is a bitmask of <c>VkImageUsageFlags</c> representing the ways the application <i>can</i> use the shared presentable image from a swapchain created with <c>VkPresentModeKHR</c> set to <c>VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR</c> or <c>VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR</c> for the surface on the specified device. <c>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT</c> <i>must</i> be included in the set but implementations may: support additional usages.
        /// </summary>
        [FieldOffset(16)]
        public VkImageUsageFlags SharedPresentSupportedUsageFlags;
    }
}
