namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCornerSampledImageFeaturesNV.html">VkPhysicalDeviceCornerSampledImageFeaturesNV</see> - Structure describing corner sampled image features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCornerSampledImageFeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_corner_sampled_image
    ///         typedef struct VkPhysicalDeviceCornerSampledImageFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cornerSampledImage;
    ///         } VkPhysicalDeviceCornerSampledImageFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CornerSampledImage</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CornerSampledImage;
    }
}
