namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassStripeSubmitInfoARM.html">VkRenderPassStripeSubmitInfoARM</see> - Structure specifying striped rendering submit information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassStripeSubmitInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_render_pass_striped
    ///         typedef struct VkRenderPassStripeSubmitInfoARM {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             uint32_t                        stripeSemaphoreInfoCount;
    ///             const VkSemaphoreSubmitInfo*    pStripeSemaphoreInfos;
    ///         } VkRenderPassStripeSubmitInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassStripeSubmitInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassStripeSubmitInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StripeSemaphoreInfoCount</c> is the number of semaphores used to signal stripe completion in the render pass instances in the submitted command buffer.
        /// </summary>
        [FieldOffset(16)]
        public int StripeSemaphoreInfoCount;

        /// <summary>
        ///     <c>StripeSemaphoreInfos</c> is a pointer to an array of <c>stripeSemaphoreInfoCount</c> <c>VkSemaphoreSubmitInfo</c> structures describing the semaphores used to signal stripe completion.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphoreSubmitInfo* StripeSemaphoreInfos;
    }
}
