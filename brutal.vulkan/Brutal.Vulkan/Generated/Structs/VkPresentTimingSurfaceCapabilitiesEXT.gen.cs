namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimingSurfaceCapabilitiesEXT.html">VkPresentTimingSurfaceCapabilitiesEXT</see> - Structure describing present timing capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentTimingSurfaceCapabilitiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPresentTimingSurfaceCapabilitiesEXT {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             VkBool32                  presentTimingSupported;
    ///             VkBool32                  presentAtAbsoluteTimeSupported;
    ///             VkBool32                  presentAtRelativeTimeSupported;
    ///             VkPresentStageFlagsEXT    presentStageQueries;
    ///         } VkPresentTimingSurfaceCapabilitiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentTimingSurfaceCapabilitiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentTimingSurfaceCapabilitiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentTimingSupported</c> indicates whether querying presentation timestamps is supported for a swapchain created from <c>VkPhysicalDeviceSurfaceInfo2KHR::surface</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentTimingSupported;

        /// <summary>
        ///     <c>PresentAtAbsoluteTimeSupported</c> indicates whether a swapchain created from <c>VkPhysicalDeviceSurfaceInfo2KHR::surface</c> supports presenting images with absolute times.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PresentAtAbsoluteTimeSupported;

        /// <summary>
        ///     <c>PresentAtRelativeTimeSupported</c> indicates whether a swapchain created from <c>VkPhysicalDeviceSurfaceInfo2KHR::surface</c> supports presenting images with relative times.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 PresentAtRelativeTimeSupported;

        /// <summary>
        ///     <c>PresentStageQueries</c> is a bitmask of <c>VkPresentStageFlagsEXT</c> indicating which present stages a swapchain created from <c>VkPhysicalDeviceSurfaceInfo2KHR::surface</c> is able to provide timing information for.
        /// </summary>
        [FieldOffset(28)]
        public VkPresentStageFlagsEXT PresentStageQueries;
    }
}
