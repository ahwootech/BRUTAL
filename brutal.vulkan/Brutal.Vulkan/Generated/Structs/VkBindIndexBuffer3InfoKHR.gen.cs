namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindIndexBuffer3InfoKHR.html">VkBindIndexBuffer3InfoKHR</see> - Index buffer binding info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindIndexBuffer3InfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkBindIndexBuffer3InfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkBindIndexBuffer3InfoKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceAddressRangeKHR     addressRange;
    ///             VkAddressCommandFlagsKHR    addressFlags;
    ///             VkIndexType                 indexType;
    ///         } VkBindIndexBuffer3InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindIndexBuffer3InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindIndexBuffer3InfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkDeviceAddressRangeKHR</c> of the address range to bind.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR AddressFlags;

        /// <summary>
        ///     <c>IndexType</c> is a <c>VkIndexType</c> value specifying the size of the indices.
        /// </summary>
        [FieldOffset(36)]
        public VkIndexType IndexType;
    }
}
