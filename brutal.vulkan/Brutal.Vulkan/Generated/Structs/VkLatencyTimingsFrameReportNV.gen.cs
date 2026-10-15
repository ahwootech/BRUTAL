namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencyTimingsFrameReportNV.html">VkLatencyTimingsFrameReportNV</see> - Structure containing latency data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencyTimingsFrameReportNV</c> structure describes latency data
    ///         returned by <c>vkGetLatencyTimingsNV</c>
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkLatencyTimingsFrameReportNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           presentID;
    ///             uint64_t           inputSampleTimeUs;
    ///             uint64_t           simStartTimeUs;
    ///             uint64_t           simEndTimeUs;
    ///             uint64_t           renderSubmitStartTimeUs;
    ///             uint64_t           renderSubmitEndTimeUs;
    ///             uint64_t           presentStartTimeUs;
    ///             uint64_t           presentEndTimeUs;
    ///             uint64_t           driverStartTimeUs;
    ///             uint64_t           driverEndTimeUs;
    ///             uint64_t           osRenderQueueStartTimeUs;
    ///             uint64_t           osRenderQueueEndTimeUs;
    ///             uint64_t           gpuRenderStartTimeUs;
    ///             uint64_t           gpuRenderEndTimeUs;
    ///         } VkLatencyTimingsFrameReportNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public unsafe partial struct VkLatencyTimingsFrameReportNV()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LatencyTimingsFrameReportNV;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentID</c>
        /// </summary>
        [FieldOffset(16)]
        public nint PresentID;

        /// <summary>
        ///     <c>InputSampleTimeUs</c>
        /// </summary>
        [FieldOffset(24)]
        public nint InputSampleTimeUs;

        /// <summary>
        ///     <c>SimStartTimeUs</c>
        /// </summary>
        [FieldOffset(32)]
        public nint SimStartTimeUs;

        /// <summary>
        ///     <c>SimEndTimeUs</c>
        /// </summary>
        [FieldOffset(40)]
        public nint SimEndTimeUs;

        /// <summary>
        ///     <c>RenderSubmitStartTimeUs</c>
        /// </summary>
        [FieldOffset(48)]
        public nint RenderSubmitStartTimeUs;

        /// <summary>
        ///     <c>RenderSubmitEndTimeUs</c>
        /// </summary>
        [FieldOffset(56)]
        public nint RenderSubmitEndTimeUs;

        /// <summary>
        ///     <c>PresentStartTimeUs</c>
        /// </summary>
        [FieldOffset(64)]
        public nint PresentStartTimeUs;

        /// <summary>
        ///     <c>PresentEndTimeUs</c>
        /// </summary>
        [FieldOffset(72)]
        public nint PresentEndTimeUs;

        /// <summary>
        ///     <c>DriverStartTimeUs</c>
        /// </summary>
        [FieldOffset(80)]
        public nint DriverStartTimeUs;

        /// <summary>
        ///     <c>DriverEndTimeUs</c>
        /// </summary>
        [FieldOffset(88)]
        public nint DriverEndTimeUs;

        /// <summary>
        ///     <c>OsRenderQueueStartTimeUs</c>
        /// </summary>
        [FieldOffset(96)]
        public nint OsRenderQueueStartTimeUs;

        /// <summary>
        ///     <c>OsRenderQueueEndTimeUs</c>
        /// </summary>
        [FieldOffset(104)]
        public nint OsRenderQueueEndTimeUs;

        /// <summary>
        ///     <c>GpuRenderStartTimeUs</c>
        /// </summary>
        [FieldOffset(112)]
        public nint GpuRenderStartTimeUs;

        /// <summary>
        ///     <c>GpuRenderEndTimeUs</c>
        /// </summary>
        [FieldOffset(120)]
        public nint GpuRenderEndTimeUs;
    }
}
