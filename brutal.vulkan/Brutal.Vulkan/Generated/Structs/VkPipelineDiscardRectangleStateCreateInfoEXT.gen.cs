namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineDiscardRectangleStateCreateInfoEXT.html">VkPipelineDiscardRectangleStateCreateInfoEXT</see> - Structure specifying discard rectangle
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineDiscardRectangleStateCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_discard_rectangles
    ///         typedef struct VkPipelineDiscardRectangleStateCreateInfoEXT {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             VkPipelineDiscardRectangleStateCreateFlagsEXT    flags;
    ///             VkDiscardRectangleModeEXT                        discardRectangleMode;
    ///             uint32_t                                         discardRectangleCount;
    ///             const VkRect2D*                                  pDiscardRectangles;
    ///         } VkPipelineDiscardRectangleStateCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineDiscardRectangleStateCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineDiscardRectangleStateCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>DiscardRectangleMode</c> is a <c>VkDiscardRectangleModeEXT</c> value determining whether the discard rectangle test is inclusive or exclusive.
        /// </summary>
        [FieldOffset(20)]
        public VkDiscardRectangleModeEXT DiscardRectangleMode;

        /// <summary>
        ///     <c>DiscardRectangleCount</c> is the number of discard rectangles to use.
        /// </summary>
        [FieldOffset(24)]
        public int DiscardRectangleCount;

        /// <summary>
        ///     <c>DiscardRectangles</c> is a pointer to an array of <c>VkRect2D</c> structures defining discard rectangles.
        /// </summary>
        [FieldOffset(32)]
        public VkRect2D* DiscardRectangles;
    }
}
