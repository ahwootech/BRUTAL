namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTileShadingFeaturesQCOM.html">VkPhysicalDeviceTileShadingFeaturesQCOM</see> - Structure describing tile shading features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTileShadingFeaturesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef struct VkPhysicalDeviceTileShadingFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           tileShading;
    ///             VkBool32           tileShadingFragmentStage;
    ///             VkBool32           tileShadingColorAttachments;
    ///             VkBool32           tileShadingDepthAttachments;
    ///             VkBool32           tileShadingStencilAttachments;
    ///             VkBool32           tileShadingInputAttachments;
    ///             VkBool32           tileShadingSampledAttachments;
    ///             VkBool32           tileShadingPerTileDraw;
    ///             VkBool32           tileShadingPerTileDispatch;
    ///             VkBool32           tileShadingDispatchTile;
    ///             VkBool32           tileShadingApron;
    ///             VkBool32           tileShadingAnisotropicApron;
    ///             VkBool32           tileShadingAtomicOps;
    ///             VkBool32           tileShadingImageProcessing;
    ///         } VkPhysicalDeviceTileShadingFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkPhysicalDeviceTileShadingFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTileShadingFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TileShading</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TileShading;

        /// <summary>
        ///     <c>TileShadingFragmentStage</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 TileShadingFragmentStage;

        /// <summary>
        ///     <c>TileShadingColorAttachments</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 TileShadingColorAttachments;

        /// <summary>
        ///     <c>TileShadingDepthAttachments</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 TileShadingDepthAttachments;

        /// <summary>
        ///     <c>TileShadingStencilAttachments</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 TileShadingStencilAttachments;

        /// <summary>
        ///     <c>TileShadingInputAttachments</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 TileShadingInputAttachments;

        /// <summary>
        ///     <c>TileShadingSampledAttachments</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 TileShadingSampledAttachments;

        /// <summary>
        ///     <c>TileShadingPerTileDraw</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 TileShadingPerTileDraw;

        /// <summary>
        ///     <c>TileShadingPerTileDispatch</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 TileShadingPerTileDispatch;

        /// <summary>
        ///     <c>TileShadingDispatchTile</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 TileShadingDispatchTile;

        /// <summary>
        ///     <c>TileShadingApron</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 TileShadingApron;

        /// <summary>
        ///     <c>TileShadingAnisotropicApron</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 TileShadingAnisotropicApron;

        /// <summary>
        ///     <c>TileShadingAtomicOps</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 TileShadingAtomicOps;

        /// <summary>
        ///     <c>TileShadingImageProcessing</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 TileShadingImageProcessing;
    }
}
