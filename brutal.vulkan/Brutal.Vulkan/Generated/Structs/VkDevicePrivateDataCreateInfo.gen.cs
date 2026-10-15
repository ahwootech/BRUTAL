namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDevicePrivateDataCreateInfo.html">VkDevicePrivateDataCreateInfo</see> - Reserve private data slots
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To reserve private data storage slots, add a
    ///         <c>VkDevicePrivateDataCreateInfo</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkDeviceCreateInfo</c> structure.
    ///         Reserving slots in this manner is not strictly necessary, but doing so may:
    ///         improve performance.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkDevicePrivateDataCreateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           privateDataSlotRequestCount;
    ///         } VkDevicePrivateDataCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDevicePrivateDataCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DevicePrivateDataCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrivateDataSlotRequestCount</c> is the amount of slots to reserve.
        /// </summary>
        [FieldOffset(16)]
        public int PrivateDataSlotRequestCount;
    }
}
