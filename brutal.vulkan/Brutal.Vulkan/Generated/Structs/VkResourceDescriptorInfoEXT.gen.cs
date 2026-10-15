namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResourceDescriptorInfoEXT.html">VkResourceDescriptorInfoEXT</see> - Structure describing a resource descriptor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkResourceDescriptorInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkResourceDescriptorInfoEXT {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkDescriptorType               type;
    ///             VkResourceDescriptorDataEXT    data;
    ///         } VkResourceDescriptorInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkResourceDescriptorInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ResourceDescriptorInfoEXT;

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
        ///     <c>Data</c> is a <c>VkResourceDescriptorDataEXT</c> union defining the properties of a resource descriptor according to <c>type</c>
        /// </summary>
        [FieldOffset(24)]
        public VkResourceDescriptorDataEXT Data;
    }
}
