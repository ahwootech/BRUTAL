namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatProperties.html">VkExternalImageFormatProperties</see> - Structure specifying supported external handle properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalImageFormatProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalImageFormatProperties {
    ///             VkStructureType               sType;
    ///             void*                         pNext;
    ///             VkExternalMemoryProperties    externalMemoryProperties;
    ///         } VkExternalImageFormatProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkExternalImageFormatProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalImageFormatProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalMemoryProperties</c> is a <c>VkExternalMemoryProperties</c> structure specifying various capabilities of the external handle type when used with the specified image creation parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryProperties ExternalMemoryProperties;
    }
}
