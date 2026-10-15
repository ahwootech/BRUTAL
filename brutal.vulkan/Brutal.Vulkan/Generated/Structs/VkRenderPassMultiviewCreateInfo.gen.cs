namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassMultiviewCreateInfo.html">VkRenderPassMultiviewCreateInfo</see> - Structure containing multiview information for all subpasses
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>VkRenderPassCreateInfo::pNext</c> chain includes a
    ///         <c>VkRenderPassMultiviewCreateInfo</c> structure, then that structure
    ///         includes an array of view masks, view offsets, and correlation masks for the
    ///         render pass.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassMultiviewCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkRenderPassMultiviewCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           subpassCount;
    ///             const uint32_t*    pViewMasks;
    ///             uint32_t           dependencyCount;
    ///             const int32_t*     pViewOffsets;
    ///             uint32_t           correlationMaskCount;
    ///             const uint32_t*    pCorrelationMasks;
    ///         } VkRenderPassMultiviewCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkRenderPassMultiviewCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassMultiviewCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubpassCount</c> is zero or the number of subpasses in the render pass.
        /// </summary>
        [FieldOffset(16)]
        public int SubpassCount;

        /// <summary>
        ///     <c>ViewMasks</c> is a pointer to an array of <c>subpassCount</c> view masks, where each mask is a bitfield of view indices describing which views rendering is broadcast to in each subpass, when multiview is enabled. If <c>subpassCount</c> is zero, each view mask is treated as zero.
        /// </summary>
        [FieldOffset(24)]
        public int* ViewMasks;

        /// <summary>
        ///     <c>DependencyCount</c> is zero or the number of dependencies in the render pass.
        /// </summary>
        [FieldOffset(32)]
        public int DependencyCount;

        /// <summary>
        ///     <c>ViewOffsets</c> is a pointer to an array of <c>dependencyCount</c> view offsets, one for each dependency. If <c>dependencyCount</c> is zero, each dependency&apos;s view offset is treated as zero. Each view offset controls which views in the source subpass the views in the destination subpass depend on.
        /// </summary>
        [FieldOffset(40)]
        public int* ViewOffsets;

        /// <summary>
        ///     <c>CorrelationMaskCount</c> is zero or the number of correlation masks.
        /// </summary>
        [FieldOffset(48)]
        public int CorrelationMaskCount;

        /// <summary>
        ///     <c>CorrelationMasks</c> is a pointer to an array of <c>correlationMaskCount</c> view masks indicating sets of views that may: be more efficient to render concurrently.
        /// </summary>
        [FieldOffset(56)]
        public int* CorrelationMasks;
    }
}
