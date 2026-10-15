namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowUsageFlagBitsNV.html">VkOpticalFlowUsageFlagBitsNV</see> - Bits specifying usage for optical flow operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkOpticalFlowImageFormatInfoNV::usage</c>,
    ///         controlling optical flow usage, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowUsageFlagBitsNV {
    ///             VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV = 0,
    ///             VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV = 0x00000001,
    ///             VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV = 0x00000002,
    ///             VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV = 0x00000004,
    ///             VK_OPTICAL_FLOW_USAGE_COST_BIT_NV = 0x00000008,
    ///             VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV = 0x00000010,
    ///         } VkOpticalFlowUsageFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkOpticalFlowUsageFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UnknownNV</c>
        /// </summary>
        UnknownNV = 0,

        /// <summary>
        ///     <c>InputBitNV</c> specifies that the image <i>can</i> be used as input or reference frame for an optical flow operation.
        /// </summary>
        InputBitNV = 0x00000001,

        /// <summary>
        ///     <c>OutputBitNV</c> specifies that the image <i>can</i> be used as output flow vector map for an optical flow operation.
        /// </summary>
        OutputBitNV = 0x00000002,

        /// <summary>
        ///     <c>HintBitNV</c> specifies that the image <i>can</i> be used as hint flow vector map for an optical flow operation.
        /// </summary>
        HintBitNV = 0x00000004,

        /// <summary>
        ///     <c>CostBitNV</c> specifies that the image <i>can</i> be used as output cost map for an optical flow operation.
        /// </summary>
        CostBitNV = 0x00000008,

        /// <summary>
        ///     <c>GlobalFlowBitNV</c> specifies that the image <i>can</i> be used as global flow vector for an optical flow operation.
        /// </summary>
        GlobalFlowBitNV = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
