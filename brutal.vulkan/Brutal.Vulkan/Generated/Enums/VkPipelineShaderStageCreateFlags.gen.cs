namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateFlagBits.html">VkPipelineShaderStageCreateFlagBits</see> - Bitmask controlling how a pipeline shader stage is created
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>flags</c> member of
    ///         <c>VkPipelineShaderStageCreateInfo</c> specifying how a pipeline shader stage
    ///         is created, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPipelineShaderStageCreateFlagBits {
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT = 0x00000001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT = 0x00000002,
    ///             // Provided by VK_EXT_subgroup_size_control
    ///             VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT,
    ///             // Provided by VK_EXT_subgroup_size_control
    ///             VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT,
    ///         } VkPipelineShaderStageCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineShaderStageCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AllowVaryingSubgroupSizeBit</c>
        /// </summary>
        AllowVaryingSubgroupSizeBit = 0x00000001,

        /// <summary>
        ///     <c>RequireFullSubgroupsBit</c>
        /// </summary>
        RequireFullSubgroupsBit = 0x00000002,

        /// <summary>
        ///     <c>AllowVaryingSubgroupSizeBitEXT</c>
        /// </summary>
        AllowVaryingSubgroupSizeBitEXT = AllowVaryingSubgroupSizeBit,

        /// <summary>
        ///     <c>RequireFullSubgroupsBitEXT</c>
        /// </summary>
        RequireFullSubgroupsBitEXT = RequireFullSubgroupsBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
