namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPastPresentationTimingFlagBitsEXT.html">VkPastPresentationTimingFlagBitsEXT</see> - Bitmask specifying past presentation timing query flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPastPresentationTimingInfoEXT::flags</c>, specifying options for
    ///         queries of past presentation timing information, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef enum VkPastPresentationTimingFlagBitsEXT {
    ///             VK_PAST_PRESENTATION_TIMING_ALLOW_PARTIAL_RESULTS_BIT_EXT = 0x00000001,
    ///             VK_PAST_PRESENTATION_TIMING_ALLOW_OUT_OF_ORDER_RESULTS_BIT_EXT = 0x00000002,
    ///         } VkPastPresentationTimingFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPastPresentationTimingFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AllowPartialResultsBitEXT</c>  specifies that <c>vkGetPastPresentationTimingEXT</c> may: return partial results for presentation requests that have not completed all requested present stages.
        /// </summary>
        AllowPartialResultsBitEXT = 0x00000001,

        /// <summary>
        ///     <c>AllowOutOfOrderResultsBitEXT</c>  specifies that <c>vkGetPastPresentationTimingEXT</c> may: return results out of order with respect to the presentation order.
        /// </summary>
        AllowOutOfOrderResultsBitEXT = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
