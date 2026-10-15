namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBindingFlagsCreateInfo.html">VkDescriptorSetLayoutBindingFlagsCreateInfo</see> - Structure specifying creation flags for descriptor set layout bindings
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of a <c>VkDescriptorSetLayoutCreateInfo</c>
    ///         structure includes a <c>VkDescriptorSetLayoutBindingFlagsCreateInfo</c>
    ///         structure, then that structure includes an array of flags, one for each
    ///         descriptor set layout binding.
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorSetLayoutBindingFlagsCreateInfo</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkDescriptorSetLayoutBindingFlagsCreateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             uint32_t                           bindingCount;
    ///             const VkDescriptorBindingFlags*    pBindingFlags;
    ///         } VkDescriptorSetLayoutBindingFlagsCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BindingCount</c> is zero or the number of elements in <c>pBindingFlags</c>.
        /// </summary>
        [FieldOffset(16)]
        public int BindingCount;

        /// <summary>
        ///     <c>BindingFlags</c> is a pointer to an array of <c>VkDescriptorBindingFlags</c> bitfields, one for each descriptor set layout binding.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorBindingFlags* BindingFlags;
    }
}
