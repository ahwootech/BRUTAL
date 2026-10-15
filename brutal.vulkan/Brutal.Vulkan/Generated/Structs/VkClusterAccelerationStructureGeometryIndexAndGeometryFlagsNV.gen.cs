namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV.html">VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV</see> - Parameters describing geometry index and flags values for cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV {
    ///             uint32_t    geometryIndex:24;
    ///             uint32_t    reserved:5;
    ///             uint32_t    geometryFlags:3;
    ///         } VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV()
    {
        /// <summary>
        ///     <c>GeometryIndex</c> specifies the geometry index for all triangles in the cluster acceleration structure.
        /// </summary>
        [FieldOffset(0)]
        private int _geometryIndex;

        /// <summary>
        ///     <c>Reserved</c> is reserved for future use.
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;

        /// <summary>
        ///     <c>GeometryFlags</c> is a bitmask of <c>VkClusterAccelerationStructureGeometryFlagsNV</c> values describing geometry flags for the cluster acceleration structure.
        /// </summary>
        [FieldOffset(0)]
        private int _geometryFlags;
    }

    public partial struct VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
    {
        /// <inheritdoc cref="_geometryIndex"/>
        public int GeometryIndex
        {
            get => BitFields.ExtractRange(_geometryIndex, start: 0, length: 24);
            set => BitFields.SetRange(ref _geometryIndex, start: 0, length: 24, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 24, length: 5);
            set => BitFields.SetRange(ref _reserved, start: 24, length: 5, value);
        }

        /// <inheritdoc cref="_geometryFlags"/>
        public int GeometryFlags
        {
            get => BitFields.ExtractRange(_geometryFlags, start: 29, length: 3);
            set => BitFields.SetRange(ref _geometryFlags, start: 29, length: 3, value);
        }
    }
}
