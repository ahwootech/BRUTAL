namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreationControlEXT.html">VkRenderPassCreationControlEXT</see> - Control about the creation of render pass or subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A <c>VkRenderPassCreationControlEXT</c> structure <i>can</i> be included in the
    ///         <c>pNext</c> chain of <c>VkRenderPassCreateInfo2</c> or <c>pNext</c> chain of
    ///         <c>VkSubpassDescription2</c>.
    ///         The <c>VkRenderPassCreationControlEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef struct VkRenderPassCreationControlEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           disallowMerging;
    ///         } VkRenderPassCreationControlEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderPassCreationControlEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassCreationControlEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisallowMerging</c> is a boolean value indicating whether subpass merging will be disabled.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DisallowMerging;
    }
}
