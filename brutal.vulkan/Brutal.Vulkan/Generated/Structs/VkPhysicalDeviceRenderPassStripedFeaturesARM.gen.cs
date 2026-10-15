namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRenderPassStripedFeaturesARM.html">VkPhysicalDeviceRenderPassStripedFeaturesARM</see> - Structure describing whether striped rendering can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRenderPassStripedFeaturesARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_render_pass_striped
    ///         typedef struct VkPhysicalDeviceRenderPassStripedFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           renderPassStriped;
    ///         } VkPhysicalDeviceRenderPassStripedFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRenderPassStripedFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRenderPassStripedFeaturesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPassStriped</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RenderPassStriped;
    }
}
