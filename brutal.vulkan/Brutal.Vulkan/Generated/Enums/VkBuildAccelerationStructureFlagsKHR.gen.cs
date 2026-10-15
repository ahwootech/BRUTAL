namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildAccelerationStructureFlagBitsKHR.html">VkBuildAccelerationStructureFlagBitsKHR</see> - Bitmask specifying additional parameters for acceleration structure builds
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildAccelerationStructureFlagBitsKHR
    ///     </para>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         specifying additional parameters for acceleration structure builds, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkBuildAccelerationStructureFlagBitsKHR {
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR = 0x00000001,
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR = 0x00000002,
    ///             VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR = 0x00000004,
    ///             VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR = 0x00000008,
    ///             VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR = 0x00000010,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV = 0x00000020,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_BIT_EXT = 0x00000100,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_BIT_NV = 0x00000200,
    ///             #endif
    ///             // Provided by VK_KHR_ray_tracing_position_fetch
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_BIT_KHR = 0x00000800,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_CLUSTER_OPACITY_MICROMAPS_BIT_NV = 0x00001000,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_KHR = 0x00000040,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_KHR = 0x00000080,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_MICROMAP_LOSSY_BIT_KHR = 0x00000400,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV = VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_EXT = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             // VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT is a legacy alias
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_EXT,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_EXT = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             // VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT is a legacy alias
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_EXT,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             // VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT is a legacy alias
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_BIT_EXT,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             // VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV is a legacy alias
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_BIT_NV,
    ///             #endif
    ///             // Provided by VK_KHR_ray_tracing_position_fetch
    ///             // VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR is a legacy alias
    ///             VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR = VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_BIT_KHR,
    ///         } VkBuildAccelerationStructureFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkBuildAccelerationStructureFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AllowUpdateBitKHR</c> specifies that the specified acceleration structure <i>can</i> be updated with .
        /// </summary>
        AllowUpdateBitKHR = 0x00000001,

        /// <summary>
        ///     <c>AllowCompactionBitKHR</c> specifies that the specified acceleration structure <i>can</i> act as the source for a copy acceleration structure command with <c>mode</c> of <c>VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR</c> to produce a compacted acceleration structure.
        /// </summary>
        AllowCompactionBitKHR = 0x00000002,

        /// <summary>
        ///     <c>PreferFastTraceBitKHR</c>  specifies that the given acceleration structure build <i>should</i> prioritize trace performance over build time.
        /// </summary>
        PreferFastTraceBitKHR = 0x00000004,

        /// <summary>
        ///     <c>PreferFastBuildBitKHR</c>  specifies that the given acceleration structure build <i>should</i> prioritize build time over trace performance.
        /// </summary>
        PreferFastBuildBitKHR = 0x00000008,

        /// <summary>
        ///     <c>LowMemoryBitKHR</c> specifies that this acceleration structure <i>should</i> minimize the size of the scratch memory and the final result acceleration structure, potentially at the expense of build time or trace performance.  [NOTE]
        /// </summary>
        LowMemoryBitKHR = 0x00000010,

        /// <summary>
        ///     <c>MotionBitNV</c>
        /// </summary>
        MotionBitNV = 0x00000020,

        /// <summary>
        ///     <c>AllowOpacityMicromapDataUpdateBitEXT</c>
        /// </summary>
        AllowOpacityMicromapDataUpdateBitEXT = 0x00000100,

        /// <summary>
        ///     <c>AllowDisplacementMicromapUpdateBitNV</c>
        /// </summary>
        AllowDisplacementMicromapUpdateBitNV = 0x00000200,

        /// <summary>
        ///     <c>AllowDataAccessBitKHR</c>
        /// </summary>
        AllowDataAccessBitKHR = 0x00000800,

        /// <summary>
        ///     <c>AllowClusterOpacityMicromapsBitNV</c>
        /// </summary>
        AllowClusterOpacityMicromapsBitNV = 0x00001000,

        /// <summary>
        ///     <c>AllowOpacityMicromapUpdateBitKHR</c>
        /// </summary>
        AllowOpacityMicromapUpdateBitKHR = 0x00000040,

        /// <summary>
        ///     <c>AllowDisableOpacityMicromapsBitKHR</c>
        /// </summary>
        AllowDisableOpacityMicromapsBitKHR = 0x00000080,

        /// <summary>
        ///     <c>MicromapLossyBitKHR</c>
        /// </summary>
        MicromapLossyBitKHR = 0x00000400,

        /// <summary>
        ///     <c>AllowUpdateBitNV</c>
        /// </summary>
        AllowUpdateBitNV = AllowUpdateBitKHR,

        /// <summary>
        ///     <c>AllowCompactionBitNV</c>
        /// </summary>
        AllowCompactionBitNV = AllowCompactionBitKHR,

        /// <summary>
        ///     <c>PreferFastTraceBitNV</c>
        /// </summary>
        PreferFastTraceBitNV = PreferFastTraceBitKHR,

        /// <summary>
        ///     <c>PreferFastBuildBitNV</c>
        /// </summary>
        PreferFastBuildBitNV = PreferFastBuildBitKHR,

        /// <summary>
        ///     <c>LowMemoryBitNV</c>
        /// </summary>
        LowMemoryBitNV = LowMemoryBitKHR,

        /// <summary>
        ///     <c>AllowOpacityMicromapUpdateBitEXT</c>
        /// </summary>
        AllowOpacityMicromapUpdateBitEXT = AllowOpacityMicromapUpdateBitKHR,

        /// <summary>
        ///     <c>AllowOpacityMicromapUpdateEXT</c>
        /// </summary>
        AllowOpacityMicromapUpdateEXT = AllowOpacityMicromapUpdateBitEXT,

        /// <summary>
        ///     <c>AllowDisableOpacityMicromapsBitEXT</c>
        /// </summary>
        AllowDisableOpacityMicromapsBitEXT = AllowDisableOpacityMicromapsBitKHR,

        /// <summary>
        ///     <c>AllowDisableOpacityMicromapsEXT</c>
        /// </summary>
        AllowDisableOpacityMicromapsEXT = AllowDisableOpacityMicromapsBitEXT,

        /// <summary>
        ///     <c>AllowOpacityMicromapDataUpdateEXT</c>
        /// </summary>
        AllowOpacityMicromapDataUpdateEXT = AllowOpacityMicromapDataUpdateBitEXT,

        /// <summary>
        ///     <c>AllowDisplacementMicromapUpdateNV</c>
        /// </summary>
        AllowDisplacementMicromapUpdateNV = AllowDisplacementMicromapUpdateBitNV,

        /// <summary>
        ///     <c>AllowDataAccessKHR</c>
        /// </summary>
        AllowDataAccessKHR = AllowDataAccessBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
