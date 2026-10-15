namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyImageToMemoryInfo.html">VkCopyImageToMemoryInfo</see> - Structure specifying parameters of an image to host memory copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyImageToMemoryInfo
    ///         :imageparam: srcImage
    ///         :imagesubresource: imageSubresource
    ///         :imageoffset: imageOffset
    ///         :imageextent: imageExtent
    ///         :bufferrowlength: memoryRowLength
    ///         :bufferimageheight: memoryImageHeight
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyImageToMemoryInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkCopyImageToMemoryInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkHostImageCopyFlags          flags;
    ///             VkImage                       srcImage;
    ///             VkImageLayout                 srcImageLayout;
    ///             uint32_t                      regionCount;
    ///             const VkImageToMemoryCopy*    pRegions;
    ///         } VkCopyImageToMemoryInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCopyImageToMemoryInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyImageToMemoryInfo;

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
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(36)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkImageToMemoryCopy</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public VkImageToMemoryCopy* Regions;
    }
}
