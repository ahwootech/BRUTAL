namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimeGOOGLE.html">VkPresentTimeGOOGLE</see> - The earliest time image should be presented
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentTimeGOOGLE</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_GOOGLE_display_timing
    ///         typedef struct VkPresentTimeGOOGLE {
    ///             uint32_t    presentID;
    ///             uint64_t    desiredPresentTime;
    ///         } VkPresentTimeGOOGLE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPresentTimeGOOGLE()
    {
        /// <summary>
        ///     <c>PresentID</c> is an application-provided identification value, that <i>can</i> be used with the results of <c>vkGetPastPresentationTimingGOOGLE</c>, in order to uniquely identify this present. In order to be useful to the application, it <i>should</i> be unique within some period of time that is meaningful to the application.
        /// </summary>
        [FieldOffset(0)]
        public int PresentID;

        /// <summary>
        ///     <c>DesiredPresentTime</c> specifies that the image given <i>should</i> not be displayed to the user any earlier than this time. <c>desiredPresentTime</c> is a time in nanoseconds, relative to a monotonically-increasing clock (e.g. `CLOCK_MONOTONIC` (see clock_gettime(2)) on Android and Linux). A value of zero specifies that the presentation engine may: display the image at any time. This is useful when the application desires to provide <c>presentID</c>,
        /// </summary>
        [FieldOffset(8)]
        public nint DesiredPresentTime;
    }
}
