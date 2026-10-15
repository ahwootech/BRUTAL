namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineViewportExclusiveScissorStateCreateInfoNV.html">VkPipelineViewportExclusiveScissorStateCreateInfoNV</see> - Structure specifying parameters controlling exclusive scissor testing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineViewportExclusiveScissorStateCreateInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_scissor_exclusive
    ///         typedef struct VkPipelineViewportExclusiveScissorStateCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           exclusiveScissorCount;
    ///             const VkRect2D*    pExclusiveScissors;
    ///         } VkPipelineViewportExclusiveScissorStateCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExclusiveScissorCount</c> is the number of exclusive scissor rectangles.
        /// </summary>
        [FieldOffset(16)]
        public int ExclusiveScissorCount;

        /// <summary>
        ///     <c>ExclusiveScissors</c> is a pointer to an array of <c>VkRect2D</c> structures defining exclusive scissor rectangles.
        /// </summary>
        [FieldOffset(24)]
        public VkRect2D* ExclusiveScissors;
    }
}
