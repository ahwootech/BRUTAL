namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassTransformBeginInfoQCOM.html">VkRenderPassTransformBeginInfoQCOM</see> - Structure describing transform parameters of a render pass instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To begin a render pass instance with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vertexpostproc-renderpass-transform">render pass transform^</see> enabled, add the
    ///         <c>VkRenderPassTransformBeginInfoQCOM</c> to the <c>pNext</c> chain of
    ///         <c>VkRenderPassBeginInfo</c> structure passed to the
    ///         <c>vkCmdBeginRenderPass</c> command specifying the render pass transform.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassTransformBeginInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_render_pass_transform
    ///         typedef struct VkRenderPassTransformBeginInfoQCOM {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkSurfaceTransformFlagBitsKHR    transform;
    ///         } VkRenderPassTransformBeginInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderPassTransformBeginInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassTransformBeginInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Transform</c> is a <c>VkSurfaceTransformFlagsKHR</c> value describing the transform to be applied to rasterization.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceTransformFlagsKHR Transform;
    }
}
