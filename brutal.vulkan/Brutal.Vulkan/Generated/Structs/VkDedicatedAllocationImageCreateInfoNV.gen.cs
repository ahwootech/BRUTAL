namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDedicatedAllocationImageCreateInfoNV.html">VkDedicatedAllocationImageCreateInfoNV</see> - Specify that an image is bound to a dedicated memory resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a
    ///         <c>VkDedicatedAllocationImageCreateInfoNV</c> structure, then that structure
    ///         includes an enable controlling whether the image will have a dedicated
    ///         memory allocation bound to it.
    ///     </para>
    ///     <para>
    ///         The <c>VkDedicatedAllocationImageCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_dedicated_allocation
    ///         typedef struct VkDedicatedAllocationImageCreateInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           dedicatedAllocation;
    ///         } VkDedicatedAllocationImageCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DedicatedAllocationImageCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DedicatedAllocation</c> specifies whether the image will have a dedicated allocation bound to it.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DedicatedAllocation;
    }
}
