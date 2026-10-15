namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHdrVividDynamicMetadataHUAWEI.html">VkHdrVividDynamicMetadataHUAWEI</see> - specify HDR Vivid dynamic metadata
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-hdrVivid"><c>hdrVivid</c>^</see> feature is enabled, HDR Vivid
    ///         dynamic metadata <i>can</i> be set to control the reproduction of content by
    ///         including the <c>VkHdrVividDynamicMetadataHUAWEI</c> in the <c>pNext</c> chain
    ///         of <c>VkHdrMetadataEXT</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkHdrVividDynamicMetadataHUAWEI</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_hdr_vivid
    ///         typedef struct VkHdrVividDynamicMetadataHUAWEI {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             size_t             dynamicMetadataSize;
    ///             const void*        pDynamicMetadata;
    ///         } VkHdrVividDynamicMetadataHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkHdrVividDynamicMetadataHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.HdrVividDynamicMetadataHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DynamicMetadataSize</c> is the size in bytes of the dynamic metadata.
        /// </summary>
        [FieldOffset(16)]
        public nuint DynamicMetadataSize;

        /// <summary>
        ///     <c>DynamicMetadata</c> is a pointer to the dynamic metadata.
        /// </summary>
        [FieldOffset(24)]
        public void* DynamicMetadata;
    }
}
