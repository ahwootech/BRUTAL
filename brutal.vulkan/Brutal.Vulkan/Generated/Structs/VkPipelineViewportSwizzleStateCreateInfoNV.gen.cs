namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportSwizzleStateCreateInfoNV.html">VkPipelineViewportSwizzleStateCreateInfoNV</see> - Structure specifying swizzle applied to primitive clip coordinates
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each primitive sent to a given viewport has a swizzle and optional: negation
    ///         applied to its clip coordinates.
    ///         The swizzle that is applied depends on the viewport index, and is controlled
    ///         by the <c>VkPipelineViewportSwizzleStateCreateInfoNV</c> pipeline state:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_viewport_swizzle
    ///         typedef struct VkPipelineViewportSwizzleStateCreateInfoNV {
    ///             VkStructureType                                sType;
    ///             const void*                                    pNext;
    ///             VkPipelineViewportSwizzleStateCreateFlagsNV    flags;
    ///             uint32_t                                       viewportCount;
    ///             const VkViewportSwizzleNV*                     pViewportSwizzles;
    ///         } VkPipelineViewportSwizzleStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportSwizzleStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineViewportSwizzleStateCreateFlagsNV Flags;

        /// <summary>
        ///     <c>ViewportCount</c> is the number of viewport swizzles used by the pipeline.
        /// </summary>
        [FieldOffset(20)]
        public int ViewportCount;

        /// <summary>
        ///     <c>ViewportSwizzles</c> is a pointer to an array of <c>VkViewportSwizzleNV</c> structures, defining the viewport swizzles.
        /// </summary>
        [FieldOffset(24)]
        public VkViewportSwizzleNV* ViewportSwizzles;
    }
}
