namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageOpaqueMemoryBindInfo.html">VkSparseImageOpaqueMemoryBindInfo</see> - Structure specifying sparse image opaque memory bind information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Memory is bound to opaque regions of <c>VkImage</c> objects created with the
    ///         <c>VK_IMAGE_CREATE_SPARSE_BINDING_BIT</c> flag using the following structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseImageOpaqueMemoryBindInfo {
    ///             VkImage                      image;
    ///             uint32_t                     bindCount;
    ///             const VkSparseMemoryBind*    pBinds;
    ///         } VkSparseImageOpaqueMemoryBindInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo()
    {
        /// <summary>
        ///     <c>Image</c> is the <c>VkImage</c> object to be bound.
        /// </summary>
        [FieldOffset(0)]
        public VkImage Image;

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
