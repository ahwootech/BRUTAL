namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimingInfoEXT.html">VkPresentTimingInfoEXT</see> - Specifies per-present timing information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentTimingInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPresentTimingInfoEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkPresentTimingInfoFlagsEXT    flags;
    ///             uint64_t                       targetTime;
    ///             uint64_t                       timeDomainId;
    ///             VkPresentStageFlagsEXT         presentStageQueries;
    ///             VkPresentStageFlagsEXT         targetTimeDomainPresentStage;
    ///         } VkPresentTimingInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPresentTimingInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentTimingInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkPresentTimingInfoFlagsEXT</c> specifying options for how to interpret the timing information.
        /// </summary>
        [FieldOffset(16)]
        public VkPresentTimingInfoFlagsEXT Flags;

        /// <summary>
        ///     <c>TargetTime</c> is zero or a value specifying the target present time or duration, in nanoseconds, of the presentation request.
        /// </summary>
        [FieldOffset(24)]
        public nint TargetTime;

        /// <summary>
        ///     <c>TimeDomainId</c> is the id of the time domain used to specify the absolute target present time and the timing results obtained in a subsequent <c>vkGetPastPresentationTimingEXT</c> call for the current presentation request.
        /// </summary>
        [FieldOffset(32)]
        public nint TimeDomainId;

        /// <summary>
        ///     <c>PresentStageQueries</c> is zero or a valid <c>VkPresentStageFlagsEXT</c> value indicating which present stages the presentation engine will collect timing information for.
        /// </summary>
        [FieldOffset(40)]
        public VkPresentStageFlagsEXT PresentStageQueries;

        /// <summary>
        ///     <c>TargetTimeDomainPresentStage</c> is a valid <c>VkPresentStageFlagsEXT</c> specifying a single present stage used to interpret <c>targetTime</c>.
        /// </summary>
        [FieldOffset(44)]
        public VkPresentStageFlagsEXT TargetTimeDomainPresentStage;
    }
}
