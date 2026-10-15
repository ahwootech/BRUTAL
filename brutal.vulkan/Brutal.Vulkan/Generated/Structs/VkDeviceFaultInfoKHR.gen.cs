namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultInfoKHR.html">VkDeviceFaultInfoKHR</see> - Structure specifying device fault information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkDeviceFaultInfoKHR {
    ///             VkStructureType                sType;
    ///             void*                          pNext;
    ///             VkDeviceFaultFlagsKHR          flags;
    ///             uint64_t                       groupId;
    ///             char                           description[VK_MAX_DESCRIPTION_SIZE];
    ///             VkDeviceFaultAddressInfoKHR    faultAddressInfo;
    ///             VkDeviceFaultAddressInfoKHR    instructionAddressInfo;
    ///             VkDeviceFaultVendorInfoKHR     vendorInfo;
    ///         } VkDeviceFaultInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 608)]
    public unsafe partial struct VkDeviceFaultInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceFaultInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDeviceFaultFlagsKHR</c> values giving information as to the type of fault and which additional fields have been populated by the driver provide further information.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceFaultFlagsKHR Flags;

        /// <summary>
        ///     <c>GroupId</c>
        /// </summary>
        [FieldOffset(24)]
        public nint GroupId;

        ///
        [FieldOffset(32)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>FaultAddressInfo</c> is a <c>VkDeviceFaultAddressInfoKHR</c> structure providing details of the memory access which caused a fault.
        /// </summary>
        [FieldOffset(288)]
        public VkDeviceFaultAddressInfoKHR FaultAddressInfo;

        /// <summary>
        ///     <c>InstructionAddressInfo</c> is a <c>VkDeviceFaultAddressInfoKHR</c> structure providing details of the GPU instruction which cause a fault.
        /// </summary>
        [FieldOffset(312)]
        public VkDeviceFaultAddressInfoKHR InstructionAddressInfo;

        /// <summary>
        ///     <c>VendorInfo</c> is a <c>VkDeviceFaultVendorInfoKHR</c> structure providing vendor specific fault information.
        /// </summary>
        [FieldOffset(336)]
        public VkDeviceFaultVendorInfoKHR VendorInfo;
    }
}
