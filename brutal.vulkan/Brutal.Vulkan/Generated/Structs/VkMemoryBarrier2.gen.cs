namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryBarrier2.html">VkMemoryBarrier2</see> - Structure specifying a global memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMemoryBarrier2
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryBarrier2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkMemoryBarrier2 {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkPipelineStageFlags2    srcStageMask;
    ///             VkAccessFlags2           srcAccessMask;
    ///             VkPipelineStageFlags2    dstStageMask;
    ///             VkAccessFlags2           dstAccessMask;
    ///         } VkMemoryBarrier2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkMemoryBarrier2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryBarrier2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcStageMask</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-scopes">first synchronization scope^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags2 SrcStageMask;

        /// <summary>
        ///     <c>SrcAccessMask</c> is a <c>VkAccessFlags2</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">first access scope^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkAccessFlags2 SrcAccessMask;

        /// <summary>
        ///     <c>DstStageMask</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-scopes">second synchronization scope^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineStageFlags2 DstStageMask;

        /// <summary>
        ///     <c>DstAccessMask</c> is a <c>VkAccessFlags2</c> mask of access flags to be included in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">second access scope^</see>.
        /// </summary>
        [FieldOffset(40)]
        public VkAccessFlags2 DstAccessMask;
    }
}
