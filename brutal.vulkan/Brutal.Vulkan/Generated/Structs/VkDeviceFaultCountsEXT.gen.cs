namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultCountsEXT.html">VkDeviceFaultCountsEXT</see> - Structure specifying device fault information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultCountsEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_fault
    ///         typedef struct VkDeviceFaultCountsEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           addressInfoCount;
    ///             uint32_t           vendorInfoCount;
    ///             VkDeviceSize       vendorBinarySize;
    ///         } VkDeviceFaultCountsEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceFaultCountsEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceFaultCountsEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressInfoCount</c> is the number of <c>VkDeviceFaultAddressInfoEXT</c> structures describing either memory accesses which may: have caused a page fault, or the addresses of active instructions at the time of the fault.
        /// </summary>
        [FieldOffset(16)]
        public int AddressInfoCount;

        /// <summary>
        ///     <c>VendorInfoCount</c> is the number of <c>VkDeviceFaultVendorInfoEXT</c> structures describing vendor-specific fault information.
        /// </summary>
        [FieldOffset(20)]
        public int VendorInfoCount;

        /// <summary>
        ///     <c>VendorBinarySize</c> is the size in bytes of a vendor-specific binary crash dump, which may provide additional information when imported into external tools.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 VendorBinarySize;
    }
}
