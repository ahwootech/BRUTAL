namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassResolvePerformanceQueryEXT.html">VkSubpassResolvePerformanceQueryEXT</see> - Structure specifying the efficiency of subpass resolve for an attachment with a format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query the performance characteristics of a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-subpass">subpass
    ///         resolve^</see> operation for an attachment with a <c>VkFormat</c>, add a
    ///         <c>VkSubpassResolvePerformanceQueryEXT</c> structure to the <c>pNext</c> chain
    ///         of <c>VkFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSubpassResolvePerformanceQueryEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///         typedef struct VkSubpassResolvePerformanceQueryEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           optimal;
    ///         } VkSubpassResolvePerformanceQueryEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSubpassResolvePerformanceQueryEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassResolvePerformanceQueryEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Optimal</c> specifies that a subpass resolve operation is optimally performed.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Optimal;
    }
}
