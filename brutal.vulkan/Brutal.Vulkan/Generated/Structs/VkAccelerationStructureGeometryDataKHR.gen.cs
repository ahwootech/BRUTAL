namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryDataKHR.html">VkAccelerationStructureGeometryDataKHR</see> - Union specifying acceleration structure geometry data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryDataKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryDataKHR</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef union VkAccelerationStructureGeometryDataKHR {
    ///             VkAccelerationStructureGeometryTrianglesDataKHR    triangles;
    ///             VkAccelerationStructureGeometryAabbsDataKHR        aabbs;
    ///             VkAccelerationStructureGeometryInstancesDataKHR    instances;
    ///         } VkAccelerationStructureGeometryDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct VkAccelerationStructureGeometryDataKHR()
    {
        /// <summary>
        ///     <c>Triangles</c> is a <c>VkAccelerationStructureGeometryTrianglesDataKHR</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryTrianglesDataKHR Triangles;

        /// <summary>
        ///     <c>Aabbs</c> is a <c>VkAccelerationStructureGeometryAabbsDataKHR</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryAabbsDataKHR Aabbs;

        /// <summary>
        ///     <c>Instances</c> is a <c>VkAccelerationStructureGeometryInstancesDataKHR</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryInstancesDataKHR Instances;
    }
}
