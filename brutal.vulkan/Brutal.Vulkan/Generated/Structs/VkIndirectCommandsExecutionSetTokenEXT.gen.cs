namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsExecutionSetTokenEXT.html">VkIndirectCommandsExecutionSetTokenEXT</see> - Structure specifying input data for a single execution set command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsExecutionSetTokenEXT</c> structure specifies the
    ///         input data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT</c>
    ///         token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsExecutionSetTokenEXT {
    ///             VkIndirectExecutionSetInfoTypeEXT    type;
    ///             VkShaderStageFlags                   shaderStages;
    ///         } VkIndirectCommandsExecutionSetTokenEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkIndirectCommandsExecutionSetTokenEXT()
    {
        /// <summary>
        ///     <c>Type</c> describes the type of indirect execution set in use.
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectExecutionSetInfoTypeEXT Type;

        /// <summary>
        ///     <c>ShaderStages</c> specifies the shaders that will be changed by this token.
        /// </summary>
        [FieldOffset(4)]
        public VkShaderStageFlags ShaderStages;
    }
}
