namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubresourceLayout2.html">VkSubresourceLayout2</see> - Structure specifying subresource layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the layout of the image subresource is returned in a
    ///         <c>VkSubresourceLayout2</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkSubresourceLayout2 {
    ///             VkStructureType        sType;
    ///             void*                  pNext;
    ///             VkSubresourceLayout    subresourceLayout;
    ///         } VkSubresourceLayout2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkSubresourceLayout2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubresourceLayout2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubresourceLayout</c> is a <c>VkSubresourceLayout</c> structure.
        /// </summary>
        [FieldOffset(16)]
        public VkSubresourceLayout SubresourceLayout;
    }
}
