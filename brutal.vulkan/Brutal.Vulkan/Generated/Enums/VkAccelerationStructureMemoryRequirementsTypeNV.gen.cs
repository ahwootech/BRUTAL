namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMemoryRequirementsTypeNV.html">VkAccelerationStructureMemoryRequirementsTypeNV</see> - Acceleration structure memory requirement type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMemoryRequirementsTypeNV
    ///     </para>
    ///     <para>
    ///         Possible values of <c>type</c> in
    ///         <c>VkAccelerationStructureMemoryRequirementsInfoNV</c> are:,
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef enum VkAccelerationStructureMemoryRequirementsTypeNV {
    ///             VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
    ///             VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
    ///             VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
    ///         } VkAccelerationStructureMemoryRequirementsTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureMemoryRequirementsTypeNV : int
    {
        /// <summary>
        ///     <c>ObjectNV</c>  requests the memory requirement for the <c>VkAccelerationStructureNV</c> backing store.
        /// </summary>
        ObjectNV = 0,

        /// <summary>
        ///     <c>BuildScratchNV</c>  requests the memory requirement for scratch space during the initial build.
        /// </summary>
        BuildScratchNV = 1,

        /// <summary>
        ///     <c>UpdateScratchNV</c>  requests the memory requirement for scratch space during an update.
        /// </summary>
        UpdateScratchNV = 2,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
