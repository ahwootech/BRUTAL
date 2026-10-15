namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTextureCompressionASTCHDRFeatures.html">VkPhysicalDeviceTextureCompressionASTCHDRFeatures</see> - Structure describing ASTC HDR features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTextureCompressionASTCHDRFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           textureCompressionASTC_HDR;
    ///         } VkPhysicalDeviceTextureCompressionASTCHDRFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTextureCompressionAstcHdrFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TextureCompressionASTCHdr</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TextureCompressionASTCHdr;
    }
}
