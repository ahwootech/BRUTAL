namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowExecuteFlagBitsARM.html">VkDataGraphOpticalFlowExecuteFlagBitsARM</see> - Bits specifying flags for a optical flow vector calculation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDataGraphPipelineOpticalFlowDispatchInfoARM::flags</c>,
    ///         controlling optical flow execution, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef enum VkDataGraphOpticalFlowExecuteFlagBitsARM {
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_ARM = 0x00000001,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_INPUT_UNCHANGED_BIT_ARM = 0x00000002,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_REFERENCE_UNCHANGED_BIT_ARM = 0x00000004,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_INPUT_IS_PREVIOUS_REFERENCE_BIT_ARM = 0x00000008,
    ///             VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_REFERENCE_IS_PREVIOUS_INPUT_BIT_ARM = 0x00000010,
    ///         } VkDataGraphOpticalFlowExecuteFlagBitsARM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDataGraphOpticalFlowExecuteFlagsARM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DisableTemporalHintsBitARM</c>  specifies that temporal hints from previously generated flow vector map are not used. If temporal hints are enabled, the optical flow vector map from previous <c>vkCmdDispatchDataGraphARM</c> calls in the same graph pipeline session may: be automatically used as hints for the current <c>vkCmdDispatchDataGraphARM</c> call, to take advantage of temporal correlation in a video sequence. Temporal hints should be disabled if there is a-priori knowledge of no temporal correlation (e.g. a scene change, independent successive image pairs).
        /// </summary>
        DisableTemporalHintsBitARM = 0x00000001,

        /// <summary>
        ///     <c>InputUnchangedBitARM</c>  specifies that the contents of the input image are the same as in the previously executed <c>vkCmdDispatchDataGraphARM</c> call in the same graph pipeline session.
        /// </summary>
        InputUnchangedBitARM = 0x00000002,

        /// <summary>
        ///     <c>ReferenceUnchangedBitARM</c>  specifies that the contents of the reference image are the same as in the previously executed <c>vkCmdDispatchDataGraphARM</c> call in the same graph pipeline session.
        /// </summary>
        ReferenceUnchangedBitARM = 0x00000004,

        /// <summary>
        ///     <c>InputIsPreviousReferenceBitARM</c>  specifies that the contents of the input image are the same as the contents of the reference image in the previously executed <c>vkCmdDispatchDataGraphARM</c> call in the same graph pipeline session.
        /// </summary>
        InputIsPreviousReferenceBitARM = 0x00000008,

        /// <summary>
        ///     <c>ReferenceIsPreviousInputBitARM</c>  specifies that the contents of the reference image are the same as the contents of the input image in the previously executed <c>vkCmdDispatchDataGraphARM</c> call in the same graph pipeline session.
        /// </summary>
        ReferenceIsPreviousInputBitARM = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumARM</c>
        /// </summary>
        FlagBitsMaxEnumARM = 0x7FFFFFFF,
    }
}
