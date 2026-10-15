namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildRangeInfoKHR.html">VkAccelerationStructureBuildRangeInfoKHR</see> - Structure specifying build offsets and counts for acceleration structure builds
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureBuildRangeInfoKHR
    ///     </para>
    ///     <para>
    ///         <c>VkAccelerationStructureBuildRangeInfoKHR</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureBuildRangeInfoKHR {
    ///             uint32_t    primitiveCount;
    ///             uint32_t    primitiveOffset;
    ///             uint32_t    firstVertex;
    ///             uint32_t    transformOffset;
    ///         } VkAccelerationStructureBuildRangeInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkAccelerationStructureBuildRangeInfoKHR()
    {
        /// <summary>
        ///     <c>PrimitiveCount</c> defines the number of primitives for a corresponding acceleration structure geometry.
        /// </summary>
        [FieldOffset(0)]
        public int PrimitiveCount;

        /// <summary>
        ///     <c>PrimitiveOffset</c> defines an offset in bytes into the memory where primitive data is defined.
        /// </summary>
        [FieldOffset(4)]
        public int PrimitiveOffset;

        /// <summary>
        ///     <c>FirstVertex</c> is the index of the first vertex to build from for triangle geometry.
        /// </summary>
        [FieldOffset(8)]
        public int FirstVertex;

        /// <summary>
        ///     <c>TransformOffset</c> defines an offset in bytes into the memory where a transform matrix is defined.
        /// </summary>
        [FieldOffset(12)]
        public int TransformOffset;
    }
}
