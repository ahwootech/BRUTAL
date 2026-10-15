namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateInfoNV.html">VkOpticalFlowSessionCreateInfoNV</see> - Structure specifying parameters of a newly created optical flow session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpticalFlowSessionCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef struct VkOpticalFlowSessionCreateInfoNV {
    ///             VkStructureType                      sType;
    ///             void*                                pNext;
    ///             uint32_t                             width;
    ///             uint32_t                             height;
    ///             VkFormat                             imageFormat;
    ///             VkFormat                             flowVectorFormat;
    ///             VkFormat                             costFormat;
    ///             VkOpticalFlowGridSizeFlagsNV         outputGridSize;
    ///             VkOpticalFlowGridSizeFlagsNV         hintGridSize;
    ///             VkOpticalFlowPerformanceLevelNV      performanceLevel;
    ///             VkOpticalFlowSessionCreateFlagsNV    flags;
    ///         } VkOpticalFlowSessionCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkOpticalFlowSessionCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpticalFlowSessionCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Width</c> is the width in pixels of the input or reference frame to be bound to this optical flow session.
        /// </summary>
        [FieldOffset(16)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is the height in pixels of the input or reference frame to be bound to this optical flow session.
        /// </summary>
        [FieldOffset(20)]
        public int Height;

        /// <summary>
        ///     <c>ImageFormat</c> is the <c>VkFormat</c> of the input and reference frame to be bound to this optical flow session.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat ImageFormat;

        /// <summary>
        ///     <c>FlowVectorFormat</c> is the <c>VkFormat</c> of the flow vector maps (output or hint) to be bound to this optical flow session.
        /// </summary>
        [FieldOffset(28)]
        public VkFormat FlowVectorFormat;

        /// <summary>
        ///     <c>CostFormat</c> is the <c>VkFormat</c> of the cost maps to be bound to this optical flow session.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat CostFormat;

        /// <summary>
        ///     <c>OutputGridSize</c> is exactly one bit of <c>VkOpticalFlowGridSizeFlagsNV</c> specifying the grid size of the output flow and cost maps to be bound to this optical flow session. The size of the output flow and cost maps is determined by <c>VkOpticalFlowSessionCreateInfoNV::width</c> and <c>VkOpticalFlowSessionCreateInfoNV::height</c> divided by <c>VkOpticalFlowSessionCreateInfoNV::outputGridSize</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkOpticalFlowGridSizeFlagsNV OutputGridSize;

        /// <summary>
        ///     <c>HintGridSize</c> is one exactly bit of <c>VkOpticalFlowGridSizeFlagsNV</c> specifying the grid size of the hint flow vector maps to be bound to this optical flow session. The size of the hint maps is determined by <c>VkOpticalFlowSessionCreateInfoNV::width</c> and <c>VkOpticalFlowSessionCreateInfoNV::height</c> divided by <c>VkOpticalFlowSessionCreateInfoNV::hintGridSize</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkOpticalFlowGridSizeFlagsNV HintGridSize;

        /// <summary>
        ///     <c>PerformanceLevel</c> is the <c>VkOpticalFlowPerformanceLevelNV</c> used for this optical flow session.
        /// </summary>
        [FieldOffset(44)]
        public VkOpticalFlowPerformanceLevelNV PerformanceLevel;

        /// <summary>
        ///     <c>Flags</c> are the <c>VkOpticalFlowSessionCreateFlagsNV</c> used for this optical flow session.
        /// </summary>
        [FieldOffset(48)]
        public VkOpticalFlowSessionCreateFlagsNV Flags;
    }
}
