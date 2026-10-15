namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLayerProperties.html">VkLayerProperties</see> - Structure specifying layer properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLayerProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkLayerProperties {
    ///             char        layerName[VK_MAX_EXTENSION_NAME_SIZE];
    ///             uint32_t    specVersion;
    ///             uint32_t    implementationVersion;
    ///             char        description[VK_MAX_DESCRIPTION_SIZE];
    ///         } VkLayerProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 520)]
    public unsafe partial struct VkLayerProperties()
    {
        ///
        [FieldOffset(0)]
        public fixed byte LayerName[256];

        /// <summary>
        ///     <c>SpecVersion</c> is the Vulkan version the layer was written to, encoded as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-coreversions-versionnumbers">here</see>.
        /// </summary>
        [FieldOffset(256)]
        public int SpecVersion;

        /// <summary>
        ///     <c>ImplementationVersion</c> is the version of this layer. It is an integer, increasing with backward compatible changes.
        /// </summary>
        [FieldOffset(260)]
        public int ImplementationVersion;

        ///
        [FieldOffset(264)]
        public fixed byte Description[256];
    }
}
