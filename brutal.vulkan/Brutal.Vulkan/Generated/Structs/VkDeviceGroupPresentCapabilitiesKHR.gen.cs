namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupPresentCapabilitiesKHR.html">VkDeviceGroupPresentCapabilitiesKHR</see> - Present capabilities from other physical devices
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceGroupPresentCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_surface
    ///         typedef struct VkDeviceGroupPresentCapabilitiesKHR {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             uint32_t                            presentMask[VK_MAX_DEVICE_GROUP_SIZE];
    ///             VkDeviceGroupPresentModeFlagsKHR    modes;
    ///         } VkDeviceGroupPresentCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupPresentCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed int PresentMask[32];

        /// <summary>
        ///     <c>Modes</c> is a bitmask of <c>VkDeviceGroupPresentModeFlagsKHR</c> indicating which device group presentation modes are supported.
        /// </summary>
        [FieldOffset(144)]
        public VkDeviceGroupPresentModeFlagsKHR Modes;
    }
}
