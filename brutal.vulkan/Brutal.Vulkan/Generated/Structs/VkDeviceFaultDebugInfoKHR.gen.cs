namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceFaultDebugInfoKHR.html">VkDeviceFaultDebugInfoKHR</see> - Structure allowing retrieval of the vendor binary crash dump
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceFaultDebugInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <para>
    ///         * <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
    ///         * <c>pNext</c> is `NULL` or a pointer to a structure extending this
    ///         structure.
    ///         * <c>vendorBinarySize</c> is the size in bytes of a vendor-specific binary
    ///         crash dump, which may: provide additional information when imported into
    ///         external tools.
    ///         * <c>pVendorBinaryData</c> is `NULL` or a pointer to <c>vendorBinarySize</c>
    ///         number of bytes of data, which will be populated with a vendor-specific
    ///         binary crash dump, as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#vendor-binary-crash-dumps">Vendor
    ///         Binary Crash Dumps^</see>.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkDeviceFaultDebugInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           vendorBinarySize;
    ///             void*              pVendorBinaryData;
    ///         } VkDeviceFaultDebugInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceFaultDebugInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceFaultDebugInfoKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VendorBinarySize</c>
        /// </summary>
        [FieldOffset(16)]
        public int VendorBinarySize;

        /// <summary>
        ///     <c>VendorBinaryData</c>
        /// </summary>
        [FieldOffset(24)]
        public void* VendorBinaryData;
    }
}
