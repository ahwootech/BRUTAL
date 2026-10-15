namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubresourceHostMemcpySize.html">VkSubresourceHostMemcpySize</see> - Memory size needed to copy to or from an image on the host with VK_HOST_IMAGE_COPY_MEMCPY_BIT
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query the memory size needed to copy to or from an image using
    ///         <c>vkCopyMemoryToImage</c> or <c>vkCopyImageToMemory</c> when the
    ///         <c>VK_HOST_IMAGE_COPY_MEMCPY_BIT</c> flag is specified, add a
    ///         <c>VkSubresourceHostMemcpySize</c> structure to the <c>pNext</c> chain of the
    ///         <c>VkSubresourceLayout2</c> structure in a call to
    ///         <c>vkGetImageSubresourceLayout2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSubresourceHostMemcpySize</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkSubresourceHostMemcpySize {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       size;
    ///         } VkSubresourceHostMemcpySize;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSubresourceHostMemcpySize()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubresourceHostMemcpySize;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of the image subresource.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;
    }
}
