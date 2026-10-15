namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVertexAttributeDivisorFeatures.html">VkPhysicalDeviceVertexAttributeDivisorFeatures</see> - Structure describing if fetching of vertex attribute may be repeated for instanced rendering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVertexAttributeDivisorFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceVertexAttributeDivisorFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           vertexAttributeInstanceRateDivisor;
    ///             VkBool32           vertexAttributeInstanceRateZeroDivisor;
    ///         } VkPhysicalDeviceVertexAttributeDivisorFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VertexAttributeInstanceRateDivisor</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VertexAttributeInstanceRateDivisor;

        /// <summary>
        ///     <c>VertexAttributeInstanceRateZeroDivisor</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 VertexAttributeInstanceRateZeroDivisor;
    }
}
