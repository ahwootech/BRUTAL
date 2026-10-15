namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportWScalingStateCreateInfoNV.html">VkPipelineViewportWScalingStateCreateInfoNV</see> - Structure specifying parameters of a newly created pipeline viewport W scaling state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineViewportWScalingStateCreateInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_clip_space_w_scaling
    ///         typedef struct VkPipelineViewportWScalingStateCreateInfoNV {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkBool32                       viewportWScalingEnable;
    ///             uint32_t                       viewportCount;
    ///             const VkViewportWScalingNV*    pViewportWScalings;
    ///         } VkPipelineViewportWScalingStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportWScalingStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ViewportWScalingEnable</c> controls whether viewport *W* scaling is enabled.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ViewportWScalingEnable;

        /// <summary>
        ///     <c>ViewportCount</c> is the number of viewports used by *W* scaling, and <i>must</i> match the number of viewports in the pipeline if viewport *W* scaling is enabled.
        /// </summary>
        [FieldOffset(20)]
        public int ViewportCount;

        /// <summary>
        ///     <c>ViewportWScalings</c> is a pointer to an array of <c>VkViewportWScalingNV</c> structures defining the *W* scaling parameters for the corresponding viewports. If the viewport *W* scaling state is dynamic, this member is ignored.
        /// </summary>
        [FieldOffset(24)]
        public VkViewportWScalingNV* ViewportWScalings;
    }
}
