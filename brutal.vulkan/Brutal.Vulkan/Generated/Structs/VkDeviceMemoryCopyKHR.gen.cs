namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryCopyKHR.html">VkDeviceMemoryCopyKHR</see> - Structure specifying a memory range copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceMemoryCopyKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceMemoryCopyKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkDeviceMemoryCopyKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceAddressRangeKHR     srcRange;
    ///             VkAddressCommandFlagsKHR    srcFlags;
    ///             VkDeviceAddressRangeKHR     dstRange;
    ///             VkAddressCommandFlagsKHR    dstFlags;
    ///         } VkDeviceMemoryCopyKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDeviceMemoryCopyKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceMemoryCopyKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcRange</c> is a <c>VkDeviceAddressRangeKHR</c> structure defining the source memory to copy from.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR SrcRange;

        /// <summary>
        ///     <c>SrcFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the copy flags for the source address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR SrcFlags;

        /// <summary>
        ///     <c>DstRange</c> is a <c>VkDeviceAddressRangeKHR</c> structure defining the destination memory to copy to.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddressRangeKHR DstRange;

        /// <summary>
        ///     <c>DstFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the copy flags for the destination address range.
        /// </summary>
        [FieldOffset(56)]
        public VkAddressCommandFlagsKHR DstFlags;
    }
}
