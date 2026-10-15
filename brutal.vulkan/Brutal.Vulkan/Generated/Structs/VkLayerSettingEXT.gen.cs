namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLayerSettingEXT.html">VkLayerSettingEXT</see> - Specify a layer capability to configure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The values of elements of the
    ///         <c>VkLayerSettingsCreateInfoEXT::pSettings</c> array, specifying layer
    ///         settings to be configured, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_layer_settings
    ///         typedef struct VkLayerSettingEXT {
    ///             const char*              pLayerName;
    ///             const char*              pSettingName;
    ///             VkLayerSettingTypeEXT    type;
    ///             uint32_t                 valueCount;
    ///             const void*              pValues;
    ///         } VkLayerSettingEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkLayerSettingEXT()
    {
        /// <summary>
        ///     <c>LayerName</c> is a pointer to a null-terminated UTF-8 string naming the layer to configure the setting from.
        /// </summary>
        [FieldOffset(0)]
        public byte* LayerName;

        /// <summary>
        ///     <c>SettingName</c> is a pointer to a null-terminated UTF-8 string naming the setting to configure. Values of <c>pSettingName</c> that are unknown to the layer are ignored.
        /// </summary>
        [FieldOffset(8)]
        public byte* SettingName;

        /// <summary>
        ///     <c>Type</c> is a <c>VkLayerSettingTypeEXT</c> value specifying the type of the <c>pValues</c> values.
        /// </summary>
        [FieldOffset(16)]
        public VkLayerSettingTypeEXT Type;

        /// <summary>
        ///     <c>ValueCount</c> is the number of values used to configure the layer setting.
        /// </summary>
        [FieldOffset(20)]
        public int ValueCount;

        /// <summary>
        ///     <c>Values</c> is a pointer to an array of <c>valueCount</c> values of the type indicated by <c>type</c> to configure the layer setting.
        /// </summary>
        [FieldOffset(24)]
        public void* Values;
    }
}
