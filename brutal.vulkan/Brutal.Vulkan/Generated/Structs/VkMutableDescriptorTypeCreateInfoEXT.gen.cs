namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeCreateInfoEXT.html">VkMutableDescriptorTypeCreateInfoEXT</see> - Structure describing the list of possible active descriptor types for mutable type descriptors
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of a <c>VkDescriptorSetLayoutCreateInfo</c> or
    ///         <c>VkDescriptorPoolCreateInfo</c> structure includes a
    ///         <c>VkMutableDescriptorTypeCreateInfoEXT</c> structure, then that structure
    ///         specifies Information about the possible descriptor types for mutable
    ///         descriptor types.
    ///     </para>
    ///     <para>
    ///         The <c>VkMutableDescriptorTypeCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mutable_descriptor_type
    ///         typedef struct VkMutableDescriptorTypeCreateInfoEXT {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             uint32_t                                 mutableDescriptorTypeListCount;
    ///             const VkMutableDescriptorTypeListEXT*    pMutableDescriptorTypeLists;
    ///         } VkMutableDescriptorTypeCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMutableDescriptorTypeCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MutableDescriptorTypeCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MutableDescriptorTypeListCount</c> is the number of elements in <c>pMutableDescriptorTypeLists</c>.
        /// </summary>
        [FieldOffset(16)]
        public int MutableDescriptorTypeListCount;

        /// <summary>
        ///     <c>MutableDescriptorTypeLists</c> is a pointer to an array of <c>VkMutableDescriptorTypeListEXT</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkMutableDescriptorTypeListEXT* MutableDescriptorTypeLists;
    }
}
