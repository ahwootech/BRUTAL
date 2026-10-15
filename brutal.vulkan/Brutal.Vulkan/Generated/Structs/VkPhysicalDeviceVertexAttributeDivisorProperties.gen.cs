namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVertexAttributeDivisorProperties.html">VkPhysicalDeviceVertexAttributeDivisorProperties</see> - Structure describing max value of vertex attribute divisor that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVertexAttributeDivisorProperties</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceVertexAttributeDivisorProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxVertexAttribDivisor;
    ///             VkBool32           supportsNonZeroFirstInstance;
    ///         } VkPhysicalDeviceVertexAttributeDivisorProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxVertexAttribDivisor</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxVertexAttribDivisor;

        /// <summary>
        ///     <c>SupportsNonZeroFirstInstance</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SupportsNonZeroFirstInstance;
    }
}
