namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapSpecialIndexKHR.html">VkOpacityMicromapSpecialIndexKHR</see> - Enum for special indices in the opacity micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkOpacityMicromapSpecialIndexKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkOpacityMicromapSpecialIndexKHR</c> enumeration is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef enum VkOpacityMicromapSpecialIndexKHR {
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_KHR = -1,
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_KHR = -2,
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_KHR = -3,
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_KHR = -4,
    ///             // Provided by VK_EXT_opacity_micromap with VK_NV_cluster_acceleration_structure
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_CLUSTER_GEOMETRY_DISABLE_OPACITY_MICROMAP_NV = -5,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT = VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT = VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT = VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT = VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_KHR,
    ///         } VkOpacityMicromapSpecialIndexKHR;
    ///     </code>
    /// </remarks>
    public enum VkOpacityMicromapSpecialIndexKHR : int
    {
        /// <summary>
        ///     <c>FullyTransparentKHR</c> specifies that the entire triangle is fully transparent.
        /// </summary>
        FullyTransparentKHR = -1,

        /// <summary>
        ///     <c>FullyOpaqueKHR</c> specifies that the entire triangle is fully opaque.
        /// </summary>
        FullyOpaqueKHR = -2,

        /// <summary>
        ///     <c>FullyUnknownTransparentKHR</c>  specifies that the entire triangle is unknown-transparent.
        /// </summary>
        FullyUnknownTransparentKHR = -3,

        /// <summary>
        ///     <c>FullyUnknownOpaqueKHR</c>  specifies that the entire triangle is unknown-opaque.
        /// </summary>
        FullyUnknownOpaqueKHR = -4,

        /// <summary>
        ///     <c>ClusterGeometryDisableOpacityMicromapNV</c>
        /// </summary>
        ClusterGeometryDisableOpacityMicromapNV = -5,

        /// <summary>
        ///     <c>FullyTransparentEXT</c>
        /// </summary>
        FullyTransparentEXT = FullyTransparentKHR,

        /// <summary>
        ///     <c>FullyOpaqueEXT</c>
        /// </summary>
        FullyOpaqueEXT = FullyOpaqueKHR,

        /// <summary>
        ///     <c>FullyUnknownTransparentEXT</c>
        /// </summary>
        FullyUnknownTransparentEXT = FullyUnknownTransparentKHR,

        /// <summary>
        ///     <c>FullyUnknownOpaqueEXT</c>
        /// </summary>
        FullyUnknownOpaqueEXT = FullyUnknownOpaqueKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
