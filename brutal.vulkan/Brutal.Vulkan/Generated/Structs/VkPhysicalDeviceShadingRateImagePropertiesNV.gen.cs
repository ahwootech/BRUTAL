namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShadingRateImagePropertiesNV.html">VkPhysicalDeviceShadingRateImagePropertiesNV</see> - Structure describing shading rate image limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShadingRateImagePropertiesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkPhysicalDeviceShadingRateImagePropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         shadingRateTexelSize;
    ///             uint32_t           shadingRatePaletteSize;
    ///             uint32_t           shadingRateMaxCoarseSamples;
    ///         } VkPhysicalDeviceShadingRateImagePropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShadingRateTexelSize</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D ShadingRateTexelSize;

        /// <summary>
        ///     <c>ShadingRatePaletteSize</c>
        /// </summary>
        [FieldOffset(24)]
        public int ShadingRatePaletteSize;

        /// <summary>
        ///     <c>ShadingRateMaxCoarseSamples</c>
        /// </summary>
        [FieldOffset(28)]
        public int ShadingRateMaxCoarseSamples;
    }
}
