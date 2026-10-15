namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatProperties2.html">VkSparseImageFormatProperties2</see> - Structure specifying sparse image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseImageFormatProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkSparseImageFormatProperties2 {
    ///             VkStructureType                  sType;
    ///             void*                            pNext;
    ///             VkSparseImageFormatProperties    properties;
    ///         } VkSparseImageFormatProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSparseImageFormatProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SparseImageFormatProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Properties</c> is a <c>VkSparseImageFormatProperties</c> structure which is populated with the same values as in <c>vkGetPhysicalDeviceSparseImageFormatProperties</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkSparseImageFormatProperties Properties;
    }
}
