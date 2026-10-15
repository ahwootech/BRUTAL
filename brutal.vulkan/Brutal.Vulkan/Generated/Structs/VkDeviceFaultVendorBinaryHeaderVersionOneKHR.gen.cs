namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorBinaryHeaderVersionOneKHR.html">VkDeviceFaultVendorBinaryHeaderVersionOneKHR</see> - Structure describing the layout of the vendor binary crash dump header
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Version one of the crash dump header is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkDeviceFaultVendorBinaryHeaderVersionOneKHR {
    ///             uint32_t                                     headerSize;
    ///             VkDeviceFaultVendorBinaryHeaderVersionKHR    headerVersion;
    ///             uint32_t                                     vendorID;
    ///             uint32_t                                     deviceID;
    ///             uint32_t                                     driverVersion;
    ///             uint8_t                                      pipelineCacheUUID[VK_UUID_SIZE];
    ///             uint32_t                                     applicationNameOffset;
    ///             uint32_t                                     applicationVersion;
    ///             uint32_t                                     engineNameOffset;
    ///             uint32_t                                     engineVersion;
    ///             uint32_t                                     apiVersion;
    ///         } VkDeviceFaultVendorBinaryHeaderVersionOneKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneKHR()
    {
        /// <summary>
        ///     <c>HeaderSize</c> is the length in bytes of the crash dump header.
        /// </summary>
        [FieldOffset(0)]
        public int HeaderSize;

        /// <summary>
        ///     <c>HeaderVersion</c> is a <c>VkDeviceFaultVendorBinaryHeaderVersionKHR</c> enum value specifying the version of the header. A consumer of the crash dump <i>should</i> use the header version to interpret the remainder of the header. <c>headerVersion</c> <i>must</i> be written as exactly 4 bytes.
        /// </summary>
        [FieldOffset(4)]
        public VkDeviceFaultVendorBinaryHeaderVersionKHR HeaderVersion;

        /// <summary>
        ///     <c>VendorID</c> is the <c>VkPhysicalDeviceProperties::vendorID</c> of the implementation.
        /// </summary>
        [FieldOffset(8)]
        public int VendorID;

        /// <summary>
        ///     <c>DeviceID</c> is the <c>VkPhysicalDeviceProperties::deviceID</c> of the implementation.
        /// </summary>
        [FieldOffset(12)]
        public int DeviceID;

        /// <summary>
        ///     <c>DriverVersion</c> is the <c>VkPhysicalDeviceProperties::driverVersion</c> of the implementation.
        /// </summary>
        [FieldOffset(16)]
        public int DriverVersion;

        ///
        [FieldOffset(20)]
        public fixed byte PipelineCacheUUID[16];

        /// <summary>
        ///     <c>ApplicationNameOffset</c> is zero, or an offset from the base address of the crash dump header to a null-terminated UTF-8 string containing the name of the application. If <c>applicationNameOffset</c> is non-zero, this string <i>must</i> match the application name specified via <c>VkApplicationInfo::pApplicationName</c> during instance creation.
        /// </summary>
        [FieldOffset(36)]
        public int ApplicationNameOffset;

        /// <summary>
        ///     <c>ApplicationVersion</c> <i>must</i> be zero or the value specified by <c>VkApplicationInfo::applicationVersion</c> during instance creation.
        /// </summary>
        [FieldOffset(40)]
        public int ApplicationVersion;

        /// <summary>
        ///     <c>EngineNameOffset</c> is zero, or an offset from the base address of the crash dump header to a null-terminated UTF-8 string containing the name of the engine (if any) used to create the application. If <c>engineNameOffset</c> is non-zero, this string <i>must</i> match the engine name specified via <c>VkApplicationInfo::pEngineName</c> during instance creation.
        /// </summary>
        [FieldOffset(44)]
        public int EngineNameOffset;

        /// <summary>
        ///     <c>EngineVersion</c> <i>must</i> be zero or the value specified by <c>VkApplicationInfo::engineVersion</c> during instance creation.
        /// </summary>
        [FieldOffset(48)]
        public int EngineVersion;

        /// <summary>
        ///     <c>ApiVersion</c> <i>must</i> be zero or the value specified by <c>VkApplicationInfo::apiVersion</c> during instance creation.
        /// </summary>
        [FieldOffset(52)]
        public int ApiVersion;
    }
}
