namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDrawIndirect2InfoKHR.html">VkDrawIndirect2InfoKHR</see> - Draw indirect info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDrawIndirect2InfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkDrawIndirect2InfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDrawIndirect2InfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkStridedDeviceAddressRangeKHR    addressRange;
    ///             VkAddressCommandFlagsKHR          addressFlags;
    ///             uint32_t                          drawCount;
    ///         } VkDrawIndirect2InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDrawIndirect2InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DrawIndirect2InfoKHR;

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
        ///     <c>DrawCount</c> is the number of draws to execute, and <i>can</i> be zero.
        /// </summary>
        [FieldOffset(44)]
        public int DrawCount;
    }
}
