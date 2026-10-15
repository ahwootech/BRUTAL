namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfo.html">VkExternalMemoryImageCreateInfo</see> - Specify that an image may be backed by external memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To define a set of external memory handle types that may: be used as backing
    ///         store for an image, add a <c>VkExternalMemoryImageCreateInfo</c> structure to
    ///         the <c>pNext</c> chain of the <c>VkImageCreateInfo</c> structure.
    ///         The <c>VkExternalMemoryImageCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalMemoryImageCreateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkExternalMemoryHandleTypeFlags    handleTypes;
    ///         } VkExternalMemoryImageCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalMemoryImageCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalMemoryImageCreateInfo;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleTypes;
    }
}
