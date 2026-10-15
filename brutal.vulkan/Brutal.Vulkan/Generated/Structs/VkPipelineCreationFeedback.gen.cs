namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedback.html">VkPipelineCreationFeedback</see> - Feedback about the creation of a pipeline or pipeline stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineCreationFeedback</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPipelineCreationFeedback {
    ///             VkPipelineCreationFeedbackFlags    flags;
    ///             uint64_t                           duration;
    ///         } VkPipelineCreationFeedback;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPipelineCreationFeedback()
    {
        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPipelineCreationFeedbackFlags</c> providing feedback about the creation of a pipeline or of a pipeline stage.
        /// </summary>
        [FieldOffset(0)]
        public VkPipelineCreationFeedbackFlags Flags;

        /// <summary>
        ///     <c>Duration</c> is the duration spent creating a pipeline or pipeline stage in nanoseconds.
        /// </summary>
        [FieldOffset(8)]
        public nint Duration;
    }
}
