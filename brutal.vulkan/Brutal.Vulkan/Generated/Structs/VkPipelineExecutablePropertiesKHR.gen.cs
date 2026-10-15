namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutablePropertiesKHR.html">VkPipelineExecutablePropertiesKHR</see> - Structure describing a pipeline executable
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutablePropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPipelineExecutablePropertiesKHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkShaderStageFlags    stages;
    ///             char                  name[VK_MAX_DESCRIPTION_SIZE];
    ///             char                  description[VK_MAX_DESCRIPTION_SIZE];
    ///             uint32_t              subgroupSize;
    ///         } VkPipelineExecutablePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 536)]
    public unsafe partial struct VkPipelineExecutablePropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineExecutablePropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Stages</c> is a bitmask of zero or more <c>VkShaderStageFlags</c> indicating which shader stages (if any) were principally used as inputs to compile this pipeline executable.
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags Stages;

        ///
        [FieldOffset(20)]
        public fixed byte Name[256];

        ///
        [FieldOffset(276)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>SubgroupSize</c> is the subgroup size with which this pipeline executable is dispatched.
        /// </summary>
        [FieldOffset(532)]
        public int SubgroupSize;
    }
}
