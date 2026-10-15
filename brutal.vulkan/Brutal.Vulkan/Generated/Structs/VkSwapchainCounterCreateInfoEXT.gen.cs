namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainCounterCreateInfoEXT.html">VkSwapchainCounterCreateInfoEXT</see> - Specify the surface counters desired
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To enable surface counters when creating a swapchain, add a
    ///         <c>VkSwapchainCounterCreateInfoEXT</c> structure to the <c>pNext</c> chain of
    ///         <c>VkSwapchainCreateInfoKHR</c>.
    ///         <c>VkSwapchainCounterCreateInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_display_control
    ///         typedef struct VkSwapchainCounterCreateInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkSurfaceCounterFlagsEXT    surfaceCounters;
    ///         } VkSwapchainCounterCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSwapchainCounterCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainCounterCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SurfaceCounters</c> is a bitmask of <c>VkSurfaceCounterFlagsEXT</c> specifying surface counters to enable for the swapchain.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceCounterFlagsEXT SurfaceCounters;
    }
}
