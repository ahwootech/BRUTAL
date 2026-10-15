namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferCaptureDescriptorDataInfoEXT.html">VkBufferCaptureDescriptorDataInfoEXT</see> - Structure specifying a buffer for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the buffer to get descriptor buffer capture data for is
    ///         passed in a <c>VkBufferCaptureDescriptorDataInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkBufferCaptureDescriptorDataInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           buffer;
    ///         } VkBufferCaptureDescriptorDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferCaptureDescriptorDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferCaptureDescriptorDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is the <c>VkBuffer</c> handle of the buffer to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;
    }
}
