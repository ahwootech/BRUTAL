namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateFlagBits.html">VkPipelineLayoutCreateFlagBits</see> - Pipeline layout creation flag bits
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0, VK_EXT_graphics_pipeline_library
    ///         typedef enum VkPipelineLayoutCreateFlagBits {
    ///             // Provided by VK_KHR_maintenance11 with VK_EXT_shader_object, VK_EXT_graphics_pipeline_library
    ///             VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = 0x00000002,
    ///             // Provided by VK_KHR_maintenance11 with VK_EXT_shader_object and (VK_EXT_mesh_shader or VK_NV_mesh_shader)
    ///             VK_PIPELINE_LAYOUT_CREATE_NO_TASK_SHADER_BIT_KHR = 0x00000004,
    ///         } VkPipelineLayoutCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineLayoutCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>IndependentSetsBitEXT</c>
        /// </summary>
        IndependentSetsBitEXT = 0x00000002,

        /// <summary>
        ///     <c>NoTaskShaderBitKHR</c>
        /// </summary>
        NoTaskShaderBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
