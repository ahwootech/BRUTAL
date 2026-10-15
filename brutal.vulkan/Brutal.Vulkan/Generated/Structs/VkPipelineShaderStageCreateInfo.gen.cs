namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateInfo.html">VkPipelineShaderStageCreateInfo</see> - Structure specifying parameters of a newly created pipeline shader stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPipelineShaderStageCreateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineShaderStageCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineShaderStageCreateInfo {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkPipelineShaderStageCreateFlags    flags;
    ///             VkShaderStageFlagBits               stage;
    ///             VkShaderModule                      module;
    ///             const char*                         pName;
    ///             const VkSpecializationInfo*         pSpecializationInfo;
    ///         } VkPipelineShaderStageCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPipelineShaderStageCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineShaderStageCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineShaderStageCreateFlags</c> specifying how the pipeline shader stage will be generated.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineShaderStageCreateFlags Flags;

        /// <summary>
        ///     <c>Stage</c> is a <c>VkShaderStageFlags</c> value specifying a single pipeline stage.
        /// </summary>
        [FieldOffset(20)]
        public VkShaderStageFlags Stage;

        /// <summary>
        ///     <c>Module</c> is a <c>VkShaderModule</c> object containing the shader code for this stage. The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(24)]
        public VkShaderModule Module;

        /// <summary>
        ///     <c>Name</c> is a pointer to a null-terminated UTF-8 string specifying the entry point name of the shader for this stage.
        /// </summary>
        [FieldOffset(32)]
        public byte* Name;

        /// <summary>
        ///     <c>SpecializationInfo</c> is a pointer to a <c>VkSpecializationInfo</c> structure, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines-specialization-constants">Specialization Constants^</see>, or `NULL`.
        /// </summary>
        [FieldOffset(40)]
        public VkSpecializationInfo* SpecializationInfo;
    }
}
