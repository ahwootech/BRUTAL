namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryBufferCreateInfo.html">VkExternalMemoryBufferCreateInfo</see> - Specify that a buffer may be backed by external memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To define a set of external memory handle types that may: be used as backing
    ///         store for a buffer, add a <c>VkExternalMemoryBufferCreateInfo</c> structure
    ///         to the <c>pNext</c> chain of the <c>VkBufferCreateInfo</c> structure.
    ///         The <c>VkExternalMemoryBufferCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkExternalMemoryBufferCreateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkExternalMemoryHandleTypeFlags    handleTypes;
    ///         } VkExternalMemoryBufferCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalMemoryBufferCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalMemoryBufferCreateInfo;

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
