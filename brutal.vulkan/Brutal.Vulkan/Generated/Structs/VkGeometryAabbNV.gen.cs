namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryAABBNV.html">VkGeometryAABBNV</see> - Structure specifying axis-aligned bounding box geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryAABBNV
    ///     </para>
    ///     <para>
    ///         The <c>VkGeometryAABBNV</c> structure specifies axis-aligned bounding box
    ///         geometry in a bottom-level acceleration structure, and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkGeometryAABBNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           aabbData;
    ///             uint32_t           numAABBs;
    ///             uint32_t           stride;
    ///             VkDeviceSize       offset;
    ///         } VkGeometryAABBNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkGeometryAabbNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GeometryAabbNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AabbData</c> is the buffer containing axis-aligned bounding box data.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer AabbData;

        /// <summary>
        ///     <c>NumAABBs</c> is the number of AABBs in this geometry.
        /// </summary>
        [FieldOffset(24)]
        public int NumAABBs;

        /// <summary>
        ///     <c>Stride</c> is the stride in bytes between AABBs in <c>aabbData</c>.
        /// </summary>
        [FieldOffset(28)]
        public int Stride;

        /// <summary>
        ///     <c>Offset</c> is the offset in bytes of the first AABB in <c>aabbData</c>.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Offset;
    }
}
