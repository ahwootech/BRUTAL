namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultFlagBitsKHR.html">VkDeviceFaultFlagBitsKHR</see> - Bits which may be set in a VkDeviceFaultFlagsKHR bitmask
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkDeviceFaultInfoKHR::flags</c> providing
    ///         information of the status of the fault reported and which additional fields
    ///         have been populated by the driver, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef enum VkDeviceFaultFlagBitsKHR {
    ///             VK_DEVICE_FAULT_FLAG_DEVICE_LOST_KHR = 0x00000001,
    ///             VK_DEVICE_FAULT_FLAG_MEMORY_ADDRESS_KHR = 0x00000002,
    ///             VK_DEVICE_FAULT_FLAG_INSTRUCTION_ADDRESS_KHR = 0x00000004,
    ///             VK_DEVICE_FAULT_FLAG_VENDOR_KHR = 0x00000008,
    ///             VK_DEVICE_FAULT_FLAG_WATCHDOG_TIMEOUT_KHR = 0x00000010,
    ///             VK_DEVICE_FAULT_FLAG_OVERFLOW_KHR = 0x00000020,
    ///         } VkDeviceFaultFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDeviceFaultFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagDeviceLostKHR</c> specifies that the fault has resulted in a device lost condition. No subsequent entries will be returned for this device.
        /// </summary>
        FlagDeviceLostKHR = 0x00000001,

        /// <summary>
        ///     <c>FlagMemoryAddressKHR</c> specifies that the fault has associated memory access address information which is stored in the faultAddressInfo field (see <c>VkDeviceFaultAddressInfoKHR</c>).
        /// </summary>
        FlagMemoryAddressKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagInstructionAddressKHR</c> specifies that the fault has an associated instruction address which is stored in the instructionAddressInfo field (see <c>VkDeviceFaultAddressInfoKHR</c>).
        /// </summary>
        FlagInstructionAddressKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagVendorKHR</c> specifies that the fault has associated vendor information stored in the vendorInfo field (see <c>VkDeviceFaultVendorInfoKHR</c>).
        /// </summary>
        FlagVendorKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagWatchdogTimeoutKHR</c> specifies that the fault was the result of a GPU timeout. Further information may: be made available using other platform specific extensions via the pNext chain of the <c>VkDeviceFaultInfoKHR</c> structure.
        /// </summary>
        FlagWatchdogTimeoutKHR = 0x00000010,

        /// <summary>
        ///     <c>FlagOverflowKHR</c> specifies that prior faults have occurred, but information about them is no longer available. This typically indicates that faults are occurring more rapidly than the calling application is able to read them back.
        /// </summary>
        FlagOverflowKHR = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
