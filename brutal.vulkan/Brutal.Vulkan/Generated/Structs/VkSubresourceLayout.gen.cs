namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubresourceLayout.html">VkSubresourceLayout</see> - Structure specifying subresource layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the layout of the image subresource is returned in a
    ///         <c>VkSubresourceLayout</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSubresourceLayout {
    ///             VkDeviceSize    offset;
    ///             VkDeviceSize    size;
    ///             VkDeviceSize    rowPitch;
    ///             VkDeviceSize    arrayPitch;
    ///             VkDeviceSize    depthPitch;
    ///         } VkSubresourceLayout;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct VkSubresourceLayout()
    {
        /// <summary>
        ///     <c>Offset</c> is the byte offset from the start of the image where the image subresource begins.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of the image subresource. <c>size</c> includes any extra memory that is required based on <c>rowPitch</c>.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>RowPitch</c> describes the number of bytes between each row of texels in an image.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 RowPitch;

        /// <summary>
        ///     <c>ArrayPitch</c> describes the number of bytes between each array layer of an image.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 ArrayPitch;

        /// <summary>
        ///     <c>DepthPitch</c> describes the number of bytes between each slice of 3D image.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 DepthPitch;
    }
}
