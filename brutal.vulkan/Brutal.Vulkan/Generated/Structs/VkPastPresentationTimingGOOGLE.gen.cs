namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingGOOGLE.html">VkPastPresentationTimingGOOGLE</see> - Structure containing timing information about a previously-presented image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPastPresentationTimingGOOGLE</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_GOOGLE_display_timing
    ///         typedef struct VkPastPresentationTimingGOOGLE {
    ///             uint32_t    presentID;
    ///             uint64_t    desiredPresentTime;
    ///             uint64_t    actualPresentTime;
    ///             uint64_t    earliestPresentTime;
    ///             uint64_t    presentMargin;
    ///         } VkPastPresentationTimingGOOGLE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct VkPastPresentationTimingGOOGLE()
    {
        /// <summary>
        ///     <c>PresentID</c> is an application-provided value that was given to a previous <c>vkQueuePresentKHR</c> command via <c>VkPresentTimeGOOGLE::presentID</c> (see below). It <i>can</i> be used to uniquely identify a previous present with the <c>vkQueuePresentKHR</c> command.
        /// </summary>
        [FieldOffset(0)]
        public int PresentID;

        /// <summary>
        ///     <c>DesiredPresentTime</c> is an application-provided value that was given to a previous <c>vkQueuePresentKHR</c> command via <c>VkPresentTimeGOOGLE::desiredPresentTime</c>. If non-zero, it was used by the application to indicate that an image not be presented any sooner than <c>desiredPresentTime</c>.
        /// </summary>
        [FieldOffset(8)]
        public nint DesiredPresentTime;

        /// <summary>
        ///     <c>ActualPresentTime</c> is the time when the image of the <c>swapchain</c> was actually displayed.
        /// </summary>
        [FieldOffset(16)]
        public nint ActualPresentTime;

        /// <summary>
        ///     <c>EarliestPresentTime</c> is the time when the image of the <c>swapchain</c> could have been displayed. This may: differ from <c>actualPresentTime</c> if the application requested that the image be presented no sooner than <c>VkPresentTimeGOOGLE::desiredPresentTime</c>.
        /// </summary>
        [FieldOffset(24)]
        public nint EarliestPresentTime;

        /// <summary>
        ///     <c>PresentMargin</c> is an indication of how early the <c>vkQueuePresentKHR</c> command was processed compared to how soon it needed to be processed, and still be presented at <c>earliestPresentTime</c>.
        /// </summary>
        [FieldOffset(32)]
        public nint PresentMargin;
    }
}
