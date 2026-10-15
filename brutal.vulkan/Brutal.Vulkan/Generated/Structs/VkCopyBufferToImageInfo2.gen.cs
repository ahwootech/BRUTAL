namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyBufferToImageInfo2.html">VkCopyBufferToImageInfo2</see> - Structure specifying parameters of a buffer to image copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyBufferToImageInfo2
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyBufferToImageInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCopyBufferToImageInfo2 {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             VkBuffer                     srcBuffer;
    ///             VkImage                      dstImage;
    ///             VkImageLayout                dstImageLayout;
    ///             uint32_t                     regionCount;
    ///             const VkBufferImageCopy2*    pRegions;
    ///         } VkCopyBufferToImageInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCopyBufferToImageInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyBufferToImageInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcBuffer</c> is the source buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer SrcBuffer;

        /// <summary>
        ///     <c>DstImage</c> is the destination image.
        /// </summary>
        [FieldOffset(24)]
        public VkImage DstImage;

        /// <summary>
        ///     <c>DstImageLayout</c> is the layout of the destination image subresources for the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkImageLayout DstImageLayout;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(36)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkBufferImageCopy2</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public VkBufferImageCopy2* Regions;
    }
}
