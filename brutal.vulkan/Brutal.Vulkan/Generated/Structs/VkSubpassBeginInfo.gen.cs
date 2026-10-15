namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassBeginInfo.html">VkSubpassBeginInfo</see> - Structure specifying subpass begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSubpassBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSubpassBeginInfo {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkSubpassContents    contents;
    ///         } VkSubpassBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSubpassBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Contents</c> is a <c>VkSubpassContents</c> value specifying how the commands in the next subpass will be provided.
        /// </summary>
        [FieldOffset(16)]
        public VkSubpassContents Contents;
    }
}
