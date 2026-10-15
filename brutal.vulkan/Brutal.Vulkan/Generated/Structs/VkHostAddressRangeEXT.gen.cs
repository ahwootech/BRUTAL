namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHostAddressRangeEXT.html">VkHostAddressRangeEXT</see> - Structure specifying a host address range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A host address range indicates a range of host memory.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkHostAddressRangeEXT {
    ///             void*     address;
    ///             size_t    size;
    ///         } VkHostAddressRangeEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkHostAddressRangeEXT()
    {
        /// <summary>
        ///     <c>Address</c> is a host memory address.
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
