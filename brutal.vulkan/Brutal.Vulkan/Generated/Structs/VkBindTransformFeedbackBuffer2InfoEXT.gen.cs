namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindTransformFeedbackBuffer2InfoEXT.html">VkBindTransformFeedbackBuffer2InfoEXT</see> - Bind transform feedback buffer info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindTransformFeedbackBuffer2InfoEXT
    ///     </para>
    ///     <para>
    ///         <c>VkBindTransformFeedbackBuffer2InfoEXT</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands with VK_EXT_transform_feedback
    ///         typedef struct VkBindTransformFeedbackBuffer2InfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkDeviceAddressRangeKHR     addressRange;
    ///             VkAddressCommandFlagsKHR    addressFlags;
    ///         } VkBindTransformFeedbackBuffer2InfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindTransformFeedbackBuffer2InfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindTransformFeedbackBuffer2InfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AddressRange</c> is the <c>VkDeviceAddressRangeKHR</c> of the address range to use.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressRangeKHR AddressRange;

        /// <summary>
        ///     <c>AddressFlags</c> is a <c>VkAddressCommandFlagsKHR</c> value defining the flags for the address range.
        /// </summary>
        [FieldOffset(32)]
        public VkAddressCommandFlagsKHR AddressFlags;
    }
}
