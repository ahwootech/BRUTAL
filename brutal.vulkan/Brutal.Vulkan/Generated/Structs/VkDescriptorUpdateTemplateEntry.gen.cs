namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateEntry.html">VkDescriptorUpdateTemplateEntry</see> - Describes a single descriptor update of the descriptor update template
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorUpdateTemplateEntry</c> structure is defined as:
    ///         <code>
    ///             // Provided by VK_VERSION_1_1
    ///             typedef struct VkDescriptorUpdateTemplateEntry {
    ///                 uint32_t            dstBinding;
    ///                 uint32_t            dstArrayElement;
    ///                 uint32_t            descriptorCount;
    ///                 VkDescriptorType    descriptorType;
    ///                 size_t              offset;
    ///                 size_t              stride;
    ///             } VkDescriptorUpdateTemplateEntry;
    ///         </code>
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkDescriptorUpdateTemplateEntry()
    {
        /// <summary>
        ///     <c>DstBinding</c> is the descriptor binding to update when using this descriptor update template.
        /// </summary>
        [FieldOffset(0)]
        public int DstBinding;

        /// <summary>
        ///     <c>DstArrayElement</c> is the starting element in the array belonging to <c>dstBinding</c>.
        /// </summary>
        [FieldOffset(4)]
        public int DstArrayElement;

        /// <summary>
        ///     <c>DescriptorCount</c> is the number of descriptors to update. If <c>descriptorCount</c> is greater than the number of remaining array elements in the destination binding, those affect consecutive bindings in a manner similar to <c>VkWriteDescriptorSet</c> above.
        /// </summary>
        [FieldOffset(8)]
        public int DescriptorCount;

        /// <summary>
        ///     <c>DescriptorType</c> is a <c>VkDescriptorType</c> specifying the type of the descriptor.
        /// </summary>
        [FieldOffset(12)]
        public VkDescriptorType DescriptorType;

        /// <summary>
        ///     <c>Offset</c> is the offset in bytes of the first binding in the raw data structure.
        /// </summary>
        [FieldOffset(16)]
        public nuint Offset;

        /// <summary>
        ///     <c>Stride</c> is the stride in bytes between two consecutive array elements of the descriptor update information in the raw data structure. The actual pointer ptr for each array element j of update entry i is computed using the following formula: + [source,c++] ---- const char *ptr = (const char *)pData + pDescriptorUpdateEntries[i].offset + j * pDescriptorUpdateEntries[i].stride ---- + The stride is useful in case the bindings are stored in structs along with other data.
        /// </summary>
        [FieldOffset(24)]
        public nuint Stride;
    }
}
