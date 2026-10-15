namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindHeapInfoEXT.html">VkBindHeapInfoEXT</see> - Structure describing a device address range and implementation reservation for a descriptor heap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkBindHeapInfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkBindHeapInfoEXT {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkDeviceAddressRangeEXT    heapRange;
    ///             VkDeviceSize               reservedRangeOffset;
    ///             VkDeviceSize               reservedRangeSize;
    ///         } VkBindHeapInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkBindHeapInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindHeapInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HeapRange</c> is a <c>VkDeviceAddressRangeKHR</c> defining the device address range used for the heap, inclusive of the implementation reserved range.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeEXT HeapRange;

        /// <summary>
        ///     <c>ReservedRangeOffset</c> is the offset within <c>heapRange</c> to the start of the reserved range for the implementation.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 ReservedRangeOffset;

        /// <summary>
        ///     <c>ReservedRangeSize</c> is the size of the reserved range for the implementation within <c>heapRange</c>.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 ReservedRangeSize;
    }
}
