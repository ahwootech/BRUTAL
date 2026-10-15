namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineCreateInfoNV.html">VkRayTracingPipelineCreateInfoNV</see> - Structure specifying parameters of a newly created ray tracing pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingPipelineCreateInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingPipelineCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkRayTracingPipelineCreateInfoNV {
    ///             VkStructureType                               sType;
    ///             const void*                                   pNext;
    ///             VkPipelineCreateFlags                         flags;
    ///             uint32_t                                      stageCount;
    ///             const VkPipelineShaderStageCreateInfo*        pStages;
    ///             uint32_t                                      groupCount;
    ///             const VkRayTracingShaderGroupCreateInfoNV*    pGroups;
    ///             uint32_t                                      maxRecursionDepth;
    ///             VkPipelineLayout                              layout;
    ///             VkPipeline                                    basePipelineHandle;
    ///             int32_t                                       basePipelineIndex;
    ///         } VkRayTracingPipelineCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkRayTracingPipelineCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RayTracingPipelineCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineCreateFlags</c> specifying how the pipeline will be generated.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCreateFlags Flags;

        /// <summary>
        ///     <c>StageCount</c> is the number of entries in the <c>pStages</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int StageCount;

        /// <summary>
        ///     <c>Stages</c> is a pointer to an array of <c>VkPipelineShaderStageCreateInfo</c> structures specifying the set of the shader stages to be included in the ray tracing pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineShaderStageCreateInfo* Stages;

        /// <summary>
        ///     <c>GroupCount</c> is the number of entries in the <c>pGroups</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int GroupCount;

        /// <summary>
        ///     <c>Groups</c> is a pointer to an array of <c>VkRayTracingShaderGroupCreateInfoNV</c> structures describing the set of the shader stages to be included in each shader group in the ray tracing pipeline.
        /// </summary>
        [FieldOffset(40)]
        public VkRayTracingShaderGroupCreateInfoNV* Groups;

        /// <summary>
        ///     <c>MaxRecursionDepth</c> is the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-tracing-recursion-depth">maximum recursion depth^</see> of shaders executed by this pipeline.
        /// </summary>
        [FieldOffset(48)]
        public int MaxRecursionDepth;

        /// <summary>
        ///     <c>Layout</c> is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        [FieldOffset(56)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>BasePipelineHandle</c> is a pipeline to derive from.
        /// </summary>
        [FieldOffset(64)]
        public VkPipeline BasePipelineHandle;

        /// <summary>
        ///     <c>BasePipelineIndex</c> is an index into the <c>pCreateInfos</c> parameter to use as a pipeline to derive from.
        /// </summary>
        [FieldOffset(72)]
        public int BasePipelineIndex;
    }
}
