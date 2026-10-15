namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFenceCreateInfo.html">VkFenceCreateInfo</see> - Structure specifying parameters of a newly created fence
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFenceCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkFenceCreateInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkFenceCreateFlags    flags;
    ///         } VkFenceCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkFenceCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FenceCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkFenceCreateFlags</c> specifying the initial state and behavior of the fence.
        /// </summary>
        [FieldOffset(16)]
        public VkFenceCreateFlags Flags;
    }
}
