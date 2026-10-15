namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushDataInfoEXT.html">VkPushDataInfoEXT</see> - Structure specifying a push data update operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPushDataInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkPushDataInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkPushDataInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             uint32_t                      offset;
    ///             VkHostAddressRangeConstEXT    data;
    ///         } VkPushDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPushDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PushDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Offset</c> is the start offset of the push data range to update, in units of bytes.
        /// </summary>
        [FieldOffset(16)]
        public int Offset;

        /// <summary>
        ///     <c>Data</c> is the host address range containing the push data to update.
        /// </summary>
        [FieldOffset(24)]
        public VkHostAddressRangeConstEXT Data;
    }
}
