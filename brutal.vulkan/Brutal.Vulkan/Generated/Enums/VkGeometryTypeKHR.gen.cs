namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryTypeKHR.html">VkGeometryTypeKHR</see> - Enum specifying which type of geometry is provided
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryTypeKHR
    ///     </para>
    ///     <para>
    ///         Geometry types are specified by <c>VkGeometryTypeKHR</c>, which takes values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkGeometryTypeKHR {
    ///             VK_GEOMETRY_TYPE_TRIANGLES_KHR = 0,
    ///             VK_GEOMETRY_TYPE_AABBS_KHR = 1,
    ///             VK_GEOMETRY_TYPE_INSTANCES_KHR = 2,
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             VK_GEOMETRY_TYPE_SPHERES_NV = 1000429004,
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV = 1000429005,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_dense_geometry_format
    ///             VK_GEOMETRY_TYPE_DENSE_GEOMETRY_FORMAT_TRIANGLES_AMDX = 1000478000,
    ///             #endif
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_GEOMETRY_TYPE_MICROMAP_KHR = 1000623000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_TYPE_TRIANGLES_NV = VK_GEOMETRY_TYPE_TRIANGLES_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_TYPE_AABBS_NV = VK_GEOMETRY_TYPE_AABBS_KHR,
    ///         } VkGeometryTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkGeometryTypeKHR : int
    {
        /// <summary>
        ///     <c>TrianglesKHR</c> specifies a geometry type consisting of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-tracing-triangle-primitive">triangles^</see>.
        /// </summary>
        TrianglesKHR = 0,

        /// <summary>
        ///     <c>AabbsKHR</c> specifies a geometry type consisting of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aabb-primitive">axis-aligned bounding boxes^</see>.
        /// </summary>
        AabbsKHR = 1,

        /// <summary>
        ///     <c>InstancesKHR</c>
        /// </summary>
        InstancesKHR = 2,

        /// <summary>
        ///     <c>SpheresNV</c>
        /// </summary>
        SpheresNV = 1000429004,

        /// <summary>
        ///     <c>LinearSweptSpheresNV</c>
        /// </summary>
        LinearSweptSpheresNV = 1000429005,

        /// <summary>
        ///     <c>DenseGeometryFormatTrianglesAMDX</c>
        /// </summary>
        DenseGeometryFormatTrianglesAMDX = 1000478000,

        /// <summary>
        ///     <c>MicromapKHR</c>
        /// </summary>
        MicromapKHR = 1000623000,

        /// <summary>
        ///     <c>TrianglesNV</c>
        /// </summary>
        TrianglesNV = TrianglesKHR,

        /// <summary>
        ///     <c>AabbsNV</c>
        /// </summary>
        AabbsNV = AabbsKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
