namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryNV.html">VkGeometryNV</see> - Structure specifying a geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryNV
    ///     </para>
    ///     <para>
    ///         The <c>VkGeometryNV</c> structure describes geometry in a bottom-level
    ///         acceleration structure and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkGeometryNV {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkGeometryTypeKHR     geometryType;
    ///             VkGeometryDataNV      geometry;
    ///             VkGeometryFlagsKHR    flags;
    ///         } VkGeometryNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public unsafe partial struct VkGeometryNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeometryNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>GeometryType</c> specifies the <c>VkGeometryTypeKHR</c> which this geometry refers to.
        /// </summary>
        [FieldOffset(16)]
        public VkGeometryTypeKHR GeometryType;

        /// <summary>
        ///     <c>Geometry</c> contains the geometry data as described in <c>VkGeometryDataNV</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkGeometryDataNV Geometry;

        /// <summary>
        ///     <c>Flags</c> has <c>VkGeometryFlagsKHR</c> describing options for this geometry.
        /// </summary>
        [FieldOffset(160)]
        public VkGeometryFlagsKHR Flags;
    }
}
