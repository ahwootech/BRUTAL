namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferCopy.html">VkBufferCopy</see> - Structure specifying a buffer copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferCopy
    ///     </para>
    ///     <para>
    ///         The <c>VkBufferCopy</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBufferCopy {
    ///             VkDeviceSize    srcOffset;
    ///             VkDeviceSize    dstOffset;
    ///             VkDeviceSize    size;
    ///         } VkBufferCopy;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkBufferCopy()
    {
        /// <summary>
        ///     <c>SrcOffset</c> is the starting offset in bytes from the start of <c>srcBuffer</c>.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 SrcOffset;

        /// <summary>
        ///     <c>DstOffset</c> is the starting offset in bytes from the start of <c>dstBuffer</c>.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 DstOffset;

        /// <summary>
        ///     <c>Size</c> is the number of bytes to copy.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;
    }
}
