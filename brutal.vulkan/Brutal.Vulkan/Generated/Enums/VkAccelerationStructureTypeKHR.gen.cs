namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureTypeKHR.html">VkAccelerationStructureTypeKHR</see> - Type of acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureTypeKHR
    ///     </para>
    ///     <para>
    ///         Values which <i>can</i> be set in
    ///         specifying the type of acceleration structure, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkAccelerationStructureTypeKHR {
    ///             VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR = 0,
    ///             VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR = 1,
    ///             VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR = 2,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_ACCELERATION_STRUCTURE_TYPE_OPACITY_MICROMAP_KHR = 1000623000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV = VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR,
    ///         } VkAccelerationStructureTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureTypeKHR : int
    {
        /// <summary>
        ///     <c>TopLevelKHR</c> is a top-level acceleration structure containing instance data referring to bottom-level acceleration structures.
        /// </summary>
        TopLevelKHR = 0,

        /// <summary>
        ///     <c>BottomLevelKHR</c> is a bottom-level acceleration structure containing the AABBs or geometry to be intersected.
        /// </summary>
        BottomLevelKHR = 1,

        /// <summary>
        ///     <c>GenericKHR</c> is an acceleration structure whose type is determined at build time used for special circumstances. In these cases, the acceleration structure type is not known at creation time, but <i>must</i> be specified at build time as top, or bottom.
        /// </summary>
        GenericKHR = 2,

        /// <summary>
        ///     <c>OpacityMicromapKHR</c>
        /// </summary>
        OpacityMicromapKHR = 1000623000,

        /// <summary>
        ///     <c>TopLevelNV</c>
        /// </summary>
        TopLevelNV = TopLevelKHR,

        /// <summary>
        ///     <c>BottomLevelNV</c>
        /// </summary>
        BottomLevelNV = BottomLevelKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
