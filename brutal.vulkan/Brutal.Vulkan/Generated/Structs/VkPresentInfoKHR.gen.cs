namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentInfoKHR.html">VkPresentInfoKHR</see> - Structure describing parameters of a queue presentation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain
    ///         typedef struct VkPresentInfoKHR {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             uint32_t                 waitSemaphoreCount;
    ///             const VkSemaphore*       pWaitSemaphores;
    ///             uint32_t                 swapchainCount;
    ///             const VkSwapchainKHR*    pSwapchains;
    ///             const uint32_t*          pImageIndices;
    ///             VkResult*                pResults;
    ///         } VkPresentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPresentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreCount</c> is the number of semaphores to wait for before issuing the present request. The number may: be zero.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreCount;

        /// <summary>
        ///     <c>WaitSemaphores</c> is `NULL` or a pointer to an array of <c>VkSemaphore</c> objects with <c>waitSemaphoreCount</c> entries, and specifies the semaphores to wait for before issuing the present request.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphore* WaitSemaphores;

        /// <summary>
        ///     <c>SwapchainCount</c> is the number of swapchains being presented to by this command.
        /// </summary>
        [FieldOffset(32)]
        public int SwapchainCount;

        /// <summary>
        ///     <c>Swapchains</c> is a pointer to an array of <c>VkSwapchainKHR</c> objects with <c>swapchainCount</c> entries.
        /// </summary>
        [FieldOffset(40)]
        public VkSwapchainKHR* Swapchains;

        /// <summary>
        ///     <c>ImageIndices</c> is a pointer to an array of indices into the array of each swapchain&apos;s presentable images, with <c>swapchainCount</c> entries. Each entry in this array identifies the image to present on the corresponding entry in the <c>pSwapchains</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int* ImageIndices;

        /// <summary>
        ///     <c>Results</c> is a pointer to an array of <c>VkResult</c> typed elements with <c>swapchainCount</c> entries. Applications that do not need per-swapchain results <i>can</i> use `NULL` for <c>pResults</c>. If non-`NULL`, each entry in <c>pResults</c> will be set to the <c>VkResult</c> for presenting the swapchain corresponding to the same index in <c>pSwapchains</c>.
        /// </summary>
        [FieldOffset(56)]
        public VkResult* Results;
    }
}
