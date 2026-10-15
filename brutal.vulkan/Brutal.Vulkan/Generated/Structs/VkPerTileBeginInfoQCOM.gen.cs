namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerTileBeginInfoQCOM.html">VkPerTileBeginInfoQCOM</see> - Structure specifying per-tile begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerTileBeginInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef struct VkPerTileBeginInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///         } VkPerTileBeginInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkPerTileBeginInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerTileBeginInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
