namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryLinearSweptSpheresDataNV.html">VkAccelerationStructureGeometryLinearSweptSpheresDataNV</see> - Structure specifying a LSS geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryLinearSweptSpheresDataNV
    ///     </para>
    ///     <para>
    ///         If <c>VkAccelerationStructureGeometryLinearSweptSpheresDataNV</c> is included
    ///         in the <c>pNext</c> chain of a <c>VkAccelerationStructureGeometryKHR</c>
    ///         structure, then that structures defines the linear swept sphere&apos;s (LSS)
    ///         geometry data.
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryLinearSweptSpheresDataNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///         typedef struct VkAccelerationStructureGeometryLinearSweptSpheresDataNV {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkFormat                                 vertexFormat;
    ///             VkDeviceOrHostAddressConstKHR            vertexData;
    ///             VkDeviceSize                             vertexStride;
    ///             VkFormat                                 radiusFormat;
    ///             VkDeviceOrHostAddressConstKHR            radiusData;
    ///             VkDeviceSize                             radiusStride;
    ///             VkIndexType                              indexType;
    ///             VkDeviceOrHostAddressConstKHR            indexData;
    ///             VkDeviceSize                             indexStride;
    ///             VkRayTracingLssIndexingModeNV            indexingMode;
    ///             VkRayTracingLssPrimitiveEndCapsModeNV    endCapsMode;
    ///         } VkAccelerationStructureGeometryLinearSweptSpheresDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkAccelerationStructureGeometryLinearSweptSpheresDataNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryLinearSweptSpheresDataNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexFormat</c> is the <c>VkFormat</c> of each LSS vertex element.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat VertexFormat;

        /// <summary>
        ///     <c>VertexData</c> is a device or host address of memory containing vertex data for this geometry.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR VertexData;

        /// <summary>
        ///     <c>VertexStride</c> is the stride in bytes between each vertex element.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 VertexStride;

        /// <summary>
        ///     <c>RadiusFormat</c> is the <c>VkFormat</c> of each LSS radius.
        /// </summary>
        [FieldOffset(40)]
        public VkFormat RadiusFormat;

        /// <summary>
        ///     <c>RadiusData</c> is a device or host address of memory containing LSS radius data value.
        /// </summary>
        [FieldOffset(48)]
        public VkDeviceOrHostAddressConstKHR RadiusData;

        /// <summary>
        ///     <c>RadiusStride</c> is the stride in bytes between each radius value.
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 RadiusStride;

        /// <summary>
        ///     <c>IndexType</c> is the <c>VkIndexType</c> of each index element.
        /// </summary>
        [FieldOffset(64)]
        public VkIndexType IndexType;

        /// <summary>
        ///     <c>IndexData</c> is a device or host address of memory containing index data for vertex and radius buffers for this geometry. When <c>indexType</c> is <c>VK_INDEX_TYPE_NONE_KHR</c> it <i>must</i> be `NULL`.
        /// </summary>
        [FieldOffset(72)]
        public VkDeviceOrHostAddressConstKHR IndexData;

        /// <summary>
        ///     <c>IndexStride</c> is the stride in bytes between each index element.
        /// </summary>
        [FieldOffset(80)]
        public ByteSize64 IndexStride;

        /// <summary>
        ///     <c>IndexingMode</c> is a <c>VkRayTracingLssIndexingModeNV</c> value specifying the mode of indexing.
        /// </summary>
        [FieldOffset(88)]
        public VkRayTracingLssIndexingModeNV IndexingMode;

        /// <summary>
        ///     <c>EndCapsMode</c> is a <c>VkRayTracingLssPrimitiveEndCapsModeNV</c> value specifying the endcaps mode for LSS primitives.
        /// </summary>
        [FieldOffset(92)]
        public VkRayTracingLssPrimitiveEndCapsModeNV EndCapsMode;
    }
}
