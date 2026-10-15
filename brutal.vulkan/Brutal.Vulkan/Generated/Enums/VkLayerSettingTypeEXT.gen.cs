namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLayerSettingTypeEXT.html">VkLayerSettingTypeEXT</see> - Type of the values that can be passed to a layer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkLayerSettingEXT::type</c>, specifying the type
    ///         of the data returned in <c>VkLayerSettingEXT::pValues</c>, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_layer_settings
    ///         typedef enum VkLayerSettingTypeEXT {
    ///             VK_LAYER_SETTING_TYPE_BOOL32_EXT = 0,
    ///             VK_LAYER_SETTING_TYPE_INT32_EXT = 1,
    ///             VK_LAYER_SETTING_TYPE_INT64_EXT = 2,
    ///             VK_LAYER_SETTING_TYPE_UINT32_EXT = 3,
    ///             VK_LAYER_SETTING_TYPE_UINT64_EXT = 4,
    ///             VK_LAYER_SETTING_TYPE_FLOAT32_EXT = 5,
    ///             VK_LAYER_SETTING_TYPE_FLOAT64_EXT = 6,
    ///             VK_LAYER_SETTING_TYPE_STRING_EXT = 7,
    ///         } VkLayerSettingTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkLayerSettingTypeEXT : int
    {
        /// <summary>
        ///     <c>Bool32EXT</c> specifies that the layer setting&apos;s type is basetype:VkBool32.
        /// </summary>
        Bool32EXT = 0,

        /// <summary>
        ///     <c>Int32EXT</c> specifies that the layer setting&apos;s type is signed 32-bit integer.
        /// </summary>
        Int32EXT = 1,

        /// <summary>
        ///     <c>Int64EXT</c> specifies that the layer setting&apos;s type is signed 64-bit integer.
        /// </summary>
        Int64EXT = 2,

        /// <summary>
        ///     <c>UInt32EXT</c> specifies that the layer setting&apos;s type is unsigned 32-bit integer.
        /// </summary>
        UInt32EXT = 3,

        /// <summary>
        ///     <c>UInt64EXT</c> specifies that the layer setting&apos;s type is unsigned 64-bit integer.
        /// </summary>
        UInt64EXT = 4,

        /// <summary>
        ///     <c>Float32EXT</c> specifies that the layer setting&apos;s type is 32-bit floating-point.
        /// </summary>
        Float32EXT = 5,

        /// <summary>
        ///     <c>Float64EXT</c> specifies that the layer setting&apos;s type is 64-bit floating-point.
        /// </summary>
        Float64EXT = 6,

        /// <summary>
        ///     <c>StringEXT</c> specifies that the layer setting&apos;s type is a pointer to a null-terminated UTF-8 string.
        /// </summary>
        StringEXT = 7,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
