namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderTileImageFeaturesEXT.html">VkPhysicalDeviceShaderTileImageFeaturesEXT</see> - Structure describing tile image features supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderTileImageFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_tile_image
    ///         typedef struct VkPhysicalDeviceShaderTileImageFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderTileImageColorReadAccess;
    ///             VkBool32           shaderTileImageDepthReadAccess;
    ///             VkBool32           shaderTileImageStencilReadAccess;
    ///         } VkPhysicalDeviceShaderTileImageFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderTileImageFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderTileImageFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderTileImageColorReadAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderTileImageColorReadAccess;

        /// <summary>
        ///     <c>ShaderTileImageDepthReadAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderTileImageDepthReadAccess;

        /// <summary>
        ///     <c>ShaderTileImageStencilReadAccess</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderTileImageStencilReadAccess;
    }
}
