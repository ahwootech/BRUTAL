namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportStateCreateInfo.html">VkPipelineViewportStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline viewport state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineViewportStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineViewportStateCreateInfo {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkPipelineViewportStateCreateFlags    flags;
    ///             uint32_t                              viewportCount;
    ///             const VkViewport*                     pViewports;
    ///             uint32_t                              scissorCount;
    ///             const VkRect2D*                       pScissors;
    ///         } VkPipelineViewportStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPipelineViewportStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineViewportStateCreateFlags Flags;

        /// <summary>
        ///     <c>ViewportCount</c> is the number of viewports used by the pipeline.
        /// </summary>
        [FieldOffset(20)]
        public int ViewportCount;

        /// <summary>
        ///     <c>Viewports</c> is a pointer to an array of <c>VkViewport</c> structures, defining the viewport transforms. If the viewport state is dynamic, this member is ignored.
        /// </summary>
        [FieldOffset(24)]
        public VkViewport* Viewports;

        /// <summary>
        ///     <c>ScissorCount</c> is the number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-scissor">scissors^</see> and <i>must</i> match the number of viewports.
        /// </summary>
        [FieldOffset(32)]
        public int ScissorCount;

        /// <summary>
        ///     <c>Scissors</c> is a pointer to an array of <c>VkRect2D</c> structures defining the rectangular bounds of the scissor for the corresponding viewport. If the scissor state is dynamic, this member is ignored.
        /// </summary>
        [FieldOffset(40)]
        public VkRect2D* Scissors;
    }
}
