namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBaseInStructure.html">VkBaseInStructure</see> - Base structure for a read-only pointer chain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBaseInStructure</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBaseInStructure {
    ///             VkStructureType                    sType;
    ///             const struct VkBaseInStructure*    pNext;
    ///         } VkBaseInStructure;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkBaseInStructure()
    {
        /// <summary>
        ///     <c>sType</c> is the structure type of the structure being iterated through.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to the next structure in a structure chain.
        /// </summary>
        [FieldOffset(8)]
        public VkBaseInStructure* Next;
    }
}
