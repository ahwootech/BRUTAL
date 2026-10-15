namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExtensionProperties.html">VkExtensionProperties</see> - Structure specifying an extension properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExtensionProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkExtensionProperties {
    ///             char        extensionName[VK_MAX_EXTENSION_NAME_SIZE];
    ///             uint32_t    specVersion;
    ///         } VkExtensionProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 260)]
    public unsafe partial struct VkExtensionProperties()
    {
        ///
        [FieldOffset(0)]
        public fixed byte ExtensionName[256];

        /// <summary>
        ///     <c>SpecVersion</c> is the version of this extension. It is an integer, incremented with backward compatible changes.
        /// </summary>
        [FieldOffset(256)]
        public int SpecVersion;
    }
}
