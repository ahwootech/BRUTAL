namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatProperties2.html">VkFormatProperties2</see> - Structure specifying image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFormatProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkFormatProperties2 {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkFormatProperties    formatProperties;
    ///         } VkFormatProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFormatProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FormatProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FormatProperties</c> is a <c>VkFormatProperties</c> structure describing features supported by the requested format.
        /// </summary>
        [FieldOffset(16)]
        public VkFormatProperties FormatProperties;
    }
}
