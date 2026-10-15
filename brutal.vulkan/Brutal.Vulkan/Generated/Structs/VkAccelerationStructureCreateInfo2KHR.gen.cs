namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateInfo2KHR.html">VkAccelerationStructureCreateInfo2KHR</see> - Structure specifying the parameters of a newly created acceleration structure object using a device address
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureCreateInfo2KHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureCreateInfo2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure with VK_KHR_device_address_commands
    ///         typedef struct VkAccelerationStructureCreateInfo2KHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkAccelerationStructureCreateFlagsKHR    createFlags;
    ///             VkDeviceAddressRangeKHR                  addressRange;
    ///             VkAddressCommandFlagsKHR                 addressFlags;
    ///             VkAccelerationStructureTypeKHR           type;
    ///         } VkAccelerationStructureCreateInfo2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkAccelerationStructureCreateInfo2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureCreateInfo2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CreateFlags</c> is a bitmask of <c>VkAccelerationStructureCreateFlagsKHR</c> specifying additional creation parameters of the acceleration structure.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureCreateFlagsKHR CreateFlags;

        /// <summary>
        ///     <c>AddressRange</c> is a <c>VkDeviceAddressRangeKHR</c> structure defining the size required for the acceleration structure and its starting address.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(40)]
        public VkAddressCommandFlagsKHR AddressFlags;

        /// <summary>
        ///     <c>Type</c> is a <c>VkAccelerationStructureTypeKHR</c> value specifying the type of acceleration structure that will be created.
        /// </summary>
        [FieldOffset(44)]
        public VkAccelerationStructureTypeKHR Type;
    }
}
