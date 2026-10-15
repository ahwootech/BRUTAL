namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTilePropertiesQCOM.html">VkTilePropertiesQCOM</see> - Structure holding available tile properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTilePropertiesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_properties
    ///         typedef struct VkTilePropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent3D         tileSize;
    ///             VkExtent2D         apronSize;
    ///             VkOffset2D         origin;
    ///         } VkTilePropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkTilePropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TilePropertiesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TileSize</c> is the dimensions of a tile, with width and height describing the width and height of a tile in pixels, and depth corresponding to the number of slices the tile spans.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent3D TileSize;

        /// <summary>
        ///     <c>ApronSize</c> is the dimension of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-tile-shading-aprons">apron^</see>.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D ApronSize;

        /// <summary>
        ///     <c>Origin</c> is the top-left corner of the first tile in attachment space.
        /// </summary>
        [FieldOffset(36)]
        public VkOffset2D Origin;
    }
}
