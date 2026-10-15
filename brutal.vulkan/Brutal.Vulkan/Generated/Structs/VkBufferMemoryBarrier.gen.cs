namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferMemoryBarrier.html">VkBufferMemoryBarrier</see> - Structure specifying a buffer memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferMemoryBarrier
    ///     </para>
    ///     <para>
    ///         The <c>VkBufferMemoryBarrier</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBufferMemoryBarrier {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkAccessFlags      srcAccessMask;
    ///             VkAccessFlags      dstAccessMask;
    ///             uint32_t           srcQueueFamilyIndex;
    ///             uint32_t           dstQueueFamilyIndex;
    ///             VkBuffer           buffer;
    ///             VkDeviceSize       offset;
    ///             VkDeviceSize       size;
    ///         } VkBufferMemoryBarrier;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkBufferMemoryBarrier()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferMemoryBarrier;

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

        /// <summary>
        ///     <c>SrcQueueFamilyIndex</c> is the source queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(24)]
        public int SrcQueueFamilyIndex;

        /// <summary>
        ///     <c>DstQueueFamilyIndex</c> is the destination queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(28)]
        public int DstQueueFamilyIndex;

        /// <summary>
        ///     <c>Buffer</c> is a handle to the buffer whose backing memory is affected by the barrier.
        /// </summary>
        [FieldOffset(32)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is an offset in bytes into the backing memory for <c>buffer</c>; this is relative to the base offset as bound to the buffer (see <c>vkBindBufferMemory</c>).
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is a size in bytes of the affected area of backing memory for <c>buffer</c>, or <c>VK_WHOLE_SIZE</c> to use the range from <c>offset</c> to the end of the buffer.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 Size;
    }
}
