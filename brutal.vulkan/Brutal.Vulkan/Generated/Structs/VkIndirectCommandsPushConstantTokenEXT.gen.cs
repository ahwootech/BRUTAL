namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsPushConstantTokenEXT.html">VkIndirectCommandsPushConstantTokenEXT</see> - Structure specifying layout token info for a single push constant command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsPushConstantTokenEXT</c> structure specifies the
    ///         layout token info for
    ///         <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT</c>,
    ///         and <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT</c> tokens.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsPushConstantTokenEXT {
    ///             VkPushConstantRange    updateRange;
    ///         } VkIndirectCommandsPushConstantTokenEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkIndirectCommandsPushConstantTokenEXT()
    {
        /// <summary>
        ///     <c>UpdateRange</c> is the push constant range that will be updated by the token.
        /// </summary>
        [FieldOffset(0)]
        public VkPushConstantRange UpdateRange;
    }
}
