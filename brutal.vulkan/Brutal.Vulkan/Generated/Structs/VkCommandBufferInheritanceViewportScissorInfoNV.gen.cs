namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceViewportScissorInfoNV.html">VkCommandBufferInheritanceViewportScissorInfoNV</see> - Structure specifying command buffer inheritance information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandBufferInheritanceViewportScissorInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_inherited_viewport_scissor
    ///         typedef struct VkCommandBufferInheritanceViewportScissorInfoNV {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkBool32             viewportScissor2D;
    ///             uint32_t             viewportDepthCount;
    ///             const VkViewport*    pViewportDepths;
    ///         } VkCommandBufferInheritanceViewportScissorInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCommandBufferInheritanceViewportScissorInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceViewportScissorInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ViewportScissor2D</c> specifies whether the listed dynamic state is inherited.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ViewportScissor2D;

        /// <summary>
        ///     <c>ViewportDepthCount</c> specifies the maximum number of viewports to inherit. When <c>viewportScissor2D</c> is <c>VK_FALSE</c>, the behavior is as if this value is zero.
        /// </summary>
        [FieldOffset(20)]
        public int ViewportDepthCount;

        /// <summary>
        ///     <c>ViewportDepths</c> is a pointer to a <c>VkViewport</c> structure specifying the expected depth range for each inherited viewport.
        /// </summary>
        [FieldOffset(24)]
        public VkViewport* ViewportDepths;
    }
}
