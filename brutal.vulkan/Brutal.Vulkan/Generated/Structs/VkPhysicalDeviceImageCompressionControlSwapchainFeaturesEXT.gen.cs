namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT.html">VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT</see> - Structure describing whether per-swapchain image compression controls can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_compression_control_swapchain
    ///         typedef struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           imageCompressionControlSwapchain;
    ///         } VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageCompressionControlSwapchain</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ImageCompressionControlSwapchain;
    }
}
