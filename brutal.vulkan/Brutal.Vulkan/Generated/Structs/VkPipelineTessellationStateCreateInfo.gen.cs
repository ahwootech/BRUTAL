namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineTessellationStateCreateInfo.html">VkPipelineTessellationStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline tessellation state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineTessellationStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineTessellationStateCreateInfo {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkPipelineTessellationStateCreateFlags    flags;
    ///             uint32_t                                  patchControlPoints;
    ///         } VkPipelineTessellationStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPipelineTessellationStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineTessellationStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineTessellationStateCreateFlags Flags;

        /// <summary>
        ///     <c>PatchControlPoints</c> is the number of control points per patch.
        /// </summary>
        [FieldOffset(20)]
        public int PatchControlPoints;
    }
}
