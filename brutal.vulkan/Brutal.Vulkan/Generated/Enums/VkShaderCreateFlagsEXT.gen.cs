namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderCreateFlagBitsEXT.html">VkShaderCreateFlagBitsEXT</see> - Bitmask controlling how a shader object is created
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>flags</c> member of <c>VkShaderCreateInfoEXT</c>
    ///         specifying how a shader object is created, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object
    ///         typedef enum VkShaderCreateFlagBitsEXT {
    ///             VK_SHADER_CREATE_LINK_STAGE_BIT_EXT = 0x00000001,
    ///             // Provided by VK_EXT_descriptor_heap with VK_EXT_shader_object
    ///             VK_SHADER_CREATE_DESCRIPTOR_HEAP_BIT_EXT = 0x00000400,
    ///             // Provided by VK_KHR_maintenance5 with VK_ARM_shader_instrumentation, VK_EXT_shader_object with VK_ARM_shader_instrumentation
    ///             VK_SHADER_CREATE_INSTRUMENT_SHADER_BIT_ARM = 0x00000800,
    ///             // Provided by VK_EXT_shader_object with VK_EXT_subgroup_size_control or VK_VERSION_1_3
    ///             VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = 0x00000002,
    ///             // Provided by VK_EXT_shader_object with VK_EXT_subgroup_size_control or VK_VERSION_1_3
    ///             VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = 0x00000004,
    ///             // Provided by VK_EXT_shader_object with VK_EXT_mesh_shader or VK_NV_mesh_shader
    ///             VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT = 0x00000008,
    ///             // Provided by VK_EXT_shader_object with VK_KHR_device_group or VK_VERSION_1_1
    ///             VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT = 0x00000010,
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_EXT_shader_object
    ///             VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT = 0x00000020,
    ///             // Provided by VK_EXT_fragment_density_map with VK_EXT_shader_object
    ///             VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x00000040,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT = 0x00000080,
    ///             // Provided by VK_KHR_opacity_micromap with VK_EXT_shader_object
    ///             VK_SHADER_CREATE_OPACITY_MICROMAP_DISALLOW_MIXED_SPECIAL_INDEX_BIT_EXT = 0x00001000,
    ///             // Provided by VK_EXT_shader_64bit_indexing
    ///             VK_SHADER_CREATE_64_BIT_INDEXING_BIT_EXT = 0x00008000,
    ///             // Provided by VK_KHR_maintenance11 with VK_EXT_shader_object
    ///             VK_SHADER_CREATE_INDEPENDENT_SETS_BIT_KHR = 0x00040000,
    ///         } VkShaderCreateFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkShaderCreateFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>LinkStageBitEXT</c> specifies that a shader is linked to all other shaders created in the same <c>vkCreateShadersEXT</c> call whose <c>VkShaderCreateInfoEXT</c> structures&apos; <c>flags</c> include <c>VK_SHADER_CREATE_LINK_STAGE_BIT_EXT</c>.
        /// </summary>
        LinkStageBitEXT = 0x00000001,

        /// <summary>
        ///     <c>DescriptorHeapBitEXT</c>
        /// </summary>
        DescriptorHeapBitEXT = 0x00000400,

        /// <summary>
        ///     <c>InstrumentShaderBitARM</c>
        /// </summary>
        InstrumentShaderBitARM = 0x00000800,

        /// <summary>
        ///     <c>AllowVaryingSubgroupSizeBitEXT</c>
        /// </summary>
        AllowVaryingSubgroupSizeBitEXT = 0x00000002,

        /// <summary>
        ///     <c>RequireFullSubgroupsBitEXT</c>
        /// </summary>
        RequireFullSubgroupsBitEXT = 0x00000004,

        /// <summary>
        ///     <c>NoTaskShaderBitEXT</c>
        /// </summary>
        NoTaskShaderBitEXT = 0x00000008,

        /// <summary>
        ///     <c>DispatchBaseBitEXT</c>
        /// </summary>
        DispatchBaseBitEXT = 0x00000010,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentBitEXT</c>
        /// </summary>
        FragmentShadingRateAttachmentBitEXT = 0x00000020,

        /// <summary>
        ///     <c>FragmentDensityMapAttachmentBitEXT</c>
        /// </summary>
        FragmentDensityMapAttachmentBitEXT = 0x00000040,

        /// <summary>
        ///     <c>IndirectBindableBitEXT</c>
        /// </summary>
        IndirectBindableBitEXT = 0x00000080,

        /// <summary>
        ///     <c>OpacityMicromapDisallowMixedSpecialIndexBitEXT</c>
        /// </summary>
        OpacityMicromapDisallowMixedSpecialIndexBitEXT = 0x00001000,

        /// <summary>
        ///     <c>_64BitIndexingBitEXT</c>
        /// </summary>
        _64BitIndexingBitEXT = 0x00008000,

        /// <summary>
        ///     <c>IndependentSetsBitKHR</c>
        /// </summary>
        IndependentSetsBitKHR = 0x00040000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
