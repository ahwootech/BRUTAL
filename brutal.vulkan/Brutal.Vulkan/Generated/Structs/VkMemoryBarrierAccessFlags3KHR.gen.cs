namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryBarrierAccessFlags3KHR.html">VkMemoryBarrierAccessFlags3KHR</see> - Structure specifying additional access flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryBarrierAccessFlags3KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance8
    ///         typedef struct VkMemoryBarrierAccessFlags3KHR {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkAccessFlags3KHR    srcAccessMask3;
    ///             VkAccessFlags3KHR    dstAccessMask3;
    ///         } VkMemoryBarrierAccessFlags3KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryBarrierAccessFlags3KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryBarrierAccessFlags3KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcAccessMask3</c> is a <c>VkAccessFlags3KHR</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">first access scope^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkAccessFlags3KHR SrcAccessMask3;

        /// <summary>
        ///     <c>DstAccessMask3</c> is a <c>VkAccessFlags3KHR</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">second access scope^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkAccessFlags3KHR DstAccessMask3;
    }
}
