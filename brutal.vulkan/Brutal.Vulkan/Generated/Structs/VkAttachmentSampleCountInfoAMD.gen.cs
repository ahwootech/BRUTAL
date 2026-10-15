namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentSampleCountInfoAMD.html">VkAttachmentSampleCountInfoAMD</see> - Structure specifying command buffer inheritance info for dynamic render pass instances
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The
    ///         structure is defined as:
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkAttachmentSampleCountInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentSampleCountInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of color attachments specified in a render pass instance.
        /// </summary>
        [FieldOffset(16)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentSamples</c> is a pointer to an array of <c>VkSampleCountFlags</c> values defining the sample count of color attachments.
        /// </summary>
        [FieldOffset(24)]
        public VkSampleCountFlags* ColorAttachmentSamples;

        /// <summary>
        ///     <c>DepthStencilAttachmentSamples</c> is a <c>VkSampleCountFlags</c> value defining the sample count of a depth/stencil attachment.
        /// </summary>
        [FieldOffset(32)]
        public VkSampleCountFlags DepthStencilAttachmentSamples;
    }
}
