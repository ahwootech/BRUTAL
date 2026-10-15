namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageMemoryBarrier2.html">VkImageMemoryBarrier2</see> - Structure specifying an image memory barrier
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageMemoryBarrier2
    ///     </para>
    ///     <para>
    ///         The <c>VkImageMemoryBarrier2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkImageMemoryBarrier2 {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkPipelineStageFlags2      srcStageMask;
    ///             VkAccessFlags2             srcAccessMask;
    ///             VkPipelineStageFlags2      dstStageMask;
    ///             VkAccessFlags2             dstAccessMask;
    ///             VkImageLayout              oldLayout;
    ///             VkImageLayout              newLayout;
    ///             uint32_t                   srcQueueFamilyIndex;
    ///             uint32_t                   dstQueueFamilyIndex;
    ///             VkImage                    image;
    ///             VkImageSubresourceRange    subresourceRange;
    ///         } VkImageMemoryBarrier2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkImageMemoryBarrier2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageMemoryBarrier2;

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
        ///     <c>OldLayout</c> is the old layout in an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-image-layout-transitions">image layout transition^</see>.
        /// </summary>
        [FieldOffset(48)]
        public VkImageLayout OldLayout;

        /// <summary>
        ///     <c>NewLayout</c> is the new layout in an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-image-layout-transitions">image layout transition^</see>.
        /// </summary>
        [FieldOffset(52)]
        public VkImageLayout NewLayout;

        /// <summary>
        ///     <c>SrcQueueFamilyIndex</c> is the source queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(56)]
        public int SrcQueueFamilyIndex;

        /// <summary>
        ///     <c>DstQueueFamilyIndex</c> is the destination queue family for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-queue-transfers">queue family ownership transfer^</see>.
        /// </summary>
        [FieldOffset(60)]
        public int DstQueueFamilyIndex;

        /// <summary>
        ///     <c>Image</c> is a handle to the image affected by this barrier.
        /// </summary>
        [FieldOffset(64)]
        public VkImage Image;

        /// <summary>
        ///     <c>SubresourceRange</c> describes the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-image-views">image subresource range^</see> within <c>image</c> that is affected by this barrier.
        /// </summary>
        [FieldOffset(72)]
        public VkImageSubresourceRange SubresourceRange;
    }
}
