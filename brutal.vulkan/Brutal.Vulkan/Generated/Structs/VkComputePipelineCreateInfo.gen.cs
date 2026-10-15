namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComputePipelineCreateInfo.html">VkComputePipelineCreateInfo</see> - Structure specifying parameters of a newly created compute pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkComputePipelineCreateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkComputePipelineCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkComputePipelineCreateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkPipelineCreateFlags              flags;
    ///             VkPipelineShaderStageCreateInfo    stage;
    ///             VkPipelineLayout                   layout;
    ///             VkPipeline                         basePipelineHandle;
    ///             int32_t                            basePipelineIndex;
    ///         } VkComputePipelineCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkComputePipelineCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ComputePipelineCreateInfo;

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
        ///     <c>Stage</c> is a <c>VkPipelineShaderStageCreateInfo</c> structure describing the compute shader.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineShaderStageCreateInfo Stage;

        /// <summary>
        ///     <c>Layout</c> is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        [FieldOffset(72)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>BasePipelineHandle</c> is a pipeline to derive from.
        /// </summary>
        [FieldOffset(80)]
        public VkPipeline BasePipelineHandle;

        /// <summary>
        ///     <c>BasePipelineIndex</c> is an index into the <c>pCreateInfos</c> parameter to use as a pipeline to derive from.
        /// </summary>
        [FieldOffset(88)]
        public int BasePipelineIndex;
    }
}
