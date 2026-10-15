namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStridedDeviceAddressRangeKHR.html">VkStridedDeviceAddressRangeKHR</see> - Structure specifying a device address range with a stride
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkStridedDeviceAddressRangeKHR
    ///     </para>
    ///     <para>
    ///         A strided device address range is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_copy_memory_indirect, VK_KHR_device_address_commands
    ///         typedef struct VkStridedDeviceAddressRangeKHR {
    ///             VkDeviceAddress    address;
    ///             VkDeviceSize       size;
    ///             VkDeviceSize       stride;
    ///         } VkStridedDeviceAddressRangeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkStridedDeviceAddressRangeKHR()
    {
        /// <summary>
        ///     <c>Address</c> is a basetype:VkDeviceAddress specifying the start of the range.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress Address;

        /// <summary>
        ///     <c>Size</c> is a basetype:VkDeviceSize specifying the size of the range.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Stride</c> is a basetype:VkDeviceSize specifying the stride of elements over the range.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Stride;
    }
}
