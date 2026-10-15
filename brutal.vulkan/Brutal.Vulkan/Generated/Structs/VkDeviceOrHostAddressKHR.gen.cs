namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceOrHostAddressKHR.html">VkDeviceOrHostAddressKHR</see> - Union specifying a device or host address
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceOrHostAddressKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceOrHostAddressKHR</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure, VK_NV_cooperative_vector
    ///         typedef union VkDeviceOrHostAddressKHR {
    ///             VkDeviceAddress    deviceAddress;
    ///             void*              hostAddress;
    ///         } VkDeviceOrHostAddressKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkDeviceOrHostAddressKHR()
    {
        /// <summary>
        ///     <c>DeviceAddress</c> is a buffer device address as returned by the <c>vkGetBufferDeviceAddressKHR</c> command.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress DeviceAddress;

        /// <summary>
        ///     <c>HostAddress</c> is a host memory address.
        /// </summary>
        [FieldOffset(0)]
        public void* HostAddress;
    }
}
