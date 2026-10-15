namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseBufferMemoryBindInfo.html">VkSparseBufferMemoryBindInfo</see> - Structure specifying a sparse buffer memory bind operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Memory is bound to <c>VkBuffer</c> objects created with the
    ///         <c>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</c> flag using the following
    ///         structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseBufferMemoryBindInfo {
    ///             VkBuffer                     buffer;
    ///             uint32_t                     bindCount;
    ///             const VkSparseMemoryBind*    pBinds;
    ///         } VkSparseBufferMemoryBindInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSparseBufferMemoryBindInfo()
    {
        /// <summary>
        ///     <c>Buffer</c> is the <c>VkBuffer</c> object to be bound.
        /// </summary>
        [FieldOffset(0)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>BindCount</c> is the number of <c>VkSparseMemoryBind</c> structures in the <c>pBinds</c> array.
        /// </summary>
        [FieldOffset(8)]
        public int BindCount;

        /// <summary>
        ///     <c>Binds</c> is a pointer to an array of <c>VkSparseMemoryBind</c> structures.
        /// </summary>
        [FieldOffset(16)]
        public VkSparseMemoryBind* Binds;
    }
}
