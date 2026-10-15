namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassEndInfo.html">VkSubpassEndInfo</see> - Structure specifying subpass end information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSubpassEndInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSubpassEndInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///         } VkSubpassEndInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkSubpassEndInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassEndInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
