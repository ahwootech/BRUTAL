namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionBindingPointNV.html">VkOpticalFlowSessionBindingPointNV</see> - Binding points of an optical flow session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The optical flow session binding points are defined with the following:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef enum VkOpticalFlowSessionBindingPointNV {
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV = 0,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV = 1,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV = 2,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV = 3,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV = 4,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV = 5,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV = 6,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV = 7,
    ///             VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV = 8,
    ///         } VkOpticalFlowSessionBindingPointNV;
    ///     </code>
    /// </remarks>
    public enum VkOpticalFlowSessionBindingPointNV : int
    {
        /// <summary>
        ///     <c>UnknownNV</c>
        /// </summary>
        UnknownNV = 0,

        /// <summary>
        ///     <c>InputNV</c> specifies the binding point for the input frame.
        /// </summary>
        InputNV = 1,

        /// <summary>
        ///     <c>ReferenceNV</c> specifies the binding point for the input reference frame.
        /// </summary>
        ReferenceNV = 2,

        /// <summary>
        ///     <c>HintNV</c> specifies the binding point for the optional external hint flow vectors.
        /// </summary>
        HintNV = 3,

        /// <summary>
        ///     <c>FlowVectorNV</c> specifies the binding point for output flow vectors of default forward flow calculation.
        /// </summary>
        FlowVectorNV = 4,

        /// <summary>
        ///     <c>BackwardFlowVectorNV</c>  specifies the binding point for the optional output flow vector map of optional backward flow calculation.
        /// </summary>
        BackwardFlowVectorNV = 5,

        /// <summary>
        ///     <c>CostNV</c> specifies the binding point for the optional output cost map of default forward flow calculation.
        /// </summary>
        CostNV = 6,

        /// <summary>
        ///     <c>BackwardCostNV</c> specifies the binding point for the optional output cost map of optional backward flow calculation.
        /// </summary>
        BackwardCostNV = 7,

        /// <summary>
        ///     <c>GlobalFlowNV</c> specifies the binding point for the optional global flow value of default forward flow calculation.
        /// </summary>
        GlobalFlowNV = 8,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
