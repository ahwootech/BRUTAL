namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkEventCreateInfo.html">VkEventCreateInfo</see> - Structure specifying parameters of a newly created event
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkEventCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkEventCreateInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkEventCreateFlags    flags;
    ///         } VkEventCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkEventCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.EventCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkEventCreateFlags</c> defining additional creation parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkEventCreateFlags Flags;
    }
}
