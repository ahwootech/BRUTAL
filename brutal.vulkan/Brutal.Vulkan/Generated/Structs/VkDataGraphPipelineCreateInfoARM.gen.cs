namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineCreateInfoARM.html">VkDataGraphPipelineCreateInfoARM</see> - Structure specifying parameters of a newly created data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineCreateInfoARM {
    ///             VkStructureType                              sType;
    ///             const void*                                  pNext;
    ///             VkPipelineCreateFlags2                       flags;
    ///             VkPipelineLayout                             layout;
    ///             uint32_t                                     resourceInfoCount;
    ///             const VkDataGraphPipelineResourceInfoARM*    pResourceInfos;
    ///         } VkDataGraphPipelineCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDataGraphPipelineCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineCreateFlags2KHR</c> specifying how the pipeline will be generated.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineCreateFlags2 Flags;

        /// <summary>
        ///     <c>Layout</c> is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineLayout Layout;

        /// <summary>
        ///     <c>ResourceInfoCount</c> is the length of the <c>pResourceInfos</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int ResourceInfoCount;

        /// <summary>
        ///     <c>ResourceInfos</c> is a pointer to an array of <c>VkDataGraphPipelineResourceInfoARM</c> structures.
        /// </summary>
        [FieldOffset(40)]
        public VkDataGraphPipelineResourceInfoARM* ResourceInfos;
    }
}
