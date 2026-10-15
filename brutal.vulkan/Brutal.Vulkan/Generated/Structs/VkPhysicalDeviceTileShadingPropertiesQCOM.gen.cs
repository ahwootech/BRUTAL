namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTileShadingPropertiesQCOM.html">VkPhysicalDeviceTileShadingPropertiesQCOM</see> - Structure describing properties supported by VK_QCOM_tile_shading
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTileShadingPropertiesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef struct VkPhysicalDeviceTileShadingPropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxApronSize;
    ///             VkBool32           preferNonCoherent;
    ///             VkExtent2D         tileGranularity;
    ///             VkExtent2D         maxTileShadingRate;
    ///         } VkPhysicalDeviceTileShadingPropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceTileShadingPropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTileShadingPropertiesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxApronSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxApronSize;

        /// <summary>
        ///     <c>PreferNonCoherent</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PreferNonCoherent;

        /// <summary>
        ///     <c>TileGranularity</c>
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D TileGranularity;

        /// <summary>
        ///     <c>MaxTileShadingRate</c>
        /// </summary>
        [FieldOffset(32)]
        public VkExtent2D MaxTileShadingRate;
    }
}
