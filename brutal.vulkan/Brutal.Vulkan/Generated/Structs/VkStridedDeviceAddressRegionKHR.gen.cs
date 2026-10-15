namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStridedDeviceAddressRegionKHR.html">VkStridedDeviceAddressRegionKHR</see> - Structure specifying a region of device addresses with a stride
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkStridedDeviceAddressRegionKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkStridedDeviceAddressRegionKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkStridedDeviceAddressRegionKHR {
    ///             VkDeviceAddress    deviceAddress;
    ///             VkDeviceSize       stride;
    ///             VkDeviceSize       size;
    ///         } VkStridedDeviceAddressRegionKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkStridedDeviceAddressRegionKHR()
    {
        /// <summary>
        ///     <c>DeviceAddress</c> is the device address (as returned by the <c>vkGetBufferDeviceAddress</c> command) at which the region starts, or zero if the region is unused.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress DeviceAddress;

        /// <summary>
        ///     <c>Stride</c> is the byte stride between consecutive elements.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Stride;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of the region starting at <c>deviceAddress</c>.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;
    }
}
