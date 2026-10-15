namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingTypeEXT.html">VkDeviceAddressBindingTypeEXT</see> - Enum describing a change in device address bindings
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceAddressBindingTypeEXT</c> enum is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_address_binding_report
    ///         typedef enum VkDeviceAddressBindingTypeEXT {
    ///             VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT = 0,
    ///             VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT = 1,
    ///         } VkDeviceAddressBindingTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDeviceAddressBindingTypeEXT : int
    {
        /// <summary>
        ///     <c>BindEXT</c> specifies that a new GPU-accessible virtual address range has been bound.
        /// </summary>
        BindEXT = 0,

        /// <summary>
        ///     <c>UnbindEXT</c> specifies that a GPU-accessible virtual address range has been unbound.
        /// </summary>
        UnbindEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
