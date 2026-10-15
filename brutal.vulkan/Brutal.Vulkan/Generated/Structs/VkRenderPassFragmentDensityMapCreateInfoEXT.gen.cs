namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassFragmentDensityMapCreateInfoEXT.html">VkRenderPassFragmentDensityMapCreateInfoEXT</see> - Structure containing fragment density map attachment for render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>VkRenderPassCreateInfo::pNext</c> chain includes a
    ///         <c>VkRenderPassFragmentDensityMapCreateInfoEXT</c> structure, then that
    ///         structure includes a fragment density map attachment for the render pass.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassFragmentDensityMapCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map
    ///         typedef struct VkRenderPassFragmentDensityMapCreateInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkAttachmentReference    fragmentDensityMapAttachment;
    ///         } VkRenderPassFragmentDensityMapCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassFragmentDensityMapCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentDensityMapAttachment</c> is the fragment density map to use for the render pass.
        /// </summary>
        [FieldOffset(16)]
        public VkAttachmentReference FragmentDensityMapAttachment;
    }
}
