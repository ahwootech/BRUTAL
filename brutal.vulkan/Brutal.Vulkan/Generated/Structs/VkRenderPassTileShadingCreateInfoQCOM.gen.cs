namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassTileShadingCreateInfoQCOM.html">VkRenderPassTileShadingCreateInfoQCOM</see> - Structure specifying, tile shading information for a render pass object.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To enable tile shading for a render pass object, add a
    ///         <c>VkRenderPassTileShadingCreateInfoQCOM</c> to the <c>pNext</c> chain of
    ///         <c>VkRenderPassCreateInfo</c>
    ///         .
    ///         To execute a secondary command buffer within a render pass, add a
    ///         <c>VkRenderPassTileShadingCreateInfoQCOM</c> to the <c>pNext</c> chain of
    ///         <c>VkCommandBufferInheritanceInfo</c> when the secondary command buffer is
    ///         recorded.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassTileShadingCreateInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef struct VkRenderPassTileShadingCreateInfoQCOM {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkTileShadingRenderPassFlagsQCOM    flags;
    ///             VkExtent2D                          tileApronSize;
    ///         } VkRenderPassTileShadingCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassTileShadingCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassTileShadingCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkTileShadingRenderPassFlagsQCOM</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkTileShadingRenderPassFlagsQCOM Flags;

        /// <summary>
        ///     <c>TileApronSize</c> is a <c>VkExtent2D</c> describing the is size of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-tile-shading-aprons">tiling apron^</see> in each dimension.
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D TileApronSize;
    }
}
