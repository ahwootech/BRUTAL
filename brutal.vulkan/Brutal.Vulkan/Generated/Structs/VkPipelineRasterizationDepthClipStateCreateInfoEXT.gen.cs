namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationDepthClipStateCreateInfoEXT.html">VkPipelineRasterizationDepthClipStateCreateInfoEXT</see> - Structure specifying depth clipping state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkPipelineRasterizationStateCreateInfo</c>
    ///         includes a <c>VkPipelineRasterizationDepthClipStateCreateInfoEXT</c>
    ///         structure, then that structure controls whether depth clipping is enabled or
    ///         disabled.
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineRasterizationDepthClipStateCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_clip_enable
    ///         typedef struct VkPipelineRasterizationDepthClipStateCreateInfoEXT {
    ///             VkStructureType                                        sType;
    ///             const void*                                            pNext;
    ///             VkPipelineRasterizationDepthClipStateCreateFlagsEXT    flags;
    ///             VkBool32                                               depthClipEnable;
    ///         } VkPipelineRasterizationDepthClipStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>DepthClipEnable</c> controls whether depth clipping is enabled as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vertexpostproc-clipping">Primitive Clipping^</see>.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DepthClipEnable;
    }
}
