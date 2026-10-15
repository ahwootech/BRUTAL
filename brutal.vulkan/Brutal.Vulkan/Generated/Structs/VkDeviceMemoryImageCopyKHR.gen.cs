namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryImageCopyKHR.html">VkDeviceMemoryImageCopyKHR</see> - Structure specifying a copy operation between a memory range and texels in an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceMemoryImageCopyKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceMemoryImageCopyKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDeviceMemoryImageCopyKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceAddressRangeKHR     addressRange;
    ///             VkAddressCommandFlagsKHR    addressFlags;
    ///             uint32_t                    addressRowLength;
    ///             uint32_t                    addressImageHeight;
    ///             VkImageSubresourceLayers    imageSubresource;
    ///             VkImageLayout               imageLayout;
    ///             VkOffset3D                  imageOffset;
    ///             VkExtent3D                  imageExtent;
    ///         } VkDeviceMemoryImageCopyKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkDeviceMemoryImageCopyKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceMemoryImageCopyKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is a <c>VkDeviceAddressRangeKHR</c> structure defining the address range accessed by the copy operation.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the copy flags for the source address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR AddressFlags;

        /// <summary>
        ///     <c>AddressRowLength</c> specifies the total number of texels in the address range representing a row of texels in the x dimension. Each new row of pixels in the copy will be read at an offset increment by this number of texels.
        /// </summary>
        [FieldOffset(36)]
        public int AddressRowLength;

        /// <summary>
        ///     <c>AddressImageHeight</c> specifies the total number of rows of texels in the address range representing a 2D slice of texels in the x and y dimensions. Each new 2D slice of pixels in the copy will be read at an offset increment by this number of rows of texels.
        /// </summary>
        [FieldOffset(40)]
        public int AddressImageHeight;

        /// <summary>
        ///     <c>ImageSubresource</c> is a <c>VkImageSubresourceLayers</c> used to specify the specific image subresources of the image used for the source or destination image data.
        /// </summary>
        [FieldOffset(44)]
        public VkImageSubresourceLayers ImageSubresource;

        /// <summary>
        ///     <c>ImageLayout</c> is the <c>VkImageLayout</c> of the image subresource accessed by this copy.
        /// </summary>
        [FieldOffset(60)]
        public VkImageLayout ImageLayout;

        /// <summary>
        ///     <c>ImageOffset</c> selects the initial <c>x</c>, <c>y</c>, <c>z</c> offsets in texels of the sub-region of the source or destination image data.
        /// </summary>
        [FieldOffset(64)]
        public VkOffset3D ImageOffset;

        /// <summary>
        ///     <c>ImageExtent</c> is the size in texels of the image to copy in <c>width</c>, <c>height</c> and <c>depth</c>.
        /// </summary>
        [FieldOffset(76)]
        public VkExtent3D ImageExtent;
    }
}
