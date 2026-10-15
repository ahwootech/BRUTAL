namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGetLatencyMarkerInfoNV.html">VkGetLatencyMarkerInfoNV</see> - Structure specifying the parameters of vkGetLatencyTimingsNV
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkGetLatencyMarkerInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkGetLatencyMarkerInfoNV {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             uint32_t                          timingCount;
    ///             VkLatencyTimingsFrameReportNV*    pTimings;
    ///         } VkGetLatencyMarkerInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkGetLatencyMarkerInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GetLatencyMarkerInfoNV;

        /// <summary>
        ///     <c>Next</c> is either `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TimingCount</c> is an integer related to the number of previous frames of latency data available or queried, as described below.
        /// </summary>
        [FieldOffset(16)]
        public int TimingCount;

        /// <summary>
        ///     <c>Timings</c> is either `NULL` or a pointer to an array of <c>VkLatencyTimingsFrameReportNV</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkLatencyTimingsFrameReportNV* Timings;
    }
}
