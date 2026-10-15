namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingInfoEXT.html">VkPastPresentationTimingInfoEXT</see> - Structure specifying swapchain present timing query parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPastPresentationTimingInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPastPresentationTimingInfoEXT {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkPastPresentationTimingFlagsEXT    flags;
    ///             VkSwapchainKHR                      swapchain;
    ///         } VkPastPresentationTimingInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPastPresentationTimingInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PastPresentationTimingInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPastPresentationTimingFlagsEXT</c> specifying options for queries of past presentation timing information.
        /// </summary>
        [FieldOffset(16)]
        public VkPastPresentationTimingFlagsEXT Flags;

        /// <summary>
        ///     <c>Swapchain</c> is the swapchain to obtain presentation timing information for.
        /// </summary>
        [FieldOffset(24)]
        public VkSwapchainKHR Swapchain;
    }
}
