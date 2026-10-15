namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferMemoryBarrier2.html">VkBufferMemoryBarrier2</see> - Structure specifying a buffer memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferMemoryBarrier2
    ///     </para>
    ///     <para>
    ///         The <c>VkBufferMemoryBarrier2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkBufferMemoryBarrier2 {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkPipelineStageFlags2    srcStageMask;
    ///             VkAccessFlags2           srcAccessMask;
    ///             VkPipelineStageFlags2    dstStageMask;
    ///             VkAccessFlags2           dstAccessMask;
    ///             uint32_t                 srcQueueFamilyIndex;
    ///             uint32_t                 dstQueueFamilyIndex;
    ///             VkBuffer                 buffer;
    ///             VkDeviceSize             offset;
    ///             VkDeviceSize             size;
    ///         } VkBufferMemoryBarrier2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkBufferMemoryBarrier2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferMemoryBarrier2;

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

        /// <summary>
        ///     <c>SrcQueueFamilyIndex</c> is the source queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(48)]
        public int SrcQueueFamilyIndex;

        /// <summary>
        ///     <c>DstQueueFamilyIndex</c> is the destination queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(52)]
        public int DstQueueFamilyIndex;

        /// <summary>
        ///     <c>Buffer</c> is a handle to the buffer whose backing memory is affected by the barrier.
        /// </summary>
        [FieldOffset(56)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is an offset in bytes into the backing memory for <c>buffer</c>; this is relative to the base offset as bound to the buffer (see <c>vkBindBufferMemory</c>).
        /// </summary>
        [FieldOffset(64)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is a size in bytes of the affected area of backing memory for <c>buffer</c>, or <c>VK_WHOLE_SIZE</c> to use the range from <c>offset</c> to the end of the buffer.
        /// </summary>
        [FieldOffset(72)]
        public ByteSize64 Size;
    }
}
