namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsInputModeFlagBitsEXT.html">VkIndirectCommandsInputModeFlagBitsEXT</see> - Bitmask specifying allowed usage of an indirect commands layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which are set in
    ///         <c>VkIndirectCommandsIndexBufferTokenEXT::mode</c>, specifying how an
    ///         index buffer is used, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_generated_commands
    ///         typedef enum VkIndirectCommandsInputModeFlagBitsEXT {
    ///             VK_INDIRECT_COMMANDS_INPUT_MODE_VULKAN_INDEX_BUFFER_EXT = 0x00000001,
    ///             VK_INDIRECT_COMMANDS_INPUT_MODE_DXGI_INDEX_BUFFER_EXT = 0x00000002,
    ///         } VkIndirectCommandsInputModeFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkIndirectCommandsInputModeFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>VulkanIndexBufferEXT</c> specifies that the indirect buffer contains <c>VkBindIndexBufferIndirectCommandEXT</c>.
        /// </summary>
        VulkanIndexBufferEXT = 0x00000001,

        /// <summary>
        ///     <c>DxgiIndexBufferEXT</c> specifies that the indirect buffer contains `D3D12_INDEX_BUFFER_VIEW`.
        /// </summary>
        DxgiIndexBufferEXT = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
