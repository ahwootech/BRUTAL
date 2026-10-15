namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTileMemorySizeInfoQCOM.html">VkTileMemorySizeInfoQCOM</see> - Structure describing tile memory size in use in a render pass instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The tile properties queried using <c>VK_QCOM_tile_properties</c> depend on
    ///         the size of the reserved tile memory by the application.
    ///         This size <i>can</i> be specified by the following structure to
    ///         <c>VkRenderPassCreateInfo</c>, <c>VkRenderPassCreateInfo2</c>
    ///         to specify the reserved tile memory size for the render pass object.
    ///     </para>
    ///     <para>
    ///         The <c>VkTileMemorySizeInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_memory_heap with VK_QCOM_tile_properties
    ///         typedef struct VkTileMemorySizeInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceSize       size;
    ///         } VkTileMemorySizeInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTileMemorySizeInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TileMemorySizeInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of tile memory used by the render pass or preserved for later use.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;
    }
}
