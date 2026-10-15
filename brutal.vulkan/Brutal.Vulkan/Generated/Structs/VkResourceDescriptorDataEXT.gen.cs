namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResourceDescriptorDataEXT.html">VkResourceDescriptorDataEXT</see> - Union specifying resource descriptor types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkResourceDescriptorDataEXT</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef union VkResourceDescriptorDataEXT {
    ///             const VkImageDescriptorInfoEXT*          pImage;
    ///             const VkTexelBufferDescriptorInfoEXT*    pTexelBuffer;
    ///             const VkDeviceAddressRangeEXT*           pAddressRange;
    ///             const VkTensorViewCreateInfoARM*         pTensorARM;
    ///         } VkResourceDescriptorDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkResourceDescriptorDataEXT()
    {
        /// <summary>
        ///     <c>Image</c> is a pointer to a <c>VkImageDescriptorInfoEXT</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkImageDescriptorInfoEXT* Image;

        /// <summary>
        ///     <c>TexelBuffer</c> is a pointer to a <c>VkTexelBufferDescriptorInfoEXT</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkTexelBufferDescriptorInfoEXT* TexelBuffer;

        /// <summary>
        ///     <c>AddressRange</c> is a pointer to a <c>VkDeviceAddressRangeKHR</c> structure.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddressRangeEXT* AddressRange;

        /// <summary>
        ///     <c>TensorARM</c>
        /// </summary>
        [FieldOffset(0)]
        public VkTensorViewCreateInfoARM* TensorARM;
    }
}
