namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupDeviceCreateInfo.html">VkDeviceGroupDeviceCreateInfo</see> - Create a logical device from multiple physical devices
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A logical device <i>can</i> be created that connects to one or more physical
    ///         devices by adding a <c>VkDeviceGroupDeviceCreateInfo</c> structure to the
    ///         <c>pNext</c> chain of <c>VkDeviceCreateInfo</c>.
    ///         The <c>VkDeviceGroupDeviceCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceGroupDeviceCreateInfo {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             uint32_t                   physicalDeviceCount;
    ///             const VkPhysicalDevice*    pPhysicalDevices;
    ///         } VkDeviceGroupDeviceCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceGroupDeviceCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupDeviceCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PhysicalDeviceCount</c> is the number of elements in the <c>pPhysicalDevices</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int PhysicalDeviceCount;

        /// <summary>
        ///     <c>PhysicalDevices</c> is a pointer to an array of physical device handles belonging to the same device group.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDevice* PhysicalDevices;
    }
}
