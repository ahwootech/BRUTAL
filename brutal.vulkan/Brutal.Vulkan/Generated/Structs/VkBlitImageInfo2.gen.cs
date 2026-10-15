namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlitImageInfo2.html">VkBlitImageInfo2</see> - Structure specifying parameters of blit image command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBlitImageInfo2
    ///     </para>
    ///     <para>
    ///         The <c>VkBlitImageInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkBlitImageInfo2 {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkImage                srcImage;
    ///             VkImageLayout          srcImageLayout;
    ///             VkImage                dstImage;
    ///             VkImageLayout          dstImageLayout;
    ///             uint32_t               regionCount;
    ///             const VkImageBlit2*    pRegions;
    ///             VkFilter               filter;
    ///         } VkBlitImageInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkBlitImageInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BlitImageInfo2;

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
        ///     <c>SrcImageLayout</c> is the layout of the source image subresources for the blit.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout SrcImageLayout;

        /// <summary>
        ///     <c>DstImage</c> is the destination image.
        /// </summary>
        [FieldOffset(32)]
        public VkImage DstImage;

        /// <summary>
        ///     <c>DstImageLayout</c> is the layout of the destination image subresources for the blit.
        /// </summary>
        [FieldOffset(40)]
        public VkImageLayout DstImageLayout;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to blit.
        /// </summary>
        [FieldOffset(44)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkImageBlit2</c> structures specifying the regions to blit.
        /// </summary>
        [FieldOffset(48)]
        public VkImageBlit2* Regions;

        /// <summary>
        ///     <c>Filter</c> is a <c>VkFilter</c> specifying the filter to apply if the blits require scaling.
        /// </summary>
        [FieldOffset(56)]
        public VkFilter Filter;
    }
}
