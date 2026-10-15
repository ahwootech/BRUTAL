namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM.html">VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM</see> - Set the multiview per view render areas for a render pass instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If a render pass instance enables multiview and if the
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-multiviewPerViewRenderAreas"><c>multiviewPerViewRenderAreas</c>^</see>
    ///         feature is enabled, the
    ///         <c>VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM</c> structure <i>can</i> be
    ///         included in the <c>pNext</c> chain of <c>VkRenderPassBeginInfo</c>
    ///     </para>
    ///     <para>
    ///         The <c>VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_multiview_per_view_render_areas
    ///         typedef struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           perViewRenderAreaCount;
    ///             const VkRect2D*    pPerViewRenderAreas;
    ///         } VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerViewRenderAreaCount</c> is the number of elements in the <c>pPerViewRenderAreas</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int PerViewRenderAreaCount;

        /// <summary>
        ///     <c>PerViewRenderAreas</c> is a pointer to an array of <c>VkRect2D</c> structures defining the render area for each view.
        /// </summary>
        [FieldOffset(24)]
        public VkRect2D* PerViewRenderAreas;
    }
}
