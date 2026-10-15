namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateInfo.html">VkDescriptorPoolCreateInfo</see> - Structure specifying parameters of a newly created descriptor pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Additional information about the pool is passed in a
    ///         <c>VkDescriptorPoolCreateInfo</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorPoolCreateInfo {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkDescriptorPoolCreateFlags    flags;
    ///             uint32_t                       maxSets;
    ///             uint32_t                       poolSizeCount;
    ///             const VkDescriptorPoolSize*    pPoolSizes;
    ///         } VkDescriptorPoolCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDescriptorPoolCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorPoolCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDescriptorPoolCreateFlags</c> specifying certain supported operations on the pool.
        /// </summary>
        [FieldOffset(16)]
        public VkDescriptorPoolCreateFlags Flags;

        /// <summary>
        ///     <c>MaxSets</c> is the maximum number of descriptor sets that <i>can</i> be allocated from the pool.
        /// </summary>
        [FieldOffset(20)]
        public int MaxSets;

        /// <summary>
        ///     <c>PoolSizeCount</c> is the number of elements in <c>pPoolSizes</c>.
        /// </summary>
        [FieldOffset(24)]
        public int PoolSizeCount;

        /// <summary>
        ///     <c>PoolSizes</c> is a pointer to an array of <c>VkDescriptorPoolSize</c> structures, each containing a descriptor type and number of descriptors of that type to be allocated in the pool.
        /// </summary>
        [FieldOffset(32)]
        public VkDescriptorPoolSize* PoolSizes;
    }
}
