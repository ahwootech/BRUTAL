namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSamplerYcbcrConversionFeatures.html">VkPhysicalDeviceSamplerYcbcrConversionFeatures</see> - Structure describing {YCbCr} conversion features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSamplerYcbcrConversionFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceSamplerYcbcrConversionFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           samplerYcbcrConversion;
    ///         } VkPhysicalDeviceSamplerYcbcrConversionFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSamplerYCbCrConversionFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSamplerYCbCrConversionFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SamplerYcbcrConversion</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SamplerYcbcrConversion;
    }
}
