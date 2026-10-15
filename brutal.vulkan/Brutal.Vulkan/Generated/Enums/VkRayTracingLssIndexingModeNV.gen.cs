namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingLssIndexingModeNV.html">VkRayTracingLssIndexingModeNV</see> - LSS indexing mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Chaining LSS primitives <i>can</i> be achieved by specifying an index buffer in
    ///         <c>VkAccelerationStructureGeometryLinearSweptSpheresDataNV::indexData</c>
    ///         and setting
    ///         <c>VkAccelerationStructureGeometryLinearSweptSpheresDataNV::indexingMode</c>
    ///         to one of <c>VkRayTracingLssIndexingModeNV</c> values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///         typedef enum VkRayTracingLssIndexingModeNV {
    ///             VK_RAY_TRACING_LSS_INDEXING_MODE_LIST_NV = 0,
    ///             VK_RAY_TRACING_LSS_INDEXING_MODE_SUCCESSIVE_NV = 1,
    ///         } VkRayTracingLssIndexingModeNV;
    ///     </code>
    /// </remarks>
    public enum VkRayTracingLssIndexingModeNV : int
    {
        /// <summary>
        ///     <c>ListNV</c> specifies that a list of indices is provided where each consecutive pair of indices define a LSS primitive.
        /// </summary>
        ListNV = 0,

        /// <summary>
        ///     <c>SuccessiveNV</c> specifies a successive implicit indexing format, in which each LSS primitive is defined by two successive positions and radii, <c>(k, k + 1)</c>, where <c>k</c> is a single index provided in the index buffer. In this indexing scheme, there is a 1:1 mapping between the index buffer and primitive index within the geometry.
        /// </summary>
        SuccessiveNV = 1,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
