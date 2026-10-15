namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryInstancesDataKHR.html">VkAccelerationStructureGeometryInstancesDataKHR</see> - Structure specifying a geometry consisting of instances of other acceleration structures
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryInstancesDataKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryInstancesDataKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureGeometryInstancesDataKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkBool32                         arrayOfPointers;
    ///             VkDeviceOrHostAddressConstKHR    data;
    ///         } VkAccelerationStructureGeometryInstancesDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryInstancesDataKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ArrayOfPointers</c> specifies whether <c>data</c> is used as an array of addresses or just an array.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ArrayOfPointers;

        /// <summary>
        ///     <c>Data</c> is either the address of an array of device or host addresses referencing individual <c>VkAccelerationStructureInstanceKHR</c> structures if <c>arrayOfPointers</c> is <c>VK_TRUE</c>, or the address of an array of <c>VkAccelerationStructureInstanceKHR</c> structures. Addresses and <c>VkAccelerationStructureInstanceKHR</c> structures are tightly packed.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR Data;
    }
}
