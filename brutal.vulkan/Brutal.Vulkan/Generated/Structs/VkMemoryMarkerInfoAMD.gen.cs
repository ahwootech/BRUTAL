namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryMarkerInfoAMD.html">VkMemoryMarkerInfoAMD</see> - Memory marker write info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMemoryMarkerInfoAMD
    ///     </para>
    ///     <para>
    ///         <c>VkMemoryMarkerInfoAMD</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands with VK_AMD_buffer_marker
    ///         typedef struct VkMemoryMarkerInfoAMD {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkPipelineStageFlags2KHR    stage;
    ///             VkDeviceAddressRangeKHR     dstRange;
    ///             VkAddressCommandFlagsKHR    dstFlags;
    ///             uint32_t                    marker;
    ///         } VkMemoryMarkerInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkMemoryMarkerInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryMarkerInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Stage</c> specifies the pipeline stage whose completion triggers the marker write.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags2KHR Stage;

        /// <summary>
        ///     <c>DstRange</c> is the <c>VkDeviceAddressRangeKHR</c> where the marker will be written.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddressRangeKHR DstRange;

        /// <summary>
        ///     <c>DstFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the copy flags for the destination address range.
        /// </summary>
        [FieldOffset(40)]
        public VkAddressCommandFlagsKHR DstFlags;

        /// <summary>
        ///     <c>Marker</c> is the 32-bit value of the marker.
        /// </summary>
        [FieldOffset(44)]
        public int Marker;
    }
}
