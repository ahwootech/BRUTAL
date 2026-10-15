namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingBeginInfo2EXT.html">VkConditionalRenderingBeginInfo2EXT</see> - Structure specifying conditional rendering begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkConditionalRenderingBeginInfo2EXT
    ///     </para>
    ///     <para>
    ///         The <c>VkConditionalRenderingBeginInfo2EXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands with VK_EXT_conditional_rendering
    ///         typedef struct VkConditionalRenderingBeginInfo2EXT {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkDeviceAddressRangeKHR           addressRange;
    ///             VkAddressCommandFlagsKHR          addressFlags;
    ///             VkConditionalRenderingFlagsEXT    flags;
    ///         } VkConditionalRenderingBeginInfo2EXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkConditionalRenderingBeginInfo2EXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ConditionalRenderingBeginInfo2EXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkDeviceAddressRangeKHR</c> containing the predicate for conditional rendering.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR AddressFlags;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkConditionalRenderingFlagsEXT</c> specifying the behavior of conditional rendering.
        /// </summary>
        [FieldOffset(36)]
        public VkConditionalRenderingFlagsEXT Flags;
    }
}
