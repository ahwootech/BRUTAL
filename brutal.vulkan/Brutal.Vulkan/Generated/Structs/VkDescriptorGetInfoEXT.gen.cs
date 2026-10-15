namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorGetInfoEXT.html">VkDescriptorGetInfoEXT</see> - Structure specifying parameters of descriptor to get
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the descriptor to get is passed in a
    ///         <c>VkDescriptorGetInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkDescriptorGetInfoEXT {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkDescriptorType       type;
    ///             VkDescriptorDataEXT    data;
    ///         } VkDescriptorGetInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorGetInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorGetInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is the type of descriptor to get.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorType Type;

        /// <summary>
        ///     <c>Data</c> is a <c>VkDescriptorDataEXT</c> union containing the information needed to get the descriptor.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorDataEXT Data;
    }
}
