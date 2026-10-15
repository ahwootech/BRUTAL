namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultVendorBinaryHeaderVersionKHR.html">VkDeviceFaultVendorBinaryHeaderVersionKHR</see> - Encode vendor binary crash dump version
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>headerVersion</c> value of the crash dump header
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef enum VkDeviceFaultVendorBinaryHeaderVersionKHR {
    ///             VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_KHR = 1,
    ///             VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT = VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_KHR,
    ///         } VkDeviceFaultVendorBinaryHeaderVersionKHR;
    ///     </code>
    /// </remarks>
    public enum VkDeviceFaultVendorBinaryHeaderVersionKHR : int
    {
        /// <summary>
        ///     <c>OneKHR</c> specifies version one of the binary crash dump header.
        /// </summary>
        OneKHR = 1,

        /// <summary>
        ///     <c>OneEXT</c>
        /// </summary>
        OneEXT = OneKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
