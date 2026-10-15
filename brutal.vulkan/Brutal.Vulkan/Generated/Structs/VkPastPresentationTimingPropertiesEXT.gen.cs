namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingPropertiesEXT.html">VkPastPresentationTimingPropertiesEXT</see> - Structure containing details about a swapchain past presentation activity
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPastPresentationTimingPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPastPresentationTimingPropertiesEXT {
    ///             VkStructureType                 sType;
    ///             void*                           pNext;
    ///             uint64_t                        timingPropertiesCounter;
    ///             uint64_t                        timeDomainsCounter;
    ///             uint32_t                        presentationTimingCount;
    ///             VkPastPresentationTimingEXT*    pPresentationTimings;
    ///         } VkPastPresentationTimingPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPastPresentationTimingPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PastPresentationTimingPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TimingPropertiesCounter</c> is a 64-bit unsigned integer set by the implementation to the current value of the swapchain&apos;s internal timing properties counter.
        /// </summary>
        [FieldOffset(16)]
        public nint TimingPropertiesCounter;

        /// <summary>
        ///     <c>TimeDomainsCounter</c> is a 64-bit unsigned integer set by the implementation to the current value of the swapchain&apos;s internal time domains list counter.
        /// </summary>
        [FieldOffset(24)]
        public nint TimeDomainsCounter;

        /// <summary>
        ///     <c>PresentationTimingCount</c> is an integer related to the number of <c>VkPastPresentationTimingEXT</c> structures available or queried, as described below.
        /// </summary>
        [FieldOffset(32)]
        public int PresentationTimingCount;

        /// <summary>
        ///     <c>PresentationTimings</c> is `NULL` or a pointer to an array of <c>VkPastPresentationTimingEXT</c> structures.
        /// </summary>
        [FieldOffset(40)]
        public VkPastPresentationTimingEXT* PresentationTimings;
    }
}
