namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyImageInfo2.html">VkCopyImageInfo2</see> - Structure specifying parameters of an image copy command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyImageInfo2
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyImageInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCopyImageInfo2 {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkImage                srcImage;
    ///             VkImageLayout          srcImageLayout;
    ///             VkImage                dstImage;
    ///             VkImageLayout          dstImageLayout;
    ///             uint32_t               regionCount;
    ///             const VkImageCopy2*    pRegions;
    ///         } VkCopyImageInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCopyImageInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyImageInfo2;

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
        ///     <c>SrcImageLayout</c> is the current layout of the source image subresource.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout SrcImageLayout;

        /// <summary>
        ///     <c>DstImage</c> is the destination image.
        /// </summary>
        [FieldOffset(32)]
        public VkImage DstImage;

        /// <summary>
        ///     <c>DstImageLayout</c> is the current layout of the destination image subresource.
        /// </summary>
        [FieldOffset(40)]
        public VkImageLayout DstImageLayout;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(44)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkImageCopy2</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(48)]
        public VkImageCopy2* Regions;
    }
}
