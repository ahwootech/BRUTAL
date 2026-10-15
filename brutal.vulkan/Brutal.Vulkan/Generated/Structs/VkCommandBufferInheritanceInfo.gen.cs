namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceInfo.html">VkCommandBufferInheritanceInfo</see> - Structure specifying command buffer inheritance information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the command buffer is a secondary command buffer, then the
    ///         <c>VkCommandBufferInheritanceInfo</c> structure defines any state that will
    ///         be inherited from the primary command buffer:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkCommandBufferInheritanceInfo {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkRenderPass                     renderPass;
    ///             uint32_t                         subpass;
    ///             VkFramebuffer                    framebuffer;
    ///             VkBool32                         occlusionQueryEnable;
    ///             VkQueryControlFlags              queryFlags;
    ///             VkQueryPipelineStatisticFlags    pipelineStatistics;
    ///         } VkCommandBufferInheritanceInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCommandBufferInheritanceInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPass</c> is a <c>VkRenderPass</c> object defining which render passes the <c>VkCommandBuffer</c> will be <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-compatibility">compatible^</see> with and <i>can</i> be executed within.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPass RenderPass;

        /// <summary>
        ///     <c>Subpass</c> is the index of the subpass within the render pass instance that the <c>VkCommandBuffer</c> will be executed within.
        /// </summary>
        [FieldOffset(24)]
        public int Subpass;

        /// <summary>
        ///     <c>Framebuffer</c> <i>can</i> refer to the <c>VkFramebuffer</c> object that the <c>VkCommandBuffer</c> will be rendering to if it is executed within a render pass instance. It <i>can</i> be <c>VK_NULL_HANDLE</c> if the framebuffer is not known. + [NOTE]
        /// </summary>
        [FieldOffset(32)]
        public VkFramebuffer Framebuffer;

        /// <summary>
        ///     <c>OcclusionQueryEnable</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 OcclusionQueryEnable;

        /// <summary>
        ///     <c>QueryFlags</c>
        /// </summary>
        [FieldOffset(44)]
        public VkQueryControlFlags QueryFlags;

        /// <summary>
        ///     <c>PipelineStatistics</c>
        /// </summary>
        [FieldOffset(48)]
        public VkQueryPipelineStatisticFlags PipelineStatistics;
    }
}
