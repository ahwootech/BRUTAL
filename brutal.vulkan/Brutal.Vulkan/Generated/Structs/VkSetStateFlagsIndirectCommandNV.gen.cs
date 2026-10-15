namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSetStateFlagsIndirectCommandNV.html">VkSetStateFlagsIndirectCommandNV</see> - Structure specifying input data for a single state flag command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSetStateFlagsIndirectCommandNV</c> structure specifies the input
    ///         data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV</c> token.
    ///         Which state is changed depends on the <c>VkIndirectStateFlagsNV</c>
    ///         specified at <c>VkIndirectCommandsLayoutNV</c> creation time.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkSetStateFlagsIndirectCommandNV {
    ///             uint32_t    data;
    ///         } VkSetStateFlagsIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkSetStateFlagsIndirectCommandNV()
    {
        /// <summary>
        ///     <c>Data</c> encodes packed state that this command alters.
        /// </summary>
        [FieldOffset(0)]
        public int Data;
    }
}
