namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderTileImagePropertiesEXT.html">VkPhysicalDeviceShaderTileImagePropertiesEXT</see> - Structure containing information about tile image support for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderTileImagePropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_tile_image
    ///         typedef struct VkPhysicalDeviceShaderTileImagePropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderTileImageCoherentReadAccelerated;
    ///             VkBool32           shaderTileImageReadSampleFromPixelRateInvocation;
    ///             VkBool32           shaderTileImageReadFromHelperInvocation;
    ///         } VkPhysicalDeviceShaderTileImagePropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderTileImagePropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderTileImagePropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderTileImageCoherentReadAccelerated</c> is a boolean that will be <c>VK_TRUE</c> if coherent reads of tile image data is accelerated.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderTileImageCoherentReadAccelerated;

        /// <summary>
        ///     <c>ShaderTileImageReadSampleFromPixelRateInvocation</c> is a boolean that will be <c>VK_TRUE</c> if reading from samples from a pixel rate fragment invocation is supported when <c>VkPipelineMultisampleStateCreateInfo::rasterizationSamples</c> &gt; 1.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderTileImageReadSampleFromPixelRateInvocation;

        /// <summary>
        ///     <c>ShaderTileImageReadFromHelperInvocation</c> is a boolean that will be <c>VK_TRUE</c> if reads of tile image data from helper fragment invocations result in valid values.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderTileImageReadFromHelperInvocation;
    }
}
