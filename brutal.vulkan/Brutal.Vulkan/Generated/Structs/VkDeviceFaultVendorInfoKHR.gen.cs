namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorInfoKHR.html">VkDeviceFaultVendorInfoKHR</see> - Structure specifying vendor-specific fault information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultVendorInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkDeviceFaultVendorInfoKHR {
    ///             char        description[VK_MAX_DESCRIPTION_SIZE];
    ///             uint64_t    vendorFaultCode;
    ///             uint64_t    vendorFaultData;
    ///         } VkDeviceFaultVendorInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public unsafe partial struct VkDeviceFaultVendorInfoKHR()
    {
        ///
        [FieldOffset(0)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>VendorFaultCode</c> is the vendor-specific fault code for this fault.
        /// </summary>
        [FieldOffset(256)]
        public nint VendorFaultCode;

        /// <summary>
        ///     <c>VendorFaultData</c> is the vendor-specific fault data associated with this fault.
        /// </summary>
        [FieldOffset(264)]
        public nint VendorFaultData;
    }
}
