namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDispatchIndirect2InfoKHR.html">VkDispatchIndirect2InfoKHR</see> - Dispatch indirect info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDispatchIndirect2InfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkDispatchIndirect2InfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDispatchIndirect2InfoKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceAddressRangeKHR     addressRange;
    ///             VkAddressCommandFlagsKHR    addressFlags;
    ///         } VkDispatchIndirect2InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDispatchIndirect2InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DispatchIndirect2InfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkDeviceAddressRangeKHR</c> containing dispatch parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR AddressFlags;
    }
}
