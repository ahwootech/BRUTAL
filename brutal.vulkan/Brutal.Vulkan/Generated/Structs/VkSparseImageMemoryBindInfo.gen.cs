namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryBindInfo.html">VkSparseImageMemoryBindInfo</see> - Structure specifying sparse image memory bind information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Memory <i>can</i> be bound to sparse image blocks of <c>VkImage</c> objects created
    ///         with the <c>VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT</c> flag using the following
    ///         structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseImageMemoryBindInfo {
    ///             VkImage                           image;
    ///             uint32_t                          bindCount;
    ///             const VkSparseImageMemoryBind*    pBinds;
    ///         } VkSparseImageMemoryBindInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSparseImageMemoryBindInfo()
    {
        /// <summary>
        ///     <c>Image</c> is the <c>VkImage</c> object to be bound
        /// </summary>
        [FieldOffset(0)]
        public VkImage Image;

        /// <summary>
        ///     <c>BindCount</c> is the number of <c>VkSparseImageMemoryBind</c> structures in <c>pBinds</c> array
        /// </summary>
        [FieldOffset(8)]
        public int BindCount;

        /// <summary>
        ///     <c>Binds</c> is a pointer to an array of <c>VkSparseImageMemoryBind</c> structures
        /// </summary>
        [FieldOffset(16)]
        public VkSparseImageMemoryBind* Binds;
    }
}
