namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingFlagBitsEXT.html">VkDeviceAddressBindingFlagBitsEXT</see> - Bitmask specifying the additional information about a binding event
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDeviceAddressBindingCallbackDataEXT::flags</c> specifying
    ///         additional information about a binding event are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_address_binding_report
    ///         typedef enum VkDeviceAddressBindingFlagBitsEXT {
    ///             VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT = 0x00000001,
    ///         } VkDeviceAddressBindingFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDeviceAddressBindingFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InternalObjectBitEXT</c> specifies that <c>VkDeviceAddressBindingCallbackDataEXT</c> describes a Vulkan object that has not been made visible to the application via a Vulkan command.
        /// </summary>
        InternalObjectBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
