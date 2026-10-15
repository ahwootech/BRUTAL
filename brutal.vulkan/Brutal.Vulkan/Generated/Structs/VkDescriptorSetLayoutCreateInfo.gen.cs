namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateInfo.html">VkDescriptorSetLayoutCreateInfo</see> - Structure specifying parameters of a newly created descriptor set layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the descriptor set layout is passed in a
    ///         <c>VkDescriptorSetLayoutCreateInfo</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorSetLayoutCreateInfo {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkDescriptorSetLayoutCreateFlags       flags;
    ///             uint32_t                               bindingCount;
    ///             const VkDescriptorSetLayoutBinding*    pBindings;
    ///         } VkDescriptorSetLayoutCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDescriptorSetLayoutCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetLayoutCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask specifying options for descriptor set layout creation.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorSetLayoutCreateFlags Flags;

        /// <summary>
        ///     <c>BindingCount</c> is the number of elements in <c>pBindings</c>.
        /// </summary>
        [FieldOffset(20)]
        public int BindingCount;

        /// <summary>
        ///     <c>Bindings</c> is a pointer to an array of <c>VkDescriptorSetLayoutBinding</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorSetLayoutBinding* Bindings;
    }
}
