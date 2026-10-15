namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiPropertiesKHR.html">VkPhysicalDeviceLayeredApiPropertiesKHR</see> - Structure describing a single layered implementation underneath the Vulkan physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLayeredApiPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance7
    ///         typedef struct VkPhysicalDeviceLayeredApiPropertiesKHR {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
    ///             uint32_t                         vendorID;
    ///             uint32_t                         deviceID;
    ///             VkPhysicalDeviceLayeredApiKHR    layeredAPI;
    ///             char                             deviceName[VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
    ///         } VkPhysicalDeviceLayeredApiPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLayeredApiPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VendorID</c> is a unique identifier for the vendor of the layered implementation.
        /// </summary>
        [FieldOffset(16)]
        public int VendorID;

        /// <summary>
        ///     <c>DeviceID</c> is a unique identifier for the layered implementation among devices available from the vendor.
        /// </summary>
        [FieldOffset(20)]
        public int DeviceID;

        /// <summary>
        ///     <c>LayeredAPI</c> is a <c>VkPhysicalDeviceLayeredApiKHR</c> specifying the API implemented by the layered implementation.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDeviceLayeredApiKHR LayeredAPI;

        ///
        [FieldOffset(28)]
        public fixed byte DeviceName[256];
    }
}
