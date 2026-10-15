namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencyMarkerNV.html">VkLatencyMarkerNV</see> - Structure used to mark different points in latency
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencyMarkerNV</c> enum is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef enum VkLatencyMarkerNV {
    ///             VK_LATENCY_MARKER_SIMULATION_START_NV = 0,
    ///             VK_LATENCY_MARKER_SIMULATION_END_NV = 1,
    ///             VK_LATENCY_MARKER_RENDERSUBMIT_START_NV = 2,
    ///             VK_LATENCY_MARKER_RENDERSUBMIT_END_NV = 3,
    ///             VK_LATENCY_MARKER_PRESENT_START_NV = 4,
    ///             VK_LATENCY_MARKER_PRESENT_END_NV = 5,
    ///             VK_LATENCY_MARKER_INPUT_SAMPLE_NV = 6,
    ///             VK_LATENCY_MARKER_TRIGGER_FLASH_NV = 7,
    ///             VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV = 8,
    ///             VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV = 9,
    ///             VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV = 10,
    ///             VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV = 11,
    ///         } VkLatencyMarkerNV;
    ///     </code>
    /// </remarks>
    public enum VkLatencyMarkerNV : int
    {
        /// <summary>
        ///     <c>SimulationStartNV</c> <i>should</i> be called at the start of the simulation execution each frame, but after the call to <c>vkLatencySleepNV</c>.
        /// </summary>
        SimulationStartNV = 0,

        /// <summary>
        ///     <c>SimulationEndNV</c> <i>should</i> be called at the end of the simulation execution each frame.
        /// </summary>
        SimulationEndNV = 1,

        /// <summary>
        ///     <c>RendersubmitStartNV</c> <i>should</i> be called at the beginning of the render submission execution each frame. This <i>should</i> be wherever Vulkan API calls are made and <i>must</i> not span into asynchronous rendering.
        /// </summary>
        RendersubmitStartNV = 2,

        /// <summary>
        ///     <c>RendersubmitEndNV</c> <i>should</i> be called at the end of the render submission execution each frame.
        /// </summary>
        RendersubmitEndNV = 3,

        /// <summary>
        ///     <c>PresentStartNV</c> <i>should</i> be called just before <c>vkQueuePresentKHR</c>.
        /// </summary>
        PresentStartNV = 4,

        /// <summary>
        ///     <c>PresentEndNV</c> <i>should</i> be called when <c>vkQueuePresentKHR</c> returns.
        /// </summary>
        PresentEndNV = 5,

        /// <summary>
        ///     <c>InputSampleNV</c> <i>should</i> be called just before the application gathers input data.
        /// </summary>
        InputSampleNV = 6,

        /// <summary>
        ///     <c>TriggerFlashNV</c> <i>should</i> be called anywhere between <c>VK_LATENCY_MARKER_SIMULATION_START_NV</c> and <c>VK_LATENCY_MARKER_SIMULATION_END_NV</c> whenever a left mouse click occurs.
        /// </summary>
        TriggerFlashNV = 7,

        /// <summary>
        ///     <c>OutOfBandRendersubmitStartNV</c>
        /// </summary>
        OutOfBandRendersubmitStartNV = 8,

        /// <summary>
        ///     <c>OutOfBandRendersubmitEndNV</c>
        /// </summary>
        OutOfBandRendersubmitEndNV = 9,

        /// <summary>
        ///     <c>OutOfBandPresentStartNV</c>
        /// </summary>
        OutOfBandPresentStartNV = 10,

        /// <summary>
        ///     <c>OutOfBandPresentEndNV</c>
        /// </summary>
        OutOfBandPresentEndNV = 11,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
