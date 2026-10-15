namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewAddressPropertiesNVX.html">VkImageViewAddressPropertiesNVX</see> - Structure specifying the image view for handle queries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageViewAddressPropertiesNVX</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_image_view_handle
    ///         typedef struct VkImageViewAddressPropertiesNVX {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceAddress    deviceAddress;
    ///             VkDeviceSize       size;
    ///         } VkImageViewAddressPropertiesNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageViewAddressPropertiesNVX()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewAddressPropertiesNVX;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceAddress</c> is the device address of the image view.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress DeviceAddress;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of the image view device memory.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Size;
    }
}
