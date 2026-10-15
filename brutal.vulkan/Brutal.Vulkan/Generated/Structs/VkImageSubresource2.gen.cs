namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSubresource2.html">VkImageSubresource2</see> - Structure specifying an image subresource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageSubresource2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkImageSubresource2 {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkImageSubresource    imageSubresource;
    ///         } VkImageSubresource2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkImageSubresource2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageSubresource2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageSubresource</c> is a <c>VkImageSubresource</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkImageSubresource ImageSubresource;
    }
}
