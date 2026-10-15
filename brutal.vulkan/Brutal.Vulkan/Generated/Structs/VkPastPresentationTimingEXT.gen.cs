namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingEXT.html">VkPastPresentationTimingEXT</see> - Structure containing timing information about a previously-presented image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPastPresentationTimingEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPastPresentationTimingEXT {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             uint64_t                  presentId;
    ///             uint64_t                  targetTime;
    ///             uint32_t                  presentStageCount;
    ///             VkPresentStageTimeEXT*    pPresentStages;
    ///             VkTimeDomainKHR           timeDomain;
    ///             uint64_t                  timeDomainId;
    ///             VkBool32                  reportComplete;
    ///         } VkPastPresentationTimingEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkPastPresentationTimingEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PastPresentationTimingEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentId</c> is zero or a value that was given to a previous <c>vkQueuePresentKHR</c> command via <c>VkPresentId2KHR::pPresentIds</c>.
        /// </summary>
        [FieldOffset(16)]
        public nint PresentId;

        /// <summary>
        ///     <c>TargetTime</c> is the application-provided target absolute time or duration of the associated presentation request in <c>VkPresentTimingInfoEXT::targetTime</c>.
        /// </summary>
        [FieldOffset(24)]
        public nint TargetTime;

        /// <summary>
        ///     <c>PresentStageCount</c> is a count of items contained in <c>pPresentStages</c>.
        /// </summary>
        [FieldOffset(32)]
        public int PresentStageCount;

        /// <summary>
        ///     <c>PresentStages</c> a pointer to an array of <c>VkPresentStageTimeEXT</c> providing timing information for the presentation request associated with <c>presentId</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkPresentStageTimeEXT* PresentStages;

        /// <summary>
        ///     <c>TimeDomain</c> is the time domain used by the presentation engine to report times in <c>pPresentStages</c>.
        /// </summary>
        [FieldOffset(48)]
        public VkTimeDomainKHR TimeDomain;

        /// <summary>
        ///     <c>TimeDomainId</c> is the id associated with <c>timeDomain</c>.
        /// </summary>
        [FieldOffset(56)]
        public nint TimeDomainId;

        /// <summary>
        ///     <c>ReportComplete</c> is <c>VK_TRUE</c> if the presentation engine has reported all the requested results in <c>pPresentStages</c>.
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 ReportComplete;
    }
}
