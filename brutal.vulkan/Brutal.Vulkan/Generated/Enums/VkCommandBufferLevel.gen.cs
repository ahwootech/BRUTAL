namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferLevel.html">VkCommandBufferLevel</see> - Enumerant specifying a command buffer level
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkCommandBufferAllocateInfo::level</c>,
    ///         specifying the command buffer level, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCommandBufferLevel {
    ///             VK_COMMAND_BUFFER_LEVEL_PRIMARY = 0,
    ///             VK_COMMAND_BUFFER_LEVEL_SECONDARY = 1,
    ///         } VkCommandBufferLevel;
    ///     </code>
    /// </remarks>
    public enum VkCommandBufferLevel : int
    {
        /// <summary>
        ///     <c>Primary</c> specifies a primary command buffer.
        /// </summary>
        Primary = 0,

        /// <summary>
        ///     <c>Secondary</c> specifies a secondary command buffer.
        /// </summary>
        Secondary = 1,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
