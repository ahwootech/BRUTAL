namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHostImageLayoutTransitionInfo.html">VkHostImageLayoutTransitionInfo</see> - Structure specifying the parameters of a host-side image layout transition
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkHostImageLayoutTransitionInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkHostImageLayoutTransitionInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkHostImageLayoutTransitionInfo {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkImage                    image;
    ///             VkImageLayout              oldLayout;
    ///             VkImageLayout              newLayout;
    ///             VkImageSubresourceRange    subresourceRange;
    ///         } VkHostImageLayoutTransitionInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkHostImageLayoutTransitionInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.HostImageLayoutTransitionInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is a handle to the image affected by this layout transition.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

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
        ///     <c>SubresourceRange</c> describes the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-image-views">image subresource range^</see> within <c>image</c> that is affected by this layout transition.
        /// </summary>
        [FieldOffset(32)]
        public VkImageSubresourceRange SubresourceRange;
    }
}
