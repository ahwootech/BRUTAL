namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeInfoARM.html">VkRenderPassStripeInfoARM</see> - Structure specifying per rendering stripe information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassStripeInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_render_pass_striped
    ///         typedef struct VkRenderPassStripeInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkRect2D           stripeArea;
    ///         } VkRenderPassStripeInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassStripeInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassStripeInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StripeArea</c> is the stripe area, and is described in more detail below.
        /// </summary>
        [FieldOffset(16)]
        public VkRect2D StripeArea;
    }
}
