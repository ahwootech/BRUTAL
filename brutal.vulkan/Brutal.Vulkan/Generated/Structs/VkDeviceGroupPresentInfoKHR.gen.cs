namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentInfoKHR.html">VkDeviceGroupPresentInfoKHR</see> - Mode and mask controlling which physical devices&amp;apos; images are presented
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPresentInfoKHR</c> includes a
    ///         <c>VkDeviceGroupPresentInfoKHR</c> structure, then that structure includes an
    ///         array of device masks and a device group present mode.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupPresentInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///         typedef struct VkDeviceGroupPresentInfoKHR {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             uint32_t                               swapchainCount;
    ///             const uint32_t*                        pDeviceMasks;
    ///             VkDeviceGroupPresentModeFlagBitsKHR    mode;
    ///         } VkDeviceGroupPresentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDeviceGroupPresentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupPresentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainCount</c> is zero or the number of elements in <c>pDeviceMasks</c>.
        /// </summary>
        [FieldOffset(16)]
        public int SwapchainCount;

        /// <summary>
        ///     <c>DeviceMasks</c> is a pointer to an array of device masks, one for each element of <c>VkPresentInfoKHR::pSwapchains</c>.
        /// </summary>
        [FieldOffset(24)]
        public int* DeviceMasks;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkDeviceGroupPresentModeFlagsKHR</c> value specifying the device group present mode that will be used for this present.
        /// </summary>
        [FieldOffset(32)]
        public VkDeviceGroupPresentModeFlagsKHR Mode;
    }
}
