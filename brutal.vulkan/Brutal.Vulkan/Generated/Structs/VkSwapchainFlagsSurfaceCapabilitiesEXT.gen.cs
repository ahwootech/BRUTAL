namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainFlagsSurfaceCapabilitiesEXT.html">VkSwapchainFlagsSurfaceCapabilitiesEXT</see> - Structure describing supported swapchain create flags for a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainFlagsSurfaceCapabilitiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multisampled_render_to_swapchain
    ///         typedef struct VkSwapchainFlagsSurfaceCapabilitiesEXT {
    ///             VkStructureType              sType;
    ///             void*                        pNext;
    ///             VkSwapchainCreateFlagsKHR    swapchainSupportedFlags;
    ///         } VkSwapchainFlagsSurfaceCapabilitiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSwapchainFlagsSurfaceCapabilitiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainFlagsSurfaceCapabilitiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainSupportedFlags</c> is a bitmask of <c>VkSwapchainCreateFlagsKHR</c> representing the supported flags in <c>VkSwapchainCreateInfoKHR</c> when creating a swapchain for the surface on the specified device.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainCreateFlagsKHR SwapchainSupportedFlags;
    }
}
