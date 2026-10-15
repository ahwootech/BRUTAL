namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceOrHostAddressConstKHR.html">VkDeviceOrHostAddressConstKHR</see> - Union specifying a const device or host address
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceOrHostAddressConstKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceOrHostAddressConstKHR</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure, VK_NV_cooperative_vector
    ///         typedef union VkDeviceOrHostAddressConstKHR {
    ///             VkDeviceAddress    deviceAddress;
    ///             const void*        hostAddress;
    ///         } VkDeviceOrHostAddressConstKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkDeviceOrHostAddressConstKHR()
    {
        /// <summary>
        ///     <c>DeviceAddress</c> is a buffer device address as returned by the <c>vkGetBufferDeviceAddressKHR</c> command.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress DeviceAddress;

        /// <summary>
        ///     <c>HostAddress</c> is a const host memory address.
        /// </summary>
        [FieldOffset(0)]
        public void* HostAddress;
    }
}
