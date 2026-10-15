namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsIndexBufferTokenEXT.html">VkIndirectCommandsIndexBufferTokenEXT</see> - Structure specifying layout token info for a single index buffer command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkIndirectCommandsIndexBufferTokenEXT</c> structure specifies the
    ///         layout token info for the
    ///         <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef struct VkIndirectCommandsIndexBufferTokenEXT {
    ///             VkIndirectCommandsInputModeFlagBitsEXT    mode;
    ///         } VkIndirectCommandsIndexBufferTokenEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkIndirectCommandsIndexBufferTokenEXT()
    {
        /// <summary>
        ///     <c>Mode</c> specifies the mode to use with this token.
        /// </summary>
        [FieldOffset(0)]
        public VkIndirectCommandsInputModeFlagsEXT Mode;
    }
}
