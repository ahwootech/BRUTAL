namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShadingRateImageFeaturesNV.html">VkPhysicalDeviceShadingRateImageFeaturesNV</see> - Structure describing shading rate image features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShadingRateImageFeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkPhysicalDeviceShadingRateImageFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shadingRateImage;
    ///             VkBool32           shadingRateCoarseSampleOrder;
    ///         } VkPhysicalDeviceShadingRateImageFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShadingRateImage</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShadingRateImage;

        /// <summary>
        ///     <c>ShadingRateCoarseSampleOrder</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShadingRateCoarseSampleOrder;
    }
}
