namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedRequirements.html">VkMemoryDedicatedRequirements</see> - Structure describing dedicated allocation requirements of buffer and image resources
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryDedicatedRequirements</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkMemoryDedicatedRequirements {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           prefersDedicatedAllocation;
    ///             VkBool32           requiresDedicatedAllocation;
    ///         } VkMemoryDedicatedRequirements;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryDedicatedRequirements()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryDedicatedRequirements;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PrefersDedicatedAllocation</c> specifies that the implementation would prefer a dedicated allocation for this resource. The application is still free to suballocate the resource but it may: get better performance if a dedicated allocation is used.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PrefersDedicatedAllocation;

        /// <summary>
        ///     <c>RequiresDedicatedAllocation</c> specifies that a dedicated allocation is required for this resource.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RequiresDedicatedAllocation;
    }
}
