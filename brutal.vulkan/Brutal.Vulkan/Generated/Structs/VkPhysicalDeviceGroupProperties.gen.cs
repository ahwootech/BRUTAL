namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGroupProperties.html">VkPhysicalDeviceGroupProperties</see> - Structure specifying physical device group properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceGroupProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceGroupProperties {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             uint32_t            physicalDeviceCount;
    ///             VkPhysicalDevice    physicalDevices[VK_MAX_DEVICE_GROUP_SIZE];
    ///             VkBool32            subsetAllocation;
    ///         } VkPhysicalDeviceGroupProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public unsafe partial struct VkPhysicalDeviceGroupProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceGroupProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PhysicalDeviceCount</c> is the number of physical devices in the group.
        /// </summary>
        [FieldOffset(16)]
        public int PhysicalDeviceCount;

        /// <summary>
        ///     <c>PhysicalDevices</c> is an array of <c>VK_MAX_DEVICE_GROUP_SIZE</c> <c>VkPhysicalDevice</c> handles representing all physical devices in the group. The first <c>physicalDeviceCount</c> elements of the array will be valid.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDevice_32 PhysicalDevices;

        /// <summary>
        ///     <c>SubsetAllocation</c> specifies whether logical devices created from the group support allocating device memory on a subset of devices, via the <c>deviceMask</c> member of the <c>VkMemoryAllocateFlagsInfo</c>. If this is <c>VK_FALSE</c>, then all device memory allocations are made across all physical devices in the group. If <c>physicalDeviceCount</c> is `1`, then <c>subsetAllocation</c> <i>must</i> be <c>VK_FALSE</c>.
        /// </summary>
        [FieldOffset(280)]
        public Brutal.Bool32 SubsetAllocation;
    }
}
