namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTileMemoryRequirementsQCOM.html">VkTileMemoryRequirementsQCOM</see> - Structure specifying tile memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine the tile memory allocation requirements of a buffer or image
    ///         resource, add a <c>VkTileMemoryRequirementsQCOM</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkMemoryRequirements2</c> structure passed as the
    ///         <c>pMemoryRequirements</c> parameter of <c>vkGetBufferMemoryRequirements2</c>
    ///         or <c>vkGetImageMemoryRequirements2</c>, respectively.
    ///         The <c>VkTileMemoryRequirementsQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_memory_heap
    ///         typedef struct VkTileMemoryRequirementsQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       size;
    ///             VkDeviceSize       alignment;
    ///         } VkTileMemoryRequirementsQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkTileMemoryRequirementsQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TileMemoryRequirementsQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Size</c> is the size, in bytes, of the tile memory allocation required for the resource.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Alignment</c> is the alignment, in bytes, of the offset within the tile memory allocation required for the resource.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Alignment;
    }
}
