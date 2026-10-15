namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineShaderModuleCreateInfoARM.html">VkDataGraphPipelineShaderModuleCreateInfoARM</see> - Structure specifying shader module parameters of a newly created data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineShaderModuleCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineShaderModuleCreateInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineShaderModuleCreateInfoARM {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkShaderModule                           module;
    ///             const char*                              pName;
    ///             const VkSpecializationInfo*              pSpecializationInfo;
    ///             uint32_t                                 constantCount;
    ///             const VkDataGraphPipelineConstantARM*    pConstants;
    ///         } VkDataGraphPipelineShaderModuleCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkDataGraphPipelineShaderModuleCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineShaderModuleCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Module</c> is optionally a <c>VkShaderModule</c> object containing the description of the graph.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderModule Module;

        /// <summary>
        ///     <c>Name</c> is a pointer to a null-terminated UTF-8 string specifying the graph entry point name for this pipeline.
        /// </summary>
        [FieldOffset(24)]
        public byte* Name;

        /// <summary>
        ///     <c>SpecializationInfo</c> is a pointer to a <c>VkSpecializationInfo</c> structure as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-specialization-constants">Specialization Constants^</see>, or `NULL`.
        /// </summary>
        [FieldOffset(32)]
        public VkSpecializationInfo* SpecializationInfo;

        /// <summary>
        ///     <c>ConstantCount</c> is the length of the <c>pConstants</c> array.
        /// </summary>
        [FieldOffset(40)]
        public int ConstantCount;

        /// <summary>
        ///     <c>Constants</c> is a pointer to an array of <c>VkDataGraphPipelineConstantARM</c> structures.
        /// </summary>
        [FieldOffset(48)]
        public VkDataGraphPipelineConstantARM* Constants;
    }
}
