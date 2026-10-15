namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureDeviceAddressInfoKHR.html">VkAccelerationStructureDeviceAddressInfoKHR</see> - Structure specifying the acceleration structure to query an address for
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureDeviceAddressInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureDeviceAddressInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureDeviceAddressInfoKHR {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkAccelerationStructureKHR    accelerationStructure;
    ///         } VkAccelerationStructureDeviceAddressInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureDeviceAddressInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructure</c> specifies the acceleration structure whose address is being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureKHR AccelerationStructure;
    }
}
