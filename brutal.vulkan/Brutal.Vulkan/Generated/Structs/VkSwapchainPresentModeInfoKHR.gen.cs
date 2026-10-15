namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentModeInfoKHR.html">VkSwapchainPresentModeInfoKHR</see> - Presentation modes for a vkQueuePresentKHR operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainPresentModeInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkSwapchainPresentModeInfoKHR {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             uint32_t                   swapchainCount;
    ///             const VkPresentModeKHR*    pPresentModes;
    ///         } VkSwapchainPresentModeInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSwapchainPresentModeInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainPresentModeInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainCount</c> is the number of swapchains being presented to by this command.
        /// </summary>
        [FieldOffset(16)]
        public int SwapchainCount;

        /// <summary>
        ///     <c>PresentModes</c> is a list of presentation modes with <c>swapchainCount</c> entries.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentModeKHR* PresentModes;
    }
}
