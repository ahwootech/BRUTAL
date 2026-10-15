namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryBarrier.html">VkMemoryBarrier</see> - Structure specifying a global memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryBarrier</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMemoryBarrier {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkAccessFlags      srcAccessMask;
    ///             VkAccessFlags      dstAccessMask;
    ///         } VkMemoryBarrier;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryBarrier()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryBarrier;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">source access mask^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkAccessFlags SrcAccessMask;

        /// <summary>
        ///     <c>DstAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">destination access mask^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkAccessFlags DstAccessMask;
    }
}
