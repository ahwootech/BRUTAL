namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageDescriptorInfoEXT.html">VkImageDescriptorInfoEXT</see> - Structure describing an image descriptor created from an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkImageDescriptorInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkImageDescriptorInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             const VkImageViewCreateInfo*    pView;
    ///             VkImageLayout                   layout;
    ///         } VkImageDescriptorInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageDescriptorInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageDescriptorInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>View</c> is an <c>VkImageViewCreateInfo</c> describing the descriptor.
        /// </summary>
        [FieldOffset(16)]
        public VkImageViewCreateInfo* View;

        /// <summary>
        ///     <c>Layout</c> is the <c>VkImageLayout</c> that the image view will be in when accessed as a descriptor.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout Layout;
    }
}
