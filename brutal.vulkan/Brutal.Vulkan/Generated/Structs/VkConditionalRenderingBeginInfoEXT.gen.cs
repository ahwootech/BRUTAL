namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingBeginInfoEXT.html">VkConditionalRenderingBeginInfoEXT</see> - Structure specifying conditional rendering begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkConditionalRenderingBeginInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conditional_rendering
    ///         typedef struct VkConditionalRenderingBeginInfoEXT {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkBuffer                          buffer;
    ///             VkDeviceSize                      offset;
    ///             VkConditionalRenderingFlagsEXT    flags;
    ///         } VkConditionalRenderingBeginInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkConditionalRenderingBeginInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ConditionalRenderingBeginInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is a buffer containing the predicate for conditional rendering.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is the byte offset into <c>buffer</c> where the predicate is located.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkConditionalRenderingFlagsEXT</c> specifying the behavior of conditional rendering.
        /// </summary>
        [FieldOffset(32)]
        public VkConditionalRenderingFlagsEXT Flags;
    }
}
