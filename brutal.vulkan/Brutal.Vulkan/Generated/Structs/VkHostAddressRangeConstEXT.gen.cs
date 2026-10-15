namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHostAddressRangeConstEXT.html">VkHostAddressRangeConstEXT</see> - Structure specifying a constant host address range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A constant host address range indicates a range of host memory that cannot
    ///         be altered.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkHostAddressRangeConstEXT {
    ///             const void*    address;
    ///             size_t         size;
    ///         } VkHostAddressRangeConstEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkHostAddressRangeConstEXT()
    {
        /// <summary>
        ///     <c>Address</c> is a read-only host memory address.
        /// </summary>
        [FieldOffset(0)]
        public void* Address;

        /// <summary>
        ///     <c>Size</c> is the size of the range.
        /// </summary>
        [FieldOffset(8)]
        public nuint Size;
    }
}
