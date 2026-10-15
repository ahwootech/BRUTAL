namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentFlagsInfoKHR.html">VkRenderingAttachmentFlagsInfoKHR</see> - Structure specifying flags extending a rendering attachment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To specify an attachment as an <i>input attachment</i> or to specify resolve
    ///         operation flags, the <c>VkRenderingAttachmentFlagsInfoKHR</c> structure <i>can</i>
    ///         be added to the <c>pNext</c> chain of <c>VkRenderingAttachmentInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderingAttachmentFlagsInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef struct VkRenderingAttachmentFlagsInfoKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkRenderingAttachmentFlagsKHR    flags;
    ///         } VkRenderingAttachmentFlagsInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkRenderingAttachmentFlagsInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingAttachmentFlagsInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkRenderingAttachmentFlagsKHR</c>
        /// </summary>
        [FieldOffset(16)]
        public VkRenderingAttachmentFlagsKHR Flags;
    }
}
