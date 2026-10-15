namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBaseOutStructure.html">VkBaseOutStructure</see> - Base structure for a read-only pointer chain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBaseOutStructure</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBaseOutStructure {
    ///             VkStructureType               sType;
    ///             struct VkBaseOutStructure*    pNext;
    ///         } VkBaseOutStructure;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkBaseOutStructure()
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
        public VkBaseOutStructure* Next;
    }
}
