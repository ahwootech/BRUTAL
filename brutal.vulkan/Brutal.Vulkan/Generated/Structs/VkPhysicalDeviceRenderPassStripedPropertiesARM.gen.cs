namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRenderPassStripedPropertiesARM.html">VkPhysicalDeviceRenderPassStripedPropertiesARM</see> - Structure describing striped rendering limits of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRenderPassStripedPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_render_pass_striped
    ///         typedef struct VkPhysicalDeviceRenderPassStripedPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         renderPassStripeGranularity;
    ///             uint32_t           maxRenderPassStripes;
    ///         } VkPhysicalDeviceRenderPassStripedPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceRenderPassStripedPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRenderPassStripedPropertiesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPassStripeGranularity</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D RenderPassStripeGranularity;

        /// <summary>
        ///     <c>MaxRenderPassStripes</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxRenderPassStripes;
    }
}
