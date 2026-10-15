namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultAddressTypeKHR.html">VkDeviceFaultAddressTypeKHR</see> - Page fault access types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDeviceFaultAddressInfoKHR::addressType</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef enum VkDeviceFaultAddressTypeKHR {
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_KHR = 0,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_KHR = 1,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_KHR = 2,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_KHR = 3,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_KHR = 4,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_KHR = 5,
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_KHR = 6,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_KHR,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT = VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_KHR,
    ///         } VkDeviceFaultAddressTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkDeviceFaultAddressTypeKHR : int
    {
        /// <summary>
        ///     <c>NoneKHR</c> specifies that <c>VkDeviceFaultAddressInfoKHR</c> does not describe a page fault, or an instruction address.
        /// </summary>
        NoneKHR = 0,

        /// <summary>
        ///     <c>ReadInvalidKHR</c> specifies that <c>VkDeviceFaultAddressInfoKHR</c> describes a page fault triggered by an invalid read operation.
        /// </summary>
        ReadInvalidKHR = 1,

        /// <summary>
        ///     <c>WriteInvalidKHR</c> specifies that <c>VkDeviceFaultAddressInfoKHR</c> describes a page fault triggered by an invalid write operation.
        /// </summary>
        WriteInvalidKHR = 2,

        /// <summary>
        ///     <c>ExecuteInvalidKHR</c> specifies that <c>VkDeviceFaultAddressInfoKHR</c> describes a page fault triggered by an attempt to execute non-executable memory.
        /// </summary>
        ExecuteInvalidKHR = 3,

        /// <summary>
        ///     <c>InstructionPointerUnknownKHR</c>  specifies an instruction pointer value at the time the fault occurred. This may or may not be related to a fault.
        /// </summary>
        InstructionPointerUnknownKHR = 4,

        /// <summary>
        ///     <c>InstructionPointerInvalidKHR</c>  specifies an instruction pointer value associated with an invalid instruction fault.
        /// </summary>
        InstructionPointerInvalidKHR = 5,

        /// <summary>
        ///     <c>InstructionPointerFaultKHR</c>  specifies an instruction pointer value associated with a fault.  [NOTE]
        /// </summary>
        InstructionPointerFaultKHR = 6,

        /// <summary>
        ///     <c>NoneEXT</c>
        /// </summary>
        NoneEXT = NoneKHR,

        /// <summary>
        ///     <c>ReadInvalidEXT</c>
        /// </summary>
        ReadInvalidEXT = ReadInvalidKHR,

        /// <summary>
        ///     <c>WriteInvalidEXT</c>
        /// </summary>
        WriteInvalidEXT = WriteInvalidKHR,

        /// <summary>
        ///     <c>ExecuteInvalidEXT</c>
        /// </summary>
        ExecuteInvalidEXT = ExecuteInvalidKHR,

        /// <summary>
        ///     <c>InstructionPointerUnknownEXT</c>
        /// </summary>
        InstructionPointerUnknownEXT = InstructionPointerUnknownKHR,

        /// <summary>
        ///     <c>InstructionPointerInvalidEXT</c>
        /// </summary>
        InstructionPointerInvalidEXT = InstructionPointerInvalidKHR,

        /// <summary>
        ///     <c>InstructionPointerFaultEXT</c>
        /// </summary>
        InstructionPointerFaultEXT = InstructionPointerFaultKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
