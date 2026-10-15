namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressInfoKHR.html">VkDeviceFaultAddressInfoKHR</see> - Structure specifying GPU virtual address information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultAddressInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkDeviceFaultAddressInfoKHR {
    ///             VkDeviceFaultAddressTypeKHR    addressType;
    ///             VkDeviceAddress                reportedAddress;
    ///             VkDeviceSize                   addressPrecision;
    ///         } VkDeviceFaultAddressInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkDeviceFaultAddressInfoKHR()
    {
        /// <summary>
        ///     <c>AddressType</c> is either the type of memory operation that triggered a page fault, or the type of association between an instruction pointer and a fault.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceFaultAddressTypeKHR AddressType;

        /// <summary>
        ///     <c>ReportedAddress</c> is the GPU virtual address recorded by the device.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress ReportedAddress;

        /// <summary>
        ///     <c>AddressPrecision</c> is a power of two value that specifies how precisely the device can report the address.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 AddressPrecision;
    }
}
