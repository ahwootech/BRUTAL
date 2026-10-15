namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCount2InfoKHR.html">VkDrawIndirectCount2InfoKHR</see> - Draw indirect count info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDrawIndirectCount2InfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkDrawIndirectCount2InfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDrawIndirectCount2InfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkStridedDeviceAddressRangeKHR    addressRange;
    ///             VkAddressCommandFlagsKHR          addressFlags;
    ///             VkDeviceAddressRangeKHR           countAddressRange;
    ///             VkAddressCommandFlagsKHR          countAddressFlags;
    ///             uint32_t                          maxDrawCount;
    ///         } VkDrawIndirectCount2InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkDrawIndirectCount2InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DrawIndirectCount2InfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkStridedDeviceAddressRangeKHR</c> containing draw parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkStridedDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(40)]
        public VkAddressCommandFlagsKHR AddressFlags;

        /// <summary>
        ///     <c>CountAddressRange</c> is the <c>VkDeviceAddressRangeKHR</c> containing the draw count.
        /// </summary>
        [FieldOffset(48)]
        public VkDeviceAddressRangeKHR CountAddressRange;

        /// <summary>
        ///     <c>CountAddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the count address range.
        /// </summary>
        [FieldOffset(64)]
        public VkAddressCommandFlagsKHR CountAddressFlags;

        /// <summary>
        ///     <c>MaxDrawCount</c> specifies the maximum number of draws that will be executed. The actual number of executed draw calls is the minimum of the count specified in <c>countAddressRange</c> and <c>maxDrawCount</c>.
        /// </summary>
        [FieldOffset(68)]
        public int MaxDrawCount;
    }
}
