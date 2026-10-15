namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainLatencyCreateInfoNV.html">VkSwapchainLatencyCreateInfoNV</see> - Specify that a swapchain will use low latency mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To allow low latency mode to be used by a swapchain, add a
    ///         <c>VkSwapchainLatencyCreateInfoNV</c> structure to the <c>pNext</c> chain of
    ///         <c>VkSwapchainCreateInfoKHR</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSwapchainLatencyCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkSwapchainLatencyCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           latencyModeEnable;
    ///         } VkSwapchainLatencyCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSwapchainLatencyCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainLatencyCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LatencyModeEnable</c> is <c>VK_TRUE</c> if the created swapchain will utilize low latency mode, <c>VK_FALSE</c> otherwise.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LatencyModeEnable;
    }
}
