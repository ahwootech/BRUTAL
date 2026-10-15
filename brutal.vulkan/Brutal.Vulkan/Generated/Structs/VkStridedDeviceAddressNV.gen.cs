namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStridedDeviceAddressNV.html">VkStridedDeviceAddressNV</see> - Structure specifying a device addresses with a stride
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkStridedDeviceAddressNV
    ///     </para>
    ///     <para>
    ///         The <c>VkStridedDeviceAddressNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkStridedDeviceAddressNV {
    ///             VkDeviceAddress    startAddress;
    ///             VkDeviceSize       strideInBytes;
    ///         } VkStridedDeviceAddressNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkStridedDeviceAddressNV()
    {
        /// <summary>
        ///     <c>StartAddress</c> is the device address (as returned by the <c>vkGetBufferDeviceAddress</c> command) at which the region starts, or zero if the region is unused.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress StartAddress;

        /// <summary>
        ///     <c>StrideInBytes</c> is the byte stride between consecutive elements. Only the bottom 32 bits are used. The field is 64 bits to ensure consistent alignment across all containing structures.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 StrideInBytes;
    }
}
