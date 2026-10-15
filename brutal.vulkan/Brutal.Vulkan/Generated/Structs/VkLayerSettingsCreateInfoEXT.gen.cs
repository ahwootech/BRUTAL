namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLayerSettingsCreateInfoEXT.html">VkLayerSettingsCreateInfoEXT</see> - Specify layer capabilities for a Vulkan instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To create a Vulkan instance with a specific configuration of layer settings,
    ///         add <c>VkLayerSettingsCreateInfoEXT</c> structures to the <c>pNext</c> chain
    ///         of the <c>VkInstanceCreateInfo</c> structure, specifying the settings to be
    ///         configured.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_layer_settings
    ///         typedef struct VkLayerSettingsCreateInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             uint32_t                    settingCount;
    ///             const VkLayerSettingEXT*    pSettings;
    ///         } VkLayerSettingsCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkLayerSettingsCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LayerSettingsCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SettingCount</c> is the number of settings to configure.
        /// </summary>
        [FieldOffset(16)]
        public int SettingCount;

        /// <summary>
        ///     <c>Settings</c> is a pointer to an array of <c>settingCount</c> <c>VkLayerSettingEXT</c> values specifying the settings to be configured.
        /// </summary>
        [FieldOffset(24)]
        public VkLayerSettingEXT* Settings;
    }
}
