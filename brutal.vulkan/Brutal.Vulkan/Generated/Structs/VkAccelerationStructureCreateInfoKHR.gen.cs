namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateInfoKHR.html">VkAccelerationStructureCreateInfoKHR</see> - Structure specifying the parameters of a newly created acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureCreateInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureCreateInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkAccelerationStructureCreateFlagsKHR    createFlags;
    ///             VkBuffer                                 buffer;
    ///             VkDeviceSize                             offset;
    ///             VkDeviceSize                             size;
    ///             VkAccelerationStructureTypeKHR           type;
    ///             VkDeviceAddress                          deviceAddress;
    ///         } VkAccelerationStructureCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkAccelerationStructureCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureCreateInfoKHR;

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
        ///     <c>Buffer</c> is the buffer on which the acceleration structure will be stored.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is an offset in bytes from the base address of the buffer at which the acceleration structure will be stored, and <i>must</i> be a multiple of `256`.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is the size required for the acceleration structure.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Type</c> is a <c>VkAccelerationStructureTypeKHR</c> value specifying the type of acceleration structure that will be created.
        /// </summary>
        [FieldOffset(48)]
        public VkAccelerationStructureTypeKHR Type;

        /// <summary>
        ///     <c>DeviceAddress</c> is the device address requested for the acceleration structure, obtained from <c>vkGetAccelerationStructureDeviceAddressKHR</c>, if the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-accelerationStructureCaptureReplay"><c>accelerationStructureCaptureReplay</c>^</see> feature is being used. If <c>deviceAddress</c> is zero, no specific address is requested.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress DeviceAddress;
    }
}
