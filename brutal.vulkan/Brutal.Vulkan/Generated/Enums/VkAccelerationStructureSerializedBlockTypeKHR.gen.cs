namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureSerializedBlockTypeKHR.html">VkAccelerationStructureSerializedBlockTypeKHR</see> - Enum for block types in a serialized acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureSerializedBlockTypeKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureSerializedBlockTypeKHR</c> enumeration is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef enum VkAccelerationStructureSerializedBlockTypeKHR {
    ///             VK_ACCELERATION_STRUCTURE_SERIALIZED_BLOCK_TYPE_OPACITY_MICROMAP_KHR = 0,
    ///         } VkAccelerationStructureSerializedBlockTypeKHR;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureSerializedBlockTypeKHR : int
    {
        /// <summary>
        ///     <c>OpacityMicromapKHR</c>  specifies that the block contains opacity micromaps.
        /// </summary>
        OpacityMicromapKHR = 0,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
