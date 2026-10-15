namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentModesCreateInfoKHR.html">VkSwapchainPresentModesCreateInfoKHR</see> - All presentation modes usable by the swapchain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Applications <i>can</i> modify the presentation mode used by the swapchain on a
    ///         per-presentation basis.
    ///         However, all presentation modes the application intends to use with the
    ///         swapchain <i>must</i> be specified at swapchain creation time.
    ///         To specify more than one presentation mode when creating a swapchain,
    ///         include the <c>VkSwapchainPresentModesCreateInfoKHR</c> structure in the
    ///         <c>pNext</c> chain of the <c>VkSwapchainCreateInfoKHR</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkSwapchainPresentModesCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkSwapchainPresentModesCreateInfoKHR {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             uint32_t                   presentModeCount;
    ///             const VkPresentModeKHR*    pPresentModes;
    ///         } VkSwapchainPresentModesCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSwapchainPresentModesCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainPresentModesCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentModeCount</c> is the number of presentation modes provided.
        /// </summary>
        [FieldOffset(16)]
        public int PresentModeCount;

        /// <summary>
        ///     <c>PresentModes</c> is a list of presentation modes with <c>presentModeCount</c> entries
        /// </summary>
        [FieldOffset(24)]
        public VkPresentModeKHR* PresentModes;
    }
}
