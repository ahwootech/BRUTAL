namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainKHR.html">VkSwapchainKHR</see> - Opaque handle to a swapchain object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A swapchain object (a.k.a.
    ///         swapchain) provides the ability to present rendering results to a surface.
    ///         Swapchain objects are represented by <c>VkSwapchainKHR</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkSwapchainKHR)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkSwapchainKHR : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.SwapchainKHR;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkSwapchainKHR(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkSwapchainKHR NullHandle = new();
    }
}
