namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindShaderGroupIndirectCommandNV.html">VkBindShaderGroupIndirectCommandNV</see> - Structure specifying input data for a single shader group command token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindShaderGroupIndirectCommandNV</c> structure specifies the input
    ///         data for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef struct VkBindShaderGroupIndirectCommandNV {
    ///             uint32_t    groupIndex;
    ///         } VkBindShaderGroupIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkBindShaderGroupIndirectCommandNV()
    {
        /// <summary>
        ///     <c>GroupIndex</c> specifies which shader group of the current bound graphics pipeline is used.
        /// </summary>
        [FieldOffset(0)]
        public int GroupIndex;
    }
}
