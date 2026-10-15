namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier.html">VkImageMemoryBarrier</see> - Structure specifying the parameters of an image memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageMemoryBarrier
    ///     </para>
    ///     <para>
    ///         The <c>VkImageMemoryBarrier</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageMemoryBarrier {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkAccessFlags              srcAccessMask;
    ///             VkAccessFlags              dstAccessMask;
    ///             VkImageLayout              oldLayout;
    ///             VkImageLayout              newLayout;
    ///             uint32_t                   srcQueueFamilyIndex;
    ///             uint32_t                   dstQueueFamilyIndex;
    ///             VkImage                    image;
    ///             VkImageSubresourceRange    subresourceRange;
    ///         } VkImageMemoryBarrier;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkImageMemoryBarrier()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageMemoryBarrier;

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
        ///     <c>OldLayout</c> is the old layout in an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-image-layout-transitions">image layout transition^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout OldLayout;

        /// <summary>
        ///     <c>NewLayout</c> is the new layout in an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-image-layout-transitions">image layout transition^</see>.
        /// </summary>
        [FieldOffset(28)]
        public VkImageLayout NewLayout;

        /// <summary>
        ///     <c>SrcQueueFamilyIndex</c> is the source queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(32)]
        public int SrcQueueFamilyIndex;

        /// <summary>
        ///     <c>DstQueueFamilyIndex</c> is the destination queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(36)]
        public int DstQueueFamilyIndex;

        /// <summary>
        ///     <c>Image</c> is a handle to the image affected by this barrier.
        /// </summary>
        [FieldOffset(40)]
        public VkImage Image;

        /// <summary>
        ///     <c>SubresourceRange</c> describes the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-image-views">image subresource range^</see> within <c>image</c> that is affected by this barrier.
        /// </summary>
        [FieldOffset(48)]
        public VkImageSubresourceRange SubresourceRange;
    }
}
