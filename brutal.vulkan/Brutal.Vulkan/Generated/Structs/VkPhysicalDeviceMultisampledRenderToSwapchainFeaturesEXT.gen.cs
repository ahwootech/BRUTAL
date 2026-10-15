namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT.html">VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT</see> - Structure describing whether multisampled rendering to single-sampled attachments is supported on swapchain images
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multisampled_render_to_swapchain
    ///         typedef struct VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           multisampledRenderToSwapchain;
    ///         } VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MultisampledRenderToSwapchain</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MultisampledRenderToSwapchain;
    }
}
