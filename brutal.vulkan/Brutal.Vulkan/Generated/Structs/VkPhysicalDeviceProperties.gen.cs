namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProperties.html">VkPhysicalDeviceProperties</see> - Structure specifying physical device properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPhysicalDeviceProperties {
    ///             uint32_t                            apiVersion;
    ///             uint32_t                            driverVersion;
    ///             uint32_t                            vendorID;
    ///             uint32_t                            deviceID;
    ///             VkPhysicalDeviceType                deviceType;
    ///             char                                deviceName[VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
    ///             uint8_t                             pipelineCacheUUID[VK_UUID_SIZE];
    ///             VkPhysicalDeviceLimits              limits;
    ///             VkPhysicalDeviceSparseProperties    sparseProperties;
    ///         } VkPhysicalDeviceProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 824)]
    public unsafe partial struct VkPhysicalDeviceProperties()
    {
        /// <summary>
        ///     <c>ApiVersion</c> is the version of Vulkan supported by the device, encoded as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-coreversions-versionnumbers">here</see>.
        /// </summary>
        [FieldOffset(0)]
        public int ApiVersion;

        /// <summary>
        ///     <c>DriverVersion</c> is the vendor-specified version of the driver.
        /// </summary>
        [FieldOffset(4)]
        public int DriverVersion;

        /// <summary>
        ///     <c>VendorID</c> is a unique identifier for the <i>vendor</i> (see below) of the physical device.
        /// </summary>
        [FieldOffset(8)]
        public int VendorID;

        /// <summary>
        ///     <c>DeviceID</c> is a unique identifier for the physical device among devices available from the vendor.
        /// </summary>
        [FieldOffset(12)]
        public int DeviceID;

        /// <summary>
        ///     <c>DeviceType</c> is a <c>VkPhysicalDeviceType</c> specifying the type of device.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceType DeviceType;

        ///
        [FieldOffset(20)]
        public fixed byte DeviceName[256];

        ///
        [FieldOffset(276)]
        public fixed byte PipelineCacheUUID[16];

        /// <summary>
        ///     <c>Limits</c> is the <c>VkPhysicalDeviceLimits</c> structure specifying device-specific limits of the physical device. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits">Limits^</see> for details.
        /// </summary>
        [FieldOffset(296)]
        public VkPhysicalDeviceLimits Limits;

        /// <summary>
        ///     <c>SparseProperties</c> is the <c>VkPhysicalDeviceSparseProperties</c> structure specifying various sparse related properties of the physical device. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory-physicalprops">Sparse Properties^</see> for details.
        /// </summary>
        [FieldOffset(800)]
        public VkPhysicalDeviceSparseProperties SparseProperties;
    }
}
