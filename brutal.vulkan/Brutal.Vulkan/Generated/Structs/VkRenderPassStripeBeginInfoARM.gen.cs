namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeBeginInfoARM.html">VkRenderPassStripeBeginInfoARM</see> - Structure specifying striped rendering information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassStripeBeginInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_render_pass_striped
    ///         typedef struct VkRenderPassStripeBeginInfoARM {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             uint32_t                            stripeInfoCount;
    ///             const VkRenderPassStripeInfoARM*    pStripeInfos;
    ///         } VkRenderPassStripeBeginInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassStripeBeginInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassStripeBeginInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StripeInfoCount</c> is the number of stripes in this render pass instance
        /// </summary>
        [FieldOffset(16)]
        public int StripeInfoCount;

        /// <summary>
        ///     <c>StripeInfos</c> is a pointer to an array of <c>stripeInfoCount</c> <c>VkRenderPassStripeInfoARM</c> structures describing the stripes used by the render pass instance.
        /// </summary>
        [FieldOffset(24)]
        public VkRenderPassStripeInfoARM* StripeInfos;
    }
}
