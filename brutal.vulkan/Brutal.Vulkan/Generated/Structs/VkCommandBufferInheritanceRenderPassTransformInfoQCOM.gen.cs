namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderPassTransformInfoQCOM.html">VkCommandBufferInheritanceRenderPassTransformInfoQCOM</see> - Structure describing transformed render pass parameters command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To begin recording a secondary command buffer compatible with execution
    ///         inside a render pass using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vertexpostproc-renderpass-transform">render
    ///         pass transform^</see>, add the
    ///         <c>VkCommandBufferInheritanceRenderPassTransformInfoQCOM</c> to the
    ///         <c>pNext</c> chain of <c>VkCommandBufferInheritanceInfo</c> structure passed
    ///         to the <c>vkBeginCommandBuffer</c> command specifying the parameters for
    ///         transformed rasterization.
    ///     </para>
    ///     <para>
    ///         The <c>VkCommandBufferInheritanceRenderPassTransformInfoQCOM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_render_pass_transform
    ///         typedef struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkSurfaceTransformFlagBitsKHR    transform;
    ///             VkRect2D                         renderArea;
    ///         } VkCommandBufferInheritanceRenderPassTransformInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceRenderPassTransformInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Transform</c> is a <c>VkSurfaceTransformFlagsKHR</c> value describing the transform to be applied to the render pass.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceTransformFlagsKHR Transform;

        /// <summary>
        ///     <c>RenderArea</c> is the render area that is affected by the command buffer.
        /// </summary>
        [FieldOffset(20)]
        public VkRect2D RenderArea;
    }
}
