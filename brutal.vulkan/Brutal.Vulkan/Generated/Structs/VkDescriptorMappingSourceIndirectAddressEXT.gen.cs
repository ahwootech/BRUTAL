namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceIndirectAddressEXT.html">VkDescriptorMappingSourceIndirectAddressEXT</see> - Structure specifying mapping a uniform buffer to an address specified indirectly
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceIndirectAddressEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceIndirectAddressEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorMappingSourceIndirectAddressEXT {
    ///             uint32_t    pushOffset;
    ///             uint32_t    addressOffset;
    ///         } VkDescriptorMappingSourceIndirectAddressEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkDescriptorMappingSourceIndirectAddressEXT()
    {
        /// <summary>
        ///     <c>PushOffset</c> is a byte offset into push data where an indirect address containing the address for the mapped resource will be retrieved.
        /// </summary>
        [FieldOffset(0)]
        public int PushOffset;

        /// <summary>
        ///     <c>AddressOffset</c> is a byte offset into the indirect address where the address for the mapped resource will be retrieved.
        /// </summary>
        [FieldOffset(4)]
        public int AddressOffset;
    }
}
