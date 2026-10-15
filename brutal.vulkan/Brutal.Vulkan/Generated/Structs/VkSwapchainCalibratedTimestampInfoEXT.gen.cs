namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainCalibratedTimestampInfoEXT.html">VkSwapchainCalibratedTimestampInfoEXT</see> - Structure specifying the swapchain to calibrate a swapchain-local timestamp query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainCalibratedTimestampInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkSwapchainCalibratedTimestampInfoEXT {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkSwapchainKHR            swapchain;
    ///             VkPresentStageFlagsEXT    presentStage;
    ///             uint64_t                  timeDomainId;
    ///         } VkSwapchainCalibratedTimestampInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSwapchainCalibratedTimestampInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainCalibratedTimestampInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Swapchain</c> is the swapchain to retrieve the swapchain-local timestamp from.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainKHR Swapchain;

        /// <summary>
        ///     <c>PresentStage</c> is zero or a <c>VkPresentStageFlagsEXT</c> value used to identify a single present stage when calibrating a timestamp in the <c>VK_TIME_DOMAIN_PRESENT_STAGE_LOCAL_EXT</c> time domain.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentStageFlagsEXT PresentStage;

        /// <summary>
        ///     <c>TimeDomainId</c> is the id for the opaque time domain being calibrated.
        /// </summary>
        [FieldOffset(32)]
        public nint TimeDomainId;
    }
}
