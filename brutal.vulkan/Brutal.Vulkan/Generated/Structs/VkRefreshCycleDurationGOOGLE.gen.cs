namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRefreshCycleDurationGOOGLE.html">VkRefreshCycleDurationGOOGLE</see> - Structure containing the RC duration of a display
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRefreshCycleDurationGOOGLE</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_GOOGLE_display_timing
    ///         typedef struct VkRefreshCycleDurationGOOGLE {
    ///             uint64_t    refreshDuration;
    ///         } VkRefreshCycleDurationGOOGLE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkRefreshCycleDurationGOOGLE()
    {
        /// <summary>
        ///     <c>RefreshDuration</c> is the number of nanoseconds from the start of one refresh cycle to the next.
        /// </summary>
        [FieldOffset(0)]
        public nint RefreshDuration;
    }
}
