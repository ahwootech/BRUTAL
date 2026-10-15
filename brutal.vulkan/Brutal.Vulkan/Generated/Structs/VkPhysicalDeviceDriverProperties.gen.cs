namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDriverProperties.html">VkPhysicalDeviceDriverProperties</see> - Structure containing driver identification information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDriverProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceDriverProperties {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             VkDriverId              driverID;
    ///             char                    driverName[VK_MAX_DRIVER_NAME_SIZE];
    ///             char                    driverInfo[VK_MAX_DRIVER_INFO_SIZE];
    ///             VkConformanceVersion    conformanceVersion;
    ///         } VkPhysicalDeviceDriverProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 536)]
    public unsafe partial struct VkPhysicalDeviceDriverProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDriverProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DriverID</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDriverId DriverID;

        ///
        [FieldOffset(20)]
        public fixed byte DriverName[256];

        ///
        [FieldOffset(276)]
        public fixed byte DriverInfo[256];

        /// <summary>
        ///     <c>ConformanceVersion</c>
        /// </summary>
        [FieldOffset(532)]
        public VkConformanceVersion ConformanceVersion;
    }
}
