namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV.html">VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV</see> - Structure describing sparse address space limits of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_extended_sparse_address_space
    ///         typedef struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkDeviceSize          extendedSparseAddressSpaceSize;
    ///             VkImageUsageFlags     extendedSparseImageUsageFlags;
    ///             VkBufferUsageFlags    extendedSparseBufferUsageFlags;
    ///         } VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExtendedSparseAddressSpacePropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExtendedSparseAddressSpaceSize</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 ExtendedSparseAddressSpaceSize;

        /// <summary>
        ///     <c>ExtendedSparseImageUsageFlags</c>
        /// </summary>
        [FieldOffset(24)]
        public VkImageUsageFlags ExtendedSparseImageUsageFlags;

        /// <summary>
        ///     <c>ExtendedSparseBufferUsageFlags</c>
        /// </summary>
        [FieldOffset(28)]
        public VkBufferUsageFlags ExtendedSparseBufferUsageFlags;
    }
}
