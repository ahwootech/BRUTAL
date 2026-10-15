namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderStageFlagBits.html">VkShaderStageFlagBits</see> - Bitmask specifying a pipeline stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set by commands and structures, specifying one or more
    ///         shader stages, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkShaderStageFlagBits {
    ///             VK_SHADER_STAGE_VERTEX_BIT = 0x00000001,
    ///             VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = 0x00000002,
    ///             VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = 0x00000004,
    ///             VK_SHADER_STAGE_GEOMETRY_BIT = 0x00000008,
    ///             VK_SHADER_STAGE_FRAGMENT_BIT = 0x00000010,
    ///             VK_SHADER_STAGE_COMPUTE_BIT = 0x00000020,
    ///             VK_SHADER_STAGE_ALL_GRAPHICS = 0x0000001F,
    ///             VK_SHADER_STAGE_ALL = 0x7FFFFFFF,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_RAYGEN_BIT_KHR = 0x00000100,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_ANY_HIT_BIT_KHR = 0x00000200,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR = 0x00000400,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_MISS_BIT_KHR = 0x00000800,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_INTERSECTION_BIT_KHR = 0x00001000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_SHADER_STAGE_CALLABLE_BIT_KHR = 0x00002000,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_SHADER_STAGE_TASK_BIT_EXT = 0x00000040,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_SHADER_STAGE_MESH_BIT_EXT = 0x00000080,
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI = 0x00004000,
    ///             // Provided by VK_HUAWEI_cluster_culling_shader
    ///             VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI = 0x00080000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_RAYGEN_BIT_NV = VK_SHADER_STAGE_RAYGEN_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_ANY_HIT_BIT_NV = VK_SHADER_STAGE_ANY_HIT_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV = VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_MISS_BIT_NV = VK_SHADER_STAGE_MISS_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_INTERSECTION_BIT_NV = VK_SHADER_STAGE_INTERSECTION_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_SHADER_STAGE_CALLABLE_BIT_NV = VK_SHADER_STAGE_CALLABLE_BIT_KHR,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_SHADER_STAGE_TASK_BIT_NV = VK_SHADER_STAGE_TASK_BIT_EXT,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_SHADER_STAGE_MESH_BIT_NV = VK_SHADER_STAGE_MESH_BIT_EXT,
    ///         } VkShaderStageFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkShaderStageFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>VertexBit</c> specifies the vertex stage.
        /// </summary>
        VertexBit = 0x00000001,

        /// <summary>
        ///     <c>TessellationControlBit</c> specifies the tessellation control stage.
        /// </summary>
        TessellationControlBit = 0x00000002,

        /// <summary>
        ///     <c>TessellationEvaluationBit</c> specifies the tessellation evaluation stage.
        /// </summary>
        TessellationEvaluationBit = 0x00000004,

        /// <summary>
        ///     <c>GeometryBit</c> specifies the geometry stage.
        /// </summary>
        GeometryBit = 0x00000008,

        /// <summary>
        ///     <c>FragmentBit</c> specifies the fragment stage.
        /// </summary>
        FragmentBit = 0x00000010,

        /// <summary>
        ///     <c>ComputeBit</c> specifies the compute stage.
        /// </summary>
        ComputeBit = 0x00000020,

        /// <summary>
        ///     <c>AllGraphics</c> is a combination of bits used as shorthand to specify all graphics stages defined above (excluding the compute stage).
        /// </summary>
        AllGraphics = 0x0000001F,

        /// <summary>
        ///     <c>All</c> is a combination of bits used as shorthand to specify all shader stages supported by the device, including all additional stages which are introduced by extensions.  [NOTE]
        /// </summary>
        All = 0x7FFFFFFF,

        /// <summary>
        ///     <c>RaygenBitKHR</c>
        /// </summary>
        RaygenBitKHR = 0x00000100,

        /// <summary>
        ///     <c>AnyHitBitKHR</c>
        /// </summary>
        AnyHitBitKHR = 0x00000200,

        /// <summary>
        ///     <c>ClosestHitBitKHR</c>
        /// </summary>
        ClosestHitBitKHR = 0x00000400,

        /// <summary>
        ///     <c>MissBitKHR</c>
        /// </summary>
        MissBitKHR = 0x00000800,

        /// <summary>
        ///     <c>IntersectionBitKHR</c>
        /// </summary>
        IntersectionBitKHR = 0x00001000,

        /// <summary>
        ///     <c>CallableBitKHR</c>
        /// </summary>
        CallableBitKHR = 0x00002000,

        /// <summary>
        ///     <c>TaskBitEXT</c>
        /// </summary>
        TaskBitEXT = 0x00000040,

        /// <summary>
        ///     <c>MeshBitEXT</c>
        /// </summary>
        MeshBitEXT = 0x00000080,

        /// <summary>
        ///     <c>SubpassShadingBitHUAWEI</c>
        /// </summary>
        SubpassShadingBitHUAWEI = 0x00004000,

        /// <summary>
        ///     <c>ClusterCullingBitHUAWEI</c>
        /// </summary>
        ClusterCullingBitHUAWEI = 0x00080000,

        /// <summary>
        ///     <c>RaygenBitNV</c>
        /// </summary>
        RaygenBitNV = RaygenBitKHR,

        /// <summary>
        ///     <c>AnyHitBitNV</c>
        /// </summary>
        AnyHitBitNV = AnyHitBitKHR,

        /// <summary>
        ///     <c>ClosestHitBitNV</c>
        /// </summary>
        ClosestHitBitNV = ClosestHitBitKHR,

        /// <summary>
        ///     <c>MissBitNV</c>
        /// </summary>
        MissBitNV = MissBitKHR,

        /// <summary>
        ///     <c>IntersectionBitNV</c>
        /// </summary>
        IntersectionBitNV = IntersectionBitKHR,

        /// <summary>
        ///     <c>CallableBitNV</c>
        /// </summary>
        CallableBitNV = CallableBitKHR,

        /// <summary>
        ///     <c>TaskBitNV</c>
        /// </summary>
        TaskBitNV = TaskBitEXT,

        /// <summary>
        ///     <c>MeshBitNV</c>
        /// </summary>
        MeshBitNV = MeshBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
