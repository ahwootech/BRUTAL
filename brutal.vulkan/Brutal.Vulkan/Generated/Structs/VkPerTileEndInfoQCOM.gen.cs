namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerTileEndInfoQCOM.html">VkPerTileEndInfoQCOM</see> - Structure specifying per-tile end information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerTileEndInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef struct VkPerTileEndInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///         } VkPerTileEndInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkPerTileEndInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerTileEndInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
