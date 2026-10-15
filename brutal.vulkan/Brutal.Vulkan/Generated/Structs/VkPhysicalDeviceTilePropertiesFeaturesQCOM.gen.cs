namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTilePropertiesFeaturesQCOM.html">VkPhysicalDeviceTilePropertiesFeaturesQCOM</see> - Structure describing tile properties features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTilePropertiesFeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_properties
    ///         typedef struct VkPhysicalDeviceTilePropertiesFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           tileProperties;
    ///         } VkPhysicalDeviceTilePropertiesFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTilePropertiesFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTilePropertiesFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TileProperties</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TileProperties;
    }
}
