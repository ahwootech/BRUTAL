namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubpassShadingFeaturesHUAWEI.html">VkPhysicalDeviceSubpassShadingFeaturesHUAWEI</see> - Structure describing whether subpass shading is enabled
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSubpassShadingFeaturesHUAWEI</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_subpass_shading
    ///         typedef struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           subpassShading;
    ///         } VkPhysicalDeviceSubpassShadingFeaturesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSubpassShadingFeaturesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubpassShading</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SubpassShading;
    }
}
