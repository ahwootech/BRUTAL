namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageCreateFlags2CreateInfoKHR.html">VkImageCreateFlags2CreateInfoKHR</see> - Extended image usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageCreateFlags2CreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_extended_flags
    ///         typedef struct VkImageCreateFlags2CreateInfoKHR {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             VkImageCreateFlags2KHR    flags;
    ///         } VkImageCreateFlags2CreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageCreateFlags2CreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageCreateFlags2CreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageCreateFlags2KHR</c> specifying creation flags of the image.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCreateFlags2KHR Flags;
    }
}
