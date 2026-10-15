namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoNV.html">VkRayTracingShaderGroupCreateInfoNV</see> - Structure specifying shaders in a shader group
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingShaderGroupCreateInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingShaderGroupCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkRayTracingShaderGroupCreateInfoNV {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkRayTracingShaderGroupTypeKHR    type;
    ///             uint32_t                          generalShader;
    ///             uint32_t                          closestHitShader;
    ///             uint32_t                          anyHitShader;
    ///             uint32_t                          intersectionShader;
    ///         } VkRayTracingShaderGroupCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RayTracingShaderGroupCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is the type of hit group specified in this structure.
        /// </summary>
        [FieldOffset(16)]
        public VkRayTracingShaderGroupTypeKHR Type;

        /// <summary>
        ///     <c>GeneralShader</c> is the index of the ray generation, miss, or callable shader from <c>VkRayTracingPipelineCreateInfoNV::pStages</c> in the group if the shader group has <c>type</c> of <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV</c>, and <c>VK_SHADER_UNUSED_NV</c> otherwise.
        /// </summary>
        [FieldOffset(20)]
        public int GeneralShader;

        /// <summary>
        ///     <c>ClosestHitShader</c> is the optional index of the closest hit shader from <c>VkRayTracingPipelineCreateInfoNV::pStages</c> in the group if the shader group has <c>type</c> of <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV</c> or <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV</c>, and <c>VK_SHADER_UNUSED_NV</c> otherwise.
        /// </summary>
        [FieldOffset(24)]
        public int ClosestHitShader;

        /// <summary>
        ///     <c>AnyHitShader</c> is the optional index of the any-hit shader from <c>VkRayTracingPipelineCreateInfoNV::pStages</c> in the group if the shader group has <c>type</c> of <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV</c> or <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV</c>, and <c>VK_SHADER_UNUSED_NV</c> otherwise.
        /// </summary>
        [FieldOffset(28)]
        public int AnyHitShader;

        /// <summary>
        ///     <c>IntersectionShader</c> is the index of the intersection shader from <c>VkRayTracingPipelineCreateInfoNV::pStages</c> in the group if the shader group has <c>type</c> of <c>VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV</c>, and <c>VK_SHADER_UNUSED_NV</c> otherwise.
        /// </summary>
        [FieldOffset(32)]
        public int IntersectionShader;
    }
}
