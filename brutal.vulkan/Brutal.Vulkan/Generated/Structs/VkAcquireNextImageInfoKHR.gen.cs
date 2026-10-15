namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAcquireNextImageInfoKHR.html">VkAcquireNextImageInfoKHR</see> - Structure specifying parameters of the acquire
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAcquireNextImageInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///         typedef struct VkAcquireNextImageInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSwapchainKHR     swapchain;
    ///             uint64_t           timeout;
    ///             VkSemaphore        semaphore;
    ///             VkFence            fence;
    ///             uint32_t           deviceMask;
    ///         } VkAcquireNextImageInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkAcquireNextImageInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AcquireNextImageInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Swapchain</c> is a non-retired swapchain from which an image is acquired.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainKHR Swapchain;

        /// <summary>
        ///     <c>Timeout</c> specifies how long the function waits, in nanoseconds, if no image is available.
        /// </summary>
        [FieldOffset(24)]
        public nint Timeout;

        /// <summary>
        ///     <c>Semaphore</c> is <c>VK_NULL_HANDLE</c> or a semaphore that defines a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-signaling">semaphore signal operation^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Fence</c> is <c>VK_NULL_HANDLE</c> or a fence to signal.
        /// </summary>
        [FieldOffset(40)]
        public VkFence Fence;

        /// <summary>
        ///     <c>DeviceMask</c> is a mask of physical devices for which the swapchain image will be ready to use when the semaphore or fence is signaled.
        /// </summary>
        [FieldOffset(48)]
        public int DeviceMask;
    }
}
