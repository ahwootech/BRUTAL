namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentLocationInfo.html">VkRenderingAttachmentLocationInfo</see> - Structure specifying attachment locations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingAttachmentLocationInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkRenderingAttachmentLocationInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           colorAttachmentCount;
    ///             const uint32_t*    pColorAttachmentLocations;
    ///         } VkRenderingAttachmentLocationInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderingAttachmentLocationInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingAttachmentLocationInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of elements in <c>pColorAttachmentLocations</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentLocations</c> is a pointer to an array of <c>colorAttachmentCount</c> <c>uint32_t</c> values defining remapped locations for color attachments.
        /// </summary>
        [FieldOffset(24)]
        public int* ColorAttachmentLocations;
    }
}
