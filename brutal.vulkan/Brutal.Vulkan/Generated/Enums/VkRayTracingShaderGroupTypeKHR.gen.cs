namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupTypeKHR.html">VkRayTracingShaderGroupTypeKHR</see> - Shader group types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingShaderGroupTypeKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingShaderGroupTypeKHR</c> enumeration is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef enum VkRayTracingShaderGroupTypeKHR {
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = 0,
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = 1,
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = 2,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR,
    ///         } VkRayTracingShaderGroupTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkRayTracingShaderGroupTypeKHR : int
    {
        /// <summary>
        ///     <c>GeneralKHR</c> specifies that a shader group with a single <c>VK_SHADER_STAGE_RAYGEN_BIT_KHR</c>, <c>VK_SHADER_STAGE_MISS_BIT_KHR</c>, or <c>VK_SHADER_STAGE_CALLABLE_BIT_KHR</c> shader in it.
        /// </summary>
        GeneralKHR = 0,

        /// <summary>
        ///     <c>TrianglesHitGroupKHR</c> specifies that a shader group that only hits triangles and <i>must</i> not contain an intersection shader, only closest hit and any-hit shaders.
        /// </summary>
        TrianglesHitGroupKHR = 1,

        /// <summary>
        ///     <c>ProceduralHitGroupKHR</c>  specifies that a shader group that only intersects with custom geometry and <i>must</i> contain an intersection shader and may: contain closest hit and any-hit shaders.  [NOTE]
        /// </summary>
        ProceduralHitGroupKHR = 2,

        /// <summary>
        ///     <c>GeneralNV</c>
        /// </summary>
        GeneralNV = GeneralKHR,

        /// <summary>
        ///     <c>TrianglesHitGroupNV</c>
        /// </summary>
        TrianglesHitGroupNV = TrianglesHitGroupKHR,

        /// <summary>
        ///     <c>ProceduralHitGroupNV</c>
        /// </summary>
        ProceduralHitGroupNV = ProceduralHitGroupKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
