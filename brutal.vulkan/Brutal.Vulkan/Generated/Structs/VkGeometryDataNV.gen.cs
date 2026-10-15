namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryDataNV.html">VkGeometryDataNV</see> - Structure specifying geometry in a bottom-level acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryDataNV
    ///     </para>
    ///     <para>
    ///         The <c>VkGeometryDataNV</c> structure specifies geometry in a bottom-level
    ///         acceleration structure and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkGeometryDataNV {
    ///             VkGeometryTrianglesNV    triangles;
    ///             VkGeometryAABBNV         aabbs;
    ///         } VkGeometryDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct VkGeometryDataNV()
    {
        /// <summary>
        ///     <c>Triangles</c> contains triangle data if <c>VkGeometryNV::geometryType</c> is <c>VK_GEOMETRY_TYPE_TRIANGLES_NV</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkGeometryTrianglesNV Triangles;

        /// <summary>
        ///     <c>Aabbs</c> contains axis-aligned bounding box data if <c>VkGeometryNV::geometryType</c> is <c>VK_GEOMETRY_TYPE_AABBS_NV</c>.
        /// </summary>
        [FieldOffset(96)]
        public VkGeometryAabbNV Aabbs;
    }
}
