namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupSwapchainCreateInfoKHR.html">VkDeviceGroupSwapchainCreateInfoKHR</see> - Structure specifying parameters of a newly created swapchain object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSwapchainCreateInfoKHR</c> includes a
    ///         <c>VkDeviceGroupSwapchainCreateInfoKHR</c> structure, then that structure
    ///         includes a set of device group present modes that the swapchain <i>can</i> be used
    ///         with.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupSwapchainCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///         typedef struct VkDeviceGroupSwapchainCreateInfoKHR {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkDeviceGroupPresentModeFlagsKHR    modes;
    ///         } VkDeviceGroupSwapchainCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Modes</c> is a bitfield of modes that the swapchain <i>can</i> be used with.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceGroupPresentModeFlagsKHR Modes;
    }
}
