namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorBufferInfo.html">VkDescriptorBufferInfo</see> - Structure specifying descriptor buffer information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorBufferInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorBufferInfo {
    ///             VkBuffer        buffer;
    ///             VkDeviceSize    offset;
    ///             VkDeviceSize    range;
    ///         } VkDescriptorBufferInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkDescriptorBufferInfo()
    {
        /// <summary>
        ///     <c>Buffer</c> is the buffer resource.
        /// </summary>
        [FieldOffset(0)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is the offset in bytes from the start of <c>buffer</c>. Access to buffer memory via this descriptor uses addressing that is relative to this starting offset.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Range</c> is the size in bytes that is used for this descriptor update, or <c>VK_WHOLE_SIZE</c> to use the range from <c>offset</c> to the end of the buffer. + [NOTE]
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Range;
    }
}
