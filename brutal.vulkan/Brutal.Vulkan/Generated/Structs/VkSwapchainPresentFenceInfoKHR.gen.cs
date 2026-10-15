namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentFenceInfoKHR.html">VkSwapchainPresentFenceInfoKHR</see> - Fences associated with a vkQueuePresentKHR operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainPresentFenceInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkSwapchainPresentFenceInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           swapchainCount;
    ///             const VkFence*     pFences;
    ///         } VkSwapchainPresentFenceInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSwapchainPresentFenceInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainPresentFenceInfoKHR;

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
        ///     <c>Fences</c> is a list of fences with <c>swapchainCount</c> entries. Each entry <i>must</i> be <c>VK_NULL_HANDLE</c> or the handle of a fence to signal when the relevant operations on the associated swapchain have completed.
        /// </summary>
        [FieldOffset(24)]
        public VkFence* Fences;
    }
}
