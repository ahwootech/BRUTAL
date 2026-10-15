namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalBufferProperties.html">VkExternalBufferProperties</see> - Structure specifying supported external handle capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalBufferProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalBufferProperties {
    ///             VkStructureType               sType;
    ///             void*                         pNext;
    ///             VkExternalMemoryProperties    externalMemoryProperties;
    ///         } VkExternalBufferProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkExternalBufferProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalBufferProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalMemoryProperties</c> is a <c>VkExternalMemoryProperties</c> structure specifying various capabilities of the external handle type when used with the specified buffer creation parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryProperties ExternalMemoryProperties;
    }
}
