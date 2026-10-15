namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetVariableDescriptorCountLayoutSupport.html">VkDescriptorSetVariableDescriptorCountLayoutSupport</see> - Structure returning information about whether a descriptor set layout can be supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of a <c>VkDescriptorSetLayoutSupport</c> structure
    ///         includes a <c>VkDescriptorSetVariableDescriptorCountLayoutSupport</c>
    ///         structure, then that structure returns additional information about whether
    ///         the descriptor set layout is supported.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkDescriptorSetVariableDescriptorCountLayoutSupport {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxVariableDescriptorCount;
    ///         } VkDescriptorSetVariableDescriptorCountLayoutSupport;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxVariableDescriptorCount</c> indicates the maximum number of descriptors supported in the highest numbered binding of the layout, if that binding is variable-sized.
        /// </summary>
        [FieldOffset(16)]
        public int MaxVariableDescriptorCount;
    }
}
