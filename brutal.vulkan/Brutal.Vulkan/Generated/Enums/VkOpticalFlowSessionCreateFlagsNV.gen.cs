namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateFlagBitsNV.html">VkOpticalFlowSessionCreateFlagBitsNV</see> - Bits specifying flags for optical flow session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkOpticalFlowSessionCreateInfoNV::flags</c>, controlling optical
    ///         flow session operations, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowSessionCreateFlagBitsNV {
    ///             VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV = 0x00000001,
    ///             VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV = 0x00000002,
    ///             VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV = 0x00000004,
    ///             VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV = 0x00000008,
    ///             VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV = 0x00000010,
    ///         } VkOpticalFlowSessionCreateFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkOpticalFlowSessionCreateFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>EnableHintBitNV</c> specifies that a <c>VkImageView</c> with external flow vectors will be used as hints in performing the motion search and <i>must</i> be bound to <c>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV</c>.
        /// </summary>
        EnableHintBitNV = 0x00000001,

        /// <summary>
        ///     <c>EnableCostBitNV</c> specifies that the cost for the forward flow is generated in a <c>VkImageView</c> which <i>must</i> be bound to <c>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV</c>. Additionally, if <c>VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV</c> is also set, the cost for backward flow is generated in a <c>VkImageView</c> which <i>must</i> be bound to <c>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV</c>. The cost is the confidence level of the flow vector for each grid in the frame. The Cost implies how (in)accurate the flow vector is. Higher cost value implies the flow vector to be less accurate and vice-versa.
        /// </summary>
        EnableCostBitNV = 0x00000002,

        /// <summary>
        ///     <c>EnableGlobalFlowBitNV</c> specifies that a global flow vector is estimated from forward flow in a single pixel <c>VkImageView</c> which <i>must</i> be bound to <c>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV</c>.
        /// </summary>
        EnableGlobalFlowBitNV = 0x00000004,

        /// <summary>
        ///     <c>AllowRegionsBitNV</c> specifies that regions of interest <i>can</i> be specified in <c>VkOpticalFlowExecuteInfoNV</c>.
        /// </summary>
        AllowRegionsBitNV = 0x00000008,

        /// <summary>
        ///     <c>BothDirectionsBitNV</c> specifies that backward flow is generated in addition to forward flow which is always generated.
        /// </summary>
        BothDirectionsBitNV = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
