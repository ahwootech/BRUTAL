namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT.html">VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT</see> - Structure describing ASTC 3D features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_texture_compression_astc_3d
    ///         typedef struct VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           textureCompressionASTC_3D;
    ///         } VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTextureCompressionAstc3DFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTextureCompressionAstc3DFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TextureCompressionASTC_3D</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TextureCompressionASTC_3D;
    }
}
