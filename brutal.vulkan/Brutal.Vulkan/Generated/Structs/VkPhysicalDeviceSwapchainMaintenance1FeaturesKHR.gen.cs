namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR.html">VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR</see> - Structure describing whether implementation supports swapchain maintenance1 functionality
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           swapchainMaintenance1;
    ///         } VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSwapchainMaintenance1FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSwapchainMaintenance1FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainMaintenance1</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SwapchainMaintenance1;
    }
}
