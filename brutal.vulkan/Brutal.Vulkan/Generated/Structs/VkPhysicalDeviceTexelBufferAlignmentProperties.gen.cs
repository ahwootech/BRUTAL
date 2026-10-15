namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTexelBufferAlignmentProperties.html">VkPhysicalDeviceTexelBufferAlignmentProperties</see> - Structure describing the texel buffer alignment requirements supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTexelBufferAlignmentProperties</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceTexelBufferAlignmentProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       storageTexelBufferOffsetAlignmentBytes;
    ///             VkBool32           storageTexelBufferOffsetSingleTexelAlignment;
    ///             VkDeviceSize       uniformTexelBufferOffsetAlignmentBytes;
    ///             VkBool32           uniformTexelBufferOffsetSingleTexelAlignment;
    ///         } VkPhysicalDeviceTexelBufferAlignmentProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StorageTexelBufferOffsetAlignmentBytes</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 StorageTexelBufferOffsetAlignmentBytes;

        /// <summary>
        ///     <c>StorageTexelBufferOffsetSingleTexelAlignment</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 StorageTexelBufferOffsetSingleTexelAlignment;

        /// <summary>
        ///     <c>UniformTexelBufferOffsetAlignmentBytes</c>
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 UniformTexelBufferOffsetAlignmentBytes;

        /// <summary>
        ///     <c>UniformTexelBufferOffsetSingleTexelAlignment</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 UniformTexelBufferOffsetSingleTexelAlignment;
    }
}
