namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessingFeaturesQCOM.html">VkPhysicalDeviceImageProcessingFeaturesQCOM</see> - Structure describing image processing features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageProcessingFeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing
    ///         typedef struct VkPhysicalDeviceImageProcessingFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           textureSampleWeighted;
    ///             VkBool32           textureBoxFilter;
    ///             VkBool32           textureBlockMatch;
    ///         } VkPhysicalDeviceImageProcessingFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceImageProcessingFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageProcessingFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TextureSampleWeighted</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TextureSampleWeighted;

        /// <summary>
        ///     <c>TextureBoxFilter</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 TextureBoxFilter;

        /// <summary>
        ///     <c>TextureBlockMatch</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 TextureBlockMatch;
    }
}
