namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTextureLODGatherFormatPropertiesAMD.html">VkTextureLODGatherFormatPropertiesAMD</see> - Structure informing whether or not texture gather bias/LOD functionality is supported for a given image format and a given physical device.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine if texture gather functions that take explicit LOD and/or bias
    ///         argument values <i>can</i> be used with a given image format, add a
    ///         <c>VkTextureLODGatherFormatPropertiesAMD</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkImageFormatProperties2</c> structure in a call to
    ///         <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkTextureLODGatherFormatPropertiesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_texture_gather_bias_lod
    ///         typedef struct VkTextureLODGatherFormatPropertiesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           supportsTextureGatherLODBiasAMD;
    ///         } VkTextureLODGatherFormatPropertiesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTextureLodGatherFormatPropertiesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TextureLodGatherFormatPropertiesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportsTextureGatherLODBiasAMD</c> tells if the image format can be used with texture gather bias/LOD functions, as introduced by the `<c>VK_AMD_texture_gather_bias_lod</c>` extension. This field is set by the implementation. An application-specified value is ignored.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SupportsTextureGatherLODBiasAMD;
    }
}
