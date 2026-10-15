namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassContents.html">VkSubpassContents</see> - Specify how commands in the first subpass of a render pass are provided
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>vkCmdBeginRenderPass::contents</c>, specifying
    ///         how the commands in the first subpass will be provided, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSubpassContents {
    ///             VK_SUBPASS_CONTENTS_INLINE = 0,
    ///             VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = 1,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_KHR = 1000451000,
    ///             // Provided by VK_EXT_nested_command_buffer
    ///             VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_EXT = VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_KHR,
    ///         } VkSubpassContents;
    ///     </code>
    /// </remarks>
    public enum VkSubpassContents : int
    {
        /// <summary>
        ///     <c>Inline</c> specifies that the contents of the subpass will be recorded inline in the primary command buffer, and secondary command buffers <i>must</i> not be executed within the subpass.
        /// </summary>
        Inline = 0,

        /// <summary>
        ///     <c>SecondaryCommandBuffers</c> specifies that the contents are recorded in secondary command buffers that will be called from the primary command buffer, and <c>vkCmdExecuteCommands</c> is the only valid command in the command buffer until <c>vkCmdNextSubpass</c> or <c>vkCmdEndRenderPass</c>.
        /// </summary>
        SecondaryCommandBuffers = 1,

        /// <summary>
        ///     <c>InlineAndSecondaryCommandBuffersKHR</c>
        /// </summary>
        InlineAndSecondaryCommandBuffersKHR = 1000451000,

        /// <summary>
        ///     <c>InlineAndSecondaryCommandBuffersEXT</c>
        /// </summary>
        InlineAndSecondaryCommandBuffersEXT = InlineAndSecondaryCommandBuffersKHR,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
