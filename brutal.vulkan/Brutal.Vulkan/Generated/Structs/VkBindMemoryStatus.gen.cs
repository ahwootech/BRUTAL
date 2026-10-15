namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindMemoryStatus.html">VkBindMemoryStatus</see> - Structure specifying where to return memory binding status
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindMemoryStatus</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkBindMemoryStatus {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkResult*          pResult;
    ///         } VkBindMemoryStatus;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBindMemoryStatus()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindMemoryStatus;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Result</c> is a pointer to a <c>VkResult</c> value.
        /// </summary>
        [FieldOffset(16)]
        public VkResult* Result;
    }
}
