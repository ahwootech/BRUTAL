namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentStageTimeEXT.html">VkPresentStageTimeEXT</see> - Associate a present stage with a timestamp
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentStageTimeEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPresentStageTimeEXT {
    ///             VkPresentStageFlagsEXT    stage;
    ///             uint64_t                  time;
    ///         } VkPresentStageTimeEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPresentStageTimeEXT()
    {
        /// <summary>
        ///     <c>Stage</c> is a <c>VkPresentStageFlagsEXT</c> value specifying a present stage.
        /// </summary>
        [FieldOffset(0)]
        public VkPresentStageFlagsEXT Stage;

        /// <summary>
        ///     <c>Time</c> is a time in nanoseconds associated with the <c>stage</c>.
        /// </summary>
        [FieldOffset(8)]
        public nint Time;
    }
}
