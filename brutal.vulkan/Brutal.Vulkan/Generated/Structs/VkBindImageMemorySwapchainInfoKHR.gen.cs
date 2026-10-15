namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindImageMemorySwapchainInfoKHR.html">VkBindImageMemorySwapchainInfoKHR</see> - Structure specifying swapchain image memory to bind to
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkBindImageMemoryInfo</c> includes a
    ///         <c>VkBindImageMemorySwapchainInfoKHR</c> structure, then that structure
    ///         includes a swapchain handle and image index indicating that the image will
    ///         be bound to memory from that swapchain.
    ///     </para>
    ///     <para>
    ///         The <c>VkBindImageMemorySwapchainInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///         typedef struct VkBindImageMemorySwapchainInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSwapchainKHR     swapchain;
    ///             uint32_t           imageIndex;
    ///         } VkBindImageMemorySwapchainInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindImageMemorySwapchainInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Swapchain</c> is <c>VK_NULL_HANDLE</c> or a swapchain handle.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainKHR Swapchain;

        /// <summary>
        ///     <c>ImageIndex</c> is an image index within <c>swapchain</c>.
        /// </summary>
        [FieldOffset(24)]
        public int ImageIndex;
    }
}
