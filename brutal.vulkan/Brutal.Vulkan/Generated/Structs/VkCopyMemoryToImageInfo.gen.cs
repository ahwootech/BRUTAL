namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToImageInfo.html">VkCopyMemoryToImageInfo</see> - Structure specifying parameters of host memory to image copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryToImageInfo
    ///         :imageparam: dstImage
    ///         :imagesubresource: imageSubresource
    ///         :imageoffset: imageOffset
    ///         :imageextent: imageExtent
    ///         :bufferrowlength: memoryRowLength
    ///         :bufferimageheight: memoryImageHeight
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyMemoryToImageInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkCopyMemoryToImageInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkHostImageCopyFlags          flags;
    ///             VkImage                       dstImage;
    ///             VkImageLayout                 dstImageLayout;
    ///             uint32_t                      regionCount;
    ///             const VkMemoryToImageCopy*    pRegions;
    ///         } VkCopyMemoryToImageInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCopyMemoryToImageInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMemoryToImageInfo;

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
        ///     <c>Regions</c> is a pointer to an array of <c>VkMemoryToImageCopy</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public VkMemoryToImageCopy* Regions;
    }
}
