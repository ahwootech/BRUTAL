namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyImageToBufferInfo2.html">VkCopyImageToBufferInfo2</see> - Structure specifying parameters of an image to buffer copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyImageToBufferInfo2
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyImageToBufferInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCopyImageToBufferInfo2 {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             VkImage                      srcImage;
    ///             VkImageLayout                srcImageLayout;
    ///             VkBuffer                     dstBuffer;
    ///             uint32_t                     regionCount;
    ///             const VkBufferImageCopy2*    pRegions;
    ///         } VkCopyImageToBufferInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCopyImageToBufferInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyImageToBufferInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcImage</c> is the source image.
        /// </summary>
        [FieldOffset(16)]
        public VkImage SrcImage;

        /// <summary>
        ///     <c>SrcImageLayout</c> is the layout of the source image subresources for the copy.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout SrcImageLayout;

        /// <summary>
        ///     <c>DstBuffer</c> is the destination buffer.
        /// </summary>
        [FieldOffset(32)]
        public VkBuffer DstBuffer;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkBufferImageCopy2</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(48)]
        public VkBufferImageCopy2* Regions;
    }
}
