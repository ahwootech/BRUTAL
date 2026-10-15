namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageToMemoryCopy.html">VkImageToMemoryCopy</see> - Structure specifying an image to host memory copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkImageToMemoryCopy
    ///         :bufferrowlength: memoryRowLength
    ///         :bufferimageheight: memoryImageHeight
    ///     </para>
    ///     <para>
    ///         Each element of <c>VkCopyImageToMemoryInfo::pRegions</c> is a structure
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkImageToMemoryCopy {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             void*                       pHostPointer;
    ///             uint32_t                    memoryRowLength;
    ///             uint32_t                    memoryImageHeight;
    ///             VkImageSubresourceLayers    imageSubresource;
    ///             VkOffset3D                  imageOffset;
    ///             VkExtent3D                  imageExtent;
    ///         } VkImageToMemoryCopy;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkImageToMemoryCopy()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageToMemoryCopy;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HostPointer</c> is the host memory address which is the destination of the copy.
        /// </summary>
        [FieldOffset(16)]
        public void* HostPointer;

        /// <summary>
        ///     <c>MemoryRowLength</c> and <c>memoryImageHeight</c> specify in texels a subregion of a larger two- or three-dimensional image in host memory, and control the addressing calculations. If either of these values is zero, that aspect of the host memory is considered to be tightly packed according to the <c>imageExtent</c>.
        /// </summary>
        [FieldOffset(24)]
        public int MemoryRowLength;

        /// <summary>
        ///     <c>MemoryImageHeight</c>
        /// </summary>
        [FieldOffset(28)]
        public int MemoryImageHeight;

        /// <summary>
        ///     <c>ImageSubresource</c> is a <c>VkImageSubresourceLayers</c> used to specify the specific image subresources of the image used for the source or destination image data.
        /// </summary>
        [FieldOffset(32)]
        public VkImageSubresourceLayers ImageSubresource;

        /// <summary>
        ///     <c>ImageOffset</c> selects the initial <c>x</c>, <c>y</c>, <c>z</c> offsets in texels of the sub-region of the source image data.
        /// </summary>
        [FieldOffset(48)]
        public VkOffset3D ImageOffset;

        /// <summary>
        ///     <c>ImageExtent</c> is the size in texels of the image to copy in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(60)]
        public VkExtent3D ImageExtent;
    }
}
