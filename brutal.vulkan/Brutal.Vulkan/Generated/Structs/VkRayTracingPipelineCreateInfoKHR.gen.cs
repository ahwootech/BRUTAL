namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineCreateInfoKHR.html">VkRayTracingPipelineCreateInfoKHR</see> - Structure specifying parameters of a newly created ray tracing pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkRayTracingPipelineCreateInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkRayTracingPipelineCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkRayTracingPipelineCreateInfoKHR {
    ///             VkStructureType                                      sType;
    ///             const void*                                          pNext;
    ///             VkPipelineCreateFlags                                flags;
    ///             uint32_t                                             stageCount;
    ///             const VkPipelineShaderStageCreateInfo*               pStages;
    ///             uint32_t                                             groupCount;
    ///             const VkRayTracingShaderGroupCreateInfoKHR*          pGroups;
    ///             uint32_t                                             maxPipelineRayRecursionDepth;
    ///             const VkPipelineLibraryCreateInfoKHR*                pLibraryInfo;
    ///             const VkRayTracingPipelineInterfaceCreateInfoKHR*    pLibraryInterface;
    ///             const VkPipelineDynamicStateCreateInfo*              pDynamicState;
    ///             VkPipelineLayout                                     layout;
    ///             VkPipeline                                           basePipelineHandle;
    ///             int32_t                                              basePipelineIndex;
    ///         } VkRayTracingPipelineCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct VkRayTracingPipelineCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RayTracingPipelineCreateInfoKHR;

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
        ///     <c>Stages</c> is a pointer to an array of <c>stageCount</c> <c>VkPipelineShaderStageCreateInfo</c> structures describing the set of the shader stages to be included in the ray tracing pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineShaderStageCreateInfo* Stages;

        /// <summary>
        ///     <c>GroupCount</c> is the number of entries in the <c>pGroups</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int GroupCount;

        /// <summary>
        ///     <c>Groups</c> is a pointer to an array of <c>groupCount</c> <c>VkRayTracingShaderGroupCreateInfoKHR</c> structures describing the set of the shader stages to be included in each shader group in the ray tracing pipeline.
        /// </summary>
        [FieldOffset(40)]
        public VkRayTracingShaderGroupCreateInfoKHR* Groups;

        /// <summary>
        ///     <c>MaxPipelineRayRecursionDepth</c> is the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-tracing-recursion-depth">maximum recursion depth^</see> of shaders executed by this pipeline.
        /// </summary>
        [FieldOffset(48)]
        public int MaxPipelineRayRecursionDepth;

        /// <summary>
        ///     <c>LibraryInfo</c> is a pointer to a <c>VkPipelineLibraryCreateInfoKHR</c> structure defining pipeline libraries to include.
        /// </summary>
        [FieldOffset(56)]
        public VkPipelineLibraryCreateInfoKHR* LibraryInfo;

        /// <summary>
        ///     <c>LibraryInterface</c> is a pointer to a <c>VkRayTracingPipelineInterfaceCreateInfoKHR</c> structure defining additional information when using pipeline libraries.
        /// </summary>
        [FieldOffset(64)]
        public VkRayTracingPipelineInterfaceCreateInfoKHR* LibraryInterface;

        /// <summary>
        ///     <c>DynamicState</c> is a pointer to a <c>VkPipelineDynamicStateCreateInfo</c> structure, and is used to indicate which properties of the pipeline state object are dynamic and <i>can</i> be changed independently of the pipeline state. This <i>can</i> be `NULL`, which means no state in the pipeline is considered dynamic.
        /// </summary>
        [FieldOffset(72)]
        public VkPipelineDynamicStateCreateInfo* DynamicState;

        /// <summary>
        ///     <c>Layout</c> is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        [FieldOffset(80)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>BasePipelineHandle</c> is a pipeline to derive from.
        /// </summary>
        [FieldOffset(88)]
        public VkPipeline BasePipelineHandle;

        /// <summary>
        ///     <c>BasePipelineIndex</c> is an index into the <c>pCreateInfos</c> parameter to use as a pipeline to derive from.
        /// </summary>
        [FieldOffset(96)]
        public int BasePipelineIndex;
    }
}
