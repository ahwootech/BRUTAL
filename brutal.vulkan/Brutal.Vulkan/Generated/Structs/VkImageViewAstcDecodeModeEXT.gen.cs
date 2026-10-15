namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewASTCDecodeModeEXT.html">VkImageViewASTCDecodeModeEXT</see> - Structure describing the ASTC decode mode for an image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a <c>VkImageViewASTCDecodeModeEXT</c>
    ///         structure, then that structure includes a parameter specifying the decode
    ///         mode for image views using ASTC compressed formats.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageViewASTCDecodeModeEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_astc_decode_mode
    ///         typedef struct VkImageViewASTCDecodeModeEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkFormat           decodeMode;
    ///         } VkImageViewASTCDecodeModeEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageViewAstcDecodeModeEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewAstcDecodeModeEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DecodeMode</c> is the intermediate format used to decode ASTC compressed formats.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat DecodeMode;
    }
}
