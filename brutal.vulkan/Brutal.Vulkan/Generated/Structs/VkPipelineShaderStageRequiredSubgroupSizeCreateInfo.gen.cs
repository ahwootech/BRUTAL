namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageRequiredSubgroupSizeCreateInfo.html">VkPipelineShaderStageRequiredSubgroupSizeCreateInfo</see> - Structure specifying the required subgroup size of a newly created pipeline shader stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineShaderStageRequiredSubgroupSizeCreateInfo</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           requiredSubgroupSize;
    ///         } VkPipelineShaderStageRequiredSubgroupSizeCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RequiredSubgroupSize</c> is an unsigned integer value specifying the required subgroup size for the newly created pipeline shader stage.
        /// </summary>
        [FieldOffset(16)]
        public int RequiredSubgroupSize;
    }
}
