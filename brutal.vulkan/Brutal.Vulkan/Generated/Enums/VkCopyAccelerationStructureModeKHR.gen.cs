namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyAccelerationStructureModeKHR.html">VkCopyAccelerationStructureModeKHR</see> - Acceleration structure copy mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyAccelerationStructureModeKHR
    ///     </para>
    ///     <para>
    ///         Possible values of <c>mode</c> specifying additional operations to perform
    ///         during the copy, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkCopyAccelerationStructureModeKHR {
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = 0,
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = 1,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = 2,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = 3,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR,
    ///         } VkCopyAccelerationStructureModeKHR;
    ///     </code>
    /// </remarks>
    public enum VkCopyAccelerationStructureModeKHR : int
    {
        /// <summary>
        ///     <c>CloneKHR</c> creates a direct copy of the acceleration structure specified in <c>src</c> into the one specified by <c>dst</c>. The <c>dst</c> acceleration structure <i>must</i> have been created with the same parameters as <c>src</c> . If <c>src</c> contains references to other acceleration structures, <c>dst</c> will reference the same acceleration structures.
        /// </summary>
        CloneKHR = 0,

        /// <summary>
        ///     <c>CompactKHR</c> creates a more compact version of an acceleration structure <c>src</c> into <c>dst</c>. The acceleration structure <c>dst</c> <i>must</i> have been created with a size at least as large as that returned by after the build of the acceleration structure specified by <c>src</c>. If <c>src</c> contains references to other acceleration structures, <c>dst</c> will reference the same acceleration structures.
        /// </summary>
        CompactKHR = 1,

        /// <summary>
        ///     <c>SerializeKHR</c>
        /// </summary>
        SerializeKHR = 2,

        /// <summary>
        ///     <c>DeserializeKHR</c>
        /// </summary>
        DeserializeKHR = 3,

        /// <summary>
        ///     <c>CloneNV</c>
        /// </summary>
        CloneNV = CloneKHR,

        /// <summary>
        ///     <c>CompactNV</c>
        /// </summary>
        CompactNV = CompactKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
