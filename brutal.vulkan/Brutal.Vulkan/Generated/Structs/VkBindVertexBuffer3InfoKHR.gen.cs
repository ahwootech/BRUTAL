namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindVertexBuffer3InfoKHR.html">VkBindVertexBuffer3InfoKHR</see> - Bind vertex buffer info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindVertexBuffer3InfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkBindVertexBuffer3InfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkBindVertexBuffer3InfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkBool32                          setStride;
    ///             VkStridedDeviceAddressRangeKHR    addressRange;
    ///             VkAddressCommandFlagsKHR          addressFlags;
    ///         } VkBindVertexBuffer3InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkBindVertexBuffer3InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindVertexBuffer3InfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SetStride</c> is a basetype:VkBool32 value indicating whether <c>addressRange</c>.stride sets the stride for the buffer. If <c>setStride</c> is <c>VK_TRUE</c>, the dynamic stride is set for all attributes from this buffer. If <c>setStride</c> is <c>VK_FALSE</c>, the stride value is not set.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SetStride;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkStridedDeviceAddressRangeKHR</c> of the address range to bind.
        /// </summary>
        [FieldOffset(24)]
        public VkStridedDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(48)]
        public VkAddressCommandFlagsKHR AddressFlags;
    }
}
