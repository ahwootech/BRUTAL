namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometrySpheresDataNV.html">VkAccelerationStructureGeometrySpheresDataNV</see> - Structure specifying a sphere geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometrySpheresDataNV
    ///     </para>
    ///     <para>
    ///         If <c>VkAccelerationStructureGeometrySpheresDataNV</c> is included in the
    ///         <c>pNext</c> chain of a <c>VkAccelerationStructureGeometryKHR</c> structure,
    ///         then that structures defines the sphere&apos;s geometry data.
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometrySpheresDataNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///         typedef struct VkAccelerationStructureGeometrySpheresDataNV {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkFormat                         vertexFormat;
    ///             VkDeviceOrHostAddressConstKHR    vertexData;
    ///             VkDeviceSize                     vertexStride;
    ///             VkFormat                         radiusFormat;
    ///             VkDeviceOrHostAddressConstKHR    radiusData;
    ///             VkDeviceSize                     radiusStride;
    ///             VkIndexType                      indexType;
    ///             VkDeviceOrHostAddressConstKHR    indexData;
    ///             VkDeviceSize                     indexStride;
    ///         } VkAccelerationStructureGeometrySpheresDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkAccelerationStructureGeometrySpheresDataNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometrySpheresDataNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexFormat</c> is the <c>VkFormat</c> of each sphere&apos;s vertex element.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat VertexFormat;

        /// <summary>
        ///     <c>VertexData</c> is a device or host address of memory containing vertex data in form of pairs of centers of spheres that define all sphere geometry.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressConstKHR VertexData;

        /// <summary>
        ///     <c>VertexStride</c> is the stride in bytes between each vertex element.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 VertexStride;

        /// <summary>
        ///     <c>RadiusFormat</c> is the <c>VkFormat</c> of each sphere&apos;s radius.
        /// </summary>
        [FieldOffset(40)]
        public VkFormat RadiusFormat;

        /// <summary>
        ///     <c>RadiusData</c> is a device or host address of memory containing sphere&apos;s radius data value.
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
    }
}
