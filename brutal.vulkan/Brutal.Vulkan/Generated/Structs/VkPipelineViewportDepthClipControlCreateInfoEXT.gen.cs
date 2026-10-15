namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportDepthClipControlCreateInfoEXT.html">VkPipelineViewportDepthClipControlCreateInfoEXT</see> - Structure specifying parameters of a newly created pipeline depth clip control state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineViewportDepthClipControlCreateInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_clip_control
    ///         typedef struct VkPipelineViewportDepthClipControlCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           negativeOneToOne;
    ///         } VkPipelineViewportDepthClipControlCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineViewportDepthClipControlCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportDepthClipControlCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NegativeOneToOne</c> sets the <c>z~m~</c> in the <i>view volume</i> to <c>-w~c~</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 NegativeOneToOne;
    }
}
