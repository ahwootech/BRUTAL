namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMutableDescriptorTypeListEXT.html">VkMutableDescriptorTypeListEXT</see> - Structure describing descriptor types that a given descriptor may mutate to
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The list of potential descriptor types a given mutable descriptor <i>can</i>
    ///         mutate to is passed in a <c>VkMutableDescriptorTypeListEXT</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkMutableDescriptorTypeListEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mutable_descriptor_type
    ///         typedef struct VkMutableDescriptorTypeListEXT {
    ///             uint32_t                   descriptorTypeCount;
    ///             const VkDescriptorType*    pDescriptorTypes;
    ///         } VkMutableDescriptorTypeListEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkMutableDescriptorTypeListEXT()
    {
        /// <summary>
        ///     <c>DescriptorTypeCount</c> is the number of elements in <c>pDescriptorTypes</c>.
        /// </summary>
        [FieldOffset(0)]
        public int DescriptorTypeCount;

        /// <summary>
        ///     <c>DescriptorTypes</c> is `NULL` or a pointer to an array of <c>descriptorTypeCount</c> <c>VkDescriptorType</c> values defining which descriptor types a given binding may mutate to.
        /// </summary>
        [FieldOffset(8)]
        public VkDescriptorType* DescriptorTypes;
    }
}
