namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferCreateInfo.html">VkBufferCreateInfo</see> - Structure specifying the parameters of a newly created buffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferCreateInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkBufferCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBufferCreateInfo {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkBufferCreateFlags    flags;
    ///             VkDeviceSize           size;
    ///             VkBufferUsageFlags     usage;
    ///             VkSharingMode          sharingMode;
    ///             uint32_t               queueFamilyIndexCount;
    ///             const uint32_t*        pQueueFamilyIndices;
    ///         } VkBufferCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkBufferCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBufferCreateFlags</c> specifying additional parameters of the buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkBufferCreateFlags Flags;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of the buffer to be created.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkBufferUsageFlags</c> specifying allowed usages of the buffer.
        /// </summary>
        [FieldOffset(32)]
        public VkBufferUsageFlags Usage;

        /// <summary>
        ///     <c>SharingMode</c> is a <c>VkSharingMode</c> value specifying the sharing mode of the buffer when it will be accessed by multiple queue families.
        /// </summary>
        [FieldOffset(36)]
        public VkSharingMode SharingMode;

        /// <summary>
        ///     <c>QueueFamilyIndexCount</c> is the number of entries in the <c>pQueueFamilyIndices</c> array.
        /// </summary>
        [FieldOffset(40)]
        public int QueueFamilyIndexCount;

        /// <summary>
        ///     <c>QueueFamilyIndices</c> is a pointer to an array of queue families that will access this buffer. It is ignored if <c>sharingMode</c> is not <c>VK_SHARING_MODE_CONCURRENT</c>.
        /// </summary>
        [FieldOffset(48)]
        public int* QueueFamilyIndices;
    }
}
