namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties2.html">VkImageFormatProperties2</see> - Structure specifying an image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageFormatProperties2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkImageFormatProperties2 {
    ///             VkStructureType            sType;
    ///             void*                      pNext;
    ///             VkImageFormatProperties    imageFormatProperties;
    ///         } VkImageFormatProperties2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkImageFormatProperties2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageFormatProperties2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure. The <c>pNext</c> chain of <c>VkImageFormatProperties2</c> is used to allow the specification of additional capabilities to be returned from <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageFormatProperties</c> is a <c>VkImageFormatProperties</c> structure in which capabilities are returned.
        /// </summary>
        [FieldOffset(16)]
        public VkImageFormatProperties ImageFormatProperties;
    }
}
