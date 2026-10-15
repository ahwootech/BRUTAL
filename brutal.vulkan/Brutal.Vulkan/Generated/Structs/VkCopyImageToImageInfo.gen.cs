namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyImageToImageInfo.html">VkCopyImageToImageInfo</see> - Structure specifying parameters of an image to image host copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyImageToImageInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyImageToImageInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkCopyImageToImageInfo {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkHostImageCopyFlags    flags;
    ///             VkImage                 srcImage;
    ///             VkImageLayout           srcImageLayout;
    ///             VkImage                 dstImage;
    ///             VkImageLayout           dstImageLayout;
    ///             uint32_t                regionCount;
    ///             const VkImageCopy2*     pRegions;
    ///         } VkCopyImageToImageInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkCopyImageToImageInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyImageToImageInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkHostImageCopyFlags</c> values describing additional copy parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkHostImageCopyFlags Flags;

        /// <summary>
        ///     <c>SrcImage</c> is the source image.
        /// </summary>
        [FieldOffset(24)]
        public VkImage SrcImage;

        /// <summary>
        ///     <c>SrcImageLayout</c> is the layout of the source image subresources for the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkImageLayout SrcImageLayout;

        /// <summary>
        ///     <c>DstImage</c> is the destination image.
        /// </summary>
        [FieldOffset(40)]
        public VkImage DstImage;

        /// <summary>
        ///     <c>DstImageLayout</c> is the layout of the destination image subresources for the copy.
        /// </summary>
        [FieldOffset(48)]
        public VkImageLayout DstImageLayout;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(52)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkImageCopy2</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(56)]
        public VkImageCopy2* Regions;
    }
}
