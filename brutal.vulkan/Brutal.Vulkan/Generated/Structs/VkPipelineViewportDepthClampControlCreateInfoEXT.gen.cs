namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportDepthClampControlCreateInfoEXT.html">VkPipelineViewportDepthClampControlCreateInfoEXT</see> - Structure specifying parameters of a newly created pipeline depth clamp control state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineViewportDepthClampControlCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_clamp_control
    ///         typedef struct VkPipelineViewportDepthClampControlCreateInfoEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkDepthClampModeEXT            depthClampMode;
    ///             const VkDepthClampRangeEXT*    pDepthClampRange;
    ///         } VkPipelineViewportDepthClampControlCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportDepthClampControlCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportDepthClampControlCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthClampMode</c> determines how the clamp range is determined for each viewport.
        /// </summary>
        [FieldOffset(16)]
        public VkDepthClampModeEXT DepthClampMode;

        /// <summary>
        ///     <c>DepthClampRange</c> sets the depth clamp range for all viewports if <c>depthClampMode</c> is <c>VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkDepthClampRangeEXT* DepthClampRange;
    }
}
