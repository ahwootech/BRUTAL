namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryAabbsDataKHR.html">VkAccelerationStructureGeometryAabbsDataKHR</see> - Structure specifying axis-aligned bounding box geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryAabbsDataKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryAabbsDataKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureGeometryAabbsDataKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDeviceOrHostAddressConstKHR    data;
    ///             VkDeviceSize                     stride;
    ///         } VkAccelerationStructureGeometryAabbsDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryAabbsDataKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Data</c> is a device or host address of memory containing <c>VkAabbPositionsKHR</c> structures containing position data for each axis-aligned bounding box in the geometry.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceOrHostAddressConstKHR Data;

        /// <summary>
        ///     <c>Stride</c> is the stride in bytes between each entry in <c>data</c>. The stride <i>must</i> be a multiple of `8`.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Stride;
    }
}
