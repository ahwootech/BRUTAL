namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryImageCreateInfoNV.html">VkExternalMemoryImageCreateInfoNV</see> - Specify that an image may be backed by external memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a <c>VkExternalMemoryImageCreateInfoNV</c>
    ///         structure, then that structure defines a set of external memory handle types
    ///         that may: be used as backing store for the image.
    ///     </para>
    ///     <para>
    ///         The <c>VkExternalMemoryImageCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory
    ///         typedef struct VkExternalMemoryImageCreateInfoNV {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkExternalMemoryHandleTypeFlagsNV    handleTypes;
    ///         } VkExternalMemoryImageCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalMemoryImageCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalMemoryImageCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c> is zero or a bitmask of <c>VkExternalMemoryHandleTypeFlagsNV</c> specifying one or more external memory handle types.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlagsNV HandleTypes;
    }
}
