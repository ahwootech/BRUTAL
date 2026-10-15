namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteFlagBitsNV.html">VkOpticalFlowExecuteFlagBitsNV</see> - Bits specifying flags for an optical flow vector calculation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkOpticalFlowExecuteInfoNV::flags</c>,
    ///         controlling optical flow execution, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowExecuteFlagBitsNV {
    ///             VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV = 0x00000001,
    ///         } VkOpticalFlowExecuteFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkOpticalFlowExecuteFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DisableTemporalHintsBitNV</c> specifies that temporal hints from previously generated flow vectors are not used. If temporal hints are enabled, optical flow vectors from previous <c>vkCmdOpticalFlowExecuteNV</c> call are automatically used as hints for the current <c>vkCmdOpticalFlowExecuteNV</c> call, to take advantage of temporal correlation in a video sequence. Temporal hints should be disabled if there is a-priori knowledge of no temporal correlation (e.g. a scene change, independent successive frame pairs).
        /// </summary>
        DisableTemporalHintsBitNV = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
