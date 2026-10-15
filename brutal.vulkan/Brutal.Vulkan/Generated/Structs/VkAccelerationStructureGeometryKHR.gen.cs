namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryKHR.html">VkAccelerationStructureGeometryKHR</see> - Structure specifying geometries to be built into an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureGeometryKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkGeometryTypeKHR                         geometryType;
    ///             VkAccelerationStructureGeometryDataKHR    geometry;
    ///             VkGeometryFlagsKHR                        flags;
    ///         } VkAccelerationStructureGeometryKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkAccelerationStructureGeometryKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GeometryType</c> describes which type of geometry this <c>VkAccelerationStructureGeometryKHR</c> refers to.
        /// </summary>
        [FieldOffset(16)]
        public VkGeometryTypeKHR GeometryType;

        /// <summary>
        ///     <c>Geometry</c> is a <c>VkAccelerationStructureGeometryDataKHR</c> union describing the geometry data for the relevant geometry type.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureGeometryDataKHR Geometry;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkGeometryFlagsKHR</c> values describing additional properties of how the geometry should be built.
        /// </summary>
        [FieldOffset(88)]
        public VkGeometryFlagsKHR Flags;
    }
}
