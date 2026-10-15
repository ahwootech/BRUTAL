namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressRangeKHR.html">VkDeviceAddressRangeKHR</see> - Structure specifying a device address range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceAddressRangeKHR
    ///     </para>
    ///     <para>
    ///         A device address range indicates a sized range of device memory.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDeviceAddressRangeKHR {
    ///             VkDeviceAddress    address;
    ///             VkDeviceSize       size;
    ///         } VkDeviceAddressRangeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkDeviceAddressRangeKHR()
    {
        /// <summary>
        ///     <c>Address</c> is 0 or a basetype:VkDeviceAddress specifying the start of the range.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress Address;

        /// <summary>
        ///     <c>Size</c> is a basetype:VkDeviceSize specifying the size of the range.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Size;
    }
}
