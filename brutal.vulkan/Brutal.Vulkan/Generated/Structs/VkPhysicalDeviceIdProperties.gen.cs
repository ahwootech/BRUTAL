namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceIDProperties.html">VkPhysicalDeviceIDProperties</see> - Structure specifying IDs related to the physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceIDProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceIDProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint8_t            deviceUUID[VK_UUID_SIZE];
    ///             uint8_t            driverUUID[VK_UUID_SIZE];
    ///             uint8_t            deviceLUID[VK_LUID_SIZE];
    ///             uint32_t           deviceNodeMask;
    ///             VkBool32           deviceLUIDValid;
    ///         } VkPhysicalDeviceIDProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceIdProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceIdProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte DeviceUUID[16];

        ///
        [FieldOffset(32)]
        public fixed byte DriverUUID[16];

        ///
        [FieldOffset(48)]
        public fixed byte DeviceLUID[8];

        /// <summary>
        ///     <c>DeviceNodeMask</c>
        /// </summary>
        [FieldOffset(56)]
        public int DeviceNodeMask;

        /// <summary>
        ///     <c>DeviceLUIDValid</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 DeviceLUIDValid;
    }
}
