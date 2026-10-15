namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSwapchainCreateInfoKHR.html">VkImageSwapchainCreateInfoKHR</see> - Specify that an image will be bound to swapchain memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageSwapchainCreateInfoKHR</c> structure, then that structure includes
    ///         a swapchain handle indicating that the image will be bound to memory from
    ///         that swapchain.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageSwapchainCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///         typedef struct VkImageSwapchainCreateInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSwapchainKHR     swapchain;
    ///         } VkImageSwapchainCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageSwapchainCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageSwapchainCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Swapchain</c> is <c>VK_NULL_HANDLE</c> or a handle of a swapchain that the image will be bound to.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainKHR Swapchain;
    }
}
