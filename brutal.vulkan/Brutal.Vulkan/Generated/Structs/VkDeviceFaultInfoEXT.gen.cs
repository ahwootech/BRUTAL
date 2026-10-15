namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultInfoEXT.html">VkDeviceFaultInfoEXT</see> - Structure specifying device fault information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_fault
    ///         typedef struct VkDeviceFaultInfoEXT {
    ///             VkStructureType                 sType;
    ///             void*                           pNext;
    ///             char                            description[VK_MAX_DESCRIPTION_SIZE];
    ///             VkDeviceFaultAddressInfoKHR*    pAddressInfos;
    ///             VkDeviceFaultVendorInfoKHR*     pVendorInfos;
    ///             void*                           pVendorBinaryData;
    ///         } VkDeviceFaultInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 296)]
    public unsafe partial struct VkDeviceFaultInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceFaultInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>AddressInfos</c> is `NULL` or a pointer to an array of <c>VkDeviceFaultAddressInfoEXT</c> structures describing either memory accesses which may: have caused a page fault, or describing active instruction pointers at the time of the fault. The length of <c>pAddressInfos</c> is specified by the <c>VkDeviceFaultCountsEXT::addressInfoCount</c> value passed to <c>vkGetDeviceFaultInfoEXT</c>. If not `NULL`, each element of <c>pAddressInfos</c> describes a bounded region of GPU virtual address space containing either the GPU virtual address accessed, or the value of an active instruction pointer.
        /// </summary>
        [FieldOffset(272)]
        public VkDeviceFaultAddressInfoKHR* AddressInfos;

        /// <summary>
        ///     <c>VendorInfos</c> is `NULL` or a pointer to an array of <c>VkDeviceFaultVendorInfoEXT</c> structures describing vendor-specific fault information. The length of <c>pVendorInfos</c> is specified by the <c>VkDeviceFaultCountsEXT::vendorInfoCount</c> value passed to <c>vkGetDeviceFaultInfoEXT</c>.
        /// </summary>
        [FieldOffset(280)]
        public VkDeviceFaultVendorInfoKHR* VendorInfos;

        /// <summary>
        ///     <c>VendorBinaryData</c> is `NULL` or a pointer to memory which will be populated with a vendor-specific binary crash dump, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vendor-binary-crash-dumps">Vendor Binary Crash Dumps^</see>. The size of <c>pVendorBinaryData</c> is specified by the <c>VkDeviceFaultCountsEXT::vendorBinarySize</c> value passed to <c>vkGetDeviceFaultInfoEXT</c>.
        /// </summary>
        [FieldOffset(288)]
        public void* VendorBinaryData;
    }
}
